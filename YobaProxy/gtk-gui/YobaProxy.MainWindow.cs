
// This file has been generated by the GUI designer. Do not modify.
namespace YobaProxy
{
	public partial class MainWindow
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Label labelChecked;
		
		private global::Gtk.Label labelGood;
		
		private global::Gtk.Label labelTotal;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.HSeparator hseparator2;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.Label label13;
		
		private global::Gtk.Label label14;
		
		private global::Gtk.SpinButton spinConnections;
		
		private global::Gtk.SpinButton spinTimeout;
		
		private global::Gtk.Button buttonRunChecker;
		
		private global::Gtk.ProgressBar progressCheck;
		
		private global::Gtk.Label GtkLabel4;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Button buttonParseAll;
		
		private global::Gtk.Button buttonParseUsProxy;
		
		private global::Gtk.Button buttonParseFreeProxyList;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.Button buttonReadFile;
		
		private global::Gtk.Label GtkLabel6;
		
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textInput;
		
		private global::Gtk.HButtonBox hbuttonbox1;
		
		private global::Gtk.Button buttonInsertGoodProxies;
		
		private global::Gtk.Button buttonParseInput;
		
		private global::Gtk.Button buttonSaveToFile;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget YobaProxy.MainWindow
			this.Name = "YobaProxy.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child YobaProxy.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(5));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.Xalign = 0F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Good");
			this.table2.Add (this.label12);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2 [this.label12]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Total");
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Checked");
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelChecked = new global::Gtk.Label ();
			this.labelChecked.Name = "labelChecked";
			this.labelChecked.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.table2.Add (this.labelChecked);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelChecked]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelGood = new global::Gtk.Label ();
			this.labelGood.Name = "labelGood";
			this.labelGood.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.table2.Add (this.labelGood);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelGood]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
			this.table2.Add (this.labelTotal);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelTotal]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox4.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hseparator2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Connections");
			this.table3.Add (this.label13);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.label13]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Timeout");
			this.table3.Add (this.label14);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.label14]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.spinConnections = new global::Gtk.SpinButton (1, 50, 1);
			this.spinConnections.CanFocus = true;
			this.spinConnections.Name = "spinConnections";
			this.spinConnections.Adjustment.PageIncrement = 5;
			this.spinConnections.ClimbRate = 1;
			this.spinConnections.Numeric = true;
			this.table3.Add (this.spinConnections);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.spinConnections]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.spinTimeout = new global::Gtk.SpinButton (1, 60, 1);
			this.spinTimeout.CanFocus = true;
			this.spinTimeout.Name = "spinTimeout";
			this.spinTimeout.Adjustment.PageIncrement = 10;
			this.spinTimeout.ClimbRate = 1;
			this.spinTimeout.Numeric = true;
			this.table3.Add (this.spinTimeout);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.spinTimeout]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox4.Add (this.table3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.table3]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.buttonRunChecker = new global::Gtk.Button ();
			this.buttonRunChecker.CanFocus = true;
			this.buttonRunChecker.Name = "buttonRunChecker";
			this.buttonRunChecker.UseUnderline = true;
			this.buttonRunChecker.Label = global::Mono.Unix.Catalog.GetString ("Run checker");
			this.vbox4.Add (this.buttonRunChecker);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonRunChecker]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.progressCheck = new global::Gtk.ProgressBar ();
			this.progressCheck.Name = "progressCheck";
			this.vbox4.Add (this.progressCheck);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.progressCheck]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.GtkAlignment1.Add (this.vbox3);
			this.frame2.Add (this.GtkAlignment1);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Checker</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel4;
			this.hbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame2]));
			w19.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonParseAll = new global::Gtk.Button ();
			this.buttonParseAll.CanFocus = true;
			this.buttonParseAll.Name = "buttonParseAll";
			this.buttonParseAll.UseUnderline = true;
			this.buttonParseAll.Label = "Parse all sites";
			this.vbox2.Add (this.buttonParseAll);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonParseAll]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonParseUsProxy = new global::Gtk.Button ();
			this.buttonParseUsProxy.CanFocus = true;
			this.buttonParseUsProxy.Name = "buttonParseUsProxy";
			this.buttonParseUsProxy.UseUnderline = true;
			this.buttonParseUsProxy.Label = global::Mono.Unix.Catalog.GetString ("us-proxy.org");
			this.vbox2.Add (this.buttonParseUsProxy);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonParseUsProxy]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonParseFreeProxyList = new global::Gtk.Button ();
			this.buttonParseFreeProxyList.CanFocus = true;
			this.buttonParseFreeProxyList.Name = "buttonParseFreeProxyList";
			this.buttonParseFreeProxyList.UseUnderline = true;
			this.buttonParseFreeProxyList.Label = global::Mono.Unix.Catalog.GetString ("free-proxy-list.net");
			this.vbox2.Add (this.buttonParseFreeProxyList);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonParseFreeProxyList]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonReadFile = new global::Gtk.Button ();
			this.buttonReadFile.CanFocus = true;
			this.buttonReadFile.Name = "buttonReadFile";
			this.buttonReadFile.UseUnderline = true;
			this.buttonReadFile.Label = global::Mono.Unix.Catalog.GetString ("Read file");
			this.vbox2.Add (this.buttonReadFile);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonReadFile]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			this.GtkAlignment.Add (this.vbox2);
			this.frame1.Add (this.GtkAlignment);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Parser</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel6;
			this.hbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame1]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textInput = new global::Gtk.TextView ();
			this.textInput.CanFocus = true;
			this.textInput.Name = "textInput";
			this.GtkScrolledWindow.Add (this.textInput);
			this.vbox5.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.GtkScrolledWindow]));
			w30.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.Spacing = 4;
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonInsertGoodProxies = new global::Gtk.Button ();
			this.buttonInsertGoodProxies.CanFocus = true;
			this.buttonInsertGoodProxies.Name = "buttonInsertGoodProxies";
			this.buttonInsertGoodProxies.UseUnderline = true;
			this.buttonInsertGoodProxies.Label = global::Mono.Unix.Catalog.GetString ("Insert good proxies");
			this.hbuttonbox1.Add (this.buttonInsertGoodProxies);
			global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonInsertGoodProxies]));
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonParseInput = new global::Gtk.Button ();
			this.buttonParseInput.CanFocus = true;
			this.buttonParseInput.Name = "buttonParseInput";
			this.buttonParseInput.UseUnderline = true;
			this.buttonParseInput.Label = global::Mono.Unix.Catalog.GetString ("Parse input");
			this.hbuttonbox1.Add (this.buttonParseInput);
			global::Gtk.ButtonBox.ButtonBoxChild w32 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonParseInput]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonSaveToFile = new global::Gtk.Button ();
			this.buttonSaveToFile.CanFocus = true;
			this.buttonSaveToFile.Name = "buttonSaveToFile";
			this.buttonSaveToFile.UseUnderline = true;
			this.buttonSaveToFile.Label = global::Mono.Unix.Catalog.GetString ("Save to file");
			this.hbuttonbox1.Add (this.buttonSaveToFile);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonSaveToFile]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			this.vbox5.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbuttonbox1]));
			w34.PackType = ((global::Gtk.PackType)(1));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox5]));
			w35.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 427;
			this.DefaultHeight = 415;
			this.Show ();
		}
	}
}
