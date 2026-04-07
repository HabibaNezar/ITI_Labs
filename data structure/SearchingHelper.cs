using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal static class SearchingHelper
    {
        public static int BinarySearch(int[] ar, int start, int end, int key)
        {
            int low = start;
            int high = end;
            int mid;
            int loc = -1;
            while(loc == -1 && low <= high)
            {
                mid = (low + high) / 2;
                if (ar[mid] == key)
                {
                    loc = mid;
                }
                else if(ar[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            };
            return loc;
        } 
    }
}
