using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, EducationContext>, ITeacherDal
    {
       public List<TeacherDetailDto> GetTeacherDetail()
        {
            using (EducationContext context=new EducationContext())
            {
                var result = from s in context.Students
                             join t in context.Teachers
                             
                             on s.TeacherId equals t.StudentId
                             join l in context.Lessons
                             on t.LessonId equals l.LessonId
                             select new TeacherDetailDto
                             {
                                 TeacherId = t.TeacherId,
                                 TFirstName = t.TFirstName,
                                 TLastName = t.TLastName,
                                 SFirstName=s.SFirstName,
                                 LessonName=l.LessonName
                                 
                             };
                return result.ToList();
            }
        }
    }
}
