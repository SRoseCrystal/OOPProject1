using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        private void InitComp()
        {
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanel.AutoScroll = true;
            this.tablePanel.BackColor = System.Drawing.Color.White;
            this.tablePanel.Location = new System.Drawing.Point(10, 20);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(800, 600);


        }
        private void InitTable(TableLayoutPanel panel, int countryNumber, int nameandvote)
        {
            panel.ColumnCount = countryNumber;
            panel.RowCount = nameandvote;
            panel.RowStyles.Clear



        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void LoadRules()
        {
            Panel guiPanel = new Panel()
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

            guiPanel.Controls.Add(unaminityButton);
            guiPanel.Controls.Add(smajorityButton);
            guiPanel.Controls.Add(qmajorityButton);
            tablePanel.Controls.Add(guiPanel);

        }
        private void LoadResult()
        {
            Panel guiPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            Label resultBox = new Label();
            resultBox.Name = "...";
            resultBox.Text = "Result";
            resultBox.Anchor = AnchorStyles.Bottom;

            guiPanel.Controls.Add(resultBox);
            tablePanel.Controls.Add(guiPanel);

        }
        private void LoadButtons(string country, int v, int countrynumber)
        {
            Panel guiPanel = new Panel()
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
            abstainButton.Location = new Point(guiPanel.Location.X = guiPanel.Width / 3);

            RadioButton noButton = new RadioButton();
            noButton.Name = country;
            noButton.Text = "Abstain";
            noButton.Anchor = AnchorStyles.Right;


            guiPanel.Controls.Add(yesButton);
            guiPanel.Controls.Add(abstainButton);
            guiPanel.Controls.Add(noButton);
            tablePanel.Controls.Add(guiPanel, v, countrynumber);

        }
        private void LoadCountry(string country, int v, int countrynumber)
        {
            Panel guiPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            foreach countrynumber(){ }

        }


    }
}

