using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchTester
{
    class ContextMenuStripBackColorRenderer : ToolStripRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(System.Drawing.Point.Empty, e.Item.Size);
            using (Brush b = new System.Drawing.SolidBrush(Color.FromArgb(62, 62, 64)))
            {
                if (e.Item.Selected)
                    g.FillRectangle(b, bounds);
                else
                    g.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 48)), bounds);
            }
            
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.White;
            base.OnRenderItemText(e);
        }

    }
}
