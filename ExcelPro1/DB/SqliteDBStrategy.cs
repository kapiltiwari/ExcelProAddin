using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcelPro1.Model;

using System.Data.SQLite;
using System.Data;

namespace ExcelPro1
{
    class SqliteDBStrategy : DBStrategy
    {
        SQLiteConnection m_dbConnection;

        public SqliteDBStrategy()
        {
            //create db file if not there
            string absolutePath = getDBFilePath();

            if (m_dbConnection == null)
            {
                //string absolutePath = getDBFilePath();
                string connectionString = string.Format("Data Source={0};Version=3;", absolutePath);
                m_dbConnection = new SQLiteConnection(connectionString);
            }

            if (!System.IO.File.Exists(absolutePath))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");

                if (m_dbConnection == null)
                {
                    //string absolutePath = getDBFilePath();
                    string connectionString = string.Format("Data Source={0};Version=3;", absolutePath);
                    m_dbConnection = new SQLiteConnection(connectionString);

                }

                //create db connection with datasource and open it
                //m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();

                // create table in the db
                string sql = "create table itemlist (field varchar(20), text varchar(20), len int, desc varchar(20))";

                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                // insert entries in the db
                sql = "insert into itemlist (field, text, len, desc) values ('STID', 'Site identifier', 3, 'desc')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('ITNBR', 'Item number', 15, 'desc')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('ITRV', 'Item revision', 6, 'desc')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('DESC', 'Standard unit cost', 1, 'desc')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('CURUC', 'Current unit cost', 19, '8')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('ITYP', 'Item Type', 1, 'desc')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                sql = "insert into itemlist (field, text, len, desc) values ('INVFG', 'Inventory Flag', 1, '0')";
                using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
                {
                    command1.CommandText = sql;
                    command1.ExecuteNonQuery();
                    command1.Dispose();
                }

                m_dbConnection.Close();
            }
        }
        public void getPnL(ref Account[] arrayAccount)
        {
            int i = 0;
            arrayAccount[i++] = new Account("Budgeted", 882000, 484960, 28704);
            arrayAccount[i++] = new Account("Actual", 434250, 187271, 11887);
            arrayAccount[i++] = new Account("Remaining", 447750, 226399, 16817);
            arrayAccount[i++] = new Account("Forecast", 447750, 226399, 13684);
        }
        public void getTop5Customer(ref Customer[] arrayCustomer)
        {
            int i = 0;
            arrayCustomer[i++] = new Customer("Wallmart", 50000);
            arrayCustomer[i++] = new Customer("Big Bazar", 40000);
            arrayCustomer[i++] = new Customer("McDonald", 30000);
            arrayCustomer[i++] = new Customer("Burger King", 20000);
            arrayCustomer[i++] = new Customer("Kings Corner", 10000);

        }

        public void getTop5Items(ref Items[] arrayItems)
        {
            int i = 0;
            arrayItems[i++] = new Items("Item1", 50000);
            arrayItems[i++] = new Items("Item2", 40000);
            arrayItems[i++] = new Items("Item3", 30000);
            arrayItems[i++] = new Items("Item4", 20000);
            arrayItems[i++] = new Items("Item5", 10000);
        }

        string getDBFilePath ()
        {
            string relativePath = @"MyDatabase.sqlite";
            string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path

            return absolutePath;
            //return "MyDatabase.sqlite";
        }

        public void getItemList(ref ItemList[] arrayItems)
        {

            //string relativePath = @"DB\MyDatabase.sqlite";
            //string currentPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //string absolutePath = System.IO.Path.Combine(currentPath, relativePath);
            //absolutePath = absolutePath.Remove(0, 6);//this code is written to remove file word from absolute path


            m_dbConnection.Open();
            // create table in the db
            string sql = "select * from itemlist";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                //field, text , len, desc
                arrayItems[i++] = new ItemList((String)reader["field"],
                                                   (String)reader["text"],
                                                        (int)reader["len"],
                                                        (String)reader["field"]);
            }

            reader.Close();

            command.Dispose();

            m_dbConnection.Close();
        }


        public void getCustomerList()
        {
            ;
        }


        public void updateItem()
        {
            ;
        }


        public bool addItem(ref ItemList itemlist)
        {
            //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            //// create table in the db
            //string sql = "insert into itemlist (field, text , len, desc) values ('@field', '@text', @len, '@desc')";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            //// (field varchar(20), text varchar(20), len int, desc varchar(20))";
            //command.Parameters.Add("@field", DbType.VarNumeric, 20).Value = itemlist.field;
            //command.Parameters.Add("@text", DbType.VarNumeric, 20).Value = itemlist.itemText;
            //command.Parameters.Add("@len", DbType.Int32).Value = itemlist.field;
            //command.Parameters.Add("@desc", DbType.VarNumeric, 20).Value = itemlist.desc;

            string sql = "insert into itemlist (field, text , len, desc) values ('" + itemlist.field +"', '"+ itemlist.itemText+"', " + itemlist.len +", '" + itemlist.desc +"')";
            //string sql = "insert into itemlist values ('WEGHT', 'Unit Weight', 7, '3')";
            //string sql = "insert into itemlist (field, text, len, desc) values ('WEGHT', 'Unit Weight', 7, 'desc')";

            using (SQLiteCommand command1 = m_dbConnection.CreateCommand())
            {
                command1.CommandText = sql;
                command1.ExecuteNonQuery();
                command1.Dispose();
            }

            m_dbConnection.Close();

            return true;
        }


        public void updateCustomer()
        {
            ;
        }


    }
}
