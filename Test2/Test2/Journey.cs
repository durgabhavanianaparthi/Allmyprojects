using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Journey
    {
        public void Mymethod()
        {
            //int[] movieDurations = { 20, 70, 50, 30, 120 };
            //int flightDuration = 120;
            //int movieCount = 0;

            //foreach (int movieDuration in movieDurations)
            //{
            //    if (movieDuration <= flightDuration)
            //    {
            //        movieCount++;
            //        flightDuration -= movieDuration;
            //    }
            //}

            //Console.WriteLine("Number of movies that can be watched: " + movieCount);
            int[] movieDurations = { 70,60,20,50,30 };
            string[] movieNames = { "Movie1", "Movie2", "Movie3", "Movie4", "Movie5" };
            int flightDuration = 150;
            List<List<string>> movieCombinations = new List<List<string>>();

            for (int i = 0; i < movieDurations.Length; i++)
            {
                if (movieDurations[i] <= flightDuration)
                {
                    List<string> combination = new List<string>
                    { 
                        movieNames[i]
                    };
                    int remainingDuration = flightDuration - movieDurations[i];
                    for (int j = i + 1; j < movieDurations.Length ; j++)
                    {
                        if (movieDurations[j] <= remainingDuration)
                        {
                            combination.Add(movieNames[j]);
                            remainingDuration -= movieDurations[j];
                        }
                    }
                    movieCombinations.Add(combination);
                }
            }

            foreach (var comb in movieCombinations)
            {
                Console.Write("Movie Combination: ");
                foreach (var m in comb)
                {
                    Console.Write(m + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
