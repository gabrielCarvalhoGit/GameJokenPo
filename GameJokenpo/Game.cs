using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJokenpo
{
    public class Game
    {
        public enum Result
        {
            Win, Lose, Tie
        }

        public static Image[] images =
        {
            Image.FromFile("Imagens/Pedra.png"),
            Image.FromFile("Imagens/Tesoura.png"),
            Image.FromFile("Imagens/Papel.png")
        };

        public Image ImgPlayer { get; private set; }
        public Image ImgMachine { get; private set; }

        public Result Play(int player)
        {
            int machine = MachinePlay();

            ImgPlayer = images[player];
            ImgMachine = images[machine];

            if (player == machine)
            {
                return Result.Tie;
            }
            else if ((player == 0 && machine == 1) || (player == 1 && machine == 2) || (player == 2 && machine == 0))
            {
                return Result.Win;
            }
            else
            {
                return Result.Lose;
            }

        }

        private int MachinePlay()
        {
            int milliseconds = DateTime.Now.Millisecond;

            if (milliseconds < 333)
            {
                return 0;
            }
            else if (milliseconds >= 333 && milliseconds < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
