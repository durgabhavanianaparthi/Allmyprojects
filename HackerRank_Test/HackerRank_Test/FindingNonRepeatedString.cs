using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Test
{
   public class FindingNonRepeatedString
    {


        public static (int index, char letter) first_non_repeated(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input.IndexOf(input[i]) == input.LastIndexOf(input[i]))
                {
                    return (i, input[i]);
                }
            }
            return (-1, ' ');
        }

        //  public  static List<(int index, char letter)> non_repeated_indexes(string input)
        //  {
        //    var indexes = new List<(int index, char letter)>();

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input.IndexOf(input[i]) == input.LastIndexOf(input[i]))
        //        {

        //            indexes.Add((i, input[i]));

        //        }
        //    }
        //    return indexes;
        //}

    }
}
