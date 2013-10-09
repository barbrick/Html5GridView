Imports Microsoft.VisualBasic

<Assembly: TagPrefix("ActiveServerControls", "asp")> 
Namespace ActiveServerControls
    < _
    ToolboxData("<{0}:Html5GridView ID='Html5GridViewID' runat=""server""> </{0}:Html5GridView>")> _
    Public Class Html5GridView
        Inherits GridView

        ' Create a new class that inherits HtmlTextWriter to modify the rendering of invalid attributes
        Private Class Html5ReWriter
                Inherits HtmlTextWriter

            Public Sub New(writer As HtmlTextWriter)
                MyBase.New(writer)
            End Sub

            Public Overrides Sub AddAttribute(key As HtmlTextWriterAttribute, value As String)
                ' Strip out attributes which cause HTML5 Validation Errors
                If (key.Equals(HtmlTextWriterAttribute.Rules)) Then
                    Return
                End If

                If (key.Equals(HtmlTextWriterAttribute.Cellspacing)) Then
                    Return
                End If

                If (key.Equals(HtmlTextWriterAttribute.Border)) Then
                    Return
                End If

                MyBase.AddAttribute(key, value)
            End Sub

            Protected Overrides Function OnTagRender(name As String, key As HtmlTextWriterTag) As Boolean
                ' Remove unnecessary span tags which cause HTML5 Validation Errors
                If (key.Equals(HtmlTextWriterTag.Span)) Then
                    Return False
                End If
                Return MyBase.OnTagRender(name, key)
            End Function

        End Class

        ' Override the render method of the GridView to use the modified HtmlTextWriter
        Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
            MyBase.Render(New Html5ReWriter(writer))
        End Sub
    End Class

End Namespace