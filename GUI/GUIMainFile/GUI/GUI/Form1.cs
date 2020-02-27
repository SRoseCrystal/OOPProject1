using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Main
{
    public partial class Form1 : Form
    {
        Countries countryFile = new Countries();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "EU Council Voting Calculator";
            int countryNumber = 27;
            int nameandvote = 2;
            int countrynumber = 0;
            InitTable(tablePanel, countryNumber, nameandvote);
            LoadRules();
            LoadResult();
            foreach(DataRow dataRow in Countries.countries)
            {
                string country = dataRow["name"].ToString();
                if(countrynumber < countryNumber)
                {
                    LoadCountry(country, 0, countrynumber);
                    LoadButtons(country, 1, countrynumber);
                    countrynumber++;
                }
            }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1141, 521);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
