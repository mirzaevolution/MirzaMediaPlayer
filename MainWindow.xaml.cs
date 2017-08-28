using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using System.IO;
using System.Windows.Threading;
using System.Threading.Tasks;
using MirzaMediaPlayer.Models;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Input;

namespace MirzaMediaPlayer
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _playListContainer = TryFindResource("playListContainer") as PlayListContainer;
        }


        #region private properties
        private TimeSpan _totalTimer, _progressTimer;
        private DispatcherTimer _timer;
        private PlayListContainer _playListContainer;
        private Uri _playUri = new Uri(@"Icons\Play.png", UriKind.Relative);
        private Uri _pauseUri = new Uri(@"Icons\Pause.png", UriKind.Relative);
        private int _currentSelectedIndex=0;
        private bool _isPaused=false;
        private string _currentlyPlayedFileName = "";
        #endregion

        #region private methods
        private void _timer_Tick(object sender, EventArgs e)
        {
            _progressTimer = mediaElementMain.Position;
            if (_progressTimer.TotalSeconds <= _totalTimer.TotalSeconds)
            {
                sliderDuration.Value = _progressTimer.TotalSeconds;
                textBlockProgress.Text = string.Format("{0:hh\\:mm\\:ss}", _progressTimer);
            }
        }
        private Task<bool> DetectTimespan()
        {
            bool hasTimespan = false;
            while (true)
            {
                if (mediaElementMain.NaturalDuration.HasTimeSpan)
                {
                    hasTimespan = true;
                    break;
                }
            }
            return Task.FromResult(hasTimespan);
        }
        private async void PlayMedia(string fileName)
        {
            try
            {
                if (!_isPaused && fileName != "")
                {
                    _currentlyPlayedFileName = fileName;
                    mediaElementMain.Source = new Uri(fileName, UriKind.Absolute);
                    sliderDuration.Value = 0;
                }
                if(!sliderDuration.IsEnabled)
                    sliderDuration.IsEnabled = true;
                mediaElementMain.Play();
                if (await DetectTimespan())
                {
                    _timer.Start();

                    _totalTimer = mediaElementMain.NaturalDuration.TimeSpan;
                    sliderDuration.Maximum = _totalTimer.TotalSeconds;
                    if (!mediaElementMain.HasVideo)
                    {
                        imageAudio.Visibility = Visibility.Visible;
                    }
                    else if (mediaElementMain.HasVideo)
                    {
                        imageAudio.Visibility = Visibility.Hidden;
                    }
                    textBlockDuration.Text = string.Format("{0:hh\\:mm\\:ss}",
                        mediaElementMain.NaturalDuration.TimeSpan);
                    textBlockMediaStatus.Text = $"Playing {_currentlyPlayedFileName}";
                    ellipseStatus.Fill = Brushes.Lime;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void PauseMedia()
        {
            if (mediaElementMain.CanPause)
            {
                try
                {

                    mediaElementMain.Pause();

                    if (mediaElementMain.NaturalDuration.HasTimeSpan)
                    {
                        _timer.IsEnabled = false;
                        _timer.Stop();
                    }
                    ellipseStatus.Fill = Brushes.RoyalBlue;
                    textBlockMediaStatus.Text = $"Paused";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private async void StopMedia()
        {
            try
            {

                mediaElementMain.Stop();
                _currentlyPlayedFileName = "";
                if (await DetectTimespan())
                {
                    _timer.IsEnabled = false;
                    _timer.Stop();
                }
                sliderDuration.IsEnabled = false;
                mediaElementMain.Position = TimeSpan.FromSeconds(0);
                sliderDuration.Value = 0;
                ellipseStatus.Fill = Brushes.Gray;
                textBlockProgress.Text = "00:00:00";
                textBlockMediaStatus.Text = $"Stopped";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private string GetNextMediaFileName(bool next=false)
        {
            string fileName = "";
            //if next equals to false, it'll get the current selected index
            if(next)
            {
                if (_currentSelectedIndex+1 < _playListContainer.PlayListData.Count)
                    _currentSelectedIndex++;
                else
                    _currentSelectedIndex = 0;
            }
            fileName = _playListContainer.PlayListData[_currentSelectedIndex].FullName;
            return fileName;
        }
        #endregion

       
        
        #region main events
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _timer = new DispatcherTimer(DispatcherPriority.Background)
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            _timer.Tick += _timer_Tick;
        }
        private void sliderVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElementMain.Volume = sliderVolume.Value;
        }

        private void sliderBalance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElementMain.Balance = sliderBalance.Value;
        }

        private void sliderSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElementMain.SpeedRatio = sliderSpeed.Value;
        }

        private void mediaElementMain_MediaEnded(object sender, RoutedEventArgs e)
        {
      
            _timer.Stop();
            if (_playListContainer.PlayListData.Count > 0)
            {
                PlayMedia(GetNextMediaFileName(true));
            }
            else
                StopMedia();
        }
              
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int clickCount = e.ClickCount;
            if(clickCount>1)
            {
                _currentSelectedIndex = listBoxPlaylist.SelectedIndex;
                PlayMedia(GetNextMediaFileName());
                BitmapImage image = null;
                _isPaused = false;
                try
                {
                    image = new BitmapImage(_pauseUri);
                    imagePlayPause.Source = image;
                }
                catch { buttonPlayPause.Content = "Pause"; }
                buttonPlayPause.ToolTip = "Pause";
            }
        }

        private void sliderDuration_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (mediaElementMain.Source != null)
            {
                if (mediaElementMain.NaturalDuration.HasTimeSpan)
                {
                    _progressTimer = TimeSpan.FromSeconds(sliderDuration.Value);
                    mediaElementMain.Position = _progressTimer;
                }
            }
        }
        #endregion



        #region Commands
        private void cmdLoad_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            e.CanExecute = true;
        }

        private void cmdLoad_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDlg = new OpenFileDialog
                {
                    FileName = "",
                    Filter = "Audio Files (*.mp3)|*.mp3|Video Files (*.mp4;*.3gp)|*.mp4;*.3gp",
                    Title = "Choose Media",
                    Multiselect = true,
                    CheckFileExists = true,
                    CheckPathExists = true,
                    ReadOnlyChecked = true
                };
                if (fileDlg.ShowDialog().Value)
                {
                    foreach (string file in fileDlg.FileNames)
                    {
                        FileInfo fi = new FileInfo(file);
                        PlayList newList = new PlayList
                        {
                            Name = fi.Name,
                            FullName = fi.FullName
                        };
                        if (fi.Extension.ToLower().Contains("mp3"))
                        {
                            newList.Icon = @"Icons\Music.ico";
                        }
                        else if (fi.Extension.ToLower().Contains("mp4") || fi.Extension.ToLower().Contains("3gp"))
                        {
                            newList.Icon = @"Icons\Video.ico";
                        }
                        _playListContainer.PlayListData.Add(newList);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmdPlayPause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _playListContainer == null ? false : _playListContainer.PlayListData.Count > 0;
        }

        private void cmdPlayPause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
             BitmapImage image = null;
            if (buttonPlayPause.ToolTip.ToString() == "Play")
            {
                if (_isPaused)
                    PlayMedia("");
                else
                {
                    PlayMedia(GetNextMediaFileName());
                }
                _isPaused = false;
                try
                {
                    image = new BitmapImage(_pauseUri);
                    imagePlayPause.Source = image;
                }
                catch { buttonPlayPause.Content = "Pause"; }
                buttonPlayPause.ToolTip = "Pause";
            }
            else if (buttonPlayPause.ToolTip.ToString() == "Pause")
            {
                _isPaused = true;
                PauseMedia();

                try
                {
                    image = new BitmapImage(_playUri);
                    imagePlayPause.Source = image;
                }
                catch { buttonPlayPause.Content = "Play"; }
                buttonPlayPause.ToolTip = "Play";
            }
        }

        private void cmdStop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void cmdStop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StopMedia();
            BitmapImage image = null;
            try
            {
                image = new BitmapImage(_playUri);
                imagePlayPause.Source = image;
            }
            catch { buttonPlayPause.Content = "Play"; }
            buttonPlayPause.ToolTip = "Play";
            _isPaused = false;
        }

        private void cmdMute_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void cmdMute_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaElementMain.IsMuted = !mediaElementMain.IsMuted;
        }

        private void cmdRemoveItems_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _playListContainer == null ? false : _playListContainer.PlayListData.Count > 0 && listBoxPlaylist.SelectedItems.Count>0;
        }

        private void cmdRemoveItems_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            for(int i=0;i< listBoxPlaylist.SelectedItems.Count; i++)
            {
                PlayList playlist = listBoxPlaylist.SelectedItems[i] as PlayList;
                if(playlist!=null)
                {
                    try
                    {
                        if (_currentlyPlayedFileName == playlist.FullName)
                        {
                            StopMedia();
                        }
                        _playListContainer.PlayListData.Remove(playlist);
                        i--;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error removing items", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void cmdClearAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _playListContainer == null ? false : _playListContainer.PlayListData.Count > 0;
        }

        private void cmdClearAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                StopMedia();
                _playListContainer.PlayListData.Clear();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Error clearing items", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Console.WriteLine(ex);
            }
        }
        #endregion
    }
}
