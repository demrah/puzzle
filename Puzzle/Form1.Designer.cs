namespace Puzzle
{
    partial class frmPuzzle
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
            this.cbSeviye = new System.Windows.Forms.ComboBox();
            this.ofdResimAc = new System.Windows.Forms.OpenFileDialog();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pChosed = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pChosed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSeviye
            // 
            this.cbSeviye.FormattingEnabled = true;
            this.cbSeviye.Items.AddRange(new object[] {
            "BASİT \t(3X3)",
            "ORTA \t(4X4)",
            "ZOR\t(5X5)",
            "PRO\t(6X6)"});
            this.cbSeviye.Location = new System.Drawing.Point(12, 10);
            this.cbSeviye.Name = "cbSeviye";
            this.cbSeviye.Size = new System.Drawing.Size(273, 21);
            this.cbSeviye.TabIndex = 0;
            this.cbSeviye.Text = "Seviye seçiniz";
            this.cbSeviye.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ofdResimAc
            // 
            this.ofdResimAc.FileName = "openFileDialog1";
            this.ofdResimAc.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 48);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(94, 23);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "RESİM SEÇ";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(128, 86);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(157, 23);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "OYUNA BAŞLA";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // pChosed
            // 
            this.pChosed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pChosed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pChosed.Location = new System.Drawing.Point(0, 127);
            this.pChosed.Name = "pChosed";
            this.pChosed.Size = new System.Drawing.Size(300, 280);
            this.pChosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pChosed.TabIndex = 5;
            this.pChosed.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(128, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Parçalar çapraz değişebilsin";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "RESİM KALDIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPuzzle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pChosed);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cbSeviye);
            this.Name = "frmPuzzle";
            this.Text = "Puzzle";
            ((System.ComponentModel.ISupportInitialize)(this.pChosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSeviye;
        private System.Windows.Forms.OpenFileDialog ofdResimAc;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox pChosed;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;

    }
}

