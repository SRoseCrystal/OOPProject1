using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.ID;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Main
{
    public partial class Form1 : Form
    {
        Countries countries = new Countries();
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable LoadTable()
        {
        DataSet countryList = countries
        DataTable countryTable = countryList.Tables("Countries");
        return countryTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "EU Council Voting Calculator";
            int countryNumber = 27;
            int nameandvote = 2;
            int countrynumber = 0;
            DataTable file = LoadTable();
            InitTable(tablePanel, countryNumber, nameandvote);
            LoadRules();
            LoadResult();
            foreach(DataRow dataRow in file.Rows)
            {
                string country = dataflow["name"].ToString();
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
