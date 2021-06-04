using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Files
{
    public partial class Form1 : Form
    {
        String nameEquipo = Environment.UserName;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        int x = 10, y = 10;
        int row = 0;

        String ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        public Form1()
        {
            InitializeComponent();
            count.Text = "Total de ítems: " + row.ToString();
            TextoRuta.Text = ruta;
        }

        private void clear()
        {
            if (row > 0)
            {
                for (int i=0; i<=row; i++)
                {
                    pnlArchivos.Controls.Clear();
                }
            }
        }

        private void changeRuta(String newRuta)
        {
            try
            {
                ruta = newRuta;
                TextoRuta.Text = ruta;

                clear();

                String[] allFiles = Directory.GetFiles(ruta, "*.*");
                String[] allFolder = Directory.GetDirectories(ruta);

                foreach (var file in allFiles)
                {
                    FileInfo info = new FileInfo(file);

                    if (info.Extension != ".ini")
                    {

                        Button btn = new Button();
                        btn.Text = info.Name;
                        btn.Visible = true;
                        btn.Size = new Size(128, 128);
                        btn.Location = new Point(x, y);
                        btn.Image = ((System.Drawing.Image) (resources.GetObject("home.Image")));
                        pnlArchivos.Controls.Add(btn);

                        x += 134;
                    }
                }
                foreach (var folder in allFolder)
                {
                    FileInfo info = new FileInfo(folder);

                    Button btn = new Button();
                    btn.Text = info.Name;
                    btn.Visible = true;
                    btn.Size = new Size(128, 128);
                    btn.Location = new Point(x, y);
                    pnlArchivos.Controls.Add(btn);

                    x += 134;
                }
                pnlArchivos.Visible = true;
                row = pnlArchivos.Controls.Count;
                count.Text = "Total de ítems: " + row.ToString();
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            changeRuta(@"C:\Users\Giovanny Bernal\Downloads");
        }

        private void home_Click(object sender, EventArgs e)
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void documents_Click(object sender, EventArgs e)
        {
            changeRuta(@"C:\Users\Giovanny Bernal\Documents");
        }

        private void music_Click(object sender, EventArgs e)
        {
            changeRuta(@"C:\Users\Giovanny Bernal\Music");
        }

        private void images_Click(object sender, EventArgs e)
        {
            changeRuta(@"C:\Users\Giovanny Bernal\Pictures");
        }

        private void movie_Click(object sender, EventArgs e)
        {
            changeRuta(@"C:\Users\Giovanny Bernal\Videos");
        }
    }
}
