﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Anolis.Core.Data {
	
#region ResourceType specific
	
	public class IconCursorImageResourceData : ResourceData {
		
		public IconCursorImageResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
	public class IconCursorDirectoryResourceData : ResourceData {
		
		public IconCursorDirectoryResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
	public class BitmapResourceData : ResourceData {
		
		public BitmapResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
	public class VersionResourceData : ResourceData {
		
		public VersionResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
#endregion

#region General Purpose or Custom Resource
	
	/// <summary>Represents a generic image that isn't a Win32 Bitmap, e.g. PNG and JPEG files.</summary>
	public class ImageResourceData : ResourceData {
		
		public ImageResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
	/// <summary>Represents a generic multimedia source, e.g. AVI, MPEG, or MP3 and WAV.</summary>
	public class MultimediaResourceData : ResourceData {
		
		public MultimediaResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
		}
		
	}
	
	/// <summary>Represents an XML, HTML, or other SGML-derived structured document, including Windows Manifests.</summary>
	public class XmlHtmlResourceData : ResourceData {
		
		public XmlHtmlResourceData(ResourceLang lang, Byte[] rawData) : base(lang, rawData) {
			
			
			
		}
		
	}
	
#endregion
	
}
