using System;
using System.Linq;
using System.IO;


namespace Wordy
{
    class Results
    {
        public string[] names = new string[50000];
        public double[] ReScores = new double[50000];

        
        public void Results_Get()
        {
            int i = 0;

            try
            {

                using (StreamReader results = new StreamReader(File.OpenRead("Results.txt")))
                {


                    string[] parts = { " " };
                    string lines = " ";

                    while ((lines = results.ReadLine()) != null)
                    {
                        parts = lines.Split('\t');

                        names[i] = parts[0];
                        try {
                            ReScores[i] = Double.Parse(parts[1]);
                        }
                        catch (IOException) { }
                            i++;
                    }



                }
            }
            catch (IOException) {}



        }



        public void Results_Sorting()
        {
            double temp = 0;
            string name = "";
            int count = File.ReadAllLines("Results.txt").Count();
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count; j++)
                {

                    if (ReScores[j] < ReScores[j + 1])
                    {
                        temp = ReScores[j];
                        ReScores[j] = ReScores[j + 1];
                        ReScores[j + 1] = temp;

                        name = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = name;

                    }
                }
            }
        }
      }
}
