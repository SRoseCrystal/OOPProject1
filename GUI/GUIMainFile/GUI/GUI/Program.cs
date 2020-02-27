using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    
    static class Program
    {
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
            foreach (Country x in country) // Iterates through all countries in the arr country 
            {
                if (!x.GetVote()) // Iterates through the Country array checking if the vote it false. 
                {
                    return false;
                }
            }
            return true;
        }

        // Below class is for the Simple Majority voting rule.
        static public bool Smajority(Countries[] country)
        {
            int votes = 0;
            foreach (Country x in country) // Iterates through all countries in the arr country 
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
        static public bool Qmajority(Countries[] country)
        {
            int totalPop = 0;
            foreach (CountryPop x in country)
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
