using System;
using System.Collections.Generic;
using System.Text;

namespace Soonn_Task.Models
{
    internal class Student
    {
        public int No { get; set; }
        public string FullName { get; set; }

        Dictionary<string, double> Exams;

        public Student()
        {
            Exams = new Dictionary<string, double>();

        }

        public void AddExam(string examName,double point)
        {
            if (examName==null )
            {
                throw new NullReferenceException("name null ola bilmez");
            }
            Exams.Add(examName, point);


        }
        public void GetExamResult(string examName)
        {
            if (examName == null)
            {
                throw new NullReferenceException("name null ola bilmez");
            }
            Exams.ContainsValue(1);
          
        }   
        public void GetExamAvg()
        {
            if (Exams == null)
            {
                throw new NullReferenceException("Exams null ola bilmez");
            }
            
           
        }
    
        
        
       
       



    }
}
