using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public class CustomeList<T>
    {
        public List<T> MyList { get; set; }

        public void ShowListItems()
        {
            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowSpecificItem(int index)
        {
            Console.WriteLine(MyList[index]);
        }
    }
}
