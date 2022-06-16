using System;
using System.Linq;
using System.Text;

namespace Pawn_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];

            int WR = 0;
            int WC = 0;
            int BR = 0;
            int BC = 0;
             for (int r = 0; r < 8; r++)
                {
                    string input = Console.ReadLine();
                    for (int c = 0; c < 8; c++)
                    {
                        matrix[r, c] = input[c];

                        if (matrix[r, c] == 'w')
                        {
                            
                            WR = r;
                            WC = c;
                        }
                        else if (matrix[r, c] == 'b')
                        {
                            BR = r;
                            BC = c;
                        }

                    }
                }
              
           
            while (true)
            {


                if ( WR - 1 > 0 && WC - 1 >= 0  && matrix[WR - 1, WC - 1] == 'b')
                {
                    matrix[WR, WC] = '-';
                    WR -= 1;
                    WC -= 1;
                    matrix[WR, WC] = 'w';
                    int WRC = Math.Abs(WR - 8);
                    char value = (char)(WC + 97);
                    Console.WriteLine($"Game over! White capture on {value.ToString() + WRC}.");
                    return;

                }
                else if (WR - 1 > 0 && WC + 1 <= 7  && matrix[WR - 1, WC + 1] == 'b')
                {
                    matrix[WR, WC] = '-';
                    WR -= 1;
                    WC += 1;
                    matrix[WR, WC] = 'w';
                    int WRC = Math.Abs(WR - 8);
                    char value = (char)(WC + 97);
                    Console.WriteLine($"Game over! White capture on {value.ToString() + WRC}.");
                    return;
                }
                else
                {
                    matrix[WR, WC] = '-';
                    WR -= 1;
                    matrix[WR, WC] = 'w';

                    if (WR == 0)
                    {

                        int WRC = Math.Abs(WR - 8);
                        char value = (char)(WC + 97);
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {value.ToString() + WRC}.");
                        return;
                    }

                }


                if (BR + 1 < 7 && BC - 1 >= 0  && matrix[BR + 1, BC - 1] == 'w')
                {
                    matrix[BR, BC] = '-';
                    BR += 1;
                    BC -= 1;
                    matrix[BR, BC] = 'b';
                    int BRC = Math.Abs(BR - 8);
                    char value = (char)(BC + 97);
                    Console.WriteLine($"Game over! Black capture on {value.ToString() + BRC}.");
                    return;


                }
                else if (BR + 1 < 7 && BC + 1 <= 7  && matrix[BR + 1, BC + 1] == 'w')
                {
                    matrix[BR, BC] = '-';
                    BR += 1;
                    BC += 1;
                    matrix[BR, BC] = 'b';
                    int BRC = Math.Abs(BR - 8);
                    char value = (char)(BC + 97);
                    Console.WriteLine($"Game over! Black capture on {value.ToString() + BRC}.");
                    return;

                }
                else
                {
                    matrix[BR, BC] = '-';
                    BR += 1;
                    matrix[BR, BC] = 'b';
                    if (BR == 7)
                    {
                        int BRC = Math.Abs(BR - 8);
                        char value = (char)(BC + 97);
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {value.ToString() + BRC}.");
                        return;
                    }
                }
            }


        }
    }
}
