using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija_DrugiPokusaj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MJENJAČNICA");
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.WriteLine("Upišite iznos KUNA(cijeli broj) koje želite promijeniti (u tekstualnom obliku):");
            string BrojeviText = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Upišite tečaj EUR-a (u brojčanom decimalnom zapisu):");
            double TecajEura = double.Parse(Console.ReadLine());

            string[] BrojText = BrojeviText.Split(' ');

            /*foreach (var item in BrojText)
            {
                Console.WriteLine(item);
            }*/

            int brojac = 0;

            for (int i = 0; i < BrojText.Length; i++)
            {
                switch (BrojText[i])
                {
                    case "nula":
                        BrojText[i] = "0";
                        brojac++;
                        break;
                    case "jedan":
                        BrojText[i] = "1";
                        brojac++;
                        break;
                    case "dva":
                        BrojText[i] = "2";
                        brojac++;
                        break;
                    case "tri":
                        BrojText[i] = "3";
                        brojac++;
                        break;
                    case "četiri":
                        BrojText[i] = "4";
                        brojac++;
                        break;
                    case "pet":
                        BrojText[i] = "5";
                        brojac++;
                        break;
                    case "šest":
                        BrojText[i] = "6";
                        brojac++;
                        break;
                    case "sedam":
                        BrojText[i] = "7";
                        brojac++;
                        break;
                    case "osam":
                        BrojText[i] = "8";
                        brojac++;
                        break;
                    case "devet":
                        BrojText[i] = "9";
                        brojac++;
                        break;

                }

            }
            

            int[] NumBroj = new int[20];

            for (int i = 0; i < BrojText.Length; i++)
            {
                NumBroj[i] = int.Parse(BrojText[i]);
            }

            double rezultat = 0;

            for (int i = 0; i < NumBroj.Length; i++)
            {
                rezultat += NumBroj[i] * Math.Pow(10, brojac - (i+1)); 
                
            }

            double spremacBroja = rezultat;

            Console.WriteLine("{0} KN po tecaju {1} iznosi {2} EUR",spremacBroja,TecajEura,rezultat/TecajEura);








          Console.ReadLine();
        }
    }
}
