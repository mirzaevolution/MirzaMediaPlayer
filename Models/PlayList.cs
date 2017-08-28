using System.ComponentModel;
namespace MirzaMediaPlayer.Models
{
    public class PlayList:INotifyPropertyChanged
    {
        private string _icon, _name, _fullName;
        public PlayList() { }
        public PlayList(string icon, string name, string fullname)
        {
            this._icon = icon;
            this._name = name;
            this._fullName = fullname;
        }
        public string Icon
        {
            get { return _icon; }
            set
            {
                if(_icon!=value)
                {
                    _icon = value;
                    OnPropertyChanged(nameof(Icon));
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if(_name!=value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if(_fullName!=value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
