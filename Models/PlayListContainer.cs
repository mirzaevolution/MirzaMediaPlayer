using System.ComponentModel;

using System.Collections.ObjectModel;
namespace MirzaMediaPlayer.Models
{
    public class PlayListContainer : INotifyPropertyChanged
    {
        private ObservableCollection<PlayList> _playListData = new ObservableCollection<PlayList>();
        public PlayListContainer()
        {
            //_playListData = new ObservableCollection<PlayList>();
            //_playListData.Add(new PlayList("Icons/Music.ico", "test.mp3", "C:\\Musics\\test.mp3"));
            //_playListData.Add(new PlayList("Icons/Video.ico", "test.mp4", "C:\\Musics\\test.mp4"));
        }
        public PlayListContainer(ObservableCollection<PlayList> playListData)
        {
            this._playListData = playListData;
        }

        public ObservableCollection<PlayList> PlayListData
        {
            get { return _playListData; }
            set
            {
                _playListData = value;
                OnPropertyChanged(nameof(PlayListData));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
