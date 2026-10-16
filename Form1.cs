using System;
using System.IO;
using System.Windows.Forms;

namespace sinifisi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. ADD FILE — Yeni fayl yaradır
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*",
                Title = "Yeni Fayl Yaradın"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;

                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    MessageBox.Show("Fayl uğurla yaradıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bu adda fayl artıq mövcuddur!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // 2. READ FILE — Faylı oxuyur və sağdakı sahəyə yazır
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*",
                Title = "Oxunacaq faylı seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                txtContent.Text = File.ReadAllText(path);
                MessageBox.Show("Fayl uğurla oxundu!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 3. REMOVE FILE — Faylı silir
        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*",
                Title = "Silinəcək faylı seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                DialogResult confirm = MessageBox.Show("Bu faylı silməkdən əminsiniz?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    File.Delete(path);
                    txtContent.Clear();
                    MessageBox.Show("Fayl uğurla silindi!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 4. WRITE FILE — Mətni fayla yazır
        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*",
                Title = "Mətni fayla yazın"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                File.WriteAllText(path, txtContent.Text);
                MessageBox.Show("Mətn fayla uğurla yazıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}