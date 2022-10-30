namespace test
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Forward = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.RichTextBox();
            this.Right = new System.Windows.Forms.RichTextBox();
            this.Left = new System.Windows.Forms.RichTextBox();
            this.Space = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(65, 9);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(57, 18);
            this.Forward.TabIndex = 0;
            this.Forward.Text = "z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forward";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(65, 51);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(57, 18);
            this.Down.TabIndex = 2;
            this.Down.Tag = "";
            this.Down.Text = "s";
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(65, 100);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(57, 18);
            this.Right.TabIndex = 3;
            this.Right.Text = "d";
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(65, 147);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(57, 18);
            this.Left.TabIndex = 4;
            this.Left.Text = "q";
            // 
            // Space
            // 
            this.Space.Location = new System.Drawing.Point(65, 196);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(57, 18);
            this.Space.TabIndex = 5;
            this.Space.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Down";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forward);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox Forward;
        private Label label1;
        private RichTextBox Down;
        private RichTextBox Right;
        private RichTextBox Left;
        private RichTextBox Space;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}