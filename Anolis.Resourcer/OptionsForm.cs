﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Anolis.Resourcer {
	
	public partial class OptionsForm : Form {
		
		public OptionsForm() {
			InitializeComponent();
			
			this.__ok.Click += new EventHandler(__ok_Click);
			
			this.__aboutLinkAnolis.Click += new EventHandler(__aboutLink_Click);
			this.__aboutLinkXpize .Click += new EventHandler(__aboutLink_Click);
			this.__aboutLinkVize  .Click += new EventHandler(__aboutLink_Click);
			this.__aboutLinkLong  .Click += new EventHandler(__aboutLink_Click);
			
		}
		
		private void __ok_Click(Object sender, EventArgs e) {
			
			Close();
			
		}
		
		private void __aboutLink_Click(Object sender, EventArgs e) {
			
			LinkLabel link = sender as LinkLabel;
			
			System.Diagnostics.Process.Start( link.Text );
			
		}
		
	}
	
}
