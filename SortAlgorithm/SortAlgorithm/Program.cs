using Newtonsoft.Json;
using SortAlgorithm.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contactList;
            using (StreamReader file = File.OpenText(@"MOCK_DATA.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                
                 contactList = (List<Contact>)serializer.Deserialize(file, typeof(List<Contact>));
            }


            var contactListAscBubble = SortFactory.GetSortType(SortType.BubbleSort, SortOrder.Asc).Sort(contactList);

            var contactListDescBubble = SortFactory.GetSortType(SortType.BubbleSort, SortOrder.Desc).Sort(contactList);

            var contactListAscQuick = SortFactory.GetSortType(SortType.QuickSort, SortOrder.Asc).Sort(contactList);

            var contactListDescQuick = SortFactory.GetSortType(SortType.QuickSort, SortOrder.Desc).Sort(contactList);


        }
    }
}
