namespace TicTacToe
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            panelPad = new Panel();
            btn33 = new Button();
            btn32 = new Button();
            btn31 = new Button();
            btn23 = new Button();
            btn22 = new Button();
            btn21 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            rbPlayer1 = new RadioButton();
            rbPlayer2 = new RadioButton();
            panelPad.SuspendLayout();
            SuspendLayout();
            // 
            // panelPad
            // 
            panelPad.BackColor = Color.YellowGreen;
            panelPad.Controls.Add(btn33);
            panelPad.Controls.Add(btn32);
            panelPad.Controls.Add(btn31);
            panelPad.Controls.Add(btn23);
            panelPad.Controls.Add(btn22);
            panelPad.Controls.Add(btn21);
            panelPad.Controls.Add(btn13);
            panelPad.Controls.Add(btn12);
            panelPad.Controls.Add(btn11);
            panelPad.Location = new Point(38, 51);
            panelPad.Name = "panelPad";
            panelPad.Size = new Size(320, 320);
            panelPad.TabIndex = 0;
            // 
            // btn33
            // 
            btn33.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn33.Location = new Point(214, 214);
            btn33.Name = "btn33";
            btn33.Size = new Size(100, 100);
            btn33.TabIndex = 8;
            btn33.UseVisualStyleBackColor = true;
            btn33.Click += btn33_Click;
            // 
            // btn32
            // 
            btn32.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn32.Location = new Point(108, 214);
            btn32.Name = "btn32";
            btn32.Size = new Size(100, 100);
            btn32.TabIndex = 7;
            btn32.UseVisualStyleBackColor = true;
            btn32.Click += btn32_Click;
            // 
            // btn31
            // 
            btn31.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn31.Location = new Point(5, 214);
            btn31.Name = "btn31";
            btn31.Size = new Size(100, 100);
            btn31.TabIndex = 6;
            btn31.UseVisualStyleBackColor = true;
            btn31.Click += btn31_Click;
            // 
            // btn23
            // 
            btn23.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn23.Location = new Point(214, 109);
            btn23.Name = "btn23";
            btn23.Size = new Size(100, 100);
            btn23.TabIndex = 5;
            btn23.UseVisualStyleBackColor = true;
            btn23.Click += btn23_Click;
            // 
            // btn22
            // 
            btn22.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn22.Location = new Point(108, 109);
            btn22.Name = "btn22";
            btn22.Size = new Size(100, 100);
            btn22.TabIndex = 4;
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += btn22_Click;
            // 
            // btn21
            // 
            btn21.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn21.Location = new Point(5, 109);
            btn21.Name = "btn21";
            btn21.Size = new Size(100, 100);
            btn21.TabIndex = 3;
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += btn21_Click;
            // 
            // btn13
            // 
            btn13.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn13.Location = new Point(213, 4);
            btn13.Name = "btn13";
            btn13.Size = new Size(100, 100);
            btn13.TabIndex = 2;
            btn13.UseVisualStyleBackColor = true;
            btn13.Click += btn13_Click;
            // 
            // btn12
            // 
            btn12.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn12.Location = new Point(107, 4);
            btn12.Name = "btn12";
            btn12.Size = new Size(100, 100);
            btn12.TabIndex = 1;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // btn11
            // 
            btn11.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btn11.Location = new Point(4, 4);
            btn11.Name = "btn11";
            btn11.Size = new Size(100, 100);
            btn11.TabIndex = 0;
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += btn11_Click;
            // 
            // rbPlayer1
            // 
            rbPlayer1.AutoSize = true;
            rbPlayer1.Checked = true;
            rbPlayer1.Location = new Point(71, 18);
            rbPlayer1.Name = "rbPlayer1";
            rbPlayer1.Size = new Size(84, 19);
            rbPlayer1.TabIndex = 1;
            rbPlayer1.TabStop = true;
            rbPlayer1.Text = "Player 1 (X)";
            rbPlayer1.UseVisualStyleBackColor = true;
            // 
            // rbPlayer2
            // 
            rbPlayer2.AutoSize = true;
            rbPlayer2.Location = new Point(199, 18);
            rbPlayer2.Name = "rbPlayer2";
            rbPlayer2.Size = new Size(86, 19);
            rbPlayer2.TabIndex = 2;
            rbPlayer2.Text = "Player 2 (O)";
            rbPlayer2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 385);
            Controls.Add(rbPlayer2);
            Controls.Add(rbPlayer1);
            Controls.Add(panelPad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += frmMain_Load;
            panelPad.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPad;
        private Button btn11;
        private Button btn33;
        private Button btn32;
        private Button btn31;
        private Button btn23;
        private Button btn22;
        private Button btn21;
        private Button btn13;
        private Button btn12;
        private RadioButton rbPlayer1;
        private RadioButton rbPlayer2;
    }
}
