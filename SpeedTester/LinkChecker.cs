using System;
using System.Linq;

namespace SpeedTester
{
    class LinkChecker
    {
        public void Check(string url, int numOfTimes)
        {
            try
            {
                Console.WriteLine("## Starting to check - " + url + " ##");

                for (int x = 0; x < numOfTimes; x++)
                {
                    CheckLink.Run(url);
                }

                CalculateAverage();
            }
            catch (Exception ex)
            {
                Console.WriteLine("## Unknown Exception " + ex.Message + " ##");
            }
        }

        private void CalculateAverage()
        {
            // sort the list
            CheckLink.Speeds.Sort();

            // remove the first and last in case of odd inconsistency
            CheckLink.Speeds.RemoveAt(0);
            CheckLink.Speeds.RemoveAt(CheckLink.Speeds.Count - 1);

            int total = CheckLink.Speeds.Sum();
            int avg = total / CheckLink.Speeds.Count;

            Console.WriteLine("The average run-time was: " + avg + " milliseconds");
        }
    }
}
