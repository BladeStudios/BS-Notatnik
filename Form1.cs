using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BS_Notatnik
{
    public partial class Form1 : Form
    {
        string filename;
        bool isSaved;
        string filePath;

        private void saveFile()
        {
            var fileContent = openedFile.Text;
            //var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "Dokumenty tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.Write(fileContent);
                    }
                }
            }
            if (filePath != "")
            {
                setFilename(Path.GetFileName(filePath));
                isSaved = true;
                setTitle(this.filename);
            }
        }

        private void setFilePath(string newFilePath)
        {
            this.filePath = newFilePath;
        }

        private string getFilePath()
        {
            return this.filePath;
        }

        private void setFilename(string newFilename)
        {
            this.filename = newFilename;
            setTitle(filename);
        }

        private string getFilename()
        {
            return this.filename;
        }

        private void setTitle(string filename)
        {
            if(this.isSaved)
                this.Text = this.filename + " - BladeStudios Notatnik";
            else
                this.Text = "*" + this.filename + " - BladeStudios Notatnik";
        }

        public Form1()
        {
            InitializeComponent();
            this.isSaved = true;
            setFilename("Bez tytułu");
            setFilePath("");
        }

        private void plikOtworz_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            //var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            openedFile.Text = fileContent;
            if(filePath!="")
            {
                setFilename(Path.GetFileName(filePath));
                this.isSaved = true;
                this.setTitle(this.filename);
            }
        }

        private void formResize(object sender, EventArgs e)
        {
            openedFile.Width = this.Width - 15;
            openedFile.Height = this.Height - 65;
        }

        private void plikNowy_Click(object sender, EventArgs e)
        {
            //TODO - w przypadku zmian zapytanie czy zapisac zmiany

            openedFile.Text = "";
            setFilename("Bez tytułu");
        }

        private void plikNoweOkno_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(() =>
            {
                Application.Run(new Form1());
            });
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void plikZapisz_Click(object sender, EventArgs e)
        {
            if(this.getFilePath()=="")
            {
                saveFile();
            }
            else
            {
                var fileContent = openedFile.Text;
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.Write(fileContent);
                }
                this.isSaved = true;
                this.setTitle(this.filename);
            }
        }

        private void plikZapiszJako_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openedFile_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
            setTitle(this.filename);
        }

        private void plikZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edycjaZaznaczWszystko_Click(object sender, EventArgs e)
        {
            openedFile.SelectAll();
        }

        private void edycjaKopiuj_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(openedFile.SelectedText);
        }

        private void edycjaWklej_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                openedFile.Paste();
            }
        }

        private void edycjaWytnij_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(openedFile.SelectedText);
            openedFile.SelectedText = "";
        }
    }
}
