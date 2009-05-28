// 
// DeviceDescriptionTests.cs
//  
// Author:
//       Scott Peterson <lunchtimemama@gmail.com>
// 
// Copyright (c) 2009 Scott Peterson
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using NUnit.Framework;

using Mono.Upnp.Xml;

namespace Mono.Upnp.Tests
{
    [TestFixture]
    public class DeviceDescriptionTests
    {
        readonly XmlSerializer serializer = new XmlSerializer ();
        readonly DummyDeserializer deserializer = new DummyDeserializer (new XmlDeserializer ());
        
        void AssertEquality (Root sourceRoot, Root targetRoot)
        {
            Assert.IsNotNull (targetRoot.SpecVersion);
            Assert.AreEqual (sourceRoot.SpecVersion.Major, targetRoot.SpecVersion.Major);
            Assert.AreEqual (sourceRoot.SpecVersion.Minor, targetRoot.SpecVersion.Minor);
            Assert.IsNotNull (targetRoot.UrlBase);
            Assert.AreEqual (sourceRoot.UrlBase, targetRoot.UrlBase);
            Assert.IsNotNull (targetRoot.RootDevice);
            AssertEquality (sourceRoot.RootDevice, targetRoot.RootDevice);
        }
        
        void AssertEquality (Device sourceDevice, Device targetDevice)
        {
            Assert.AreEqual (sourceDevice.Type, targetDevice.Type);
            Assert.AreEqual (sourceDevice.FriendlyName, targetDevice.FriendlyName);
            Assert.AreEqual (sourceDevice.Manufacturer, targetDevice.Manufacturer);
            Assert.AreEqual (sourceDevice.ManufacturerUrl, targetDevice.ManufacturerUrl);
            Assert.AreEqual (sourceDevice.ModelDescription, targetDevice.ModelDescription);
            Assert.AreEqual (sourceDevice.ModelName, targetDevice.ModelName);
            Assert.AreEqual (sourceDevice.ModelNumber, targetDevice.ModelNumber);
            Assert.AreEqual (sourceDevice.ModelUrl, targetDevice.ModelUrl);
            Assert.AreEqual (sourceDevice.SerialNumber, targetDevice.SerialNumber);
            Assert.AreEqual (sourceDevice.Udn, targetDevice.Udn);
            Assert.AreEqual (sourceDevice.Upc, targetDevice.Upc);
            Assert.IsNotNull (targetDevice.Icons);
            var source_icons = sourceDevice.Icons.GetEnumerator ();
            var target_icons = targetDevice.Icons.GetEnumerator ();
            while (source_icons.MoveNext ()) {
                Assert.IsTrue (target_icons.MoveNext ());
                AssertEquality (source_icons.Current, target_icons.Current);
            }
            Assert.IsFalse (target_icons.MoveNext ());
            Assert.IsNotNull (targetDevice.Services);
            var source_services = sourceDevice.Services.GetEnumerator ();
            var target_services = targetDevice.Services.GetEnumerator ();
            while (source_services.MoveNext ()) {
                Assert.IsTrue (target_services.MoveNext ());
                AssertEquality (source_services.Current, target_services.Current);
            }
            Assert.IsFalse (target_services.MoveNext ());
            Assert.IsNotNull (targetDevice.Devices);
            var source_devices = sourceDevice.Devices.GetEnumerator ();
            var target_devices = targetDevice.Devices.GetEnumerator ();
            while (source_devices.MoveNext ()) {
                Assert.IsTrue (target_devices.MoveNext ());
                AssertEquality (source_devices.Current, target_devices.Current);
            }
            Assert.IsFalse (target_services.MoveNext ());
        }
        
        void AssertEquality (Icon sourceIcon, Icon targetIcon)
        {
            Assert.AreEqual (sourceIcon.MimeType, targetIcon.MimeType);
            Assert.AreEqual (sourceIcon.Width, targetIcon.Width);
            Assert.AreEqual (sourceIcon.Height, targetIcon.Height);
            Assert.AreEqual (sourceIcon.Depth, targetIcon.Depth);
            Assert.AreEqual (sourceIcon.Url, targetIcon.Url);
        }
        
        void AssertEquality (Service sourceService, Service targetService)
        {
            Assert.AreEqual (sourceService.Type, targetService.Type);
            Assert.AreEqual (sourceService.Id, targetService.Id);
            Assert.AreEqual (sourceService.ScpdUrl, targetService.ScpdUrl);
            Assert.AreEqual (sourceService.ControlUrl, targetService.ControlUrl);
            Assert.AreEqual (sourceService.EventUrl, targetService.EventUrl);
        }
        
        [Test]
        public void FullDescriptionTest ()
        {
            var source_root = new DummyRoot (
                new DeviceSettings (
                    new DeviceType ("urn:schemas-upnp-org:device:mono-upnp-tests-full-device:1"),
                    "uuid:fd1",
                    "Mono.Upnp.Tests Full Device",
                    "Mono Project",
                    "Full Device") {
                    ManufacturerUrl = new Uri ("http://www.mono-project.org/"),
                    ModelDescription = "A device description with all optional information.",
                    ModelNumber = "1",
                    ModelUrl = new Uri ("http://www.mono-project.org/Mono.Upnp/"),
                    SerialNumber = "12345",
                    Upc = "67890",
                    Icons = new Icon[] {
                        new DummyIcon (100, 100, 32, "image/png"),
                        new DummyIcon (100, 100, 32, "image/jpeg")
                    },
                    Services = new Service[] {
                        new DummyService (new ServiceType ("urn:schemas-upnp-org:service:mono-upnp-test-service:1"), "urn:upnp-org:serviceId:testService1"),
                        new DummyService (new ServiceType ("urn:schemas-upnp-org:service:mono-upnp-test-service:2"), "urn:upnp-org:serviceId:testService2"),
                    }
                }, 
                new Device[] {
                    new Device (new DeviceSettings (
                        new DeviceType ("urn:schemas-upnp-org:device:mono-upnp-tests-full-embedded-device:1"),
                        "uuid:fed1",
                        "Mono.Upnp.Tests Full Embedded Device",
                        "Mono Project",
                        "Full Embedded Device") {
                        ManufacturerUrl = new Uri ("http://www.mono-project.org/"),
                        ModelDescription = "An embedded device description with all optional information.",
                        ModelNumber = "1",
                        ModelUrl = new Uri ("http://www.mono-project.org/Mono.Upnp/"),
                        SerialNumber = "12345",
                        Upc = "67890",
                        Icons = new Icon[] {
                            new DummyIcon (100, 100, 32, "image/png"),
                            new DummyIcon (100, 100, 32, "image/jpeg")
                        },
                        Services = new Service[] {
                            new DummyService (new ServiceType ("urn:schemas-upnp-org:service:mono-upnp-test-service:1"), "urn:upnp-org:serviceId:testService1"),
                            new DummyService (new ServiceType ("urn:schemas-upnp-org:service:mono-upnp-test-service:2"), "urn:upnp-org:serviceId:testService2"),
                        }
                    })
                }
            );
            source_root.Initialize ();
            var target_root = deserializer.DeserializeRoot (serializer.GetString<Root> (source_root));
            AssertEquality (source_root, target_root);
        }
    }
}
