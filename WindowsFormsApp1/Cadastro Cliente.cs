﻿using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cadastro_Cliente : MaterialSkin.Controls.MaterialForm
    {
        public Cadastro_Cliente()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange700,
                TextShade.WHITE

          );
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
