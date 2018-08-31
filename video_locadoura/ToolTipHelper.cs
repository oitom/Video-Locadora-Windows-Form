using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Final_PJS_Video_Locadora
{
    public static class ToolTipHelper
    {
        public static void ShowToolTip(out ToolTip toolTip, Control control, string title, string message)
        {
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Error;
            toolTip.ToolTipTitle = title;
            toolTip.Show(string.Empty, control, 0);
            toolTip.Show(message, control, control.Width / 2 + 15, control.Height + 25, 5000);
        }
    }
}
