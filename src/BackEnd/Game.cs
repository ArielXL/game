using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Game
    {
        private int[] dx = { 1, 0, -1, 0 };
        private int[] dy = { 0, 1, 0, -1 };

        public int Row { get; private set; }
        public int Column { get; private set; }
        public GameStates State { get; private set; }
        public bool[,] Board { get; private set; }

        public Game()
        {
            State = GameStates.Playing;
            
            Row = 9;
            Column = 9;
            Board = new bool[Row, Column];
            GenerateBoard();
            ChangeNCell(20);
        }

        public void Save()
        {
            StreamWriter file = new StreamWriter("save.txt");

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (j == Column - 1)
                    {
                        if (Board[i, j])
                            file.Write("1");
                        else
                            file.Write("0");
                    }
                    else
                    {
                        if (Board[i, j])
                            file.Write("1 ");
                        else
                            file.Write("0 ");
                    }
                }
                if (i != Row - 1)
                    file.WriteLine();
            }

            file.Close();
        }

        public void Load()
        {
            StreamReader file = new StreamReader("save.txt");
            
            for (int i = 0; i < Row; i++)
            {
                string[] line = file.ReadLine().Split();
                for (int j = 0; j < Column; j++)
                {
                    if (int.Parse(line[j]) == 1)
                        Board[i, j] = true;
                    else
                        Board[i, j] = false;
                }
            }

            file.Close();
        }

        public void Play(int row, int column)
        {
            ChangeCell(row, column);
            for (int i = 0; i < 4; i++)
            {
                int next_row = row + dx[i];
                int next_column = column + dy[i];

                if (IsValid(next_row, next_column))
                    ChangeCell(next_row, next_column);
            }

            if (GameFinished())
                State = GameStates.Finished;
        }

        public bool GameFinished()
        {
            for (int row = 0; row < Row; row++)
            {
                for (int column = 0; column < Column; column++)
                {
                    if (!Board[row, column])
                        return false;
                }
            }
            return true;
        }

        private void ChangeNCell(int n)
        {
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int row = random.Next(0, Row);
                int column = random.Next(0, Column);
                Console.WriteLine(row);
                Console.WriteLine(column);

                ChangeCell(row, column);
                for (int j = 0; j < 4; j++)
                {
                    int next_row = row + dx[j];
                    int next_column = column + dy[j];

                    if (IsValid(next_row, next_column))
                        ChangeCell(next_row, next_column);
                }
            }
        }

        private void GenerateBoard()
        {
            Board[0, 1] = Board[0, 4] = Board[0, 6] = Board[0, 8] = false;
            Board[0, 0] = Board[0, 2] = Board[0, 3] = Board[0, 5] = Board[0, 7] = true;

            Board[1, 3] = Board[1, 4] = Board[1, 5] = Board[1, 6] = Board[1, 7] = false;
            Board[1, 0] = Board[1, 1] = Board[1, 2] = Board[1, 8] = true;

            Board[2, 2] = Board[2, 3] = Board[2, 4] = Board[2, 5] = Board[2, 7] = false;
            Board[2, 0] = Board[2, 1] = Board[2, 6] = Board[2, 8] = true;

            Board[3, 2] = Board[3, 8] = false;
            Board[3, 0] = Board[3, 1] = Board[3, 3] = Board[3, 4] = Board[3, 5] = Board[3, 6] = Board[3, 7] = true;

            Board[4, 1] = Board[4, 2] = Board[4, 3] = Board[4, 4] = Board[4, 5] = Board[4, 7] = false;
            Board[4, 0] = Board[4, 6] = Board[4, 8] = true;

            Board[5, 0] = Board[5, 3] = Board[5, 6] = Board[5, 7] = false;
            Board[5, 1] = Board[5, 2] = Board[5, 4] = Board[5, 5] = Board[5, 8] = true;

            Board[6, 1] = Board[6, 2] = Board[6, 4] = Board[6, 5] = Board[6, 8] = false;
            Board[6, 0] = Board[6, 3] = Board[6, 6] = Board[6, 7] = true;

            Board[7, 4] = Board[7, 5] = false;
            Board[7, 0] = Board[7, 1] = Board[7, 2] = Board[7, 3] = Board[7, 6] = Board[7, 7] = Board[7, 8] = true;

            Board[8, 3] = Board[8, 4] = Board[8, 5] = Board[8, 8] = false;
            Board[8, 0] = Board[8, 1] = Board[8, 2] = Board[8, 6] = Board[8, 7] = true;
        }
        
        private void ChangeCell(int row, int column)
        {
            if (Board[row, column])
                Board[row, column] = false;
            else
                Board[row, column] = true;
        }

        private bool IsValid(int row, int column)
        {
            return row >= 0 && column >= 0 && row < Row && column < Column;
        }
    }
}
