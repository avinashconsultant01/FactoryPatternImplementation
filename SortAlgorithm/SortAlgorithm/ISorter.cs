using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public interface ISorter
    {
        List<Contact> Sort(List<Contact> contacts);
    }
}
