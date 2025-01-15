using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pou_Game_Lib
{
    public class MyPou : Pou
    {
        public MyPou(string name)  : base(name) { }


        public override string AsciiArtMegkapas()
        {
            switch (JelenlegiHangulat)
            {
                case Hangulat.Vidám:
                    return File.ReadAllText("PouVeryHappyAscii.txt");
                case Hangulat.Boldog:
                    return File.ReadAllText("PouHappyAscii.txt");
                case Hangulat.Semleges:
                    return File.ReadAllText("PouNeturalAscii.txt");
                case Hangulat.Unott:
                    return File.ReadAllText("PouBoredAscii.txt");
                case Hangulat.Szomorú:
                    return File.ReadAllText("PouSadAscii.txt");
                case Hangulat.Beteg:
                    return File.ReadAllText("PouSickAscii.txt");
                default:
                    return File.ReadAllText("PouNeturalAscii.txt");
            }
        }
    }
}
