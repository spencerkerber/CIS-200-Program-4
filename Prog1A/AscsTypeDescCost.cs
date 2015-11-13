using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class AscsTypeDescCost :IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: When item1 < item2, method returns negative #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns positive #
        public int Compare(Parcel item1, Parcel item2)
        {
            string type1; // Item1's type
            string type2; // Item2's type

            if (item1 == null && item2 == null) 
                return 0;

            if (item1 == null) 
                return -1;

            if (item2 == null) 
                return 1;

            type1 = item1.GetType().ToString();
            type2 = item2.GetType().ToString();

            if (type1 == type2) 
                return (item1.CalcCost()).CompareTo(item2.CalcCost());

            return type1.CompareTo(type2);
        }
    }
}
