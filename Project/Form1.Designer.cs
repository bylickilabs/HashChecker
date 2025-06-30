namespace HashCheckerWin
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox picGitHub;

        private void InitializeComponent()
        {
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.picGitHub = new System.Windows.Forms.PictureBox();

            this.SuspendLayout();

            // txtFile
            this.txtFile.Location = new System.Drawing.Point(12, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(260, 23);

            // btnSelectFile
            this.btnSelectFile.Location = new System.Drawing.Point(278, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFile.Text = "Datei auswählen";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);

            // txtMD5
            this.txtMD5.Location = new System.Drawing.Point(12, 50);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.ReadOnly = true;
            this.txtMD5.Size = new System.Drawing.Size(366, 23);
            this.txtMD5.PlaceholderText = "MD5-Hash";

            // txtSHA256
            this.txtSHA256.Location = new System.Drawing.Point(12, 85);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.ReadOnly = true;
            this.txtSHA256.Size = new System.Drawing.Size(366, 23);
            this.txtSHA256.PlaceholderText = "SHA-256-Hash";

            // txtReference
            this.txtReference.Location = new System.Drawing.Point(12, 120);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(260, 23);
            this.txtReference.PlaceholderText = "Referenz-Hash";

            // btnCompare
            this.btnCompare.Location = new System.Drawing.Point(278, 120);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 23);
            this.btnCompare.Text = "Vergleichen";
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);

            // lblCopyright
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.Location = new System.Drawing.Point(10, 200);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(240, 13);
            this.lblCopyright.Text = "©Thorsten Bylicki | 30.06.2025 | ©BylickiLabs — All Rights Reserved";

            // picGitHub
            this.picGitHub.Location = new System.Drawing.Point(330, 195);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(32, 32);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            // Bild-Ladeblock mit Exception-Handling
            try
            {
                if (System.IO.File.Exists("github.png"))
                {
                    this.picGitHub.Image = System.Drawing.Image.FromFile("github.png");
                }
            }
            catch { /* Bild nicht gefunden oder fehlerhaft, einfach leer lassen */ }
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.picGitHub);
            this.Name = "Form1";
            this.Text = "Datei-Hash-Checker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
