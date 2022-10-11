using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roka
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Adja meg hogy milyen széles legyen a mező:");
            int mezox = int.Parse(Console.ReadLine());
            Console.Write("Adja meg hogy milyen magas legyen a mező:");
            int mezoy = int.Parse(Console.ReadLine());
            int ossz = mezoy * mezox;
            Console.WriteLine($"Összesen {ossz} mező van");
            Console.WriteLine("\n");
            Random rnd = new Random();
            int[,] fu = new int[mezox, mezoy];
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    fu[x, y] = rnd.Next(1, 4);
                }
            }
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (fu[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t " + fu[x, y]);
                    }
                    else if (fu[x, y] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\t " + fu[x, y]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\t " + fu[x, y]);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Így néz ki a mező \n");
            Console.Write("Adja meg a nyulak számát (lehetőleg ne legyen sok):");
            int nyulszam = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int nyulszamolas = 0;
            int[,] nyul = new int[mezox, mezoy];
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (rnd.Next(1, 5) > 3)
                    {
                        if (nyulszamolas < nyulszam)
                        {
                            nyulszamolas++;
                            nyul[x, y] = 1;
                        }
                        else
                        {
                            nyul[x, y] = 0;
                        }
                    }
                }
            }
            do
            {
                   for (int x = 0; x < mezox; x++)
                    {
                        for (int y = 0; y < mezoy; y++)
                        {
                            if (rnd.Next(1, 5) > 3 && nyul[x, y] != 1)
                            {
                                if (nyulszamolas < nyulszam)
                                {
                                    nyulszamolas++;
                                    nyul[x, y] = 1;
                                }
                                else
                                {
                                    nyul[x, y] = 0;
                                }
                            }
                        }
                    }
                
            } while (nyulszamolas != nyulszam);
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (nyul[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\t " + nyul[x, y]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t " + nyul[x, y]);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Így jöttek létre a nyulak a mezőn \n");
            Console.Write("Adja meg a rókák számát (lehetőleg ne legyen sok):");
            int rokaszam = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int rokaszamolas = 0;
            int[,] roka = new int[mezox, mezoy];
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (rnd.Next(1, 5) > 3)
                    {
                        if (rokaszamolas < rokaszam && nyul[x,y]!=1)
                        {
                            rokaszamolas++;
                            roka[x, y] = 1;
                        }
                        else
                        {
                            roka[x, y] = 0;
                        }
                    }
                }
            }
            do
            {
                for (int x = 0; x < mezox; x++)
                {
                    for (int y = 0; y < mezoy; y++)
                    {
                        if (rnd.Next(1, 5) > 3 && roka[x, y] != 1 && nyul[x, y] != 1)
                        {
                            if (rokaszamolas < rokaszam)
                            {
                                rokaszamolas++;
                                roka[x, y] = 1;
                            }
                            else
                            {
                                roka[x, y] = 0;
                            }
                        }
                    }
                }

            } while (rokaszamolas != rokaszam);
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (roka[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t " + roka[x, y]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t " + roka[x, y]);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Így jöttek létre a rókák a mezőn \n");
            for (int x = 0; x < mezox; x++)
            {
                for (int y = 0; y < mezoy; y++)
                {
                    if (fu[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(fu[x, y] + ",");
                    }
                    else if (fu[x, y] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(fu[x, y] + ",");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(fu[x, y] + ",");
                    }
                    if (nyul[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(nyul[x, y] + ",");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(nyul[x, y] + ",");
                    }
                    if (roka[x, y] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(roka[x, y]+ "\t ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(roka[x, y]+ "\t ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
