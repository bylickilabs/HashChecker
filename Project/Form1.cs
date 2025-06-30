using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HashCheckerWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = dialog.FileName;
                    ComputeHashes(dialog.FileName);
                }
            }
        }

        private void ComputeHashes(string filePath)
        {
            txtMD5.Text = GetFileHash(filePath, "MD5");
            txtSHA256.Text = GetFileHash(filePath, "SHA256");
            lblResult.Text = "";
        }

        private string GetFileHash(string filePath, string algorithm)
        {
            using var stream = File.OpenRead(filePath);
            HashAlgorithm hasher = algorithm switch
            {
                "MD5" => MD5.Create(),
                "SHA256" => SHA256.Create(),
                _ => throw new ArgumentException("Nur MD5 und SHA256 werden unterstützt!")
            };
            byte[] hash = hasher.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string refHash = txtReference.Text.Trim();
            if (string.IsNullOrEmpty(refHash)) return;

            bool match = txtMD5.Text.Equals(refHash, StringComparison.OrdinalIgnoreCase)
                      || txtSHA256.Text.Equals(refHash, StringComparison.OrdinalIgnoreCase);

            lblResult.ForeColor = match ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            lblResult.Text = match ? "✔ Hash stimmt überein!" : "✘ Hash stimmt NICHT überein!";
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/bylickilabs",
                UseShellExecute = true
            });
        }
    }
}
