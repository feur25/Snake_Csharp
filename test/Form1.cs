using System.Collections;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private static int widthFrame { get; set; }
        private static int heightFrame { get; set; }
        private static int score { get; set; }
        private static bool speedAction { get; set; }
        private int speed { get; set; }
        private static int horizontale { get; set; }
        private static int vertically { get; set; }
        private static int upGradePLayer { get; set; }
        private static int heightPlayer { get; set; }
        private static bool top, right, left, bottom;
        private static bool reload { get; set; } = true;
        private static int nextStep { get; set; } = 0;
        private List<PictureBox> Snake = new List<PictureBox>();

        Random random = new Random();
        List<Color> randomColorSnakeBody = new List<Color> { 
            Color.Red, Color.Blue, Color.Brown, Color.CadetBlue, Color.Gold, Color.Coral, Color.DarkOrange, Color.DeepPink, Color.Lime, Color.LightYellow
        };
        PictureBox newApple = new PictureBox
        {
            Size = new Size(28, 26),
            Tag = "apple",
            //va dans le bin/Debug en l'occurence mes images ne sont pas la donc ce chemin est obligatoire
            ImageLocation = @"..\..\..\picture\apple.png",
            SizeMode = PictureBoxSizeMode.CenterImage
        };

        int x, y;
        PictureBox backgroundGenerate = new PictureBox
        {
            BackgroundImage = Image.FromFile(@"..\..\..\picture\background2.png")
        };

        public Form1(int speeding)
        {
            InitializeComponent();
            InitializeVariable();
            InitializeSnake();
            GenerateFood();
            readTextBestRecords();

            this.speed = speeding;
        }
        private void InitializeSnake()
        {
            PictureBox Head = new PictureBox
            {
                Width = upGradePLayer,
                Height = heightPlayer,
                BackColor = Color.Green
            };
            x = random.Next(Head.Width + 5, widthFrame - Head.Width);
            y = random.Next(Head.Height + 5, heightFrame - Head.Height);
            Head.Location = new Point(x, y);
            Snake.Add(Head);
            ShowingSnake();
        }
        private void InitializeVariable()
        {
            upGradePLayer = 16;
            heightPlayer = 16;
            widthFrame = borderBox.ClientSize.Width;
            heightFrame = borderBox.ClientSize.Height;
            score = 0;
            speedAction = true;
            horizontale = Location.X;
            vertically = Location.Y;
        }
        private void GenerateFood()
        {
            x = random.Next(newApple.Width+5, widthFrame - newApple.Width);
            y = random.Next(newApple.Height+5, heightFrame - newApple.Height);
            newApple.Location = new Point(x,y);
            this.Controls.Add(newApple);
            newApple.BringToFront();
        }
        private bool Eat()
        {
            foreach (var pomme in this.Controls
                   .OfType<PictureBox>()
                   .Where(x => (string)x.Tag == "apple")
                   .Where(x => Snake[0].Bounds.IntersectsWith(x.Bounds))
                   .ToList())
            {
                this.Controls.Remove(pomme);
                return true;
            }
            return false;
        }
        private void PlayerIsDead()
        {
            foreach (var endGame in this.Controls
               .OfType<PictureBox>()
               .Where(x => (string)x.Name == "borderBox")
               .Where(x => !Snake[0].Bounds.IntersectsWith(x.Bounds))
               .ToList())
            {
                Debug.WriteLine("tu touche la bordure !!");
                gameOver();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool speedUp(bool action)
        {
            if (action)
            {
                speed *= 2;
                speedAction = false;
                return !action;
            }
            speed /= 2;
            speedAction = true;
            return action;
        }
        private void GenerateCompenentToUpgradeSnake()
        {
            PictureBox Body = new PictureBox
            {
                Location = new Point(Snake[Snake.Count - 1].Location.X, Snake[Snake.Count - 1].Location.Y),
                Width = upGradePLayer,
                Height = heightPlayer,
                BackColor = randomColorSnakeBody[random.Next(0, 9)]
            };
            Snake.Add(Body);
            ShowingSnake();
        }
        private void CallFunctionCondition()
        {
            if (reload)
            {
                GenerateFood();
                reload = false;
            }
            if (Eat())
            {
                score++;
                nextStep++;
                GenerateCompenentToUpgradeSnake();
                reload = true;
            }
        }
        private void ShowingSnake()
        {
            for(int i = 0; i < Snake.Count; i++)
            {
                this.Controls.Add(Snake[i]);
                Snake[i].BringToFront();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void borderBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Drawing(object sender, PaintEventArgs e)
        {
        }
        private void FunctionCallImportant()
        {
            UpgradeSppedNextLvl();
            CallFunctionCondition();
            PlayerIsDead();
        }

        private void movePositionPlayer(object sender, EventArgs e)
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Snake[i].Left = right == true ? Snake[i].Left += speed : left == true ? Snake[i].Left -= speed : Snake[i].Left;
                    Snake[i].Top = top == true ? Snake[i].Top -= speed : bottom == true ? Snake[i].Top += speed : Snake[i].Top;
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].Location.X == Snake[j].Location.X && Snake[i].Location.Y == Snake[j].Location.Y)
                        {
                            gameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].Location = new Point(Snake[i - 1].Location.X, Snake[i - 1].Location.Y);
                }
            }
            counter.Text = score.ToString();
            FunctionCallImportant();
        }
        private void readTextBestRecords()
        {
            string path = @"..\..\..\counter.txt";
            StreamReader stream = new StreamReader(path);
            string file = stream.ReadToEnd();
            label2.Text = file.ToString();
            stream.Close();
        }
        private void writeTextBestRecords()
        {
            if(int.Parse(label2.Text) < int.Parse(counter.Text))
            {
                string path = @"..\..\..\counter.txt";
                StreamWriter fileWriter = new StreamWriter(path);
                fileWriter.WriteLine(score);
                fileWriter.Close();
            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private static void CheckDirectionAll(bool rightBool, bool leftBool, bool topBool, bool downBool)
        {
            right = rightBool;
            left = leftBool;
            top = topBool;
            bottom = downBool;
        }
        private void UpgradeSppedNextLvl()
        {
            if(nextStep >= 45)
            {
                speed *= 1;
                nextStep = 0;
            }
        }
        private void KeyGetInput(object sender, KeyEventArgs e)
        {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        CheckDirectionAll(true, false, false, false);
                        break;
                    case Keys.Left:
                        CheckDirectionAll(false, true, false, false);
                        break;
                    case Keys.Up:
                        CheckDirectionAll(false, false, true, false);
                        break;
                    case Keys.Down:
                        CheckDirectionAll(false, false, false, true);
                        break;
                    case Keys.Space:
                        speedUp(speedAction);
                        break;
            }
        }
        private void gameOver()
        {
            writeTextBestRecords();
            timer1.Stop();
            MessageBox.Show("Game Over");
            this.Hide();
            homecs goToHome = new homecs();
            goToHome.Show();
            return;
        }
    }
}