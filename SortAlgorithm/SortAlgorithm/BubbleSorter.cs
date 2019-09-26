using SortAlgorithm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class BubbleSorter : ISorter
    {

        private SortOrder sortOrder;

        public BubbleSorter(SortOrder sortOrder)
        {
            this.sortOrder = sortOrder;
        }

        public List<Contact> Sort(List<Contact> contacts)
        {
            Contact[] a = contacts.ToArray();
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i].LastName.CompareTo(a[i + 1].LastName)>0 && sortOrder == SortOrder.Asc)
                    {
                        Contact t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                    else if (a[i].LastName.CompareTo(a[i + 1].LastName) < 0 && sortOrder == SortOrder.Desc)
                    {
                        Contact t = a[i];
                        a[i] = a[i +1];
                        a[i +1] = t;
                    }
                }
            }

            return a.ToList();
        }
    }
}
