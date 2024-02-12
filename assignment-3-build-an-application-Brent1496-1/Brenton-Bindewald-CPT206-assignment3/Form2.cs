using System;  //Form 2 opens once the user selects a state from the downdown, along with the filtered information
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP;

namespace Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP
{
    public partial class Form2 : Form
    {
        public Form2(string stateName, State state)
        {
            InitializeComponent();
            labelStateName.Text = stateName;
            DisplayStateDetails(state);
        }

        private void DisplayStateDetails(State state) //Set up foe the state info labels.
        {
            if (state != null)
            {
                labelStateName.Text = state.StateName;
                labelStatePopulation.Text = state.StatePopulation.ToString();
                labelStateFlower.Text = state.StateFlower;
                labelStateBird.Text = state.StateBird;
                labelColors.Text = state.Colors;
                labelThreeLargestCities.Text = state.ThreeLargestCities;
                labelStateCapitol.Text = state.StateCapitol;
                labelMedianIncome.Text = state.MedianIncome.ToString();
                labelPercentOfComputerJobs.Text = state.PercentOfComputerJobs.ToString();
            }
            else
            {
                MessageBox.Show("State details are null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error message
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

