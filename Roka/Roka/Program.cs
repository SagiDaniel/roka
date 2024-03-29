﻿using System;
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
            #region bekeresek 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Adja meg hogy milyen széles legyen a mező:");
            int mezoy = int.Parse(Console.ReadLine());
            Console.Write("Adja meg hogy milyen magas legyen a mező:");
            int mezox = int.Parse(Console.ReadLine());
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
                            nyul[x, y] = 3;
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
                        if (rnd.Next(1, 5) > 3 && nyul[x, y] != 3)
                        {
                            if (nyulszamolas < nyulszam)
                            {
                                nyulszamolas++;
                                nyul[x, y] = 3;
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
                    if (nyul[x, y] >= 1)
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
                        if (rokaszamolas < rokaszam && nyul[x, y] != 5)
                        {
                            rokaszamolas++;
                            roka[x, y] = 10;
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
                        if (rnd.Next(1, 5) > 3 && roka[x, y] != 10 && nyul[x, y] != 5)
                        {
                            if (rokaszamolas < rokaszam)
                            {
                                rokaszamolas++;
                                roka[x, y] = 10;
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
                    if (roka[x, y] >= 1)
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
                    if (nyul[x, y] >= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(nyul[x, y] + ",");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(nyul[x, y] + ",");
                    }
                    if (roka[x, y] >= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(roka[x, y] + "\t ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(roka[x, y] + "\t ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Inuljon a menet?(Igen/Nem)");
            string beker = Console.ReadLine();
            var mozognyul = 0;
            int haromhely = 0;
            int ketohely = 0;
            int rokaol = 0;
            #endregion
            //cselekvesek
            if (beker == "Igen" || beker == "I" || beker == "igen" || beker == "i")
            {
                do
                {
                    for (int x = 0; x < mezox; x++)
                    {
                        for (int y = 0; y < mezoy; y++)
                        {
                            mezox--;
                            mezoy--;
                            rokaol = 0;
                            #region hplevonas
                            if (nyul[x, y] != 0)
                            {
                                nyul[x, y] = nyul[x, y] - 1;
                            }
                            if (roka[x, y] != 0)
                            {
                                roka[x, y] = roka[x, y] - 2;
                            }
                            #endregion
                            #region fuetkezes
                            if (fu[x, y] != 1 && nyul[x, y] != 0)
                            {

                                if (fu[x, y] == 3)
                                {
                                    nyul[x, y] = 3;
                                }
                                else if (fu[x, y] == 2)
                                {
                                    if (nyul[x, y] == 1)
                                    {
                                        nyul[x, y] = 2;
                                    }
                                    else if (nyul[x, y] == 2)
                                    {
                                        nyul[x, y] = 3;
                                    }
                                }
                                fu[x, y] = fu[x, y] - 1;
                            }
                            #endregion
                            #region roka kill
                            if (roka[x, y] != 0 && nyul[x, y] != 0)
                            {
                                
                                roka[x, y] += nyul[x, y];
                                if (roka[x, y] > 10)
                                {
                                    roka[x, y] = 10;
                                }
                                nyul[x, y] = 0;
                                rokaol++;
                            }
                            #endregion
                            //mozgasok
                            #region nyul mozgas
                            if (fu[x, y] == 1 && nyul[x, y] != 0)
                            {
                                //x-2
                                if (x >= 2)
                                {
                                    if (roka[x - 2, y] == 0 && fu[x - 2, y] == 3 && nyul[x - 2, y] == 0)
                                    {
                                        haromhely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 2, y - 1] == 0 && fu[x - 2, y - 1] == 3 && nyul[x - 2, y - 1] == 0 && x >= 2 && y >= 1)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 2, y - 2] == 0 && fu[x - 2, y - 2] == 3 && nyul[x - 2, y - 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 2, y + 1] == 0 && fu[x - 2, y + 1] == 3 && nyul[x - 2, y + 1] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 2, y + 2] == 0 && fu[x - 2, y + 2] == 3 && nyul[x - 2, y + 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                }
                                //x-1
                                if (x >= 1)
                                {
                                    if (roka[x - 1, y] == 0 && fu[x - 1, y] == 3 && nyul[x - 1, y] == 0 && x >= 1)
                                    {
                                        haromhely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 1, y - 1] == 0 && fu[x - 1, y - 1] == 3 && nyul[x - 1, y - 1] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 1, y - 2] == 0 && fu[x - 1, y - 2] == 3 && nyul[x - 1, y - 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 1, y + 1] == 0 && fu[x - 1, y + 1] == 3 && nyul[x - 1, y + 1] == 0)
                                        {
                                            haromhely++;
                                        }

                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 1, y + 2] == 0 && fu[x - 1, y + 2] == 3 && nyul[x - 1, y + 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }

                                }
                                //x
                                if (y >= 1)
                                {
                                    if (roka[x, y - 1] == 0 && fu[x, y - 1] == 3 && nyul[x, y - 1] == 0)
                                    {
                                        haromhely++;
                                    }
                                }
                                if (y >= 2)
                                {
                                    if (roka[x, y - 2] == 0 && fu[x, y - 2] == 3 && nyul[x, y - 2] == 0)
                                    {
                                        haromhely++;
                                    }
                                }
                                if (y <= mezoy - 1)
                                {
                                    if (roka[x, y + 1] == 0 && fu[x, y + 1] == 3 && nyul[x, y + 1] == 0)
                                    {
                                        haromhely++;
                                    }
                                }
                                if (y <= mezoy - 2)
                                {
                                    if (roka[x, y + 2] == 0 && fu[x, y + 2] == 3 && nyul[x, y + 2] == 0)
                                    {
                                        haromhely++;
                                    }
                                }
                                //x+1
                                if (x <= mezox - 1)
                                {
                                    if (roka[x + 1, y] == 0 && fu[x + 1, y] == 3 && nyul[x + 1, y] == 0)
                                    {
                                        haromhely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 1, y - 1] == 0 && fu[x + 1, y - 1] == 3 && nyul[x + 1, y - 1] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 1, y - 2] == 0 && fu[x + 1, y - 2] == 3 && nyul[x + 1, y - 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 1, y + 1] == 0 && fu[x + 1, y + 1] == 3 && nyul[x + 1, y + 1] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 1, y + 2] == 0 && fu[x + 1, y + 2] == 3 && nyul[x + 1, y + 2] == 0)
                                        {
                                            haromhely++;
                                        }
                                    }
                                }
                                //x+2
                                if (x <= mezox - 2)
                                {
                                    if (roka[x + 2, y] == 0 && fu[x + 2, y] == 3 && nyul[x + 2, y] == 0 && x <= mezox - 2)
                                    {
                                        haromhely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 2, y - 1] == 0 && fu[x + 2, y - 1] == 3 && nyul[x + 2, y - 1] == 0 && x <= mezox - 2 && y >= 1)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 2, y - 2] == 0 && fu[x + 2, y - 2] == 3 && nyul[x + 2, y - 2] == 0 && x <= mezox - 2 && y >= 2)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 2, y + 1] == 0 && fu[x + 2, y + 1] == 3 && nyul[x + 2, y + 1] == 0 && x <= mezox - 2 && y <= mezoy - 1)
                                        {
                                            haromhely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 2, y + 2] == 0 && fu[x + 2, y + 2] == 3 && nyul[x + 2, y + 2] == 0 && x <= mezox - 2 && y <= mezoy - 2)
                                        {
                                            haromhely++;
                                        }
                                    }
                                }
                                //masodikhely
                                //x-2
                                if (x >= 2)
                                {
                                    if (roka[x - 2, y] == 0 && fu[x - 2, y] == 2 && nyul[x - 2, y] == 0)
                                    {
                                        ketohely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 2, y - 1] == 0 && fu[x - 2, y - 1] == 2 && nyul[x - 2, y - 1] == 0 && x >= 2 && y >= 1)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 2, y - 2] == 0 && fu[x - 2, y - 2] == 2 && nyul[x - 2, y - 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 2, y + 1] == 0 && fu[x - 2, y + 1] == 2 && nyul[x - 2, y + 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 2, y + 2] == 0 && fu[x - 2, y + 2] == 2 && nyul[x - 2, y + 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                }
                                //x-1
                                if (x >= 1)
                                {
                                    if (roka[x - 1, y] == 0 && fu[x - 1, y] == 2 && nyul[x - 1, y] == 0 && x >= 1)
                                    {
                                        ketohely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 1, y - 1] == 0 && fu[x - 1, y - 1] == 2 && nyul[x - 1, y - 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 1, y - 2] == 0 && fu[x - 1, y - 2] == 2 && nyul[x - 1, y - 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 1, y + 1] == 0 && fu[x - 1, y + 1] == 2 && nyul[x - 1, y + 1] == 0)
                                        {
                                            ketohely++;
                                        }

                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 1, y + 2] == 0 && fu[x - 1, y + 2] == 2 && nyul[x - 1, y + 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }

                                }
                                //x
                                if (y >= 1)
                                {
                                    if (roka[x, y - 1] == 0 && fu[x, y - 1] == 2 && nyul[x, y - 1] == 0)
                                    {
                                        ketohely++;
                                    }
                                }
                                if (y >= 2)
                                {
                                    if (roka[x, y - 2] == 0 && fu[x, y - 2] == 2 && nyul[x, y - 2] == 0)
                                    {
                                        ketohely++;
                                    }
                                }
                                if (y <= mezoy - 1)
                                {
                                    if (roka[x, y + 1] == 0 && fu[x, y + 1] == 2 && nyul[x, y + 1] == 0)
                                    {
                                        ketohely++;
                                    }
                                }
                                if (y <= mezoy - 2)
                                {
                                    if (roka[x, y + 2] == 0 && fu[x, y + 2] == 2 && nyul[x, y + 2] == 0)
                                    {
                                        ketohely++;
                                    }
                                }
                                //x+1
                                if (x <= mezox - 1)
                                {
                                    if (roka[x + 1, y] == 0 && fu[x + 1, y] == 2 && nyul[x + 1, y] == 0)
                                    {
                                        ketohely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 1, y - 1] == 0 && fu[x + 1, y - 1] == 2 && nyul[x + 1, y - 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 1, y - 2] == 0 && fu[x + 1, y - 2] == 2 && nyul[x + 1, y - 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 1, y + 1] == 0 && fu[x + 1, y + 1] == 2 && nyul[x + 1, y + 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 1, y + 2] == 0 && fu[x + 1, y + 2] == 2 && nyul[x + 1, y + 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                }
                                //x+2
                                if (x <= mezox - 2)
                                {
                                    if (roka[x + 2, y] == 0 && fu[x + 2, y] == 2 && nyul[x + 2, y] == 0)
                                    {
                                        ketohely++;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 2, y - 1] == 0 && fu[x + 2, y - 1] == 2 && nyul[x + 2, y - 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 2, y - 2] == 0 && fu[x + 2, y - 2] == 2 && nyul[x + 2, y - 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 2, y + 1] == 0 && fu[x + 2, y + 1] == 2 && nyul[x + 2, y + 1] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 2, y + 2] == 0 && fu[x + 2, y + 2] == 2 && nyul[x + 2, y + 2] == 0)
                                        {
                                            ketohely++;
                                        }
                                    }
                                }
                            }
                            ketohely++;
                            haromhely++;
                            if (haromhely != 0)
                            {
                                mozognyul = rnd.Next(1, haromhely);
                            }
                            else if (ketohely != 0)
                            {
                                mozognyul = rnd.Next(1, ketohely);
                            }
                            if (fu[x, y] == 1 && nyul[x, y] != 0)
                            {
                                //x-2
                                if (x >= 2)
                                {
                                    if (roka[x - 2, y] == 0 && fu[x - 2, y] == 3 && nyul[x - 2, y] == 0 && mozognyul <= 1)
                                    {
                                        nyul[x - 2, y] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 2, y - 1] == 0 && fu[x - 2, y - 1] == 3 && nyul[x - 2, y - 1] == 0 && mozognyul <= 2)
                                        {
                                            nyul[x - 2, y - 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 2, y - 2] == 0 && fu[x - 2, y - 2] == 3 && nyul[x - 2, y - 2] == 0 && mozognyul <= 3)
                                        {
                                            nyul[x - 2, y - 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 2, y + 1] == 0 && fu[x - 2, y + 1] == 3 && nyul[x - 2, y + 1] == 0 && mozognyul <= 4)
                                        {
                                            nyul[x - 2, y + 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 2, y + 2] == 0 && fu[x - 2, y + 2] == 3 && nyul[x - 2, y + 2] == 0 && mozognyul <= 5)
                                        {
                                            nyul[x - 2, y + 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                }
                                //x-1
                                if (x >= 1)
                                {
                                    if (roka[x - 1, y] == 0 && fu[x - 1, y] == 3 && nyul[x - 1, y] == 0 && x >= 1 && mozognyul <= 6)
                                    {
                                        nyul[x - 1, y] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x - 1, y - 1] == 0 && fu[x - 1, y - 1] == 3 && nyul[x - 1, y - 1] == 0 && mozognyul <= 7)
                                        {
                                            nyul[x - 1, y - 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x - 1, y - 2] == 0 && fu[x - 1, y - 2] == 3 && nyul[x - 1, y - 2] == 0 && mozognyul <= 8)
                                        {
                                            nyul[x - 1, y - 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x - 1, y + 1] == 0 && fu[x - 1, y + 1] == 3 && nyul[x - 1, y + 1] == 0 && mozognyul <= 9)
                                        {
                                            nyul[x - 1, y + 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }

                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x - 1, y + 2] == 0 && fu[x - 1, y + 2] == 3 && nyul[x - 1, y + 2] == 0 && mozognyul <= 10)
                                        {
                                            nyul[x - 1, y + 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                }
                                //x
                                if (y >= 1)
                                {
                                    if (roka[x, y - 1] == 0 && fu[x, y - 1] == 3 && nyul[x, y - 1] == 0 && mozognyul <= 11)
                                    {
                                        nyul[x, y - 1] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                }
                                if (y >= 2)
                                {
                                    if (roka[x, y - 2] == 0 && fu[x, y - 2] == 3 && nyul[x, y - 2] == 0 && mozognyul <= 12)
                                    {
                                        nyul[x, y - 2] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                }
                                if (y <= mezoy - 1)
                                {
                                    if (roka[x, y + 1] == 0 && fu[x, y + 1] == 3 && nyul[x, y + 1] == 0 && mozognyul <= 13)
                                    {
                                        nyul[x, y + 1] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                }
                                if (y <= mezoy - 2)
                                {
                                    if (roka[x, y + 2] == 0 && fu[x, y + 2] == 3 && nyul[x, y + 2] == 0 && mozognyul <= 14)
                                    {
                                        nyul[x, y + 2] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                }
                                //x+1
                                if (x <= mezox - 1)
                                {
                                    if (roka[x + 1, y] == 0 && fu[x + 1, y] == 3 && nyul[x + 1, y] == 0 && mozognyul <= 15)
                                    {
                                        nyul[x + 1, y] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 1, y - 1] == 0 && fu[x + 1, y - 1] == 3 && nyul[x + 1, y - 1] == 0 && mozognyul <= 16)
                                        {
                                            nyul[x + 1, y - 1] = nyul[x, y];
                                            nyul[x, y] = 0;

                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 1, y - 2] == 0 && fu[x + 1, y - 2] == 3 && nyul[x + 1, y - 2] == 0 && mozognyul <= 17)
                                        {
                                            nyul[x + 1, y - 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 1, y + 1] == 0 && fu[x + 1, y + 1] == 3 && nyul[x + 1, y + 1] == 0 && mozognyul <= 18)
                                        {
                                            nyul[x + 1, y + 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 1, y + 2] == 0 && fu[x + 1, y + 2] == 3 && nyul[x + 1, y + 2] == 0 && mozognyul <= 19)
                                        {
                                            nyul[x + 1, y + 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                }
                                //x+2
                                if (x <= mezox - 2)
                                {
                                    if (roka[x + 2, y] == 0 && fu[x + 2, y] == 3 && nyul[x + 2, y] == 0 && x <= mezox - 2 && mozognyul <= 20)
                                    {
                                        nyul[x + 2, y] = nyul[x, y];
                                        nyul[x, y] = 0;
                                    }
                                    if (y >= 1)
                                    {
                                        if (roka[x + 2, y - 1] == 0 && fu[x + 2, y - 1] == 3 && nyul[x + 2, y - 1] == 0 && x <= mezox - 2 && y >= 1 && mozognyul <= 21)
                                        {
                                            nyul[x + 2, y - 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (roka[x + 2, y - 2] == 0 && fu[x + 2, y - 2] == 3 && nyul[x + 2, y - 2] == 0 && x <= mezox - 2 && y >= 2 && mozognyul <= 22)
                                        {
                                            nyul[x + 2, y - 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (roka[x + 2, y + 1] == 0 && fu[x + 2, y + 1] == 3 && nyul[x + 2, y + 1] == 0 && x <= mezox - 2 && y <= mezoy - 1 && mozognyul <= 23)
                                        {
                                            nyul[x + 2, y + 1] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (roka[x + 2, y + 2] == 0 && fu[x + 2, y + 2] == 3 && nyul[x + 2, y + 2] == 0 && x <= mezox - 2 && y <= mezoy - 2 && mozognyul <= 24)
                                        {
                                            nyul[x + 2, y + 2] = nyul[x, y];
                                            nyul[x, y] = 0;
                                        }
                                    }
                                }
                            }
                            haromhely = 0;
                            ketohely = 0;
                            #endregion
                            #region roka mozgas
                            if (rokaol == 0)
                            {
                                if (roka[x, y] != 0)
                                {
                                    //x-1
                                    if (x >= 1)
                                    {
                                        if (nyul[x - 1, y] != 0 && roka[x - 1, y] == 0)
                                        {
                                            roka[x - 1, y] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                        if (y >= 1)
                                        {
                                            if (nyul[x - 1, y - 1] != 0 && roka[x - 1, y - 1] == 0)
                                            {
                                                roka[x - 1, y - 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y >= 2)
                                        {
                                            if (nyul[x - 1, y - 2] != 0 && roka[x - 1, y - 2] == 0)
                                            {
                                                roka[x - 1, y - 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 1)
                                        {
                                            if (nyul[x - 1, y + 1] != 0 && roka[x - 1, y + 1] == 0)
                                            {
                                                roka[x - 1, y + 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 2)
                                        {
                                            if (nyul[x - 1, y + 2] != 0 && roka[x - 1, y + 2] == 0)
                                            {
                                                roka[x - 1, y + 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                    }
                                    //x-2
                                    if (x >= 2)
                                    {
                                        if (nyul[x - 2, y] != 0 && roka[x - 2, y] == 0)
                                        {
                                            roka[x - 2, y] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                        if (y >= 1)
                                        {
                                            if (nyul[x - 2, y - 1] != 0 && roka[x - 2, y - 1] == 0)
                                            {
                                                roka[x - 2, y - 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y >= 2)
                                        {
                                            if (nyul[x - 2, y - 2] != 0 && roka[x - 2, y - 2] == 0)
                                            {
                                                roka[x - 2, y - 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 1)
                                        {
                                            if (nyul[x - 2, y + 1] != 0 && roka[x - 2, y + 1] == 0)
                                            {
                                                roka[x - 2, y + 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 2)
                                        {
                                            if (nyul[x - 2, y + 2] != 0 && roka[x - 2, y + 2] == 0)
                                            {
                                                roka[x - 2, y + 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                    }
                                    //x
                                    if (y >= 1)
                                    {
                                        if (nyul[x, y - 1] != 0 && roka[x, y - 1] == 0)
                                        {
                                            roka[x, y - 1] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                    }
                                    if (y >= 2)
                                    {
                                        if (nyul[x, y - 2] != 0 && roka[x, y - 2] == 0)
                                        {
                                            roka[x, y - 2] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 1)
                                    {
                                        if (nyul[x, y + 1] != 0 && roka[x, y + 1] == 0)
                                        {
                                            roka[x, y + 1] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                    }
                                    if (y <= mezoy - 2)
                                    {
                                        if (nyul[x, y + 2] != 0 && roka[x, y + 2] == 0)
                                        {
                                            roka[x, y + 2] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                    }
                                    //x+1
                                    if (x <= mezox - 1)
                                    {
                                        if (nyul[x + 1, y] != 0 && roka[x + 1, y] == 0)
                                        {
                                            roka[x + 1, y] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                        if (y >= 1)
                                        {
                                            if (nyul[x + 1, y - 1] != 0 && roka[x + 1, y - 1] == 0)
                                            {
                                                roka[x + 1, y - 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y >= 2)
                                        {
                                            if (nyul[x + 1, y - 2] != 0 && roka[x + 1, y - 2] == 0)
                                            {
                                                roka[x + 1, y - 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 1)
                                        {
                                            if (nyul[x + 1, y + 1] != 0 && roka[x + 1, y + 1] == 0)
                                            {
                                                roka[x + 1, y + 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 2)
                                        {
                                            if (nyul[x + 1, y + 2] != 0 && roka[x + 1, y + 2] == 0)
                                            {
                                                roka[x + 1, y + 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                    }
                                    //x+2
                                    if (x <= mezox - 2)
                                    {
                                        if (nyul[x + 2, y] != 0 && roka[x + 2, y] == 0)
                                        {
                                            roka[x + 2, y] = roka[x, y];
                                            roka[x, y] = 0;
                                        }
                                        if (y >= 1)
                                        {
                                            if (nyul[x + 2, y - 1] != 0 && roka[x + 2, y - 1] == 0)
                                            {
                                                roka[x + 2, y - 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y >= 2)
                                        {
                                            if (nyul[x + 2, y - 2] != 0 && roka[x + 2, y - 2] == 0)
                                            {
                                                roka[x + 2, y - 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 1)
                                        {
                                            if (nyul[x + 2, y + 1] != 0 && roka[x + 2, y + 1] == 0)
                                            {
                                                roka[x + 2, y + 1] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                        if (y <= mezoy - 2)
                                        {
                                            if (nyul[x + 2, y + 2] != 0 && roka[x + 2, y + 2] == 0)
                                            {
                                                roka[x + 2, y + 2] = roka[x, y];
                                                roka[x, y] = 0;
                                            }
                                        }
                                    }
                                }
                                #endregion
                                //szaporodas  
                                #region nyulszaporodas
                                /*
                                if (nyul[x, y] != 0)
                                {
                                    if (nyul[x + 1, y] != 0 && x <= mezox - 1)
                                    {
                                        if (fu[x, y - 1] > 0 && roka[x, y - 1] == 0 && y >= 1)
                                        {
                                            nyul[x, y - 1] = 3;
                                        }
                                        else if (fu[x, y + 1] > 0 && roka[x, y + 1] == 0)
                                        {
                                            nyul[x, y + 1] = 3;
                                        }
                                        else if (fu[x + 1, y + 1] > 0 && roka[x + 1, y + 1] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x + 1, y + 1] = 3;
                                        }
                                        else if (fu[x - 1, y] > 0 && roka[x - 1, y] == 0)
                                        {
                                            nyul[x - 1, y] = 3;
                                        }
                                        else if (fu[x + 1, y - 1] > 0 && roka[x + 1, y - 1] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x + 1, y - 1] = 3;
                                        }
                                        else if (fu[x + 2, y] > 0 && roka[x + 2, y] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x + 2, y] = 3;
                                        }
                                    }
                                    else if (nyul[x, y - 1] != 0 && y >= 1)
                                    {
                                        if (fu[x - 1, y] > 0 && roka[x - 1, y] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x - 1, y] = 3;
                                        }
                                        else if (fu[x - 1, y - 1] > 0 && roka[x - 1, y - 1] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x - 1, y - 1] = 3;
                                        }
                                        else if (fu[x, y + 1] > 0 && roka[x, y + 1] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x, y + 1] = 3;
                                        }
                                        else if (fu[x + 1, y - 1] > 0 && roka[x + 1, y - 1] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x + 1, y - 1] = 3;
                                        }
                                        else if (fu[x + 1, y] > 0 && roka[x + 1, y] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x + 1, y] = 3;
                                        }
                                        else if (fu[x, y - 2] > 0 && roka[x, y - 2] == 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            nyul[x, y - 2] = 3;
                                        }
                                    }
                                }
                                */
                                #endregion
                                #region rokaszaporodas
                                /*
                                if (roka[x, y] != 0)
                                {
                                    if (roka[x + 1, y] > 5)
                                    {
                                        if (roka[x + 2, y] == 0 && fu[x + 2, y] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x + 2, y] = 5;
                                        }
                                        else if (roka[x - 1, y] == 0 && fu[x - 1, y] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x - 1, y] = 5;
                                        }
                                        else if (roka[x, y - 1] == 0 && fu[x, y - 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x, y - 1] = 5;
                                        }
                                        else if (roka[x, y + 1] == 0 && fu[x, y + 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x, y + 1] = 5;
                                        }
                                        else if (roka[x + 1, y - 1] == 0 && fu[x + 1, y - 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x + 1, y - 1] = 5;
                                        }
                                        else if (roka[x + 1, y + 1] == 0 && fu[x + 1, y + 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x + 1, y + 1] = 5;
                                        }
                                    }
                                    else if (roka[x, y - 1] > 5)
                                    {
                                        if (roka[x - 1, y] == 0 && fu[x - 1, y] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x - 1, y] = 5;
                                        }
                                        else if (roka[x - 1, y - 1] == 0 && fu[x - 1, y - 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x - 1, y - 1] = 5;
                                        }
                                        else if (roka[x, y - 2] == 0 && fu[x, y - 2] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x, y - 2] = 5;
                                        }
                                        else if (roka[x + 1, y - 1] == 0 && fu[x + 1, y - 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x + 1, y - 1] = 5;
                                        }
                                        else if (roka[x + 1, y] == 0 && fu[x + 1, y] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x + 1, y] = 5;
                                        }
                                        else if (roka[x, y + 1] == 0 && fu[x, y + 1] > 0 && x <= 1 && x <= mezox && y <= 1 && y <= mezoy)
                                        {
                                            roka[x, y + 1] = 5;
                                        }
                                    }
                                }
                                */
                                #endregion 
                            }

                            #region fu noves
                            if (fu[x, y] != 3 && nyul[x, y] == 0)
                            {
                                fu[x, y]++;
                            }
                            #endregion
                            mezoy++;
                            mezox++;
                        }
                    }
                    #region kiiras

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
                            if (nyul[x, y] >= 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(nyul[x, y] + ",");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(nyul[x, y] + ",");
                            }
                            if (roka[x, y] >= 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(roka[x, y] + "\t ");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(roka[x, y] + "\t ");
                            }
                        }
                        Console.WriteLine("\n");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Jöjjön a következő kör?(Igen/Nem)");
                    beker = Console.ReadLine();
                } while (beker == "Igen" || beker == "I" || beker == "igen" || beker == "i");
                #endregion
            }
            Console.ReadKey();
        }
    }
}
