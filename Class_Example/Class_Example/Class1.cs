using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Example
{
   public class Student
    {

       public  List<double> Grades { get; set; }


        public string Name { get; set; }
        private int Id;

        public void SetId(int id)
        {
           Id = id;
        }
        public int GetId()
        {
            return Id;
        }

        public Student()
        {
            Id = 0;
            Name = "";
            Grades = new List<double>();
        }

    }
}
