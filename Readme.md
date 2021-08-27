<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615905/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2797)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication32/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication32/Form1.vb))
* [ActiveFilesButtonClickEventArgs.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/ActiveFilesButtonClickEventArgs.cs) (VB: [ActiveFilesButtonClickEventArgs.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/ActiveFilesButtonClickEventArgs.vb))
* [MySkinTabControlViewInfo.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabControlViewInfo.cs) (VB: [MySkinTabControlViewInfo.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabControlViewInfo.vb))
* [MySkinTabHeaderViewInfo.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabHeaderViewInfo.cs) (VB: [MySkinTabHeaderViewInfo.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabHeaderViewInfo.vb))
* [MySkinViewInfoRegistrator.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinViewInfoRegistrator.cs) (VB: [MySkinViewInfoRegistrator.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinViewInfoRegistrator.vb))
* [MyTabbedMdiManager.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MyTabbedMdiManager.cs) (VB: [MyTabbedMdiManager.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MyTabbedMdiManager.vb))
* [MyTabButtonsPanel.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MyTabButtonsPanel.cs) (VB: [MyTabButtonsPanel.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MyTabButtonsPanel.vb))
* [Program.cs](./CS/WindowsFormsApplication32/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication32/Program.vb))
<!-- default file list end -->
# How to add a button showing MDI child windows list to the XtraTabbedMdiManager's header


<p>This sample shows how to add a button showing MDI child windows list to the XtraTabbedMdiManager's header. A button like  <i>"Active Files"</i>  in Visual Studio. To accomplish this, we've created an XtraTabbedMdiManager descendant along with descendants of other classes like the TabHeaderViewInfo and TabButtonsPanel. Also, since we cannot make changes to the Enums, we cannot extend the buttons set available in the <strong>HeaderButtons</strong> property. So, a separate property controlling this button's visibility has been added - <strong>HeaderShowActiveFilesButton</strong>. It has the <strong>bool</strong> type and by default is set to false.</p>

<br/>


