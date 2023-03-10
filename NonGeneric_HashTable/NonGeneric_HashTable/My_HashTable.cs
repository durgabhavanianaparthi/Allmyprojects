using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric_HashTable
{
    public class My_HashTable
    {
        public void Mymethod()
        {
            Hashtable objHashTable = new Hashtable();


            objHashTable.Add("A1", "Chinni");
            objHashTable.Add("1", "Durga");
            objHashTable.Add("Bhavani ", "3");
            objHashTable.Add(0.3,12);

            foreach (DictionaryEntry Element in objHashTable)
            {
                Console.WriteLine("key: {0} and value is : {1}", Element.Key, Element.Value);
            }
        }

        //private void Add(string v1, string v2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}



    

