using System.Drawing;
using System.Windows.Forms;

namespace GUI
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

            }
        }
        private void LoadResult()
        {
            Panel guiPanel = new Panel()
            {

            }
        }
        private void LoadButtons(string country, int v, int countrynumber)
        {
            Panel guiPanel = new Panel()
            {
                Margin = new System.Windows.Forms.Padding(),
                Dock = System.Windows.Forms.DockStyle.Fill
            };
            ExtendedRadio yesButton = new ExtendedRadio();
            yesButton.ButtonName = country;
            yesButton.Text = "Yes";
            yesButton.Anchor = AnchorStyles.Left;
            

            ExtendedRadio abstainButton = new ExtendedRadio();
            abstainButton.ButtonName = country;
            abstainButton.Text = "Abstain";
            abstainButton.Anchor = AnchorStyles.None;
            abstainButton.Location = new Point(guiPanel.Location.X = guiPanel.Width / 3);

            ExtendedRadio noButton = new ExtendedRadio();
            noButton.ButtonName = country;
            noButton.Text = "Abstain";
            noButton.Anchor = AnchorStyles.Right;
            

            guiPanel.Controls.Add(yesButton);
            guiPanel.Controls.Add(abstainButton);
            guiPanel.Controls.Add(noButton);
            tablePanel

        }
        private void LoadCountry(string country, int v, int countrynumber)
        {
            Panel guiPanel = new Panel()
            {

            }
        }


    }
}

