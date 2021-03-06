
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;
	
	private global::Gtk.Table table2;
	
	private global::Gtk.Table iconsTable;
	
	private global::Gtk.Button button13;
	
	private global::Gtk.Button button14;
	
	private global::Gtk.Button exitAction;
	
	private global::Gtk.Button mailButton;
	
	private global::Gtk.Button phoneButton;
	
	private global::Gtk.Button skypeButton;
	
	private global::Gtk.Table table4;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Label timedateLabel;
	
	private global::Gtk.Label timeoutLabel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Menu");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AcceptFocus = false;
		this.Decorated = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		this.alignment1.LeftPadding = ((uint)(50));
		this.alignment1.RightPadding = ((uint)(50));
		this.alignment1.BorderWidth = ((uint)(12));
		// Container child alignment1.Gtk.Container+ContainerChild
		this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.iconsTable = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
		this.iconsTable.Name = "iconsTable";
		this.iconsTable.RowSpacing = ((uint)(6));
		this.iconsTable.ColumnSpacing = ((uint)(6));
		// Container child iconsTable.Gtk.Table+TableChild
		this.button13 = new global::Gtk.Button ();
		this.button13.Name = "button13";
		this.button13.UseUnderline = true;
		this.button13.FocusOnClick = false;
		this.button13.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w1 = new global::Gtk.Image ();
		w1.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.webIcon.png");
		this.button13.Image = w1;
		this.iconsTable.Add (this.button13);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.iconsTable [this.button13]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		// Container child iconsTable.Gtk.Table+TableChild
		this.button14 = new global::Gtk.Button ();
		this.button14.Name = "button14";
		this.button14.UseUnderline = true;
		this.button14.FocusOnClick = false;
		this.button14.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w3 = new global::Gtk.Image ();
		w3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.infoIcon.png");
		this.button14.Image = w3;
		this.iconsTable.Add (this.button14);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.iconsTable [this.button14]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		// Container child iconsTable.Gtk.Table+TableChild
		this.exitAction = new global::Gtk.Button ();
		this.exitAction.Name = "exitAction";
		this.exitAction.UseUnderline = true;
		this.exitAction.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w5 = new global::Gtk.Image ();
		w5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.exitIcon.png");
		this.exitAction.Image = w5;
		this.iconsTable.Add (this.exitAction);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.iconsTable [this.exitAction]));
		w6.TopAttach = ((uint)(1));
		w6.BottomAttach = ((uint)(2));
		w6.LeftAttach = ((uint)(2));
		w6.RightAttach = ((uint)(3));
		// Container child iconsTable.Gtk.Table+TableChild
		this.mailButton = new global::Gtk.Button ();
		this.mailButton.Name = "mailButton";
		this.mailButton.UseUnderline = true;
		this.mailButton.FocusOnClick = false;
		this.mailButton.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w7 = new global::Gtk.Image ();
		w7.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.mailIcon.png");
		this.mailButton.Image = w7;
		this.iconsTable.Add (this.mailButton);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.iconsTable [this.mailButton]));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		// Container child iconsTable.Gtk.Table+TableChild
		this.phoneButton = new global::Gtk.Button ();
		this.phoneButton.Name = "phoneButton";
		this.phoneButton.UseUnderline = true;
		this.phoneButton.FocusOnClick = false;
		this.phoneButton.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w9 = new global::Gtk.Image ();
		w9.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.phoneIcon.png");
		this.phoneButton.Image = w9;
		this.iconsTable.Add (this.phoneButton);
		// Container child iconsTable.Gtk.Table+TableChild
		this.skypeButton = new global::Gtk.Button ();
		this.skypeButton.Name = "skypeButton";
		this.skypeButton.UseUnderline = true;
		this.skypeButton.FocusOnClick = false;
		this.skypeButton.Relief = ((global::Gtk.ReliefStyle)(2));
		global::Gtk.Image w11 = new global::Gtk.Image ();
		w11.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Menu.skypeIcon.png");
		this.skypeButton.Image = w11;
		this.iconsTable.Add (this.skypeButton);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.iconsTable [this.skypeButton]));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		this.table2.Add (this.iconsTable);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.iconsTable]));
		w13.TopAttach = ((uint)(1));
		w13.BottomAttach = ((uint)(2));
		// Container child table2.Gtk.Table+TableChild
		this.table4 = new global::Gtk.Table (((uint)(1)), ((uint)(3)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\"bold\" size=\"10\"> Smart Spot 1337</span>");
		this.label3.UseMarkup = true;
		this.table4.Add (this.label3);
		global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table4 [this.label3]));
		w14.LeftAttach = ((uint)(1));
		w14.RightAttach = ((uint)(2));
		// Container child table4.Gtk.Table+TableChild
		this.timedateLabel = new global::Gtk.Label ();
		this.timedateLabel.Name = "timedateLabel";
		this.timedateLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("14:00:00 12.01.2016");
		this.timedateLabel.Justify = ((global::Gtk.Justification)(1));
		this.table4.Add (this.timedateLabel);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table4 [this.timedateLabel]));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.timeoutLabel = new global::Gtk.Label ();
		this.timeoutLabel.Name = "timeoutLabel";
		this.timeoutLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("13:27");
		this.table4.Add (this.timeoutLabel);
		this.table2.Add (this.table4);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.table4]));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		this.alignment1.Add (this.table2);
		this.Add (this.alignment1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 695;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.skypeButton.Clicked += new global::System.EventHandler (this.OnSkypeButtonClicked);
		this.phoneButton.Clicked += new global::System.EventHandler (this.OnPhoneButtonClicked);
		this.mailButton.Clicked += new global::System.EventHandler (this.OnMailButtonClicked);
		this.exitAction.Clicked += new global::System.EventHandler (this.OnExitActionClicked);
		this.button14.Clicked += new global::System.EventHandler (this.OnButton14Clicked);
		this.button13.Clicked += new global::System.EventHandler (this.OnButton13Clicked);
	}
}
