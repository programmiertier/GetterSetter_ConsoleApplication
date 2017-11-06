using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GetterSetter_ConsoleApplication
{
    class Brummbrumm
    {
        private double _tankinhalt;
        private double _tankvolumen;
        private string _kennzeichen;

        public double tankinhalt
        {
            get
            {
                return _tankinhalt;
            }

            set
            {
                _tankinhalt = value;
            }
        }

        public double tankvolumen
        {
            get
            {
                return _tankvolumen;
            }

            set
            {
                _tankvolumen = value;
            }
        }

        public string kennzeichen
        {
            get
            {
                return _kennzeichen;
            }

            set
            {
                _kennzeichen = value;
            }
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Brummbrumm meinAutochen = new Brummbrumm();
            meinAutochen.tankinhalt = 55.30;
            WriteLine(meinAutochen.tankinhalt);
        }
    }
}
