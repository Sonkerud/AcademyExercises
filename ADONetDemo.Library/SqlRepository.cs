using ADONetDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetDemo.Library
{
    public class SqlRepository : IDisposable
    {
        SqlConnection sqlConnection = new SqlConnection();

        public SqlRepository()
        {
            sqlConnection.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mercury;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        public void Dispose()
        {
            sqlConnection.Dispose();
        }

        public List<Fruit> GetAll()
        {
            sqlConnection.Open();

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "select * from Fruits";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                // sqlCommand.ExecuteNonQuery - when updating och not retrieving data
                //sqlCommande.ExecuteReader - when retrieving data
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<Fruit> fruits = new List<Fruit>();
                Fruit f = null;  

                while (sqlDataReader.Read())
                {
                    f = new Fruit();
                    f.Id = (int)sqlDataReader["ID"];
                    f.FruitType = sqlDataReader["FruitType"].ToString();
                    f.FruitName = sqlDataReader["FruitName"].ToString();
                    f.PricePerKg = (decimal)sqlDataReader["PricePerKg"];

                    fruits.Add(f);
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                return fruits;
            }
        }
        public int AddNew(string fruitType, string fruitName, decimal pricePerKg)
        {
            sqlConnection.Open();
            int rowsAffected;

            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"insert into Fruits values(@fruitType, @fruitName, @pricePerKg)";
                sqlCommand.CommandType = CommandType.Text;

                AddParameter("@fruitType", fruitType, sqlCommand);
                AddParameter("@fruitName", fruitName, sqlCommand);

                AddMoneyParameterToSQLCommand("@pricePerKg", pricePerKg, sqlCommand);

                //sqlCommand.ExecuteNonQuery - when updating och not retrieving data
                //sqlCommande.ExecuteReader - when retrieving data
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
            return rowsAffected;
        }

        //public int NumOfFruits()
        //{
        //    sqlConnection.Open();
        //    int rowsAffected;

        //    using (SqlCommand sqlCommand = new SqlCommand())
        //    {
        //        sqlCommand.Connection = sqlConnection;
        //        sqlCommand.CommandText = $"NumOfFruits";
        //        sqlCommand.CommandType = CommandType.StoredProcedure;

        //        AddParameter("@fruitType", fruitType, sqlCommand);
                

        //        // sqlCommand.ExecuteNonQuery - when updating och not retrieving data
        //        //sqlCommande.ExecuteReader - when retrieving data
        //        //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //        rowsAffected = sqlCommand.ExecuteNonQuery();
        //    }
        //    sqlConnection.Close();
        //    return rowsAffected;
        //}

        private static void AddMoneyParameterToSQLCommand(string paramName, decimal pricePerKg, SqlCommand sqlCommand)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = paramName;
            parameter.Value = pricePerKg;
            parameter.SqlDbType = SqlDbType.Money;
            parameter.Direction = ParameterDirection.Input;
            sqlCommand.Parameters.Add(parameter);
        }

        private static SqlParameter AddParameter(string paramName, string paramValue, SqlCommand sqlCommand)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = paramName;
            parameter.Value = paramValue;
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 32;
            parameter.Direction = ParameterDirection.Input;
            sqlCommand.Parameters.Add(parameter);
            return parameter;
        }
    }
}
