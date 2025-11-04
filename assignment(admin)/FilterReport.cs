using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_admin_
{
    public class FilterReport
    {
        private string connectionString;

        public FilterReport()
        {
            connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        }

        public DataTable FilteredData(string filterChoice)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "";

                // Switch statement to handle different filters
                switch (filterChoice)
                {
                    case "Month":
                        //query = "SELECT Month, TotalPrice FROM Sales";
                        query = "SELECT Month, SUM(TotalPrice) AS TotalPrice FROM Sales GROUP BY Month ORDER BY " +
                            "CASE Month WHEN 'January' THEN 1 " +
                            "WHEN 'February' THEN 2 " +
                            "WHEN 'March' THEN 3 " +
                            "WHEN 'April' THEN 4 " +
                            "WHEN 'May' THEN 5 " +
                            "WHEN 'June' THEN 6 " +
                            "WHEN 'July' THEN 7 " +
                            "WHEN 'August' THEN 8 " +
                            "WHEN 'September' THEN 9 " +
                            "WHEN 'October' THEN 10 " +
                            "WHEN 'November' THEN 11 " +
                            "WHEN 'December' THEN 12 END";
                        break;
                    case "Category":
                        //query = "SELECT Category, TotalPrice FROM Sales";
                        query = "SELECT Category, SUM(TotalPrice) AS TotalPrice FROM Sales GROUP BY Category";
                        break;
                    case "Chef":
                        //query = "SELECT Chef, TotalPrice FROM Sales";
                        query = "SELECT Chef, SUM(TotalPrice) AS TotalPrice FROM Sales GROUP BY Chef";
                        break;
                    default:
                        throw new ArgumentException("Invalid filter type");
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
