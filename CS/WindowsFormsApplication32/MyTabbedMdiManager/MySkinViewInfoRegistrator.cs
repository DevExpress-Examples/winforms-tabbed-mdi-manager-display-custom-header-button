using DevExpress.XtraTab;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.ViewInfo;

namespace CustomTabbedMdiManager
{
	public class MySkinViewInfoRegistrator : SkinViewInfoRegistrator
	{
		public MySkinViewInfoRegistrator()
		{
		}

		public override BaseTabHeaderViewInfo CreateHeaderViewInfo(BaseTabControlViewInfo viewInfo)
		{
			return new MySkinTabHeaderViewInfo(viewInfo);
		}

		public override BaseTabControlViewInfo CreateViewInfo(IXtraTab tabControl)
		{
			return new MySkinTabControlViewInfo(tabControl);
		}
	}
}
