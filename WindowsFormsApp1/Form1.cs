﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;

namespace WindowsFormsApp1
{
    public partial class Myapp : Form
    {
        public Myapp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Myapp_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido pa");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = "Bienvenido";
             FrmIngreso forma = new FrmIngreso();
              forma.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxPWD.Equals("admin")&&textBoxUSR.Text.Equals("admin"))
            {
                FrmIngreso forma = new FrmIngreso();
                forma.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectas");
                textBoxPWD.Text = "";
                textBoxUSR.Text = "";
            }
        }

        //private void buttonInicio_Click(object sender, EventArgs e)
        //{
        //    LblTitulo.Text = "Bienvenido a mi habitacion terciopelo";
        //    FrmIngreso forma = new FrmIngreso();
        //    forma.Show();
        //}
    }
}
