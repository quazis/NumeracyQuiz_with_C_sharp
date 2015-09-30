using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace STP_P1019796_20150613
{
    public class StudentDatabase
    {

        public static SqlConnection GetConnection()
        {
            string connStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\STP_2015_Term_5\VPR_Term_5\STP_P1019796_20150613\STP_P1019796_20150613\StudentDB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }
        public static void AddStudent(string firstName, string lastName, string studentNumber)
        {
            string insertStatement = "INSERT INTO STUDENT (FirstName, LastName, StudentNumber) VALUES (@firstName, @lastName, @studentNumber)";
            SqlConnection conn = GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Parameters.AddWithValue("@firstName", firstName);
            insertCommand.Parameters.AddWithValue("@lastName", lastName);
            insertCommand.Parameters.AddWithValue("@studentNumber", studentNumber);

            try
            {
                conn.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Student> GetStudent()
        {
            List<Student> studentList = new List<Student>();
            SqlConnection conn = GetConnection();
            string selectStatement = "SELECT * FROM STUDENT ORDER BY ID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.ID = (int)reader["ID"];
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    student.StudentNumber = reader["StudentNumber"].ToString();
                    studentList.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return studentList;

        }
//        public static void display()
//        {
//            Student student = new Student();
//            SqlConnection conn = GetConnection();
//            string selectStatement = "SELECT FIRSTNAME FROM STUDENT";
//            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
//            SqlDataReader reader = selectCommand.ExecuteReader();;
//            student.FirstName = reader["FirstName"].ToString();
//        }
    }
}
