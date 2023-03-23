using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\nikrm\OneDrive\Рабочий стол\Практики для проекта\Практическая работа №2\Practice2\Practice2\bin\Debug\net6.0\Practice2");
        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\nikrm\OneDrive\Рабочий стол\Практики для проекта\Практическая работа №2\Practice2.2\Practice2.2\bin\Debug\net6.0\Practice2.2");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WorkingField.Clear();
            openFileDialog1.FileName = @"data\Text2.txt";
            openFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter =
                     "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == String.Empty) return;
            try
            {
                TextReader reader = new System.IO.StreamReader(
                openFileDialog1.FileName, Encoding.GetEncoding(1251));
                WorkingField.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (System.IO.FileNotFoundException error)
            {
                MessageBox.Show(error.Message + "\nНет такого файла",
                         "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,
                     "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextWriter writer = new System.IO.StreamWriter(
                    saveFileDialog1.FileName, false,
                                        System.Text.Encoding.GetEncoding(1251));
                    writer.Write(WorkingField.Text);
                    writer.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingField.SelectionLength > 0)
                WorkingField.Copy();
        }
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingField.SelectedText != "")
                WorkingField.Cut();
        }
        private void отменитьДействиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingField.CanUndo == true)
            {
                WorkingField.Undo();
                WorkingField.ClearUndo();
            }
        }
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                WorkingField.Paste();
        }

        private void задание1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"");
        }

        private void задание2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"");
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"");
        }
    }
}
