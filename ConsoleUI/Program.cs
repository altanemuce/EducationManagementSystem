using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Memory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherManager teacherManager = new TeacherManager( new TeacherDal());
            teacherManager.Add(new Teacher {TFirstName="altan2",TLastName="emuce2"});
            teacherManager.Add(new Teacher { TFirstName = "Kaan2", TLastName = "Sağlam2" });
            //foreach (var item in teacherManager.GetAll())
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}

            

            //foreach (var item in teacherManager.GetAll())
            //{
            //    Console.WriteLine(item.FirstName);
            //}
        }
    }
}
