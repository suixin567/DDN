﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Diagnostics;
using ToolLib;

namespace MainProgram.UserControls
{
    public partial class DialogueItem : UserControl
    {
        #region 属性
        public SynchronizationContext m_SyncContext = null;
        public string m_friendAndGroupID="";
        public string m_friendAndGroupNickName="";
        public string m_friendAndGroupContent="";
        #endregion

        public DialogueItem()
        {
            InitializeComponent();
        }

        
        public DialogueItem(string friendAndGroupID,string content)
        {
            InitializeComponent();
            
            m_SyncContext = SynchronizationContext.Current;
            m_friendAndGroupID = friendAndGroupID;
            m_friendAndGroupContent = content;
            reFreshContentSafePost(null);
            //获取昵称与头像
            if (friendAndGroupID.Contains("friend"))
            {
                //获取这个人的基本信息
                DataMgr.Instance.getPersonalByID(friendAndGroupID.Substring("friend".Length), delegate (PersonalInfoModel model) {
                    m_friendAndGroupNickName = model.Nickname;//获取昵称
                    reFreshContentSafePost(null);
                    //下载头像
                    if (model.Face != "" && model.Face != null)
                    {
                        HttpReqHelper.loadFaceSync(model.Face, delegate (Image face)
                        {
                            if (face != null)
                            {
                                this.PictureBoxDialogueFace.Image = face;
                            }
                        });
                    }
                    else
                    {
                        Debug.Print("err---------错误的头像！！！" + model.Face);
                    }
                });
            }
            else if (friendAndGroupID.Contains("group"))
            {
                //获取这个群的基本信息
                DataMgr.Instance.getGroupByID(friendAndGroupID.Substring("group".Length), delegate (GroupInfoModel model) {
                    m_friendAndGroupNickName = model.Name;//获取昵称
                    reFreshContentSafePost(null);
                    //下载头像
                    if (model.Face != "" && model.Face != null)
                    {
                        HttpReqHelper.loadFaceSync(model.Face, delegate (Image face)
                        {
                            if (face != null)
                            {
                                this.PictureBoxDialogueFace.Image = face;
                            }
                        });
                    }
                    else
                    {
                        Debug.Print("err---------错误的头像！！！" + model.Face);
                    }
                });
            }
            else {
                Debug.Print("错误的对话item类型");
            }
            
        }

        private void DialogueItem_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(PictureBoxDialogueFace.DisplayRectangle, 0, 360);
            PictureBoxDialogueFace.Region = new Region(path);
        }

        //更新内容
        public void reFreshContentSafePost(string content) {
            m_SyncContext.Post(reFreshContent, content);
        }

        void reFreshContent(object state)
        {
            string content = (string)state;
            if (content != null)//外部传来的值
            {
                this.LabelHistory.Text = content;
            }
            else {//使用自己的值
                this.LabelHistory.Text = m_friendAndGroupContent;
            }         
            this.LabelNickName.Text = m_friendAndGroupNickName;
        }


        private void 移除会话ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMgr.Instance.formMain.flowLayoutPanelDialogueList.removeDialogueSafePost(m_friendAndGroupID);
        }
    }
}
