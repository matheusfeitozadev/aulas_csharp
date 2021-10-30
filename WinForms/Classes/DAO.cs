using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LogicaProgramacao.Classes.Assembly;
using WinForms.Classes.Entity;

namespace WinForms.Classes
{
    public class DAO
    {
        public void FirstExampleUsingDAO()
        {
            List<CustomerViewModel> customers = new List<CustomerViewModel>();

            using (var conn = new SqlConnection(Constants.AssemblyConn))
            {
                conn.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from customer";

                    using (var reader = cmd.ExecuteReader())
                    {
                        if(reader != null)
                        {
                            while (reader.Read())
                            {
                                customers.Add(new CustomerViewModel()
                                {
                                    Id = int.Parse(reader["Id"].ToString()),
                                    CustomerName = reader["CustomerName"].ToString(),
                                    Active = bool.Parse(reader["Active"].ToString())
                                });
                            }
                        }
                    }
                }
            }
        }

        public void FirstExampleUsingDapper()
        {
            using (var conn = new SqlConnection(Constants.AssemblyConn))
            {
                var list = conn.Query<CustomerViewModel>("select * from customer").ToList();
            }
        }

        public void FirstExampleUsingEntity()
        {
            var context = new CursoDEVEntities();

            //select* from Customer where Active = 1
            //order by Id desc

            var list = context.Customers.ToList();

            var listActives = context.Customers.Where(x => x.Active == true).OrderByDescending(x=> x.Id).ToList();
        }
    }
}
