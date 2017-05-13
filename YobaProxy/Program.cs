using System;
using Gtk;

namespace YobaProxy
{
   class MainClass
   {
      public static void Main()
      {
         Application.Init();

         MainWindow window = new MainWindow();
         window.Show();

         Application.Run();
      }
   }
}
