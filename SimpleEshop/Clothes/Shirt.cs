using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEshop.Enums;
using SimpleEshop.Clothes;

namespace SimpleEshop.Clothes
{
    public enum Upperwear
    {
        Jacket,
        TShirt,
        Shirt,
        Sweater,
        Blouse
    }

    public class Shirt : Clothes
    {
        public Upperwear Type;
        public Sizes Size;
        public bool LongSleeves;
        public bool HasHood;
        //public bool HasPockets;
        public bool HasZip;



        public Shirt(Upperwear type, Sizes size, Sex sex, Enums.Color color, double price, string brand, int quantityInStock) : base(sex, color, price, brand, quantityInStock)
        {
            Type = type;
            Size = size;
            //HasZip = false;
            //HasHood = false;
            //HasPockets = false;
        }

        public Shirt(Upperwear type, Sizes size, Sex sex, Enums.Color color, double price, string brand, int quantityInStock, bool hasLLongSleeves, bool hasZip, bool hasHood) : this(type, size, sex, color, price, brand, quantityInStock)
        {
            LongSleeves = hasLLongSleeves;
            HasZip = hasZip;
            HasHood = hasHood;
            //HasPockets = hasPockets;
        }
    }
}
