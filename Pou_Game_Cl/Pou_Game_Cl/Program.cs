using System;
using Pou_Game_Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Üdvözlünk a Pou The Game nevezetű virtuális játékban.");
        string kezdes = Console.ReadLine();
        Pou enPoum = null;

        enPoum = new MyPou("Egy nevet adj meg majd!");

        if (enPoum != null)
        {
            Console.WriteLine("Milyen nevet szeretnél megadni a Poud-nak?");
            enPoum.Nev = Console.ReadLine();

            Console.Clear();

            bool exit = false;
            while (!exit)
            {
                enPoum.HangulatValtozas();
                if (enPoum.Ehseg == 0 && enPoum.Szomjusag == 0 && enPoum.Boldogsag == 0)
                {
                    Console.WriteLine("Sajnos elhunyt a Pou-d");
                    break;
                }

                PouSzolgalat.AsciiMegjelenites(enPoum);
                Console.WriteLine($"\nA jelenlegi hangulata a Pounak: {enPoum.JelenlegiHangulat}");
                Console.WriteLine($"A jelenlegi éhinség állapota: {enPoum.Ehseg}");
                Console.WriteLine($"A jelenlegi szomjúság állapota: {enPoum.Szomjusag}\n");
                Console.WriteLine("Mit szeretnél csinálni a Pouddal?");
                Console.WriteLine("[1] Megetetés");
                Console.WriteLine("[2] Itatni");
                Console.WriteLine("[3] Játék");
                Console.WriteLine("[4] Alvás");
                Console.WriteLine("[5] Jelenlegi Hangulata:");
                Console.WriteLine("[0] Exit");

                string dontes = Console.ReadLine();
                Console.Clear();

                switch (dontes)
                {
                    case "1":
                        enPoum.Eves();
                        break;
                    case "2":
                        enPoum.Ivas();
                        break;
                    case "3":
                        enPoum.Jatek();
                        break;
                    case "4":
                        Console.WriteLine("Alvás");
                        break;
                    case "5":
                        PouSzolgalat.AllapotMegjelenites(enPoum);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid response.");
                        break;
                }

                enPoum.IdoValtozas();

                Console.Clear();
                if (enPoum.Ehseg == 0 && enPoum.Szomjusag == 0 && enPoum.Boldogsag == 0)
                {
                    Console.WriteLine("Sajnos elhunyt a Pou-d");
                    exit = true;
                }
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen válasz kérlek indítsd újra a programot!");
        }
    }
}

