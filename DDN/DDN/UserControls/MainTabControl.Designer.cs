﻿namespace DDN.UserControls
{
    partial class MainTabControl
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
            this.buttonDialogue = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDialogue
            // 
            this.buttonDialogue.Location = new System.Drawing.Point(0, 0);
            this.buttonDialogue.Name = "buttonDialogue";
            this.buttonDialogue.Size = new System.Drawing.Size(94, 36);
            this.buttonDialogue.TabIndex = 0;
            this.buttonDialogue.Text = "会话";
            this.buttonDialogue.UseVisualStyleBackColor = true;
            this.buttonDialogue.Click += new System.EventHandler(this.buttonDialogue_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(94, 0);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(94, 36);
            this.buttonFriends.TabIndex = 1;
            this.buttonFriends.Text = "联系人";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // buttonCompany
            // 
            this.buttonCompany.Location = new System.Drawing.Point(188, 0);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(94, 36);
            this.buttonCompany.TabIndex = 2;
            this.buttonCompany.Text = "公司";
            this.buttonCompany.UseVisualStyleBackColor = true;
            this.buttonCompany.Click += new System.EventHandler(this.buttonCompany_Click);
            // 
            // MainTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCompany);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonDialogue);
            this.Name = "MainTabControl";
            this.Size = new System.Drawing.Size(282, 36);
            this.Load += new System.EventHandler(this.MainTabControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDialogue;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonCompany;
    }
}
