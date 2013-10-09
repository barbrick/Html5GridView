Html5GridView
=============

HTML5 Compliant ASP Grid View Control

Removes tables attributes that cause HTML5 Validation Errors:
-> Rules
-> CellSpacing
-> Border

Removes span tags to avoid HTML5 Validation error cause by unsupported attributes being added



Useage:

On each aspx page include the following:
<%@ Register TagPrefix="asp" 
    Namespace="ActiveServerControls"%>
    
You may than use the grid view as below:
<asp:Html5GridView id="gridView" runat="Server"></asp:Html5GridView>
