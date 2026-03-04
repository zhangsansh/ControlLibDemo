using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class ButtonEx : Button
    {
        public ButtonEx()
        {
            InitializeComponent();
        }

        public enum ButtonPresetImage
        {
            /// <summary>
            /// 没有图标
            /// </summary>
            None,
            /// <summary>
            /// 确认图标
            /// </summary>
            Check,
            /// <summary>
            /// 关闭图标
            /// </summary>
            Close,
            /// <summary>
            /// 取消图标
            /// </summary>
            Cancel,
            // 后续可以扩展
        }

        private ButtonPresetImage buttontype = ButtonPresetImage.None;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取按钮图标样式")]
        public ButtonPresetImage PreSetImage
        {
            get
            {
                return buttontype;
            }
            set
            {
                buttontype = value;
                if (buttontype != ButtonPresetImage.None)
                {
                    this.ImageAlign = ContentAlignment.MiddleLeft;
                    this.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    this.ImageAlign = ContentAlignment.MiddleCenter;
                    this.TextAlign = ContentAlignment.MiddleCenter;
                }
                switch (buttontype)
                {
                    case ButtonPresetImage.None:
                        this.Image = null;
                        break;
                    case ButtonPresetImage.Check:
                        this.Image = Properties.Resources.check;
                        break;
                    case ButtonPresetImage.Close:
                        this.Image = Properties.Resources.close;
                        break;
                    case ButtonPresetImage.Cancel:
                        this.Image = Properties.Resources.cancel;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
