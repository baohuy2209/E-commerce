using Microsoft.Data.SqlClient;
using ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerConnector: SQLConnector
    {
        public Customer Login(string email, string password)
        {
            string sql = "select * from Customer where email='" + email + "' and password='" + password + "'";
            SqlDataReader reader = Query(sql); 
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string Name = reader.GetString(1);
                string Email = reader.GetString(2);
                string Phone = reader.GetString(3);
                string Address = reader.GetString(4);
                DateTime DOB = reader.GetDateTime(5);
                string Gender = reader.GetString(6);
                DateTime FirstBuyDate = reader.GetDateTime(7);
                Customer loginCustomer = new Customer();
                loginCustomer.CustomerId = id;
                loginCustomer.Name = Name;
                loginCustomer.Phone = Phone;
                loginCustomer.Address = Address;
                loginCustomer.Email = Email;
                loginCustomer.DOB = DOB;
                loginCustomer.Gender = Gender;
                loginCustomer.FirstBuyDate = FirstBuyDate;
                loginCustomer.Password = password;
                return loginCustomer; 
            }
            reader.Close();
            return null; 
        }
    }
}
