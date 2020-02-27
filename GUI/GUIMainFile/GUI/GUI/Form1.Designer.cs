using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        TableLayoutPanel tablePanel = new TableLayoutPanel();
        private void InitComp()
        {


            tablePanel = new System.Windows.Forms.TableLayoutPanel();
            tablePanel.AutoScroll = true;
            tablePanel.BackColor = System.Drawing.Color.White;
            tablePanel.Location = new System.Drawing.Point(10, 20);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new System.Drawing.Size(800, 600);


        }
        public void InitTable(TableLayoutPanel panel, int countryNumber, int nameandvote)
        {
            panel.ColumnCount = countryNumber;
            panel.RowCount = nameandvote;
            panel.RowStyles.Clear();
            panel.ColumnStyles.Clear();
            for (int countrynumber = 27; countrynumber <= countryNumber; countrynumber++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                
            }



        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void LoadRules()
        {
            Panel rulesPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            RadioButton unaminityButton = new RadioButton();
            unaminityButton.Name = "Unaminity";
            unaminityButton.Text = "Unaminity";
            unaminityButton.Anchor = AnchorStyles.Left;

            RadioButton smajorityButton = new RadioButton();
            smajorityButton.Name = "Simple Majority";
            smajorityButton.Text = "Simple Majority";
            smajorityButton.Anchor = AnchorStyles.Left;

            RadioButton qmajorityButton = new RadioButton();
            qmajorityButton.Name = "Qualified Majority";
            qmajorityButton.Text = "Qualified Majority";
            qmajorityButton.Anchor = AnchorStyles.Left;

            rulesPanel.Controls.Add(unaminityButton);
            rulesPanel.Controls.Add(smajorityButton);
            rulesPanel.Controls.Add(qmajorityButton);
            tablePanel.Controls.Add(rulesPanel);

        }
        private void LoadResult()
        {
            Panel resultPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Label resultBox = new Label();
            resultBox.Name = "...";
            resultBox.Text = "Result";
            resultBox.Anchor = AnchorStyles.Bottom;

            resultPanel.Controls.Add(resultBox);
            tablePanel.Controls.Add(resultPanel);

        }
        public void LoadButtons(string country, int v, int countrynumber)
        {
            Panel buttonPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            RadioButton yesButton = new RadioButton();
            yesButton.Name = country;
            yesButton.Text = "Yes";
            yesButton.Anchor = AnchorStyles.Left;


            RadioButton abstainButton = new RadioButton();
            abstainButton.Name = country;
            abstainButton.Text = "Abstain";
            abstainButton.Anchor = AnchorStyles.None;
            abstainButton.Location = new Point(buttonPanel.Location.X, buttonPanel.Location.X = buttonPanel.Width / 3); 

            RadioButton noButton = new RadioButton();
            noButton.Name = country;
            noButton.Text = "No";
            noButton.Anchor = AnchorStyles.Right;


            buttonPanel.Controls.Add(yesButton);
            buttonPanel.Controls.Add(abstainButton);
            buttonPanel.Controls.Add(noButton);
            tablePanel.Controls.Add(buttonPanel, v, countrynumber);

        }
        public void LoadCountry(string country, int v, int countrynumber)
        {
            Panel countriesPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Label text = new Label();


        }


    }
}

