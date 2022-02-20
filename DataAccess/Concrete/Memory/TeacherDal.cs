using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Memory
{
    public class TeacherDal : ITeacherDal
    {
        List<Teacher> _teachers;
        public TeacherDal()
        {
            _teachers = new List<Teacher> {
                new Teacher{TeacherId=1,TFirstName="Altan"},
                new Teacher{TeacherId=2,TFirstName="Kaan"}
            };
        }

        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public Teacher Get(Expression<Func<Teacher, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAll() 
        {
            return _teachers;
        }

        public List<Teacher> GetAll(Expression<Func<Teacher, bool>> filter = null)
        {
            return _teachers;
        }

        public List<TeacherDetailDto> GetTeacherDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
