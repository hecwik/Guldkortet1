
namespace Guldkortet1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartaServer = new System.Windows.Forms.Button();
            this.btnStängServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblKundLogin = new System.Windows.Forms.Label();
            this.lblKortNummer = new System.Windows.Forms.Label();
            this.btnCheckWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartaServer
            // 
            this.btnStartaServer.Location = new System.Drawing.Point(44, 275);
            this.btnStartaServer.Name = "btnStartaServer";
            this.btnStartaServer.Size = new System.Drawing.Size(180, 82);
            this.btnStartaServer.TabIndex = 0;
            this.btnStartaServer.Text = "Starta Server";
            this.btnStartaServer.UseVisualStyleBackColor = true;
            this.btnStartaServer.Click += new System.EventHandler(this.btnStartaServer_Click);
            // 
            // btnStängServer
            // 
            this.btnStängServer.Enabled = false;
            this.btnStängServer.Location = new System.Drawing.Point(44, 377);
            this.btnStängServer.Name = "btnStängServer";
            this.btnStängServer.Size = new System.Drawing.Size(180, 61);
            this.btnStängServer.TabIndex = 1;
            this.btnStängServer.Text = "Stäng server";
            this.btnStängServer.UseVisualStyleBackColor = true;
            this.btnStängServer.Click += new System.EventHandler(this.btnStängServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(419, 29);
            this.textBox2.TabIndex = 4;
            // 
            // lblKundLogin
            // 
            this.lblKundLogin.AutoSize = true;
            this.lblKundLogin.Location = new System.Drawing.Point(44, 33);
            this.lblKundLogin.Name = "lblKundLogin";
            this.lblKundLogin.Size = new System.Drawing.Size(221, 25);
            this.lblKundLogin.TabIndex = 5;
            this.lblKundLogin.Text = "Konto-ID (AXXXXXXX)";
            // 
            // lblKortNummer
            // 
            this.lblKortNummer.AutoSize = true;
            this.lblKortNummer.Location = new System.Drawing.Point(44, 122);
            this.lblKortNummer.Name = "lblKortNummer";
            this.lblKortNummer.Size = new System.Drawing.Size(278, 25);
            this.lblKortNummer.TabIndex = 6;
            this.lblKortNummer.Text = "Kortnummer (KXXXXXXXXX)";
            // 
            // btnCheckWin
            // 
            this.btnCheckWin.Enabled = false;
            this.btnCheckWin.Location = new System.Drawing.Point(534, 92);
            this.btnCheckWin.Name = "btnCheckWin";
            this.btnCheckWin.Size = new System.Drawing.Size(191, 85);
            this.btnCheckWin.TabIndex = 7;
            this.btnCheckWin.Text = "Kontrollera vinst";
            this.btnCheckWin.UseVisualStyleBackColor = true;
            this.btnCheckWin.Click += new System.EventHandler(this.btnCheckWin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckWin);
            this.Controls.Add(this.lblKortNummer);
            this.Controls.Add(this.lblKundLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStängServer);
            this.Controls.Add(this.btnStartaServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartaServer;
        private System.Windows.Forms.Button btnStängServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblKundLogin;
        private System.Windows.Forms.Label lblKortNummer;
        private System.Windows.Forms.Button btnCheckWin;
    }
}

