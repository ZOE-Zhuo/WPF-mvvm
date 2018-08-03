using Demo.Service;

namespace Demo.Model
{
    public class Book:NotificationObject
    {
        public int BookId { get; set; }

        public string BookName { get; set; }
        public string BookType { get; set; }
        public string BookAuthor { get; set; }
        public string Publisher { get; set; }

        private bool _IsSelected = false;
     

        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
            set
            {
                _IsSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }
    }
}