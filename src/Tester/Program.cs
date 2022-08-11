using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Utils.PrintBoard(game.Board);

            while (game.State != GameStates.Finished)
            {
                Console.WriteLine("Escriba las coordenadas a jugar");
                string[] line = Console.ReadLine().Split();
                int row = int.Parse(line[0]);
                int column = int.Parse(line[1]);

                game.Play(row, column);
                Utils.PrintBoard(game.Board);
            }
        }
    }
}
