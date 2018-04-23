using System.Drawing;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.ViewInfo;

namespace CustomTabbedMdiManager
{
	public class MySkinTabHeaderViewInfo : SkinTabHeaderViewInfo
	{
		public MySkinTabHeaderViewInfo(BaseTabControlViewInfo viewInfo)
			: base(viewInfo)
		{
		}

		protected override TabButtonsPanel CreateHeaderButtons()
		{
			return new MyTabButtonsPanel(ViewInfo);
		}

		protected override Size CalcButtonsSize(TabButtons btns)
		{
			Size buttonsSize = base.CalcButtonsSize(btns);
			if ( buttonsSize == Size.Empty && ViewInfo.AddActiveFilesButton )
				buttonsSize = Buttons.CalcSize(GraphicsInfo.Graphics);

			return buttonsSize;
		}

		public new MySkinTabControlViewInfo ViewInfo
		{
			get
			{
				return base.ViewInfo as MySkinTabControlViewInfo;
			}
		}
	}
}
