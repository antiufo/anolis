﻿namespace Anolis.Installer.Pages {
	partial class ModifyPackagePage {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.@__ofd = new System.Windows.Forms.OpenFileDialog();
			this.@__packageView = new System.Windows.Forms.TreeView();
			this.@__infoPicture = new System.Windows.Forms.PictureBox();
			this.@__infoLbl = new System.Windows.Forms.Label();
			this.@__content.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.@__infoPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// __content
			// 
			this.@__content.Controls.Add(this.@__packageView);
			this.@__content.Controls.Add(this.@__infoLbl);
			this.@__content.Controls.Add(this.@__infoPicture);
			// 
			// __ofd
			// 
			this.@__ofd.Filter = "Anolis Package (*.anop)|*.anop|All files (*.*)|*.*";
			this.@__ofd.Title = "Select Anolis Package File";
			// 
			// __packageView
			// 
			this.@__packageView.CheckBoxes = true;
			this.@__packageView.Location = new System.Drawing.Point(0, 0);
			this.@__packageView.Name = "__packageView";
			this.@__packageView.ShowRootLines = false;
			this.@__packageView.Size = new System.Drawing.Size(241, 219);
			this.@__packageView.TabIndex = 0;
			// 
			// __infoPicture
			// 
			this.@__infoPicture.Location = new System.Drawing.Point(247, 0);
			this.@__infoPicture.Margin = new System.Windows.Forms.Padding(0);
			this.@__infoPicture.Name = "__infoPicture";
			this.@__infoPicture.Size = new System.Drawing.Size(209, 156);
			this.@__infoPicture.TabIndex = 1;
			this.@__infoPicture.TabStop = false;
			// 
			// __infoLbl
			// 
			this.@__infoLbl.BackColor = System.Drawing.Color.Transparent;
			this.@__infoLbl.Location = new System.Drawing.Point(247, 160);
			this.@__infoLbl.Name = "__infoLbl";
			this.@__infoLbl.Size = new System.Drawing.Size(193, 68);
			this.@__infoLbl.TabIndex = 3;
			this.@__infoLbl.Text = "The selected item \'{0}\' does not have any information associated with it";
			// 
			// ModifyPackagePage
			// 
			this.Name = "ModifyPackagePage";
			this.PageSubtitle = "You can choose whether or not to install components of this package";
			this.PageTitle = "Modify Package";
			this.@__content.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.@__infoPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog __ofd;
		private System.Windows.Forms.TreeView __packageView;
		private System.Windows.Forms.PictureBox __infoPicture;
		private System.Windows.Forms.Label __infoLbl;
	}
}