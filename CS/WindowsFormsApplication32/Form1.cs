using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;

namespace WindowsFormsApplication32
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            this.myTabbedMdiManager1.HeaderShowActiveFilesButton = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			XtraForm xtraForm = new XtraForm();
			xtraForm.MdiParent = this;
			xtraForm.Text = "Form 1";
			xtraForm.Show();

			XtraForm xtraForm1 = new XtraForm();
			xtraForm1.MdiParent = this;
			xtraForm1.Text = "Form 2";
			xtraForm1.Show();
		}

		private void myTabbedMdiManager1_PageAdded(object sender, MdiTabPageEventArgs e)
		{
			XtraTabbedMdiManager tabbedMdi = (XtraTabbedMdiManager)sender;
			e.Page.ImageIndex = tabbedMdi.Pages.Count - 1;
		}
	}
}