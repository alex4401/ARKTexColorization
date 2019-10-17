using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ARKTexColorization
{
    public class MainWindow : Window
    {
        private Grid _channelGrid;
        private ColorChannelWidget _redColorizationTarget;
        
        public MainWindow() : this(new Builder("Interface.glade")) {}

        private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
        {
            _channelGrid = builder.GetObject("ChannelTargetGrid") as Grid;
            _SetupColorChannels();
            DeleteEvent += Window_DeleteEvent;
        }

        private void _SetupColorChannels()
        {
            _redColorizationTarget = new ColorChannelWidget(ColorChannel.Red);
            _AddColorChannelToGrid(_redColorizationTarget, 0, 0);
        }

        private void _AddColorChannelToGrid(ColorChannelWidget widget, int index, int column)
        {
            _channelGrid.Attach(widget, column, 1 + index, 1, 1);
            widget.Show();
        }

        private void Window_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}