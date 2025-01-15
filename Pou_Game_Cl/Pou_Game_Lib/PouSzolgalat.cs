using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pou_Game_Lib
{
    public static class PouSzolgalat
    {
        public static void AllapotMegjelenites(Pou pou)
        {
            Console.WriteLine($"{pou.Nev} állapota:");
            Console.WriteLine($"Éhség: {pou.Ehseg}");
            Console.WriteLine($"Szomjúság: {pou.Szomjusag}");
            Console.WriteLine($"Fáradtság: Kipihent");
            Console.WriteLine($"Hangulat: {pou.JelenlegiHangulat}");

        }

        public static void AsciiMegjelenites(Pou pet)
        {
            Console.WriteLine(pet.AsciiArtMegkapas());
        }
    }
}
