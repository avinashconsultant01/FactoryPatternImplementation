using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithm.Enums;

namespace SortAlgorithm
{
    class QuickSorter : ISorter
    {
        private SortOrder sortOrder;

        public QuickSorter(SortOrder sortOrder)
        {
            this.sortOrder = sortOrder;
        }

        public List<Contact> Sort(List<Contact> contacts)
        {
           Contact[] arr = contacts.ToArray();
            int left = 0;
            int right = arr.Length - 1;

            Quick_Sort(arr, left,right);

            return arr.ToList();


        }

        private void Quick_Sort(Contact[] arr, int left, int right)
        {

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private int Partition(Contact[] arr, int left, int right)
        {
            var pivot = arr[left];
            while (true)
            {

                while (arr[left].LastName.CompareTo(pivot.LastName) < 0)
                {
                    left++;
                }

                while (arr[right].LastName.CompareTo(pivot.LastName) > 0)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[right].LastName.CompareTo(arr[left].LastName) == 0) return right;

                    Contact temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
            }
    }
}
