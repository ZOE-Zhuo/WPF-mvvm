using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleE.Model
{
    public class Student : INotifyPropertyChanged
    {
        /// <summary>
        /// 学号
        /// </summary>
        private int studentId;
        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
                NotifyPropertyChanged("StudentId");
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        private string studentName;
        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
                NotifyPropertyChanged("StudentName");
            }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        private int studentAge;
        public int StudentAge
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
                NotifyPropertyChanged("StudentAge");
            }
        }

        /// <summary>
        /// Email
        /// </summary>
        private string studentEmail;
        public string StudentEmail
        {
            get
            {
                return studentEmail;
            }
            set
            {
                studentEmail = value;
                NotifyPropertyChanged("StudentEmail");
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        private string studentSex;
        public string StudentSex
        {
            get
            {
                return studentSex;
            }
            set
            {
                studentSex = value;
                NotifyPropertyChanged("StudentSex");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
