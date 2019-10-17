using System;
using System.Net.Mime;
using Gtk;

namespace ARKTexColorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            var win = new MainWindow();
            win.ShowAll();
            Application.Run();
        }
    }
}