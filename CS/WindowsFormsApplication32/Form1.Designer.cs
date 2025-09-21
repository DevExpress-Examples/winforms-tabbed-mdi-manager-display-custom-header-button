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
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.myTabbedMdiManager2 = new CustomTabbedMdiManager.MyTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("bo_employee", "image://svgimages/business objects/bo_employee.svg");
            this.svgImageCollection1.Add("bo_department", "image://svgimages/business objects/bo_department.svg");
            // 
            // myTabbedMdiManager2
            // 
            this.myTabbedMdiManager2.Images = this.svgImageCollection1;
            this.myTabbedMdiManager2.MdiParent = this;
            this.myTabbedMdiManager2.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.myTabbedMdiManager_PageAdded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 744);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private MyTabbedMdiManager myTabbedMdiManager2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}

