﻿using PixelBuilder.Abs;
using PixelBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOXClient.UCs
{
    public partial class UC_Game : UserControl
    {

        public UC_Game(Size gameSize, int sizeMultiplier)
        {
            InitializeComponent();

            pictureBoxMain.MouseMove += PictureBoxMain_MouseMove;
            pictureBoxMain.MouseDown += PictureBoxMain_MouseDown;
            pictureBoxMain.MouseUp += PictureBoxMain_MouseUp;


            PixelComponent[] components = new PixelComponent[]
            {

            };

            PForm = new PixelForm(gameSize, sizeMultiplier, Textures.Colors.backgroundColor, components);

            PForm.OnRedraw += PForm_OnRedraw;

            PForm_OnRedraw(null, null);
        }


        PixelForm PForm;


        #region Essential Events

        private void PForm_OnRedraw(object sender, EventArgs e)
        {
            pictureBoxMain.Image = PForm.IMAGE;
        }

        private void PictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            PForm.TriggerMouseUp(e.Location);
        }

        private void PictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            PForm.TriggerMouseDown(e.Location);
        }

        private void PictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            PForm.TriggerMouseMove(e.Location);
        }
        #endregion
    }
}