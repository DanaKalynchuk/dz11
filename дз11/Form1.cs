using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз11
{

    //namespace ChessBoard

    public partial class Form1 : Form
    {
        private const int BoardSize = 8;
        private const int SquareSize = 50;
        private readonly Brush LightSquareBrush = Brushes.White;
        private readonly Brush DarkSquareBrush = Brushes.Gray;
        private readonly Font PieceFont = new Font("Arial", 32);
        private readonly Brush PieceBrush = Brushes.Black;
        private readonly Brush PieceBrush1 = Brushes.AntiqueWhite;
        private readonly int[] PieceValues = { 1, 2, 3,4, 5, 9 };
        private int[,] Board = new int[BoardSize, BoardSize];
       
        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
    
        }

        private void InitializeBoard()
        {
            
            Board[0, 0] = Board[0, 7] = PieceValues[3];
            Board[7, 0] = Board[7, 7] = -PieceValues[3];
            Board[0, 1] = Board[0, 6] = PieceValues[1];
            Board[7, 1] = Board[7, 6] = -PieceValues[1];
            Board[0, 2] = Board[0, 5] = PieceValues[2];
            Board[7, 2] = Board[7, 5] = -PieceValues[2];
            Board[0, 3] = PieceValues[4];
            Board[7, 3] = -PieceValues[4];
            Board[0, 4] = PieceValues[5];
            Board[7, 4] = -PieceValues[5];
            Board[1,0]= Board[1, 1]= Board[1, 2]= Board[1, 3]= Board[1, 4]= PieceValues[0];
            Board[1, 5] = Board[1, 6] = Board[1, 7]= PieceValues[0];
            Board[6, 0] = Board[6, 1] = Board[6, 2] = Board[6, 3] = Board[6, 4] = -PieceValues[0];
            Board[6, 5] = Board[6, 6] = Board[6, 7] = -PieceValues[0];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard(e.Graphics);
            DrawPieces(e.Graphics);
        }

        private void DrawBoard(Graphics g)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Brush brush = (x + y) % 2 == 0 ? LightSquareBrush : DarkSquareBrush;
                    g.FillRectangle(brush, x * SquareSize+ SquareSize, y * SquareSize+ SquareSize, SquareSize, SquareSize);
                }
            }
        }

        private void DrawPieces(Graphics g)
        {
            int row = 1;
            char stow = 'A';
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (y == 0 )
                    {

                        Point position = new Point(x * SquareSize + SquareSize, y * SquareSize);
                        g.DrawString(row.ToString(), PieceFont, PieceBrush, position);
                        row++;
                    }
                    if (x == 0)
                    {

                        Point position = new Point(x * SquareSize , y * SquareSize + SquareSize);
                        g.DrawString(stow.ToString(), PieceFont, PieceBrush, position);
                        stow++;
                    }
                    int pieceValue = Board[x, y];
                    if (pieceValue > 0)
                    {
                        char pieceSymbol = GetPieceSymbol(pieceValue);
                        Point position = new Point(x * SquareSize - (SquareSize / 4) + SquareSize, y * SquareSize + SquareSize);
                        g.DrawString(pieceSymbol.ToString(), PieceFont, PieceBrush, position);
                    }
                    else if (pieceValue < 0)
                    {
                        char pieceSymbol = GetPieceSymbol(pieceValue);
                        Point position = new Point(x * SquareSize - (SquareSize / 4) + SquareSize, y * SquareSize + SquareSize);
                        g.DrawString(pieceSymbol.ToString(), PieceFont, PieceBrush1, position);
                    }

                }
            }
        }

        private char GetPieceSymbol(int pieceValue)
        {
            switch (Math.Abs(pieceValue))
            {
                case 1:
                    return '♙'; // пішак 
                case 2:
                    return '♘'; // конь 
                case 3:
                    return '♗'; // слон 
                case 4:
                    return '♖'; // тура 
                case 5:
                    return '♕'; // королева 
                case 9:
                    return '♔'; // король 
                default:
                    throw new ArgumentException("Invalid piece value");
            }
        }


         
        private void Piece_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {

                int pieceValue = Board[e.X / SquareSize - 1, e.Y / SquareSize - 1];
                if (pieceValue != 0)
                {
                    char pieceSymbol = GetPieceSymbol(pieceValue);
                    MessageBox.Show($"{pieceSymbol.ToString()}");

                }
            }
        }

    }
}
