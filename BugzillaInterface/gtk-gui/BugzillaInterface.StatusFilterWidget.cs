
// This file has been generated by the GUI designer. Do not modify.
namespace BugzillaInterface
{
	public partial class StatusFilterWidget
	{
		private global::Gtk.VBox vbox8;
		private global::Gtk.Frame frame7;
		private global::Gtk.Alignment GtkAlignment;
		private global::BugzillaInterface.StringArrayWidget statusArray;
		private global::Gtk.Label GtkLabel1;
		private global::Gtk.Frame frame8;
		private global::Gtk.Alignment GtkAlignment1;
		private global::BugzillaInterface.StringArrayWidget resolutionArray;
		private global::Gtk.Label GtkLabel17;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BugzillaInterface.StatusFilterWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BugzillaInterface.StatusFilterWidget";
			// Container child BugzillaInterface.StatusFilterWidget.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.frame7 = new global::Gtk.Frame ();
			this.frame7.Name = "frame7";
			this.frame7.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame7.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.statusArray = new global::BugzillaInterface.StringArrayWidget ();
			this.statusArray.Events = ((global::Gdk.EventMask)(256));
			this.statusArray.Name = "statusArray";
			this.GtkAlignment.Add (this.statusArray);
			this.frame7.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Status</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame7.LabelWidget = this.GtkLabel1;
			this.vbox8.Add (this.frame7);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.frame7]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.frame8 = new global::Gtk.Frame ();
			this.frame8.Name = "frame8";
			this.frame8.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame8.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.resolutionArray = new global::BugzillaInterface.StringArrayWidget ();
			this.resolutionArray.Events = ((global::Gdk.EventMask)(256));
			this.resolutionArray.Name = "resolutionArray";
			this.GtkAlignment1.Add (this.resolutionArray);
			this.frame8.Add (this.GtkAlignment1);
			this.GtkLabel17 = new global::Gtk.Label ();
			this.GtkLabel17.Name = "GtkLabel17";
			this.GtkLabel17.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Resolution</b>");
			this.GtkLabel17.UseMarkup = true;
			this.frame8.LabelWidget = this.GtkLabel17;
			this.vbox8.Add (this.frame8);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.frame8]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox8);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
