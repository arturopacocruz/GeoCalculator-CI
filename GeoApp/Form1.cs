using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class Form1 : Form
    {
        private Button btnRectangulo;
        private Button btnCirculo;
        private Button btnTriangulo;

        public Form1()
        {
            InitializeComponent();
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            // Botón Rectángulo
            btnRectangulo = new Button();
            btnRectangulo.Text = "Rectángulo";
            btnRectangulo.Location = new System.Drawing.Point(30, 30);
            btnRectangulo.Size = new System.Drawing.Size(100, 40);
            btnRectangulo.Click += BtnRectangulo_Click;
            this.Controls.Add(btnRectangulo);

            // Botón Círculo
            btnCirculo = new Button();
            btnCirculo.Text = "Círculo";
            btnCirculo.Location = new System.Drawing.Point(150, 30);
            btnCirculo.Size = new System.Drawing.Size(100, 40);
            btnCirculo.Click += BtnCirculo_Click;
            this.Controls.Add(btnCirculo);

            // Botón Triángulo
            btnTriangulo = new Button();
            btnTriangulo.Text = "Triángulo";
            btnTriangulo.Location = new System.Drawing.Point(270, 30);
            btnTriangulo.Size = new System.Drawing.Size(100, 40);
            btnTriangulo.Click += BtnTriangulo_Click;
            this.Controls.Add(btnTriangulo);

            // Configuraciones generales
            this.Text = "Calculadora de Figuras Geométricas";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(420, 150);
        }

        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo formR = new FormRectangulo();
            formR.ShowDialog();
        }

        private void BtnCirculo_Click(object sender, EventArgs e)
        {
            FormCirculo formC = new FormCirculo();
            formC.ShowDialog();
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo formT = new FormTriangulo();
            formT.ShowDialog();
        }
    }
}

