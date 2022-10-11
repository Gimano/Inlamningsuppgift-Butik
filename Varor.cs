using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_Butik
{
    internal abstract class Ware
    {

        private double rating;
        public double Rating
        {
            get { return rating; }
            set { rating = Math.Round(value, 1); }
        }
        public string? ProductArt { get; set; }
        public decimal Price { get; set; }   
    }

    internal class Tshirt : Ware, IComparable
    {
        public string? Size { get; set; }
        public string? Material { get; set; }

        public Tshirt ()
        {
            ProductArt = "";
            Rating = 0.0d;
            Price = 0;
            Size = "";
            Material = "";
        }
        public Tshirt (string? productArt, double rating, decimal price, string? size, string? material)
        {
            ProductArt = productArt;
            Rating = rating;
            Price = price;
            Size = size;
            Material = material;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Tshirt? nextWare = obj as Tshirt;
            if (nextWare != null)
            {
                return nextWare.Rating.CompareTo(this.Rating);
            }
            else
            {
                throw new ArgumentException("Object doesn't have a proper rating");
            }
        }
    }

    internal class Mug : Ware, IComparable
    {
        public string? Type { get; set; }

        public Mug()
        {
            ProductArt = "";
            Rating = 0.0d;
            Price = 0;
            Type = "";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Mug? nextMug = obj as Mug;
            if (nextMug != null)
            {
                return this.Rating.CompareTo(nextMug.Rating);
            }
            else
            {
                throw new ArgumentException("Object doesn't have a proper rating");
            }
        }
    }
}
