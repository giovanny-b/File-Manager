
namespace Files
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoRuta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.movie = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.Button();
            this.music = new System.Windows.Forms.Button();
            this.documents = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.pnlArchivos = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.count = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TextoRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 61);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(459, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(422, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TextoRuta
            // 
            this.TextoRuta.BackColor = System.Drawing.Color.Silver;
            this.TextoRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoRuta.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoRuta.ForeColor = System.Drawing.Color.Black;
            this.TextoRuta.Location = new System.Drawing.Point(13, 13);
            this.TextoRuta.Name = "TextoRuta";
            this.TextoRuta.Size = new System.Drawing.Size(403, 31);
            this.TextoRuta.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.movie);
            this.panel2.Controls.Add(this.images);
            this.panel2.Controls.Add(this.music);
            this.panel2.Controls.Add(this.documents);
            this.panel2.Controls.Add(this.download);
            this.panel2.Controls.Add(this.home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 668);
            this.panel2.TabIndex = 1;
            // 
            // movie
            // 
            this.movie.Image = ((System.Drawing.Image)(resources.GetObject("movie.Image")));
            this.movie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movie.Location = new System.Drawing.Point(5, 237);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(191, 39);
            this.movie.TabIndex = 6;
            this.movie.Text = "Videos";
            this.movie.UseVisualStyleBackColor = true;
            this.movie.Click += new System.EventHandler(this.movie_Click);
            // 
            // images
            // 
            this.images.Image = ((System.Drawing.Image)(resources.GetObject("images.Image")));
            this.images.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.images.Location = new System.Drawing.Point(5, 193);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(191, 38);
            this.images.TabIndex = 5;
            this.images.Text = "Imagenes";
            this.images.UseVisualStyleBackColor = true;
            this.images.Click += new System.EventHandler(this.images_Click);
            // 
            // music
            // 
            this.music.Image = ((System.Drawing.Image)(resources.GetObject("music.Image")));
            this.music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.music.Location = new System.Drawing.Point(5, 147);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(191, 40);
            this.music.TabIndex = 4;
            this.music.Text = "Musica";
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // documents
            // 
            this.documents.Image = ((System.Drawing.Image)(resources.GetObject("documents.Image")));
            this.documents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documents.Location = new System.Drawing.Point(5, 101);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(191, 40);
            this.documents.TabIndex = 3;
            this.documents.Text = "Documentos";
            this.documents.UseVisualStyleBackColor = true;
            this.documents.Click += new System.EventHandler(this.documents_Click);
            // 
            // download
            // 
            this.download.Image = ((System.Drawing.Image)(resources.GetObject("download.Image")));
            this.download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.download.Location = new System.Drawing.Point(5, 55);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(191, 40);
            this.download.TabIndex = 2;
            this.download.Text = "Descargas";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(5, 7);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(191, 42);
            this.home.TabIndex = 0;
            this.home.Text = "Hogar";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pnlArchivos
            // 
            this.pnlArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArchivos.Location = new System.Drawing.Point(200, 61);
            this.pnlArchivos.Name = "pnlArchivos";
            this.pnlArchivos.Size = new System.Drawing.Size(1150, 668);
            this.pnlArchivos.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.count);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 712);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1150, 17);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(3, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(80, 13);
            this.count.TabIndex = 0;
            this.count.Text = "Total de Items: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlArchivos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextoRuta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button movie;
        private System.Windows.Forms.Button images;
        private System.Windows.Forms.Button music;
        private System.Windows.Forms.Button documents;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.FlowLayoutPanel pnlArchivos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label count;
    }
}

