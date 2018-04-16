using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        int columnNumber = 0;
        int zoneIndex = -1;
        for (int index = 0; index <= 15; index++) {
            if (index % 4 == 0) {
                zoneIndex += 1;
                columnNumber = 0;
            }
            columnNumber += 1;
            ASPxDockPanel panel = new ASPxDockPanel();
            panel.ID = String.Format("panel{0}", index);
            Form.Controls.Add(panel);
            panel.OwnerZoneUID = String.Format("zone{0}", zoneIndex);
            panel.Width = 200;
            panel.Height = 200;
            panel.MaxHeight = 200;
            panel.VisibleIndex = columnNumber;
            panel.AllowedDockState = AllowedDockState.DockedOnly;
            panel.HeaderText = String.Format("Panel{0}", index);
        }
        for (int index = 0; index < 4; index++) {
            ASPxDockZone zone = new ASPxDockZone();
            zone.ID = String.Format("zone{0}", index);
            Form.Controls.Add(zone);
            zone.Width = 800;
            zone.Height = 200;
            zone.Orientation = DockZoneOrientation.Horizontal;
            zone.ZoneUID = String.Format("zone{0}", index);
        }
    }
}
           