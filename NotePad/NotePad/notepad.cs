using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class notepad : Form
    {
        private String fileName = null;
        private bool isunsaved = false;
        private bool ignoreTextChangedEvent = false;
        public notepad()
        {
            InitializeComponent();
            UpdateTitle();

        }
        private void UpdateTitle()
        {
            string file;
            if (string.IsNullOrEmpty(fileName))
            {
                file = "Unnamed";
            }
            else
            {
                file = Path.GetFileName(fileName);
            }
            if (isunsaved)
            {
                Text = file + "* - Notpad";     
            }
            else
            {
                Text = file + " - Notpad";
            } 
        }
        private void saveFile()
        {
            if (string.IsNullOrEmpty(fileName))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(fileName, textBox.Text);
            isunsaved = false;
            UpdateTitle();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
            {
                return;
            }

            textBox.Text = string.Empty;
            fileName = null;
            isunsaved = false;
            UpdateTitle();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
            {
                return;
            }
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                ignoreTextChangedEvent = true;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                fileName= openFileDialog.FileName;
                isunsaved = false;
                UpdateTitle();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreTextChangedEvent)
            {
                
                ignoreTextChangedEvent = false;
                return;
            }
            isunsaved = true;
            UpdateTitle();
        }

        private void notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isunsaved)
            {
                var res = MessageBox.Show(this, "Vill du spara?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
               
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFile();
                }
                else if (res == System.Windows.Forms.DialogResult.No)
                {
                    //Gör ingeting
                }
                else if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

        }
    }
}
