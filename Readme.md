# How to add a button showing MDI child windows list to the XtraTabbedMdiManager's header


<p>This sample shows how to add a button showing MDI child windows list to the XtraTabbedMdiManager's header. A button like  <i>"Active Files"</i>  in Visual Studio. To accomplish this, we've created an XtraTabbedMdiManager descendant along with descendants of other classes like the TabHeaderViewInfo and TabButtonsPanel. Also, since we cannot make changes to the Enums, we cannot extend the buttons set available in the <strong>HeaderButtons</strong> property. So, a separate property controlling this button's visibility has been added - <strong>HeaderShowActiveFilesButton</strong>. It has the <strong>bool</strong> type and by default is set to false.</p>

<br/>


