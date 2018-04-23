using CustomTabbedMdiManager;

namespace WindowsFormsApplication32
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
			this.myTabbedMdiManager1 = new CustomTabbedMdiManager.MyTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// imageCollection1
			// 
			this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
			this.imageCollection1.TransparentColor = System.Drawing.Color.Fuchsia;
			this.imageCollection1.Images.SetKeyName(0, "cash.bmp");
			this.imageCollection1.Images.SetKeyName(1, "clients.bmp");
			// 
			// myTabbedMdiManager1
			// 
			this.myTabbedMdiManager1.HeaderShowActiveFilesButton = true;
			this.myTabbedMdiManager1.Images = this.imageCollection1;
			this.myTabbedMdiManager1.MdiParent = this;
			this.myTabbedMdiManager1.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.myTabbedMdiManager1_PageAdded);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 387);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MyTabbedMdiManager myTabbedMdiManager1;
		private DevExpress.Utils.ImageCollection imageCollection1;
	}
}

