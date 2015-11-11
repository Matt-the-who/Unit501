/*
Created by Matthew Ho
Created on 11-11-15
Created for ICS3U
Assignment #5-`01
This program uses arrays to ~ the average of 10 random numbers.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit501
{
    public partial class frmArrays : Form
    {
        //Global variable of array
        int[] arrayOfNumbers = new int[10];

        //Random number generator
        Random rnd = new Random();

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Clear the array and listbox
            this.lstNumbers.Items.Clear();
            Array.Clear(arrayOfNumbers, 0, 10);

            //Variables
            int numbersGenerated = 0;
            int sumOfNumbers = 0;
            double averageOfNumbers = 0;

            //A for loop that loops until 10 and adds 10 random numbers to the array and listbox/
            for(int counter = 0; counter < 10; counter++)
            {
                numbersGenerated = rnd.Next(1 , 10+1);
                arrayOfNumbers[counter] = numbersGenerated;
                this.lstNumbers.Items.Add(numbersGenerated);
            }

            //Output
            sumOfNumbers = arrayOfNumbers.Sum();
            averageOfNumbers = Convert.ToDouble (sumOfNumbers) / 10;
            this.lblAverage.Text = "The average is " + averageOfNumbers;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
