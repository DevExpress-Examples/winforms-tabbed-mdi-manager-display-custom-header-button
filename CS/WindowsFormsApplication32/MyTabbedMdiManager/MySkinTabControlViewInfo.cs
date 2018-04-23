using System;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.ViewInfo;

namespace CustomTabbedMdiManager
{
	public class MySkinTabControlViewInfo : SkinTabControlViewInfo
	{
		public event EventHandler<ActiveFilesButtonClickEventArgs> ActiveFilesButtonClick;

		public MySkinTabControlViewInfo(IXtraTab tabControl)
			: base(tabControl)
		{
			AddActiveFilesButton = false;
		}

		protected override void OnHeaderButtonClick(TabButtonInfo button)
		{
			base.OnHeaderButtonClick(button);
			
			if ( button.ButtonType == TabButtonType.User )
				OnActiveFilesButtonClick(new ActiveFilesButtonClickEventArgs(button));
		}

		protected virtual void OnActiveFilesButtonClick(ActiveFilesButtonClickEventArgs ea)
		{
			if ( ActiveFilesButtonClick != null )
				ActiveFilesButtonClick(this, ea);
		}
		
		public bool AddActiveFilesButton
		{
			get;
			set;
		}
	}
}