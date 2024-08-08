using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class ctrlApplicationOption : ToolStripMenuItem
    {
        public ctrlApplicationOption(string text) : base(text)
        {
            this.Padding = new Padding(4, 10, 4, 10); // Add padding to top and bottom
            this.AutoSize = false;
            this.Height = 50; // Set a desired height if needed

            //this.OwnerDraw = true;
            //this.DrawItem += CustomToolStripMenuItem_DrawItem;
            //this.MeasureItem += CustomToolStripMenuItem_MeasureItem;
        }

        private void CustomToolStripMenuItem_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Height; // Set the height of the item
        }

        private void CustomToolStripMenuItem_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background
            e.DrawBackground();

            // Draw the text with padding
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(this.Text, e.Font, textBrush, new RectangleF(e.Bounds.Left + this.Padding.Left, e.Bounds.Top + this.Padding.Top, e.Bounds.Width - this.Padding.Horizontal, e.Bounds.Height - this.Padding.Vertical));
            }

            // Draw the focus rectangle if the item is focused
            e.DrawFocusRectangle();
        }
    }
}
