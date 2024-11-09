using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFahrenheitTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initializing variables
            double fahrenheit;
            double celsius;

            // Adding a header to the table
            temperatureListBox.Items.Add("Celsius\t\tFahrenheit");

            // Display the values for celsius to fahrenheit conversion with a for loop
            for (celsius = 0; celsius <= 100; celsius++) // I wanted to start at 0 and go all the way up to boiling point
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32; // using the provided formula to calculate fahrenheit temps from celsius
                temperatureListBox.Items.Add(celsius + "\t|\t" + fahrenheit); // iterating new lines to the list box for each celsius value
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
