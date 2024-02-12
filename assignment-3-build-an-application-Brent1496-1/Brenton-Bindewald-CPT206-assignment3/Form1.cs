//This program takes data from a Access Database named 'USA_Database'. and provides it via a windows form after the user selects a state from the dropdown.
using System; 
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP;

namespace Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Databases\USA_Database.accdb;"; //Connection string to access database. I also added the database to the solution explorer so it can be accessed there too.

        public Form1()
        {
            InitializeComponent();
            LoadStates();
        }

        private void LoadStates()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT StateName FROM StateTable";
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        StateComboBox.Items.Add(reader["StateName"].ToString());
                    }

                    reader.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e) //Setup dropdown menu
        {
            string selectedState = StateComboBox.SelectedItem.ToString();
            State state = State.GetStateDetails(selectedState, connectionString);
            if (state != null)
            {
                Form2 form2 = new Form2(selectedState, state);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("State details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Close program
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            // Check if a state is selected
            if (StateComboBox.SelectedItem != null)
            {
                string selectedState = StateComboBox.SelectedItem.ToString();
                // Fetch state details from the database or wherever they are stored
                State state = State.GetStateDetails(selectedState, connectionString);
                // Open Form2 with the selected state details
                if (state != null)
                {
                    Form2 form2 = new Form2(selectedState, state);
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("State details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
