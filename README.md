# Mono.Upnp

Mono.Upnp is set of client/server libraries for the Universal Plug 'n Play
specifications. See <http://www.upnp.org>.

To build with Visual Studio or MonoDevelop, open Mono.Upnp.sln and build the
solution.

To build with from the command line with Mono:

    xbuild Mono.Upnp.sln

To build with from the command line with .NET:

    msbuild Mono.Upnp.sln

About the projects:

* Mono.Ssdp:

  An implementation of the Simple Discovery Protocol (see UPnP Device
  Architecture 1.1, Section 1).

* Mono.Upnp:

  An implementation of the UPnP Device Archetecture 1.1, Secions 2-5.

* Mono.Upnp.GtkClient:

  An executable GTK+ user interface for inspecting UPnP devices and services on
  the network.

* Mono.Upnp.Dcp.MediaServer1:

  An implementation of the UPnP Audio/Video MediaServer1 Device Control
  Protocol.

* Mono.Upnp.Dcp.MediaServer1.FileSystem:

  A MediaServer1 implementation which serves media from the file system.

* Mono.Upnp.Dcp.MediaServer1.FileSystem.ConsoleServer:

  An executable console program which serves media from the file system.

* Mono.Upnp.Dcp.MSMediaServerRegistrar1:

  An implementation of the Microsoft MSMediaServerRegistrar1 Device Control
  Protocol.
