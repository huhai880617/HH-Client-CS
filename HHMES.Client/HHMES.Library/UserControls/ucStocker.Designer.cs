namespace HHMES.Library.UserControls
{
    partial class ucStocker
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStocker));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "空盘空闲-00.png");
            this.imageList1.Images.SetKeyName(1, "空盘预定-01.png");
            this.imageList1.Images.SetKeyName(2, "空盘工作-02.png");
            this.imageList1.Images.SetKeyName(3, "仓位暂锁-03.png");
            this.imageList1.Images.SetKeyName(4, "仓位禁用-04.png");
            this.imageList1.Images.SetKeyName(5, "半盘空闲-10.png");
            this.imageList1.Images.SetKeyName(6, "半盘预定-11.png");
            this.imageList1.Images.SetKeyName(7, "半盘工作-12.png");
            this.imageList1.Images.SetKeyName(8, "满盘空闲-20.png");
            this.imageList1.Images.SetKeyName(9, "满盘预定-21.png");
            this.imageList1.Images.SetKeyName(10, "满盘工作-22.png");
            // 
            // ucStocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucStocker";
            this.Size = new System.Drawing.Size(572, 392);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;



    }
}
