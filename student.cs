using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class Student
    {
         1.Định nghĩa trường Name
        private string Name;
        2.Định nghĩa thuộc tính StudentName từ trường Name
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        3.Định nghĩa phương thức khởi tạo Student(string stName)
       
