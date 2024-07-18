using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace College.DAL
{
    internal class SeedService
    {
        
        public SeedService EnsureDataBaseSetup()
        {
            try
            {
                EnsureDataBase();
                EnsureTables(getTablesQuaries());
                //SeedData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            return this;
        }

        private List<Tuple<string, string>> getTablesQuaries()
        {
            
            using (StreamReader r = new StreamReader("Config\\createTables.json"))
            {
                string json = r.ReadToEnd();
                var t = JsonConvert.DeserializeObject<List<Tuple<string, string>>>(json);
                if (t == null) throw new Exception("unable to read json file");
                return t;
            }
            
            
        }

        private  void EnsureDataBase()
        {
            string ? dbname = DBContext.GetDBName();  
            string quary = @$" 
                use master;
                IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = '{dbname}')
                                BEGIN
                                    CREATE DATABASE [{dbname}]
                                END";
            DBContext.ExecuteNonQuery(quary);

        }


        private void EnsureTables(List<Tuple<string, string>> tablesCreateQuary)
        {
            try
            {
                string dbname = DBContext.GetDBName();

                foreach (var tableNameQuary in tablesCreateQuary)
                {
                    string quary = $@"
                        use {DBContext.GetDBName};
                        IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = '{tableNameQuary.Item1}' AND type = 'U')
                        BEGIN
		                	{tableNameQuary.Item2}
		                END";

                    DBContext.ExecuteNonQuery(quary);
                }
                Console.WriteLine("Tables created or already exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating tables: {ex.Message}");
            }
        }


    }

}
