﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaUniversitario
{
    public partial class Form2login : Form
    {
        public Form2login()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form frm = new Form1menuprincipal();
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form frm = new Form3MenuAdministrador();
            frm.Show();
        }
    }
}
