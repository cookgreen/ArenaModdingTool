namespace ArenaModdingTool.Controls
{
    partial class ucCultureList
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.cultureList = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// cultureList
			// 
			this.cultureList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cultureList.Location = new System.Drawing.Point(0, 0);
			this.cultureList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cultureList.Name = "cultureList";
			this.cultureList.Size = new System.Drawing.Size(496, 572);
			this.cultureList.TabIndex = 0;
			this.cultureList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cultureList_AfterSelect);
			// 
			// ucCultureList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cultureList);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ucCultureList";
			this.Size = new System.Drawing.Size(496, 572);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView cultureList;
    }
}
