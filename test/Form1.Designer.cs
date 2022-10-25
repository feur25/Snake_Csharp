namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.borderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.borderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.movePositionPlayer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score : 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // borderBox
            // 
            this.borderBox.BackColor = System.Drawing.Color.Bisque;
            this.borderBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borderBox.BackgroundImage")));
            this.borderBox.Image = ((System.Drawing.Image)(resources.GetObject("borderBox.Image")));
            this.borderBox.Location = new System.Drawing.Point(40, 32);
            this.borderBox.Name = "borderBox";
            this.borderBox.Size = new System.Drawing.Size(449, 416);
            this.borderBox.TabIndex = 2;
            this.borderBox.TabStop = false;
            this.borderBox.Click += new System.EventHandler(this.borderBox_Click);
            this.borderBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Drawing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(801, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borderBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyGetInput);
            ((System.ComponentModel.ISupportInitialize)(this.borderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox borderBox;
    }
}