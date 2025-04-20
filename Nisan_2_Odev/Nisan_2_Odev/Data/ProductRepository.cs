using Nisan_2_Odev.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Nisan_2_Odev.Data;

public class ProductRepository
{
    private readonly string _connectionString;

    public ProductRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        var products = new List<Product>();
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Products", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Price = (decimal)reader["Price"],
                        Stock = (int)reader["Stock"]
                    });
                }
            }
        }
        return products;
    }

    public Product GetProductById(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("SELECT * FROM Products WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Price = (decimal)reader["Price"],
                        Stock = (int)reader["Stock"]
                    };
                }
            }
        }
        return null;
    }

    public void AddProduct(Product product)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)", connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();
        }
    }

    public void UpdateProduct(int id, Product product)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();
        }
    }

    public void DeleteProduct(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            var command = new SqlCommand("DELETE FROM Products WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }
    }
}