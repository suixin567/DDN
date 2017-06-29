﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDN
{


    public partial class FormCreateGroup : Form
    {
        int MaxGroupAmount = 10;
        bool tomanyGroup = false;
        SynchronizationContext m_SyncContext = null;//线程上下文

        public FormCreateGroup()
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
        }

        private void FormCreateGroup_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width/2 - this.Size.Width/2);
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height/2 - this.Size.Width/2);
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            this.Location = (Point)new Size(x, y);         //窗体的起始位置为(x,y)     
            labelTip.Text = "";
            //检查一个人的最多公司数
            checkGroupAmount();
        }

        void checkGroupAmount() {
            if (Manager.Instance.formMain.flowLayoutPanelCompanyList.amount> MaxGroupAmount) {
                labelTip.Text = "最多有"+ MaxGroupAmount+"个公司，你的公司太多不可以创建了！";
                tomanyGroup = true;
            }
            
        }

        //创建群按钮
        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            if (tomanyGroup) {
                labelTip.Text = "最多有" + MaxGroupAmount + "个公司，你的公司太多不可以创建了！";
                return;
            }
            if (textBoxGroupName.Text=="") {
                labelTip.Text = "请输入公司名字...";
                return;
            }
            //群的基本信息
            CreateGroupModel createGroupModel = new CreateGroupModel();

            createGroupModel.Groupname = this.textBoxGroupName.Text;           
            if (this.radioButtonNoVerify.Checked) {
                createGroupModel.VerifyModel = 0;
            } else {
                createGroupModel.VerifyModel = 1;
            }
            string msgContent = Coding<CreateGroupModel>.encode(createGroupModel);
            MsgModel mm = new MsgModel(MsgProtocol.CREATE_GROUP_CREQ, GameInfo.ACC_ID, "", msgContent, DateTime.Now.ToString());
            Manager.Instance.msgMgr.sendMessage(MsgProtocol.GROUP, mm);
            this.textBoxGroupName.Text = "";
        }


        //更新提示文字
        public void showOpreationResultSafePost(string content)
        {
            m_SyncContext.Post(showOpreationResult, content);
        }

        void showOpreationResult(object content)
        {
            this.labelTip.Text = content.ToString();          
        }
    }
}
