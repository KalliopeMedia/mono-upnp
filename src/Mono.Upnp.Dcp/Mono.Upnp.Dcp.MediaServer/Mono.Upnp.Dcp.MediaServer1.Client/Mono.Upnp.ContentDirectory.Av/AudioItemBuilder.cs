// 
// AudioItemBuilder.cs
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
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Mono.Upnp.ContentDirectory.Av
{
	public abstract class AudioItemBuilder : ItemBuilder
	{
		readonly List<string> genres = new List<string> ();
		readonly List<string> publishers = new List<string> ();
		readonly List<Uri> relations = new List<Uri> ();
		readonly List<string> rights = new List<string> ();
		
		[XmlArrayItem ("genre", Namespace = Schemas.UpnpSchema)]
		public ICollection<string> Genres { get { return genres; } }
		
		[XmlElement ("description", Namespace = Schemas.UpnpSchema)]
        public string Description { get; set; }
		
		[XmlElement ("longDescription", Namespace = Schemas.UpnpSchema)]
        public string LongDescription { get; set; }
		
		[XmlArrayItem ("publisher", Namespace = Schemas.DublinCoreSchema)]
        public ICollection<string> Publishers { get { return publishers; } }
		
		[XmlElement ("language", Namespace = Schemas.DublinCoreSchema)]
        public string Language { get; set; }
		
		[XmlArrayItem ("relation", Namespace = Schemas.DublinCoreSchema)]
        public ICollection<Uri> Relations { get { return relations; } }
		
		[XmlArrayItem ("rights", Namespace = Schemas.DublinCoreSchema)]
        public ICollection<string> Rights { get { return rights; } }
	}
}