using System;
using Pou_Game_Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Üdvözlünk a Pou The Game nevezetű virtuális játékban.");
        Pou enPoum = null;


        if (enPoum != null)
        {
            Console.WriteLine("Milyen nevet szeretnél megadni a Poud-nak?");
            enPoum.Nev = Console.ReadLine();

            Console.Clear();

            bool exit = false;
            while (!exit)
            {

            }
        }
        else
        {
            Console.WriteLine("Érvénytelen válasz kérlek indítsd újra a programot!");
        }
    }
}

