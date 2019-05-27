using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace photoeditor.img2
{
    class Image
   : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string author;
        private string create_date;
        private string format;
        private int author_id;


        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }

        public string Create_date
        {
            get { return create_date; }
            set
            {
                create_date = value;
                OnPropertyChanged("Create_date");
            }
        }

        public string Format
        {
            get { return format; }
            set
            {
                format = value;
                OnPropertyChanged("Format");
            }
        }

        public int Author_id
        {
            get { return author_id; }
            set
            {
                author_id = value;
                OnPropertyChanged("Author_id");
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
