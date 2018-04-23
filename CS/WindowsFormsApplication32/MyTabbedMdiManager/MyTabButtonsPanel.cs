using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.ViewInfo;

namespace CustomTabbedMdiManager
{
	public class MyTabButtonsPanel : TabButtonsPanel
	{
		public MyTabButtonsPanel(BaseTabControlViewInfo tabViewInfo)
			: base(tabViewInfo)
		{
		}


        public override void CreateButtons(TabButtons buttons, CustomHeaderButtonCollection userButtons) {
            if (this.keepButtons > 0)
                return;

            Buttons.Clear();
            if (TabViewInfo.AddActiveFilesButton)
                this.Buttons.Add(CreateButton(TabButtonType.User));
            if ((buttons & TabButtons.Prev) != 0)
                this.Buttons.Add(CreateButton(TabButtonType.Prev));
            if ((buttons & TabButtons.Next) != 0)
                this.Buttons.Add(CreateButton(TabButtonType.Next));
            if ((buttons & TabButtons.Close) != 0)
                this.Buttons.Add(CreateButton(TabButtonType.Close));
        }

		protected override TabButtonInfo CreateButton(TabButtonType button)
		{
			if ( button == TabButtonType.User )
			{
				ButtonPredefines predefine = Orientation == TabOrientation.Horizontal ? ButtonPredefines.Down : ButtonPredefines.Right;
				TabButtonInfo tabBtn = new TabButtonInfo(new EditorButton(predefine), button);
				return tabBtn;
			}

			return base.CreateButton(button);
		}

		public new MySkinTabControlViewInfo TabViewInfo
		{
			get
			{
				return base.TabViewInfo as MySkinTabControlViewInfo;
			}
		}
	}
}
