using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedjivanjeBiljka
{
    internal class Program
    {
        class Biljka
        {

        }
        class Stablo : Biljka
        {
            public bool otpadajuLIstovi;

            public Stablo(bool otpadajuLIstovi)
            {
                this.otpadajuLIstovi = otpadajuLIstovi;
            }

            public bool OtpadajuLIstovi { get => otpadajuLIstovi; set => otpadajuLIstovi = value; }

            public virtual string Ispis()
            {
                return "Otpadaju listovi: " + otpadajuLIstovi;
            }
        }
        class Cvijet : Biljka
        {

        }

        class Bijelogoricno : Stablo
        {
            public override string Ispis()
            {
                return "Otpadaju listovi: " + otpadajuLIstovi; 
            }

            public Bijelogoricno(bool otpadajuLIstovi) : base(otpadajuLIstovi)
            {
            }
        }

        class Crnogoricno : Stablo
        {
            public override string Ispis()
            {
                return "Otpadaju listovi: " + otpadajuLIstovi;
            }

            public Crnogoricno(bool otpadajuLIstovi) : base(otpadajuLIstovi)
            {
            }
        }
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);

            Console.WriteLine(Hrast.Ispis());
            Console.WriteLine(Bor.Ispis());

            Console.ReadKey();
        }
    }
}
