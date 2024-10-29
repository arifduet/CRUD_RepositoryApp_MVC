using EF.Repository.Manager;
using RepositoryApp.Interfaces.Manager;
using RepositoryApp.Models;
using RepositoryApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryApp.Manager
{
    public class StudentManager:CommonManager<Student>,IStudentManager
    {
        public StudentManager():base(new StudentRepository())
        {
            
        }

        public bool IsExisting(string regNo)
        {
            var student = GetFirstOrDefault(c=>c.RegNo.ToLower() == regNo.ToLower());
            if(student!=null)
            {
                return true;
            }
            return false;
        }

        public bool IsExistings(string email)
        {
            var student = GetFirstOrDefault(c => c.Email.ToLower() == email.ToLower());
            if (student != null)
            {
                return true;
            }
            return false;
        }

        public Student GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}