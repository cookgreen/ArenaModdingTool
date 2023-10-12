namespace ArenaModdingTool.Controls
{
    partial class ucHeroEditor
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
			this.panelDetails = new System.Windows.Forms.Panel();
			this.panelList = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelDetails
			// 
			this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDetails.Location = new System.Drawing.Point(247, 0);
			this.panelDetails.Name = "panelDetails";
			this.panelDetails.Size = new System.Drawing.Size(515, 511);
			this.panelDetails.TabIndex = 3;
			// 
			// panelList
			// 
			this.panelList.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelList.Location = new System.Drawing.Point(0, 0);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(247, 511);
			this.panelList.TabIndex = 2;
			// 
			// ucHeroEditor
			// 
			this.Controls.Add(this.panelDetails);
			this.Controls.Add(this.panelList);
			this.Name = "ucHeroEditor";
			this.Size = new System.Drawing.Size(762, 511);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelList;
    }
}
