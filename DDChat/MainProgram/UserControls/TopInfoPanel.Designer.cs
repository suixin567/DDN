﻿namespace MainProgram.UserControls
{
    partial class TopInfoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopInfoPanel));
            this.labelSelfNickName = new System.Windows.Forms.Label();
            this.pictureBoxTopFace = new System.Windows.Forms.PictureBox();
            this.labelSelfDescription = new System.Windows.Forms.Label();
            this.labelOnlineState = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopFace)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelfNickName
            // 
            this.labelSelfNickName.AutoSize = true;
            this.labelSelfNickName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSelfNickName.ForeColor = System.Drawing.Color.White;
            this.labelSelfNickName.Location = new System.Drawing.Point(83, 11);
            this.labelSelfNickName.Name = "labelSelfNickName";
            this.labelSelfNickName.Size = new System.Drawing.Size(76, 16);
            this.labelSelfNickName.TabIndex = 1;
            this.labelSelfNickName.Text = "惠佳科技";
            // 
            // pictureBoxTopFace
            // 
            this.pictureBoxTopFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTopFace.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopFace.Image")));
            this.pictureBoxTopFace.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTopFace.Name = "pictureBoxTopFace";
            this.pictureBoxTopFace.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxTopFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopFace.TabIndex = 2;
            this.pictureBoxTopFace.TabStop = false;
            this.pictureBoxTopFace.Click += new System.EventHandler(this.pictureBoxTopFace_Click);
            this.pictureBoxTopFace.MouseEnter += new System.EventHandler(this.pictureBoxTopFace_MouseEnter);
            this.pictureBoxTopFace.MouseLeave += new System.EventHandler(this.pictureBoxTopFace_MouseLeave);
            // 
            // labelSelfDescription
            // 
            this.labelSelfDescription.Location = new System.Drawing.Point(83, 47);
            this.labelSelfDescription.Name = "labelSelfDescription";
            this.labelSelfDescription.Size = new System.Drawing.Size(125, 12);
            this.labelSelfDescription.TabIndex = 3;
            this.labelSelfDescription.Text = "今天是个好天气！~~~~";
            // 
            // labelOnlineState
            // 
            this.labelOnlineState.AutoSize = true;
            this.labelOnlineState.ForeColor = System.Drawing.Color.Lime;
            this.labelOnlineState.Location = new System.Drawing.Point(194, 15);
            this.labelOnlineState.Name = "labelOnlineState";
            this.labelOnlineState.Size = new System.Drawing.Size(29, 12);
            this.labelOnlineState.TabIndex = 4;
            this.labelOnlineState.Text = "状态";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.ForeColor = System.Drawing.Color.Yellow;
            this.labelLevel.Location = new System.Drawing.Point(165, 15);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(23, 12);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "Lv1";
            // 
            // TopInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelOnlineState);
            this.Controls.Add(this.labelSelfDescription);
            this.Controls.Add(this.pictureBoxTopFace);
            this.Controls.Add(this.labelSelfNickName);
            this.Name = "TopInfoPanel";
            this.Size = new System.Drawing.Size(254, 80);
            this.Load += new System.EventHandler(this.TopInfoPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelfNickName;
        private System.Windows.Forms.PictureBox pictureBoxTopFace;
        private System.Windows.Forms.Label labelSelfDescription;
        private System.Windows.Forms.Label labelOnlineState;
        private System.Windows.Forms.Label labelLevel;
    }
}
