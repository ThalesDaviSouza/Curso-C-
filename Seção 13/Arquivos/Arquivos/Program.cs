using System.IO;
using System.Collections.Generic;
using Arquivos.Entities;

class Program {
    public static void Main(string[] args) {
        try {
            // Directories
            string currentDirectory = Directory.GetCurrentDirectory();
            string pathInput = (currentDirectory + @"\input.csv");
            string pathOut = (currentDirectory + @"\out\output.csv");


            string[] input = File.ReadAllLines(pathInput);
            List<Input> inputs = new List<Input>();
            List<Output> outputs = new List<Output>();

            // Read the inputs
            foreach (string s in input) {
                string[] infomations = s.Split(',');
                string name = infomations[0];
                double value = double.Parse(infomations[1]);
                int quantity = int.Parse(infomations[2]);

                inputs.Add(new Input(name, value, quantity));
            }

            // Creating the outputs
            foreach (Input i in inputs) {
                outputs.Add(new Output(i.Name, (i.Quantity * i.Value)));
            }

            // If the output folder didn't exists, create it
            if (Directory.GetDirectories(currentDirectory).ToList().Find(directory => directory == (currentDirectory + @"\out")) == null) {
                Directory.CreateDirectory(currentDirectory + @"\out");
            }

            // Write the outputs in the file
            using (StreamWriter sw = File.CreateText(pathOut)) {
                foreach (Output o in outputs) {
                    sw.WriteLine($"{o.Name},{o.TotalValue.ToString("F2")}");
                }
            }
        }
        catch (IOException e) {
            Console.WriteLine("An error ocurred.");
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
