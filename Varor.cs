using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_Butik
{
    interface IVaror
    {
        string Motiv { get; set; }
        double Betyg { get; set; }
        decimal Pris { get; set; }   
    }

    internal class Tshirt : IVaror
    {
        public string Motiv { get; set; }
        public double Betyg { get; set; }
        public decimal Pris { get; set; }
        public string Storlek { get; set; }
        public string Material { get; set; }
    }

    internal class Mug : IVaror
    {
        public string Motiv { get; set; }
        public double Betyg { get; set; }
        public decimal Pris { get; set; }
        public string Typ { get; set; }
    }
}
