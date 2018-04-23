using System;
using DevExpress.XtraTab.Buttons;

namespace CustomTabbedMdiManager
{
	public class ActiveFilesButtonClickEventArgs : EventArgs
	{
		private TabButtonInfo clickedButtonInfo;

		public ActiveFilesButtonClickEventArgs(TabButtonInfo button)
		{
			clickedButtonInfo = button;
		}

		public TabButtonInfo ButtonInfo
		{
			get
			{
				return clickedButtonInfo;
			}
		}
	}
}
