using EF.Repository.Repository;
using RepositoryApp.Data;
using RepositoryApp.Interfaces.Repository;
using RepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryApp.Repository
{
    public class StudentRepository:CommonRepository<Student>,IStudentRepository
    {
        public StudentRepository():base(new ApplicationDbContext())
        {
            
        }
    }
}