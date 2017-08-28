using System.Windows.Input;

namespace MirzaMediaPlayer.Commands
{
    public class PlayerCoreCommands
    {
        /// <summary>
        /// Load Command
        /// </summary>
        public static RoutedUICommand LoadCommand { get; set; } =
            new RoutedUICommand("Load Files", "LoadFiles",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.O,ModifierKeys.Control)
                });
        /// <summary>
        /// Play or Pause Command
        /// </summary>
        public static RoutedUICommand PlayPauseCommand { get; set; } =
            new RoutedUICommand("Play/Pause", "PlayPause",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.P,ModifierKeys.Control)
                });
        /// <summary>
        /// Stop Command
        /// </summary>
        public static RoutedUICommand StopCommand { get; set; } =
            new RoutedUICommand("Stop", "Stop",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.S,ModifierKeys.Control)
                });
        /// <summary>
        /// Mute Command
        /// </summary>
        public static RoutedUICommand MuteCommand { get; set; } =
            new RoutedUICommand("Mute", "Mute",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.M,ModifierKeys.Control)
                });
        /// <summary>
        /// Remove Selected Items in Playlist Command
        /// </summary>
        public static RoutedUICommand RemoveItemsPlaylistCommand { get; set; } =
            new RoutedUICommand("Remove Selected Items", "RemoveSelectedItems",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.Delete,ModifierKeys.Control)
                });
        /// <summary>
        /// Clear All Command
        /// </summary>
        public static RoutedUICommand ClearAllCommand { get; set; } =
            new RoutedUICommand("Clear All", "ClearAll",
                typeof(PlayerCoreCommands),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.R,ModifierKeys.Control)
                });


    }
}
