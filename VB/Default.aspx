<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to implement a table layout for DockPanels (Matrix of DockPanels)</title>
    <script type="text/javascript">
        var arrayDimension = 4;
        function OnAfterDock(s, e) {
            UpdatePanelPosition(e.zone);
        }
        function UpdatePanelPosition(zone) {
            var zoneToUpdate = myDockManager.GetZones();

            for (var i = 0; i < arrayDimension - 1; i++) {
                var panelCount = zoneToUpdate[i].GetPanelCount();
                if (panelCount > arrayDimension) {
                    zoneToUpdate[i].GetPanelByVisibleIndex(panelCount - 1).Dock(zoneToUpdate[i + 1], 0);

                } else if ((panelCount < arrayDimension) && (zoneToUpdate[i + 1].GetPanelCount() > 0)) {
                    zoneToUpdate[i + 1].GetPanelByVisibleIndex(0).Dock(zoneToUpdate[i]);
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDockManager ID="myDockManager" ClientInstanceName="myDockManager" runat="server">
                <ClientSideEvents   AfterDock="OnAfterDock" />
            </dx:ASPxDockManager>
        </div>
    </form>
</body>
</html>