
// This file has been generated by the GUI designer. Do not modify.
namespace Mono.Upnp.GtkClient
{
	public partial class ServiceAnnouncementInfo
	{
		private global::Gtk.Table table1;
        
		private global::Gtk.Label deviceUdn;
        
		private global::Gtk.Label label1;
        
		private global::Gtk.Label label2;
        
		private global::Gtk.Label label3;
        
		private global::Gtk.VBox locationBox;
        
		private global::Gtk.Label serviceType;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Mono.Upnp.GtkClient.ServiceAnnouncementInfo
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Mono.Upnp.GtkClient.ServiceAnnouncementInfo";
			// Container child Mono.Upnp.GtkClient.ServiceAnnouncementInfo.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(10));
			this.table1.ColumnSpacing = ((uint)(10));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.deviceUdn = new global::Gtk.Label ();
			this.deviceUdn.Name = "deviceUdn";
			this.deviceUdn.Xalign = 0F;
			this.deviceUdn.LabelProp = "deviceUdn";
			this.deviceUdn.Selectable = true;
			this.table1.Add (this.deviceUdn);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.deviceUdn]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Service Type</b>");
			this.label1.UseMarkup = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Device UDN</b>");
			this.label2.UseMarkup = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.Yalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Locations</b>");
			this.label3.UseMarkup = true;
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.locationBox = new global::Gtk.VBox ();
			this.locationBox.Name = "locationBox";
			this.locationBox.Spacing = 6;
			this.table1.Add (this.locationBox);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.locationBox]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.serviceType = new global::Gtk.Label ();
			this.serviceType.Name = "serviceType";
			this.serviceType.Xalign = 0F;
			this.serviceType.LabelProp = "serviceType";
			this.serviceType.Selectable = true;
			this.table1.Add (this.serviceType);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.serviceType]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
