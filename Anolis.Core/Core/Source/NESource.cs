﻿using System;
using System.Collections.Generic;
using System.Text;

using Anolis.Core.Data;

namespace Anolis.Core.Source {
	
	public class NEResourceSource : ResourceSource {
		
		public NEResourceSource() : base(true, ResourceSourceLoadMode.Blind) {
			
		}
		
		public override String Name {
			get { throw new NotImplementedException(); }
		}
		
		public override ResourceData GetResourceData(ResourceLang lang) {
			
			throw new NotImplementedException();
		}
		
		public override void CommitChanges() {
			
			throw new NotImplementedException();
		}
		
		public override void Reload() {
			
			throw new NotImplementedException();
		}
	}
}
