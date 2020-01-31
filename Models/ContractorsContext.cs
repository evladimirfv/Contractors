

using MySql.Data.MySqlClient;    

using System;    
using System.Collections.Generic; 


        
namespace Contractors.Models
{    
    public class ContractorsContext    
    {    
        public string ConnectionString { get; set; }    
        
        public ContractorsContext(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }    
        
      
        
        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        }  
        
        
        public List<Profesional> GetAllProfesional()  
        {  
            List<Profesional> list = new List<Profesional>();

            try
            {
                using (MySqlConnection conn = GetConnection())  
                {  
                    conn.Open();  
                    MySqlCommand cmd = new MySqlCommand("select * from profesional where id < 10", conn);  
      
                    using (var reader = cmd.ExecuteReader())  
                    {  
                        while (reader.Read())  
                        {  
                            list.Add(new Profesional()  
                            {  
                                Id = Convert.ToInt32(reader["Id"]),  
                                Nombre = reader["nombre"].ToString(),  
                                Profesion = reader["profesion"].ToString(),  
                                RankingCalificacion = Convert.ToDouble(reader["rankingcalificacion"])  
                          
                            });  
                        }  
                    }  
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
              
            return list;  
        }
        
    }    
}  
