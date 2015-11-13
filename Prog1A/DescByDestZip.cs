// Spencer Kerber
// CIS 200-01
// Program 4
// Due 6/25/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class DescByDestZip :IComparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: When item1 < item2, method returns negative #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns positive #
        public int Compare(Parcel item1, Parcel item2)
        {
            if (item1 == null && item2 == null)
                return 0;

            if (item1 == null) 
                return -1;

            if (item2 == null) 
                return 1;

            return (item2.DestinationAddress.Zip).CompareTo(item1.DestinationAddress.Zip);
        }
    }
}
