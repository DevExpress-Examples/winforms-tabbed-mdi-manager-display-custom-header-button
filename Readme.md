<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615905/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2797)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Tabbed MDI Manager - Display a custom button in the tab header panel

This sample creates a custom Tabbed MDI Manager that can display a dropdown button. This button invokes a popup menu that allows you to switch between tabs (MDI child windows). Set the `HeaderShowActiveFilesButton` custom property to **true** to display the button:

```csharp
public Form1() {
    InitializeComponent();
    this.myTabbedMdiManager1.HeaderShowActiveFilesButton = true;
}
```

![WinForms Tabbed MDI Manager - Display a custom button in the tab header panel](https://raw.githubusercontent.com/DevExpress-Examples/how-to-add-a-button-showing-mdi-child-windows-list-to-the-xtratabbedmdimanagers-header-e2797/13.1.4%2B/media/winforms-mdi-tabbed-ui.png)


## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication32/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication32/Form1.vb))
* [ActiveFilesButtonClickEventArgs.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/ActiveFilesButtonClickEventArgs.cs) (VB: [ActiveFilesButtonClickEventArgs.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/ActiveFilesButtonClickEventArgs.vb))
* [MySkinTabControlViewInfo.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabControlViewInfo.cs) (VB: [MySkinTabControlViewInfo.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabControlViewInfo.vb))
* [MySkinTabHeaderViewInfo.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabHeaderViewInfo.cs) (VB: [MySkinTabHeaderViewInfo.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinTabHeaderViewInfo.vb))
* [MySkinViewInfoRegistrator.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MySkinViewInfoRegistrator.cs) (VB: [MySkinViewInfoRegistrator.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MySkinViewInfoRegistrator.vb))
* [MyTabbedMdiManager.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MyTabbedMdiManager.cs) (VB: [MyTabbedMdiManager.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MyTabbedMdiManager.vb))
* [MyTabButtonsPanel.cs](./CS/WindowsFormsApplication32/MyTabbedMdiManager/MyTabButtonsPanel.cs) (VB: [MyTabButtonsPanel.vb](./VB/WindowsFormsApplication32/MyTabbedMdiManager/MyTabButtonsPanel.vb))
