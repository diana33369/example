using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace photoeditor
{
    class Log : INotifyPropertyChanged
    {
        private int id;
        private string authorization;
        private string username;
        private int user_id;


        public int Id { get; set; }

        public string Authorization
        {
            get { return authorization; }
            set
            {
                authorization = value;
                OnPropertyChanged("Authorization");
            }
        }
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public int User_id
        {
            get { return user_id; }
            set
            {
                user_id = value;
                OnPropertyChanged("Admin");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

