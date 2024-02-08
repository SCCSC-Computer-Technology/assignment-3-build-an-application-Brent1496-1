using System; //State class setup
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Brenton_Bindewald_Assignment3CPT_206_A01S_2024SP
{
    public class State
    {
        public string? StateName { get; set; }  
        public int? StatePopulation { get; set; }
        public string? StateFlower { get; set; }
        public string? StateBird { get; set; }
        public string? Colors { get; set; }
        public string? ThreeLargestCities { get; set; }
        public string? StateCapitol { get; set; }
        public decimal? MedianIncome { get; set; }
        public decimal? PercentOfComputerJobs { get; set; }

        public static State GetStateDetails(string stateName, string connectionString) 
        {
            State state = null;
            string query = "SELECT * FROM StateTable WHERE StateName = @StateName";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StateName", stateName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        state = new State
                        {
                            StateName = reader["StateName"].ToString(),
                            StatePopulation = Convert.ToInt32(reader["StatePopulation"]),
                            StateFlower = reader["StateFlower"].ToString(),
                            StateBird = reader["StateBird"].ToString(),
                            Colors = reader["Colors"].ToString(),
                            ThreeLargestCities = reader["ThreeLargestCities"].ToString(),
                            StateCapitol = reader["StateCapitol"].ToString(),
                            MedianIncome = Convert.ToDecimal(reader["MedianIncome"]),
                            PercentOfComputerJobs = Convert.ToDecimal(reader["PercentOfComputerJobs"])
                        };
                    }
                    reader.Close();
                }
                catch (OleDbException ex)
                {
                    // Handle database exception
                }
            }

            return state;
        }
    }
}
