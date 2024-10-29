using EF.Repository.Interface.Manager;
using RepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryApp.Interfaces.Manager
{
    internal interface IStudentManager:ICommonManager<Student>
    {
        bool IsExisting(string regNo);
        bool IsExistings(string email);
        Student GetById(int id);
    }
}
