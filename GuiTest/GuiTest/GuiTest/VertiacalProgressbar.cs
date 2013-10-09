using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public class VerticalProgressBar : ProgressBar
{
    public VerticalProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint|ControlStyles.OptimizedDoubleBuffer, true);
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x04;
            return cp;
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        LinearGradientBrush brush = null;
        Rectangle rec = e.ClipRectangle;

        rec.Height = (int)(rec.Height * ((double)Value / Maximum)) - 4;
        if (ProgressBarRenderer.IsSupported)
            ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
        rec.Width = rec.Width - 4;
        brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Horizontal);
        e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
    }
}