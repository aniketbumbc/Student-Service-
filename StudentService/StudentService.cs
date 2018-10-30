using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {
        public void DeleteStudent(int Id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int Id)
        {
            Student student = new Student();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterID = new SqlParameter();
                parameterID.ParameterName = "@Id";
                parameterID.Value = Id;
                cmd.Parameters.Add(parameterID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = reader["Name"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.BirthDate = Convert.ToDateTime(reader["DateOfBirth"]);
                    student.Fees = Convert.ToInt32(reader["Fees"]);
                    student.City = reader["City"].ToString();
                    student.School = reader["School"].ToString();
                }
                return student;
            }

        }

        public void SaveStudent(Student student)
        {
            
        }
    }
}
