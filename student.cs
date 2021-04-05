using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class student
    {
        private string Name;
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
        public void student(string stName)
        
            Console.WriteLine("Student.");
        }
    private void btnname_Click(object sender, RoutedEventArgs e)
    {
        student st1 = new student("Phuong");
        st.Talk();
        Student st2 = new student();
        st1.StudentName = "Thinh";
        st1.Talk();
    }
}
