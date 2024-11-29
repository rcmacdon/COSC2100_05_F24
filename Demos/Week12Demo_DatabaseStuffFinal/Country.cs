using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Week12Demo_DatabaseStuffFinal.Properties;

namespace Week12Demo_DatabaseStuffFinal
{
    public class Country
    {
        public static List<Country> countries = new List<Country>();

        public String CountryID { get; set; }
        public String CountryName { get; set; }
        public int RegionID { get; set; }

        public Country() { }

        public Country(String countryID, String countryName, int regionID)
        {
            CountryID = countryID;
            CountryName = countryName;
            RegionID = regionID;
        }

        public static void PopulateCountries()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                //SqlCommand cmd = new SqlCommand("SELECT * FROM Countries", conn);
                SqlCommand cmd;

                conn.Open();

                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Countries";
                cmd.CommandType = System.Data.CommandType.Text;


                // SELECT * FROM countries WHERE UPPER(CountryName) LIKE '@Letter%'

                //cmd = new SqlCommand();
                //cmd.Connection = conn;
                //cmd.CommandText = "spGetSomeCountries";
                //cmd.Parameters.AddWithValue("@Letter", letter);
                //cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Country c = new Country();
                    //c.CountryID = reader.GetInt32(0);
                    c.CountryID = reader["CountryID"].ToString();
                    c.CountryName = reader["CountryName"].ToString();
                    c.RegionID = (int)reader["RegionID"];
                    countries.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool UpdateCountry()
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @CountryName, RegionID = @RegionID WHERE CountryID = @CountryID", conn);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
                cmd.Parameters.AddWithValue("@RegionID", RegionID);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                conn.Close();
                return isSuccessful;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InsertCountry()
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                SqlCommand cmd = new SqlCommand("INSERT INTO Countries (CountryID, CountryName, RegionID) VALUES (@CountryID, @CountryName, @RegionID)", conn);
                cmd.Parameters.AddWithValue("@CountryID", CountryID);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
                cmd.Parameters.AddWithValue("@RegionID", RegionID);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                conn.Close();
                return isSuccessful;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool DeleteCountry(String countryID)
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                SqlCommand cmd = new SqlCommand("DELETE FROM Countries WHERE CountryID = @CountryID", conn);
                cmd.Parameters.AddWithValue("@CountryID", countryID);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                conn.Close();
                return isSuccessful;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        }
}
