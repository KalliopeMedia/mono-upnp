
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Upnp.GtkClient
{
	public partial class LazyIcon
	{
		private global::Gtk.Alignment alignment;
        
		private global::Gtk.Label loading;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Upnp.GtkClient.LazyIcon
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Mono.Upnp.GtkClient.LazyIcon";
			// Container child Mono.Upnp.GtkClient.LazyIcon.Gtk.Container+ContainerChild
			this.alignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment.Name = "alignment";
			// Container child alignment.Gtk.Container+ContainerChild
			this.loading = new global::Gtk.Label ();
			this.loading.Name = "loading";
			this.loading.LabelProp = global::Mono.Unix.Catalog.GetString ("Loading Icon");
			this.alignment.Add (this.loading);
			this.Add (this.alignment);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.Mapped += new global::System.EventHandler (this.OnMapped);
		}
	}
}
