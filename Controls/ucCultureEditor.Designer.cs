
namespace ArenaModdingTool.Controls
{
    partial class ucCultureEditor
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelDetails = new System.Windows.Forms.Panel();
			this.panelList = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panelDetails);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(329, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(579, 633);
			this.panel2.TabIndex = 5;
			// 
			// panelDetails
			// 
			this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDetails.Location = new System.Drawing.Point(0, 0);
			this.panelDetails.Name = "panelDetails";
			this.panelDetails.Size = new System.Drawing.Size(579, 633);
			this.panelDetails.TabIndex = 1;
			// 
			// panelList
			// 
			this.panelList.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelList.Location = new System.Drawing.Point(0, 0);
			this.panelList.Margin = new System.Windows.Forms.Padding(4);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(329, 633);
			this.panelList.TabIndex = 4;
			// 
			// ucCultureEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelList);
			this.Name = "ucCultureEditor";
			this.Size = new System.Drawing.Size(908, 633);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelList;
		private System.Windows.Forms.Panel panelDetails;
	}
}
