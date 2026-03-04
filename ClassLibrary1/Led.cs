using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class Led : UserControl
    {
        public Led()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }



        private Color[] colorList = new Color[] { Color.Red, Color.LimeGreen };
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取指示灯颜色集合")]
        public Color[] ColorList
        {
            get { return colorList; }
            set
            {
                if (value == null || value.Length <= 0)
                    return;
                colorList = value;
                this.Invalidate();
            }
        }

        private bool isBorder = true;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取是否有边框")]
        public bool IsBorder
        {
            get { return isBorder; }
            set
            {
                isBorder = value;
                this.Invalidate();
            }
        }

        private int gapWidth = 5;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取外环间隙宽度")]
        public int GapWidth
        {
            get { return gapWidth; }
            set
            {
                gapWidth = value;
                this.Invalidate();
            }
        }

        private int borderWidth = 5;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取外环宽度")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }

        private bool isHighLight = false;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取是否高亮显示")]
        public bool IsHighLight
        {
            get { return isHighLight; }
            set
            {
                isHighLight = value;
                this.Invalidate();
            }
        }

        private Color centerColor = Color.White;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取中心颜色")]
        public Color CenterColor
        {
            get { return centerColor; }
            set
            {
                centerColor = value;
                this.Invalidate();
            }
        }

        private int currentValue = 0;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设定或获取颜色值")]
        public int CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (currentValue != value)
                {
                    currentValue = value;
                    this.Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //绘制椭圆
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            PointF center = new PointF(Math.Min(this.Width, this.Height), Math.Min(this.Width, this.Height));
            SolidBrush sb = new SolidBrush(this.colorList[currentValue]);
            RectangleF rec = new RectangleF(1, 1, center.X - 2, center.Y - 2);
            graphics.FillEllipse(sb, rec);

            //绘制边框
            if (isBorder)
            {
                Pen p = new Pen(this.BackColor, gapWidth);
                float f = 1 + gapWidth * 0.5f + borderWidth;
                rec = new RectangleF(f, f, center.X - 2 * f, center.Y - 2 * f);
                graphics.DrawEllipse(p, rec);
            }

            if (isHighLight)
            {
                if (isBorder)
                {
                    //画布路径
                    GraphicsPath gp = new GraphicsPath();
                    float f = 1 + borderWidth + gapWidth * 0.5f;
                    rec = new RectangleF(f, f, center.X - 2 * f, center.Y - 2 * f);
                    gp.AddEllipse(rec);
                    //渐变画刷
                    PathGradientBrush pb = new PathGradientBrush(gp);
                    pb.CenterColor = centerColor;
                    pb.SurroundColors = new Color[] { this.colorList[currentValue] };
                    graphics.FillPath(pb, gp);
                }
                else
                {
                    //画布路径
                    GraphicsPath gp = new GraphicsPath();
                    rec = new RectangleF(1, 1, center.X - 2, center.Y - 2);
                    gp.AddEllipse(rec);
                    //渐变画刷
                    PathGradientBrush pb = new PathGradientBrush(gp);
                    pb.CenterColor = centerColor;
                    pb.SurroundColors = new Color[] { this.colorList[currentValue] };
                    graphics.FillPath(pb, gp);
                }
            }
        }

    }
}
