﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            StarGame(0);
=======

>>>>>>> 0ca6d1739468213ac57afd7216620b78aa9f3a7a
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            StarGame(2);
=======

>>>>>>> 0ca6d1739468213ac57afd7216620b78aa9f3a7a
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            StarGame(1);
        }

        private void StarGame (int opcao)
        {
            labelResultado.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
            }
=======

>>>>>>> 0ca6d1739468213ac57afd7216620b78aa9f3a7a
        }
    }
}
