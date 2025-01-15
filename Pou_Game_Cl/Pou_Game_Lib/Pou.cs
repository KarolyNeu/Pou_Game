using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pou_Game_Lib
{
    public abstract class Pou
    {
        public enum Hangulat
        {
            Vidám,
            Boldog,
            Semleges,
            Unott,
            Szomorú,
            Beteg
        }

        public string Nev {  get; set; }

        public int Ehseg { get; protected set; } = 10;

        public int Boldogsag { get; protected set; } = 10;

        public int Szomjusag { get; protected set; } = 10;

        public Hangulat JelenlegiHangulat { get; protected set; }

        public void ValtozoStatok()
        {
            Ehseg -= 1;
            Szomjusag -= 1;
            Boldogsag -= 1;

            Ehseg = Math.Max(Ehseg, 0);
            Szomjusag = Math.Max(Szomjusag, 0);
            Boldogsag = Math.Max(Boldogsag, 0);


            if (Ehseg == 0 || Szomjusag == 0 || Boldogsag == 0 )
            {
                Console.WriteLine($"{Nev} has passed away.");
            }
        }

        public void HangulatValtozas()
        {
            if (Boldogsag > 14)
            {
                JelenlegiHangulat = Hangulat.Vidám;
            }
            else if (Boldogsag > 12)
            {
                JelenlegiHangulat = Hangulat.Boldog;
            }
            else if ( Boldogsag >= 10)
            {
                JelenlegiHangulat = Hangulat.Semleges;
            }

            if (Boldogsag < 5)
            {
                JelenlegiHangulat = Hangulat.Unott;
            }

            if (Boldogsag < 3 && Ehseg < 3)
            {
                JelenlegiHangulat = Hangulat.Beteg;
            }
        }

        protected Pou (string name)
        {
            Nev = name;
        }

        public virtual void Eves()
        {
            Console.Clear();

            Console.WriteLine($"Válassz egy ételt mit egyen a Pou-d!");
            Console.WriteLine($"[1] KFC");
            Console.WriteLine($"[2] Tészta");

            string foodChoice = Console.ReadLine();

            string foodResponse = "";
            switch (foodChoice)
            {
                case "1":
                    foodResponse = "*Nyam nyam* Miért kezd a bőrőm sötétebb lenni??\n Ja csak leettem magam";
                    break;
                case "2":
                    foodResponse = "*Habububu* Finom finom!\n";
                    break;
                default:
                    foodResponse = "Nem hiszem, hogy ezt megtudom enni!\n";
                    break;
            }

            Ehseg += 2;
        }
        public virtual void Ivas()
        {
            Console.Clear();

            Console.WriteLine($"Válassz egy ételt mit egyen a Pou-d!");
            Console.WriteLine($"[1] Víz");
            Console.WriteLine($"[2] Görögdinnyés ital");
            Console.WriteLine($"[3] Fehér Monster");
            Console.WriteLine($"[4] Meggyes sör");

            string drinkChoice = Console.ReadLine();

            string drinkResponse = "";
            switch (drinkChoice)
            {
                case "1":
                    drinkChoice = "Hajnali 3-kor a legjobb.\n";
                    break;
                case "2":
                    drinkChoice = "Egy KFC-t enni emellé a legjobb lenne.\n";
                    break;
                case "3":
                    drinkChoice = "Isteni\n";
                    break;
                case "4":
                    drinkChoice = "Ez már a 4. és csak dél van.\n";
                    break;
                default:
                    drinkChoice = "Nem hiszem, hogy ezt megtudom inni!\n";
                    break;
            }

            Szomjusag += 2;
        }

        public virtual void Jatek()
        {
            Console.Clear();
            Console.WriteLine("Válassz egy játékot a pou-dnak, hogy mit játszon");
            Console.WriteLine("[1] Labdázás");
            Console.WriteLine("[2] Focizás");
            Console.WriteLine("[3] Pumpálás");
            Console.WriteLine("[4] Clash Royale");
            Console.WriteLine("[5] Skibidi Toilet");
            Console.WriteLine("[6] Görgetésmaxolás");
            string playChoice = Console.ReadLine();

            string playResponse = "";
            switch (playChoice)
            {
                case "1":
                    playResponse = "Boing Boing\n";
                    break;
                case "2":
                    playResponse = "Jaj ne, véletlenül saját kapura játszottam.\n";
                    break;
                case "3":
                    playResponse = "(Szivás hang) már csak egypár pumpa maradt\n";
                    break;
                case "4":
                    playResponse = "(Agresszív asztal verés hangok) Ezt nem hiszem el!!!\n";
                    break;
                case "5":
                    playResponse = "Gyerünk Camera man támadj rá!!!\n";
                    break;
                case "6":
                    playResponse = "I bought a property in Egypt and what they do for you, is they give you the property, Eye of Rah, Chopped Chin Dancing so nonchalant.\n";
                    break;
                default:
                    playResponse = "Gazdám nem hiszem, hogy tudnék ezzel játszani!\n";
                    break;
            }

          
            Boldogsag += 2;
        }



    }
}
