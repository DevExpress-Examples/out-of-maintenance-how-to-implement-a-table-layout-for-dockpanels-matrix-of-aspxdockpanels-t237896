Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim columnNumber As Integer = 0
        Dim zoneIndex As Integer = -1
        For index As Integer = 0 To 15
            If index Mod 4 = 0 Then
                zoneIndex += 1
                columnNumber = 0
            End If
            columnNumber += 1
            Dim panel As New ASPxDockPanel()
            panel.ID = String.Format("panel{0}", index)
            Form.Controls.Add(panel)
            panel.OwnerZoneUID = String.Format("zone{0}", zoneIndex)
            panel.Width = 200
            panel.Height = 200
            panel.MaxHeight = 200
            panel.VisibleIndex = columnNumber
            panel.AllowedDockState = AllowedDockState.DockedOnly
            panel.HeaderText = String.Format("Panel{0}", index)
        Next index
        For index As Integer = 0 To 3
            Dim zone As New ASPxDockZone()
            zone.ID = String.Format("zone{0}", index)
            Form.Controls.Add(zone)
            zone.Width = 800
            zone.Height = 200
            zone.Orientation = DockZoneOrientation.Horizontal
            zone.ZoneUID = String.Format("zone{0}", index)
        Next index
    End Sub
End Class
