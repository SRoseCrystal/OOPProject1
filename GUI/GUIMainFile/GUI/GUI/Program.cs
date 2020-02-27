using System;
using System.Windows.Forms;

namespace Main
{

    static class Program
    {
        private static bool vote;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }



        // Below class is for the Unaminity voting rule.
        static public bool Unaminity(Countries[] country)
        {
            foreach (Countries x in country) // Iterates through all countries in the arr country 
            {
                if (x.GetVote()) // Iterates through the Country array checking if the vote it false. 
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        // Below class is for the Simple Majority voting rule.
        static public object Smajority(Countries[] country)
        {
            int votes = 0;
            foreach (Countries x in country) // Iterates through all countries in the arr country 
            {
                for (x.GetVote())
                {
                    if (vote == true)
                    {
                        votes++;
                    }
                }
                if (votes >= 14)
                {
                    return true;
                }
            }
            return false;
        }

        // Below class is for the qualified majority. 
        static public bool Qmajority(countryPop[] country)
        {
            int totalPop = 0;
            int countryPop = 0;
            foreach (countryPop x in country)
            {
                if (!x.GetVote()) // Iterates through the Country array checking if the vote it false. 
                {
                    totalPop += countryPop;
                }
                if (totalPop >= 55)
                {
                    return true;
                }
            }
            return true;
        }



    }
}
