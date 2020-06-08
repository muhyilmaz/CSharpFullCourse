using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.ProductDemo
{
    public class ProductDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true");

        /*public DataTable GetAll()
        {
            SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true");

            if(_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand("Select * from Products",_sqlConnection);
            SqlDataReader sqlDataReader =  sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            sqlDataReader.Close();
            _sqlConnection.Close();

            return dataTable;
        }*/

        public List<Product> GetAll()
        {
            ConnectionController();

            SqlCommand sqlCommand = new SqlCommand("Select * from Products", _sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = (sqlDataReader["Name"]).ToString(),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"])
                };

                products.Add(product);
            }

            sqlDataReader.Close();
            _sqlConnection.Close();

            return products;
        }

        private void ConnectionController()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionController();

            SqlCommand sqlCommand = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }


        public void Update(Product product)
        {
            ConnectionController();

            SqlCommand sqlCommand = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);

            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Delete(int id)
        {
            ConnectionController();

            SqlCommand sqlCommand = new SqlCommand("Delete from Products where Id=@id", _sqlConnection);
            
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }
    }
}
