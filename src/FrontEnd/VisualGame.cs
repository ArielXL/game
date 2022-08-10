using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;

namespace FrontEnd
{
    public partial class frmVisualGame : Form
    {
        private Game game;

        public frmVisualGame()
        {
            InitializeComponent();
        }

        private void pcboxBoard_Paint(object sender, PaintEventArgs e)
        {
            if (game == null)
                InitializeGame();

            int ancho = pbxBoard.Width / game.Row;
            SolidBrush brush = new SolidBrush(Color.Black);
            Font font = new Font(Font.FontFamily, ancho / 3);

            for (int i = 0; i < game.Row; i++)
            {
                e.Graphics.DrawLine(Pens.Black, 0, i * ancho, pbxBoard.Width, i * ancho);
                e.Graphics.DrawLine(Pens.Black, i * ancho, 0, i * ancho, pbxBoard.Width);
            }

            for (int i = 0; i < game.Row; i++)
            {
                for (int j = 0; j < game.Column; j++)
                {
                    if (!game.Board[i, j])
                        e.Graphics.FillRectangle(brush, i * ancho, j * ancho, ancho, ancho);
                    else
                        e.Graphics.DrawString(" ", font, brush, i * ancho, j * ancho);
                }
            }
        }

        private void InitializeGame()
        {
            game = new Game();
            pbxBoard.Refresh();
        }

        private void pcboxBoard_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X * game.Row / pbxBoard.Width;
            int y = e.Y * game.Column / pbxBoard.Width;
            game.Play(x, y);
            pbxBoard.Refresh();

            if (game.State == GameStates.Finished)
            {
                MessageBox.Show("Felicidades!!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Desea iniciar otro juego?", "Nuevo juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    InitializeGame();
                else
                    Close();
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Realmente desea salir del juego?", "Salir del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string information = "App : Jueguito v2.0 \n";
            information += "Author : Ariel Plasencia Díaz \n";

            MessageBox.Show(information, "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "El objetivo del juego es hacer blanco el tablero completo";

            MessageBox.Show(help, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea iniciar un nuevo juego?", "Nuevo juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                InitializeGame();
        }

        private void salvarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea salvar el juego?", "Salvar juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                game.Save();
                MessageBox.Show("Juego salvado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea cargar el juego?", "Cargar juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                game.Load();
                pbxBoard.Refresh();
                MessageBox.Show("Juego cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
