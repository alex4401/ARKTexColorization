using Gtk;

namespace ARKTexColorization
{
    public class ColorChannelWidget : Box
    {
        private Label _label;
        private Entry _rEntry;
        private Entry _gEntry;
        private Entry _bEntry;

        public ColorChannelWidget(ColorChannel channel) : base(Gtk.Orientation.Horizontal, 0)
        {
            _label = new Label
            {
                Text = channel.ToString()
            };
            _rEntry = _NewColorEntry();
            _gEntry = _NewColorEntry();
            _bEntry = _NewColorEntry();
            
            PackStart(_label, false, false, 8);
        }

        private Entry _NewColorEntry()
        {
            var entry = new Entry();
            entry.InputHints = InputHints.NoSpellcheck;
            entry.InputPurpose = InputPurpose.Number;
            entry.Text = "1.0";
            return entry;
        }
    }
}