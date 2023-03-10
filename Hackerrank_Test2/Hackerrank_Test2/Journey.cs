namespace Hackerrank_Test2
{
    public class Journey
    {
        public void MyMethod()
        {
            int flightTime = 110;
            int[] movies = new int[] { 10, 30, 10, 10, 10, 70 };
            List<string> CombinationOfMovies = new List<string>();
            string[] movieTitles = new string[] { "Movie-1", "Movie-2", "Movie-3", "Movie-4", "Movie-5", "Movie-6" };
            for (int i = 0; i < Math.Pow(2, movies.Length); i++)
            {
                int currentTime = flightTime;
                string currentMovie = "";
                for (int j = 0; j < movies.Length; j++)
                {
                   if ((i & (1 << j)) > 0)
                    {
                        currentTime -= movies[j];
                        currentMovie += movieTitles[j] + " ";
                    }
                }
                if (currentTime == 0)
                {
                    CombinationOfMovies.Add(currentMovie);
                }
            }
            foreach (string movie in CombinationOfMovies)
            {
                Console.WriteLine(movie);
            }
            //int flightTime = 120;
            //List<string> Movies = new List<string>();
            //string[] movieTimings = File.ReadAllLines("C:\\Users\\Durga Anaparthi\\Documents\\MoviesTime.txt");
            //List<string> movieNames = new List<string>();
            //List<int> movieDuration = new List<int>();
            //foreach (string line in movieTimings)
            //{
            //    string[] parts = line.Split('=');
            //    movieNames.Add(parts[0]);
            //    movieDuration.Add(int.Parse(parts[1]));
            //}
            //int[] movies = movieDuration.ToArray();
            //for (int i = 0; i < Math.Pow(2, movies.Length); i++)
            //{
            //    int currentTime = flightTime;
            //    string currentMovie = "";
            //    for (int j = 0; j < movies.Length; j++)
            //    {
            //        if ((i & (1 << j)) > 0)
            //        {
            //            currentTime -= movies[j];
            //            currentMovie += movieNames[j] + " ";
            //        }
            //    }
            //    if (currentTime == 0)
            //    {
            //        Movies.Add(currentMovie);
            //    }
            //}
            //foreach (string movie in Movies)
            //{
            //    Console.WriteLine(movie);
            //}
        }

    }
    

}





