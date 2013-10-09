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

<%@ Register TagPrefix="asp" Namespace="ActiveServerControls"%>
    
You may then use the grid view as you had replacing GridView with Html5GridView
