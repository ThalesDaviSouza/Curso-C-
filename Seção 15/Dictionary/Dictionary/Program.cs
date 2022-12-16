using System;
using System.Collections.Generic;
using System.Reflection.Metadata;


public class Program {
    static void Main(string[] args) {
        try {
            string currentDirectory = Directory.GetCurrentDirectory();
            string inputFile = currentDirectory + @"\in.txt";

            // Creating a default input file
            if (!File.Exists(inputFile)) {
                using(StreamWriter sw = File.CreateText(inputFile)) {
                    sw.WriteLine("Alex Blue,15");
                    sw.WriteLine("Maria Green,22");
                    sw.WriteLine("Bob Brown,21");
                    sw.WriteLine("Alex Blue,30");
                    sw.WriteLine("Bob Brown,15");
                    sw.WriteLine("Maria Green,27");
                    sw.WriteLine("Maria Green,22");
                    sw.WriteLine("Bob Brown,25");
                    sw.WriteLine("Alex Blue,31");
                }
            }

            //Reading the data on input file
            SortedDictionary<string, int> votesCount = new SortedDictionary<string, int>();

            using(StreamReader sr = File.OpenText(inputFile)) {
                while (!sr.EndOfStream) {
                    string[] info = sr.ReadLine().Split(",");
                    string name = info[0];
                    int count = int.Parse(info[1]);

                    if (votesCount.ContainsKey(name)) {
                        votesCount[name] += count;
                    }
                    else {
                        votesCount.Add(name, count);
                    }
                }
            }

            //Sorting the Dictionary based on the value, not based on key
            List<KeyValuePair<string, int>> sortedVotes = votesCount.ToList();
            sortedVotes.Sort((a, b) => b.Value.CompareTo(a.Value));

            //Printing the data
            Console.WriteLine("Votes count:");
            foreach(var vote in sortedVotes) {
                Console.WriteLine(vote.Key + ": " + vote.Value);
            }

        }
        catch(Exception e) {
            Console.WriteLine("An error ocurred: " + e.Message);
        }


    }
}