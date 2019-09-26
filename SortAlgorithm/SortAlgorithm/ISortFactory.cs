using SortAlgorithm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public static class SortFactory
    {
        public static  ISorter GetSortType(SortType sortType, SortOrder sortOrder)
        {
            if(sortType == SortType.BubbleSort)
            {
                return new BubbleSorter(sortOrder);
            }
            else
            {
                return new QuickSorter(sortOrder);
            }
        }
    }
}
