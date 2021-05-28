using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAO_Interface;
using ProjectEntities;

namespace DAO
{
    public class Product_DAO : IProductDAO
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
       
        /*gg*/
        public void AddNewProduct(Product product)
        {
             
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewProduct";
                cmd.Parameters.AddWithValue("@productName", product.ProductName);

                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "DateCome",
                    Direction = ParameterDirection.Input,
                    Value = product.DateCome == null ? (object)DBNull.Value : product.DateCome,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "DateOut",
                    Direction = ParameterDirection.Input,
                    Value = product.DateOut == null ? (object)DBNull.Value : product.DateOut,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "dateUtilization",
                    Direction = ParameterDirection.Input,
                    Value = product.DateUtilization == null ? (object)DBNull.Value : product.DateUtilization,
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    DbType = DbType.DateTime,
                    ParameterName = "shelfLife",
                    Direction = ParameterDirection.Input,
                    Value = product.ShelfLife == null ? (object)DBNull.Value : product.ShelfLife,
                });
                var idProduct = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "idProduct",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(idProduct);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /*gg*/
        public void DeleteProduct(int idProduct)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteProduct";
                cmd.Parameters.AddWithValue("@idProduct", idProduct);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /*gg*/
        public IEnumerable<Product> GetAllProduct()
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProducts";
                connection.Open();

                var coms = cmd.ExecuteReader();
                while (coms.Read())
                {
                    res.Add(new Product(
                        id: (int)coms["ID_Product"],
                        name: Convert.ToString(coms["ProductName"]),
                        d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                        s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                        d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                        d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                    ));
                }
            }
            return res;
        }

        /*gg*/
        public IEnumerable<Product> SearchByProductName(string name)
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByProductName";
                cmd.Parameters.AddWithValue("@productName", name);
                connection.Open();

                var coms = cmd.ExecuteReader();
                while (coms.Read())
                {
                    res.Add(new Product(
                        name: Convert.ToString(coms["ProductName"]),
                        id: (int)coms["ID_Product"],
                        d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                        s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                        d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                        d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                    ));
                }
            }
            return res;
        }

        /**/
        public IEnumerable<Product> SearchByDateCome(DateTime curDate)
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByDateCome";
                cmd.Parameters.AddWithValue("@currentDate", curDate);
                connection.Open();

                var coms = cmd.ExecuteReader();

                while (coms.Read())
                {
                    res.Add(new Product(
                       name: Convert.ToString(coms["ProductName"]),
                       id: (int)coms["ID_Product"],
                       d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                       s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                       d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                       d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                   ));
                }
            }
            return res;
        }

        /**/
        public IEnumerable<Product> SearchByDateOut(DateTime curDate)
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByDateOut";
                cmd.Parameters.AddWithValue("@currentDate", curDate);
                connection.Open();

                var coms = cmd.ExecuteReader();

                while (coms.Read())
                {
                    res.Add(new Product(
                       name: Convert.ToString(coms["ProductName"]),
                       id: (int)coms["ID_Product"],
                       d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                       s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                       d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                       d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                   ));
                }
            }
            return res;
        }

        /**/
        public IEnumerable<Product> SearchByDateUtilization(DateTime curDate)
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByDateUtilization";
                cmd.Parameters.AddWithValue("@currentDate", curDate);
                connection.Open();

                var coms = cmd.ExecuteReader();

                while (coms.Read())
                {
                    res.Add(new Product(
                       name: Convert.ToString(coms["ProductName"]),
                       id: (int)coms["ID_Product"],
                       d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                       s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                       d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                       d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                   ));
                }
            }
            return res;
        }


        /**/
        public IEnumerable<Product> SearchByShelfLife(DateTime curDate)
        {
            List<Product> res = new List<Product>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchByShelfLife";
                cmd.Parameters.AddWithValue("@currentDate", curDate);
                connection.Open();

                var coms = cmd.ExecuteReader();

                while (coms.Read())
                {
                    res.Add(new Product(
                       name: Convert.ToString(coms["ProductName"]),
                       id: (int)coms["ID_Product"],
                       d_c: coms["DateCome"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateCome"]),
                       s_l: coms["ShelfLife"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["ShelfLife"]),
                       d_o: coms["DateOut"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateOut"]),
                       d_u: coms["DateUtilization"] is DBNull ? null : (DateTime?)Convert.ToDateTime(coms["DateUtilization"])
                   ));
                }
            }
            return res;
        }
    }
}
