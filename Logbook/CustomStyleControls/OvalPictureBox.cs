﻿using System.Drawing.Drawing2D;

namespace Logbook.CustomControls;

public class OvalPictureBox : PictureBox
{
    public OvalPictureBox()
    {
        this.BackColor = Color.DarkGray;
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        using (var gp = new GraphicsPath())
        {
            gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            this.Region = new Region(gp);
        }
    }
}
