using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATMLib
{
    public class UserDataStore : IUserDataStore
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;

        public UserDataStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public decimal AddAmount(string CardNumber,decimal Balance)
        {
            
            try
            {
                string sql = "UPDATE USERMANAGEMENT SET  BALANCE =@Balance+Balance WHERE CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Balance", Balance);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);





                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public decimal GetBalanceByCardNumber(string CardNumber)
        {
            

            decimal balance=0;
            try
            {
                string sql = "SELECT distinct BALANCE FROM USERMANAGEMENT where CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);
                


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                object res = command.ExecuteScalar();
                balance =Convert.ToDecimal( res);
                return balance;
              
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return balance;
        }

        public List<Transaction> GetTransaction(string CardNumber)
        {

           List<Transaction> transactionslist = new List<Transaction>();
            try
            {
                string sql = " SELECT U.CARDNUMBER,TRANSACTIONAMOUNT,TRANSACTIONDATE FROM USERMANAGEMENT U JOIN TRANSACTIONS T ON  U.CARDNUMBER=T.CARDNUMBER WHERE U.CARDNUMBER=@CardNumber ORDER BY T.TRANSACTIONDATE  DESC";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.CardNumber = reader["CardNumber"].ToString();
                   
                    if (string.IsNullOrEmpty(reader["TransactionDate"].ToString()) != true)
                    {
                        transaction.TransactionDate = Convert.ToDateTime(Convert.ToString(reader["TransactionDate"]));
                    }
                    if (string.IsNullOrEmpty(reader["TransactionAmount"].ToString()) != true)
                    {
                        transaction.TransactionAmount = Convert.ToDecimal(Convert.ToString(reader["TransactionAmount"]));
                    }

                    transactionslist.Add(transaction);


                }
                return transactionslist;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return transactionslist;
        }

        public bool ValidateUser(User user)
        {
            bool result = false;
            try
            {
                string sql = "SELECT * FROM USERMANAGEMENT where CARDNUMBER=@CardNumber and PINNUMBER=@PinNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", user.CardNumber);
                command.Parameters.AddWithValue("@PinNumber", user.PinNumber);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return result;
        }

        public decimal WithDrawAmount(string CardNumber, decimal Balance)
        {
            try
            {
                string sql = "UPDATE USERMANAGEMENT SET  BALANCE =BALANCE-@Balance WHERE CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Balance", Balance);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);





                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = command.ExecuteNonQuery();

                return count;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
