using EF.Repository.Interface.Repository;
using RepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryApp.Interfaces.Repository
{
    internal interface IStudentRepository:ICommonRepository<Student>
    {
    }
}
