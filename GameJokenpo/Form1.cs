using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameJokenpo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPictureStone_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPicturePaper_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnPictureScissors_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int option)
        {
            //labelQuestionMarkResult.Visible = false;

            Game game = new Game();

            switch (game.Play(option)) 
            {
                case Game.Result.Win:
                    labelQuestionMarkResult.Text = "Você Venceu!";
                    labelQuestionMarkResult.ForeColor = Color.Green;
                    goto default;

                case Game.Result.Tie:
                    labelQuestionMarkResult.Text = "Empate";
                    labelQuestionMarkResult.ForeColor = Color.Yellow;
                    goto default;

                case Game.Result.Lose:
                    labelQuestionMarkResult.Text = "Você Perdeu!";
                    labelQuestionMarkResult.ForeColor = Color.Red;
                    goto default;

                default:
                    labelPerson.Visible = false;
                    labelMachine.Visible = false;

                    pictureBoxPerson.Image = game.ImgPlayer;
                    pictureBoxMachine.Image = game.ImgMachine;
                    break;
            }
        }
    }
}
