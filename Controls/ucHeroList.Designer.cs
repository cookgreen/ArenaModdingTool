namespace ArenaModdingTool.Controls
{
    partial class ucHeroList
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
            this.heroList = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // heroList
            // 
            this.heroList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroList.Location = new System.Drawing.Point(0, 0);
            this.heroList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heroList.Name = "heroList";
            this.heroList.Size = new System.Drawing.Size(463, 550);
            this.heroList.TabIndex = 0;
            this.heroList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.heroList_AfterSelect);
            // 
            // ucHeroList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heroList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucHeroList";
            this.Size = new System.Drawing.Size(463, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView heroList;
    }
}
