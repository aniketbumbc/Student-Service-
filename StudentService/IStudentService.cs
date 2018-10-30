using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
       Student GetStudent(int Id);

        [OperationContract]
        void SaveStudent(Student student);

        [OperationContract]
        void DeleteStudent(int Id);

    }
}
