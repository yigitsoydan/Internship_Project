using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntertechProject.IntertechProjectClasses
{
    class Project
    {
        public int Id { get; set; }
        public int ClientNo { get; set; }
        public int MainBranchCode { get; set; }
        public String Name { get; set; }
        public String MiddleName { get; set; }
        public String Surname { get; set; }
        public long CitizenshipNumber { get; set; }
        public String MotherName { get; set; }
        public String FatherName { get; set; }
        public short CustomerType { get; set; }
        public short UnitStatus { get; set; }
        public string IBAN { get; set; }
        public long Balance { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //to get customers table
        public DataTable SelectCust()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM customers";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //to get accounts table
        public DataTable SelectAcc()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM accounts";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Inserting into Database
        public bool Insert(Project c)
        {
            Random r = new Random();
            this.ClientNo = r.Next(1496451, 9614659);
            int randomIBAN1 = r.Next(16849325, 91432876);
            int randomIBAN2 = r.Next(16324721, 96583588);
            string IBAN1 = randomIBAN1.ToString();
            string IBAN2 = randomIBAN2.ToString();
            string IBANComplete = "TR" + IBAN1 + IBAN2;
            this.IBAN = IBANComplete;

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql1 = "INSERT INTO customers (ClientNo, MainBranchCode, Name, MiddleName, Surname, CitizenshipNumber, MotherName, FatherName, CustomerType, UnitStatus) VALUES (@ClientNo, @MainBranchCode, @Name, @MiddleName, @Surname, @CitizenshipNumber, @MotherName, @FatherName, @CustomerType, @UnitStatus)";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                cmd1.Parameters.AddWithValue("@ClientNo", this.ClientNo);
                cmd1.Parameters.AddWithValue("@MainBranchCode", c.MainBranchCode);
                cmd1.Parameters.AddWithValue("@Name", c.Name);
                cmd1.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd1.Parameters.AddWithValue("@Surname", c.Surname);
                cmd1.Parameters.AddWithValue("@CitizenshipNumber", c.CitizenshipNumber);
                cmd1.Parameters.AddWithValue("@MotherName", DBNull.Value);
                cmd1.Parameters.AddWithValue("@FatherName", DBNull.Value);
                cmd1.Parameters.AddWithValue("@CustomerType", DBNull.Value);
                cmd1.Parameters.AddWithValue("@UnitStatus", DBNull.Value);

                string sql2 = "INSERT INTO accounts (MainBranchCode, AccountNumber, Name, MiddleName, Surname, Balance, IBAN) VALUES (@MainBranchCode, @AccountNumber, @Name, @MiddleName, @Surname, @Balance, @IBAN)";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@MainBranchCode", c.MainBranchCode);
                cmd2.Parameters.AddWithValue("@AccountNumber", c.ClientNo);
                cmd2.Parameters.AddWithValue("@Name", c.Name);
                cmd2.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd2.Parameters.AddWithValue("@Surname", c.Surname);
                cmd2.Parameters.AddWithValue("@Balance", DBNull.Value);
                cmd2.Parameters.AddWithValue("@IBAN", c.IBAN);

                conn.Open();

                int rows1 = cmd1.ExecuteNonQuery();
                int rows2 = cmd2.ExecuteNonQuery();
                if (rows1 + rows2 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool InsertAcc(Project c)
        {
            Random r = new Random();
            this.ClientNo = r.Next(1496451, 9614659);
            int randomIBAN1 = r.Next(16849325, 91432876);
            int randomIBAN2 = r.Next(16324721, 96583588);
            string IBAN1 = randomIBAN1.ToString();
            string IBAN2 = randomIBAN2.ToString();
            string IBANComplete = "TR" + IBAN1 + IBAN2;
            this.IBAN = IBANComplete;

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql2 = "INSERT INTO accounts (MainBranchCode, AccountNumber, Name, MiddleName, Surname, Balance, IBAN) VALUES (@MainBranchCode, @AccountNumber, @Name, @MiddleName, @Surname, @Balance, @IBAN)";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@MainBranchCode", c.MainBranchCode);
                cmd2.Parameters.AddWithValue("@AccountNumber", c.ClientNo);
                cmd2.Parameters.AddWithValue("@Name", c.Name);
                cmd2.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd2.Parameters.AddWithValue("@Surname", c.Surname);
                cmd2.Parameters.AddWithValue("@Balance", DBNull.Value);
                cmd2.Parameters.AddWithValue("@IBAN", c.IBAN);

                conn.Open();


                int rows2 = cmd2.ExecuteNonQuery();
                if (rows2 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Updating Database
        public bool Update(Project c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql1 = "UPDATE customers SET Name=@Name, MiddleName=@MiddleName, Surname=@Surname, CitizenshipNumber=@CitizenshipNumber,MainBranchCode=@MainBranchCode WHERE Id=@Id";

                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                cmd1.Parameters.AddWithValue("@MainBranchCode", c.MainBranchCode);
                cmd1.Parameters.AddWithValue("@Name", c.Name);
                cmd1.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd1.Parameters.AddWithValue("@Surname", c.Surname);
                cmd1.Parameters.AddWithValue("@CitizenshipNumber", c.CitizenshipNumber);
                cmd1.Parameters.AddWithValue("@MotherName", DBNull.Value);
                cmd1.Parameters.AddWithValue("@FatherName", DBNull.Value);
                cmd1.Parameters.AddWithValue("@CustomerType", DBNull.Value);
                cmd1.Parameters.AddWithValue("@UnitStatus", DBNull.Value);
                cmd1.Parameters.AddWithValue("@Id", c.Id);

                String sql2 = "UPDATE accounts SET Name=@Name, MiddleName=@MiddleName, Surname=@Surname, MainBranchCode=@MainBranchCode WHERE AccountNumber=@AccountNumber";

                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@MainBranchCode", c.MainBranchCode);
                cmd2.Parameters.AddWithValue("@Name", c.Name);
                cmd2.Parameters.AddWithValue("@MiddleName", c.MiddleName);
                cmd2.Parameters.AddWithValue("@Surname", c.Surname);
                cmd2.Parameters.AddWithValue("@AccountNumber", c.ClientNo);

                conn.Open();
                int rows2 = cmd2.ExecuteNonQuery();
                int rows1 = cmd1.ExecuteNonQuery();
                if (rows1 + rows2 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //Deleting From Database
        public bool DeleteCust(Project c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql1 = "DELETE FROM customers WHERE Id = @Id";

                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                cmd1.Parameters.AddWithValue("@Id", c.Id);

                conn.Open();

                int rows1 = cmd1.ExecuteNonQuery();


                if (rows1 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool DeleteAccount(Project c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql2 = "DELETE FROM accounts WHERE AccountNumber = @AccountNumber";

                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("@AccountNumber", c.ClientNo);

                conn.Open();


                int rows2 = cmd2.ExecuteNonQuery();

                if (rows2 > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }



        public bool InsertExtra(Project c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "UPDATE customers SET UnitStatus=@UnitStatus, CustomerType=@CustomerType WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UnitStatus", c.UnitStatus);
                cmd.Parameters.AddWithValue("@CustomerType", c.CustomerType);
                cmd.Parameters.AddWithValue("@Id", c.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool UpdateBalance(Project c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                String sql = "UPDATE accounts SET Balance=@Balance WHERE AccountNumber=@AccountNumber"; ;

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Balance", c.Balance);
                cmd.Parameters.AddWithValue("@AccountNumber", c.ClientNo);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public DataTable SelectReport1()
        {
            //Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM customers WHERE UnitStatus = 1 AND CustomerType = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }



    }
}