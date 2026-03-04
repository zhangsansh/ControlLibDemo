namespace ControlLibDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEx1 = new ClassLibrary1.ButtonEx();
            this.headPanel1 = new ClassLibrary1.HeadPanel();
            this.led1 = new ClassLibrary1.Led();
            this.textShow1 = new ClassLibrary1.TextShow();
            this.SuspendLayout();
            // 
            // buttonEx1
            // 
            this.buttonEx1.Image = ((System.Drawing.Image)(resources.GetObject("buttonEx1.Image")));
            this.buttonEx1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEx1.Location = new System.Drawing.Point(41, 36);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.PreSetImage = ClassLibrary1.ButtonEx.ButtonPresetImage.Check;
            this.buttonEx1.Size = new System.Drawing.Size(140, 43);
            this.buttonEx1.TabIndex = 0;
            this.buttonEx1.Text = "buttonEx1";
            this.buttonEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEx1.UseVisualStyleBackColor = true;
            // 
            // headPanel1
            // 
            this.headPanel1.BorderColor = System.Drawing.Color.Gray;
            this.headPanel1.HeadBackColor = System.Drawing.Color.LightSeaGreen;
            this.headPanel1.HeadForeColor = System.Drawing.Color.Black;
            this.headPanel1.HeadHeight = 30;
            this.headPanel1.LinearGradientRate = 0.4F;
            this.headPanel1.Location = new System.Drawing.Point(41, 100);
            this.headPanel1.Name = "headPanel1";
            this.headPanel1.Size = new System.Drawing.Size(200, 100);
            this.headPanel1.TabIndex = 1;
            this.headPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headPanel1.TitleText = "上位机";
            // 
            // led1
            // 
            this.led1.BorderWidth = 5;
            this.led1.CenterColor = System.Drawing.Color.White;
            this.led1.ColorList = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen};
            this.led1.CurrentValue = 0;
            this.led1.GapWidth = 5;
            this.led1.IsBorder = true;
            this.led1.IsHighLight = false;
            this.led1.Location = new System.Drawing.Point(41, 238);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(141, 150);
            this.led1.TabIndex = 2;
            // 
            // textShow1
            // 
            this.textShow1.BindVarName = null;
            this.textShow1.CurrentValue = "0.0";
            this.textShow1.Location = new System.Drawing.Point(288, 36);
            this.textShow1.Name = "textShow1";
            this.textShow1.Size = new System.Drawing.Size(451, 66);
            this.textShow1.TabIndex = 3;
            this.textShow1.TitleName = "参数名称";
            this.textShow1.TitleScale = 50;
            this.textShow1.Unit = "℃";
            this.textShow1.ValueScale = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textShow1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.headPanel1);
            this.Controls.Add(this.buttonEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.ButtonEx buttonEx1;
        private ClassLibrary1.HeadPanel headPanel1;
        private ClassLibrary1.Led led1;
        private ClassLibrary1.TextShow textShow1;
    }
}

