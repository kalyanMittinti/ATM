using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATMLib
{
    public class UserDataStore : IUserData
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataReader reader = null;

        public UserDataStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public decimal AddAmount(string CardNumber, decimal Balance)
        {

            try
            {
                string sql = "update UserInfo set  BALANCE =@Balance+Balance WHERE CARDNUMBER=@CardNumber";
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


            decimal balance = 0;
            try
            {
                string sql = "SELECT distinct BALANCE FROM UserInfo where CARDNUMBER=@CardNumber";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);



                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                object res = command.ExecuteScalar();
                balance = Convert.ToDecimal(res);
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

        public List<TransactionInfo> GetTransaction(string CardNumber)
        {

            List<TransactionInfo> transactionslist = new List<TransactionInfo>();
            try
            {
                string sql = " SELECT U.CardNumber,TransactionAmount,TransactionDate FROM UserInfo U JOIN TransactionInfo T ON  U.CardNumber=T.CardNumber WHERE U.CardNumber=@CardNumber ORDER BY T.TransactionDate  DESC";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CardNumber", CardNumber);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TransactionInfo transaction = new TransactionInfo();
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

        public bool ValidateUser(UserInfo user)
        {
            bool result = false;
            try
            {
                string sql = "SELECT * FROM UserInfo where CARDNUMBER=@CardNumber and PINNUMBER=@PinNumber";
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
            return result;
        }

        public decimal WithDrawAmount(string CardNumber, decimal Balance)
        {
            try
            {
                string sql = "UPDATE UserInfo SET  BALANCE =BALANCE-@Balance WHERE CARDNUMBER=@CardNumber";
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
