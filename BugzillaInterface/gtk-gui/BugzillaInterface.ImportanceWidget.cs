
// This file has been generated by the GUI designer. Do not modify.
namespace BugzillaInterface
{
	public partial class ImportanceWidget
	{
		private global::Gtk.VBox vbox9;
		private global::Gtk.Frame frame9;
		private global::Gtk.Alignment GtkAlignment;
		private global::BugzillaInterface.StringArrayWidget severityArray;
		private global::Gtk.Label GtkLabel1;
		private global::Gtk.Frame frame10;
		private global::Gtk.Alignment GtkAlignment1;
		private global::BugzillaInterface.StringArrayWidget priorityArray;
		private global::Gtk.Label GtkLabel178;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BugzillaInterface.ImportanceWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BugzillaInterface.ImportanceWidget";
			// Container child BugzillaInterface.ImportanceWidget.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.frame9 = new global::Gtk.Frame ();
			this.frame9.Name = "frame9";
			this.frame9.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame9.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.severityArray = new global::BugzillaInterface.StringArrayWidget ();
			this.severityArray.Events = ((global::Gdk.EventMask)(256));
			this.severityArray.Name = "severityArray";
			this.GtkAlignment.Add (this.severityArray);
			this.frame9.Add (this.GtkAlignment);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Severity</b>");
			this.GtkLabel1.UseMarkup = true;
			this.frame9.LabelWidget = this.GtkLabel1;
			this.vbox9.Add (this.frame9);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.frame9]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.frame10 = new global::Gtk.Frame ();
			this.frame10.Name = "frame10";
			this.frame10.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame10.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.priorityArray = new global::BugzillaInterface.StringArrayWidget ();
			this.priorityArray.Events = ((global::Gdk.EventMask)(256));
			this.priorityArray.Name = "priorityArray";
			this.GtkAlignment1.Add (this.priorityArray);
			this.frame10.Add (this.GtkAlignment1);
			this.GtkLabel178 = new global::Gtk.Label ();
			this.GtkLabel178.Name = "GtkLabel178";
			this.GtkLabel178.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Priority</b>");
			this.GtkLabel178.UseMarkup = true;
			this.frame10.LabelWidget = this.GtkLabel178;
			this.vbox9.Add (this.frame10);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.frame10]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.vbox9);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
