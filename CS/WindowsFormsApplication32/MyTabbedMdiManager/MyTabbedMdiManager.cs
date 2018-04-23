using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTabbedMdi;

namespace CustomTabbedMdiManager
{
	public class MyTabbedMdiManager : XtraTabbedMdiManager
	{
		private bool headerShowActiveFilesButton;

		public MyTabbedMdiManager(IContainer container)
			: base(container)
		{
		}
		public MyTabbedMdiManager()
		{
		}

		protected override BaseViewInfoRegistrator GetView()
		{
			BaseViewInfoRegistrator view = base.GetView();
			SkinViewInfoRegistrator skinView = view as SkinViewInfoRegistrator;
			if ( skinView == null )
				return view;

			return new MySkinViewInfoRegistrator();
		}

		protected override void CreateView()
		{
			if ( ViewInfo != null )
				ViewInfo.ActiveFilesButtonClick -= new EventHandler<ActiveFilesButtonClickEventArgs>(OnActiveFilesButtonClick);

			base.CreateView();
			ViewInfo.ActiveFilesButtonClick += new EventHandler<ActiveFilesButtonClickEventArgs>(OnActiveFilesButtonClick);
		}

		protected virtual DXPopupMenu CreateActiveFilesPopupMenu()
		{
			return new DXPopupMenu();
		}

		protected virtual DXMenuItem CreateMenuItem(XtraMdiTabPage page)
		{
			DXMenuItem menuItem = new DXMenuItem();
			menuItem.Caption = page.Text;
			menuItem.Image = GetMdiTabPageImage(page);
			menuItem.Tag = page.MdiChild;
			
			return menuItem;
		}

		protected Image GetMdiTabPageImage(XtraMdiTabPage page)
		{
			if ( page.Image != null )
				return page.Image;

			return ImageCollection.GetImageListImage(page.TabControl.Images, page.ImageIndex);
		}

		protected virtual void OnActiveFilesButtonClick(object sender, ActiveFilesButtonClickEventArgs e)
		{
			Form parentForm = this.MdiParent;
			if ( parentForm == null )
				return;

			DXPopupMenu activeFilesPopupMenu = CreateActiveFilesPopupMenu();
			foreach ( XtraMdiTabPage page in this.Pages )
			{
				if ( !page.PageVisible || !page.PageEnabled )
					continue;

				DXMenuItem menuItem = CreateMenuItem(page);
				menuItem.Click += new EventHandler(OnActiveFilesButtonMenuItemClick);
				activeFilesPopupMenu.Items.Add(menuItem);
			}

			IXtraTab xtraTabIntf = this as IXtraTab;
			if ( xtraTabIntf == null )
				return;

			Point menuPos = new Point(e.ButtonInfo.Bounds.X, e.ButtonInfo.Bounds.Bottom);
			MenuManagerHelper.GetMenuManager(xtraTabIntf.LookAndFeel).ShowPopupMenu(activeFilesPopupMenu, parentForm, menuPos);
		}

		private void OnActiveFilesButtonMenuItemClick(object sender, EventArgs e)
		{
			DXMenuItem menuItem = (DXMenuItem)sender;
			Form childForm = menuItem.Tag as Form;
			if ( childForm != null )
				childForm.BringToFront();
		}

		[DefaultValue(false)]
		public bool HeaderShowActiveFilesButton
		{
			get
			{
				return headerShowActiveFilesButton;
			}
			set
			{
				if ( headerShowActiveFilesButton == value )
					return;

				headerShowActiveFilesButton = value;
				if ( ViewInfo != null )
					ViewInfo.AddActiveFilesButton = value;
			}
		}

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		public new MySkinTabControlViewInfo ViewInfo
		{
			get
			{
				return base.ViewInfo as MySkinTabControlViewInfo;
			}
		}
	}
}
