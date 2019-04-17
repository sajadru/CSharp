using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        string name;
        string isbn;
        string author;
        string publisher;
        DateTime year;
        public static string Name { get; set; }
        public static string Isbn { get; set; }
        public static string Author { get; set; }
        public static string Publisher { get; set; }
        public static DateTime Year { get; set; }

        public static void Mapper()
        {
            SqlConnection connection = new SqlConnection("server=.;database= Library;integrated security=true");
            SqlCommand command = new SqlCommand("INSERT INTO Book(Name,ISBN,Author,Publisher,Year) VALUES(@name, @isbn, @author, @publisher, @year)",connection);
            command.Connection.Open();
            command.Parameters.Add(new SqlParameter("Name",SqlDbType.NVarChar));
            command.Parameters["name"].Value = Name;
            command.Parameters.Add(new SqlParameter("ISBN", SqlDbType.NVarChar));
            command.Parameters["isbn"].Value = Name;
            command.Parameters.Add(new SqlParameter("Author", SqlDbType.NVarChar));
            command.Parameters["author"].Value = Name;
            command.Parameters.Add(new SqlParameter("Publisher", SqlDbType.NVarChar));
            command.Parameters["publisher"].Value = Name;
          
             command.Parameters.Add(new SqlParameter("Year", SqlDbType.Date));
             command.Parameters["year"].Value = Year;
            command.ExecuteNonQuery();
            command.Connection.Close();
            HomePage h = new HomePage();
            h.List();
        }
        public override string ToString()
        {
            return $"{Name}{Isbn}{Year}".ToString();
        }
    }
}
