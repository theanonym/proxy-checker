using System;
using Gtk;
using System.Net;

namespace YobaProxy
{
   public partial class MainWindow : Gtk.Window
   {
      private ProxyList proxylistAll = new ProxyList();
      private ProxyList proxylistGood = new ProxyList();
      private ProxyChecker checker = new ProxyChecker();

      public MainWindow()
         : base(Gtk.WindowType.Toplevel)
      {
         Build();
         Title = "Yoba Proxy";

         spinConnections.Value = 25;
         spinTimeout.Value = 20;
         textInput.IsFocus = true;

         DeleteEvent += OnClose;

         // Parser
         buttonParseInput.Clicked += ParseInput;
         buttonParseAll.Clicked += ParseAll;
         buttonParseUsProxy.Clicked += ParseUsProxy;
         buttonParseFreeProxyList.Clicked += ParseFreeProxyList;
         buttonReadFile.Clicked += ChooseFileAndRead;
         buttonSaveToFile.Clicked += ChooseFileAndWrite;
         buttonInsertGoodProxies.Clicked += InsertGoodProxies;

         // Checker
         buttonRunChecker.Clicked += RunChecker;

         checker.ProxyChecked += delegate {
            Application.Invoke(delegate {
               double progress = progressCheck.Fraction + 1.0 / (double)proxylistAll.Count;
               if(progress > 1.0)
                  progress = 1.0;

               progressCheck.Fraction = progress;

               labelChecked.Text = (int.Parse(labelChecked.Text) + 1).ToString();
            });
         };

         checker.ProxyCheckedSuccessfull += delegate(object sender, WebProxy proxy) {
            Application.Invoke(delegate {
               proxylistGood.AddUnique(proxy);
               labelGood.Text = proxylistGood.Count.ToString();
            });
         };
      }

      private void ParseInput(object sender, EventArgs args)
      {
         proxylistAll.AddRange(ProxyParser.ParseString(textInput.Buffer.Text));

         Application.Invoke(delegate {
            labelTotal.Text = proxylistAll.Count.ToString();
         });
      }

      private async void ParseAll(object sender, EventArgs args)
      {
         Application.Invoke(delegate {
            buttonParseAll.Sensitive = false;
         });

         proxylistAll.AddRange(await ProxyParser.ParseAllAsync());

         Application.Invoke(delegate {
            labelTotal.Text = proxylistAll.Count.ToString();
            textInput.Buffer.Text = proxylistAll.ToString();

            buttonParseAll.Sensitive = true;
         });
      }

      private async void ParseUsProxy(object sender, EventArgs args)
      {
         Application.Invoke(delegate {
            buttonParseUsProxy.Sensitive = false;
         });

         proxylistAll.AddRange(await ProxyParser.ParseUsProxyAsync());

         Application.Invoke(delegate {
            labelTotal.Text = proxylistAll.Count.ToString();
            textInput.Buffer.Text = proxylistAll.ToString();

            buttonParseUsProxy.Sensitive = true;
         });
      }

      private async void ParseFreeProxyList(object sender, EventArgs args)
      {
         Application.Invoke(delegate {
            buttonParseFreeProxyList.Sensitive = false;
         });

         proxylistAll.AddRange(await ProxyParser.ParseFreeProxyListAsync());

         Application.Invoke(delegate {
            labelTotal.Text = proxylistAll.Count.ToString();
            textInput.Buffer.Text = proxylistAll.ToString();

            buttonParseFreeProxyList.Sensitive = true;
         });
      }

      private async void RunChecker(object sender, EventArgs args)
      {
         Application.Invoke(delegate {
            buttonRunChecker.Sensitive = false;
            spinConnections.Sensitive = false;
            spinTimeout.Sensitive = false;
         });

         try
         {
            await checker.CheckAsync(proxylistAll,
                                     spinConnections.ValueAsInt,
                                     TimeSpan.FromSeconds(spinTimeout.ValueAsInt));
         }
         catch(Exception e)
         {
            Console.WriteLine(e.Message);
         }

         Application.Invoke(delegate {
            buttonRunChecker.Sensitive = true;
            spinConnections.Sensitive = true;
            spinTimeout.Sensitive = true;
         });
      }

      private void ChooseFileAndRead(object sender, EventArgs args)
      {
         var dialog = new FileChooserDialog("Open file",
                                            this,
                                            FileChooserAction.Open,
                                            "Close", ResponseType.Cancel,
                                            "Open", ResponseType.Accept);
         switch((ResponseType)dialog.Run())
         {
            case ResponseType.Accept:
               try
               {
                  Application.Invoke(delegate {
                     ReadFromFile(dialog.Filename);
                  });
               }
               catch(Exception e)
               {
                  Console.WriteLine(e.Message);
                  Application.Invoke(delegate {
                     textInput.Buffer.Clear();
                  });
               }

               break;
         }

         dialog.Destroy();
      }

      private void ChooseFileAndWrite(object sender, EventArgs args)
      {
         if(textInput.Buffer.Text.Length == 0)
            return;

         var dialog = new FileChooserDialog("Save file",
                                            this,
                                            FileChooserAction.Save,
                                            "Close", ResponseType.Cancel,
                                            "Save", ResponseType.Accept);
         switch((ResponseType)dialog.Run())
         {
            case ResponseType.Accept:
               try
               {
                  WriteToFile(dialog.Filename);
               }
               catch(Exception e)
               {
                  Console.WriteLine(e.Message);
               }
               break;
         }

         dialog.Destroy();
      }

      private void InsertGoodProxies(object sender, EventArgs args)
      {
         textInput.Buffer.Text = proxylistGood.ToString();
      }

      private void ReadFromFile(string filename)
      {
         proxylistAll.AddRange(ProxyParser.ReadFile(filename));

         textInput.Buffer.Text = proxylistAll.ToString();
         labelTotal.Text = proxylistAll.Count.ToString();
      }

      private void WriteToFile(string filename)
      {
         ProxyParser.WriteFile(filename, ProxyParser.ParseString(textInput.Buffer.Text));
      }

      private void OnClose(object sender, EventArgs args)
      {
         Application.Quit();
      }

      private void UpdateIndicators()
      {
         labelTotal.Text = proxylistAll.Count.ToString();
         labelGood.Text = proxylistGood.Count.ToString();
      }
   }
}
