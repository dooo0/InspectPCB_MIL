using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Global;

namespace Vision.Forms
{
    public partial class Form_Recipe : System.Windows.Forms.Form
    {
        private bool bMove = false;

        private Point ptStartPosition = new Point(0, 0);
        private Point ptEndPosition = new Point(0, 0);
        private Point ptOffset = new Point(0, 0);

        public Form_Recipe()
        {
            InitializeComponent();

            this.columnHeader1.TextAlign = HorizontalAlignment.Center;
            this.columnHeader2.TextAlign = HorizontalAlignment.Center;
            this.columnHeader3.TextAlign = HorizontalAlignment.Center;
        }

        private void listView_RecipeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void UpdateRecipeList()
        {
            this.listView_RecipeList.Items.Clear();

            PathList ePath = GlobalInstance.Mode == 0 ? PathList.Recipe_Top : PathList.Recipe_Bottom;
            String sPath = Common.GetPath(ePath, false);
            if (sPath != null)
            {
                String[] sPathList = Directory.GetDirectories(sPath);

                for (int i =  0; i<sPathList.Count();i++)
                {
                    string s = sPathList[i];
                    this.listView_RecipeList.Items.Add(s.Substring(s.Length-4,4));

                    string sInfo_Path = s + "\\" + "RecipeInfo.ini";

                    string sCompany = Global.INI_Helper.GetValue(sInfo_Path, "Info", "Company", "Error");
                    string sProduct = Global.INI_Helper.GetValue(sInfo_Path, "Info", "Product", "Error");

                    this.listView_RecipeList.Items[i].SubItems.Add(sCompany);
                    this.listView_RecipeList.Items[i].SubItems.Add(sProduct);

                    if(i%2==1)
                    {
                        this.listView_RecipeList.Items[i].BackColor = Color.LightGray;
                    }

                }
            }
            
        }

        private void Btn_SaveRecipe(object sender, EventArgs e)
        {
            int SelectedIndex = -1;
            if (listView_RecipeList.SelectedItems.Count != 0)
            {
                SelectedIndex = this.listView_RecipeList.SelectedItems[0].Index;
            }
            else
            {
                Common.ShowMsgBox("선택된 레시피가 없습니다.");
                return;
            }

            int RecipeNum = Convert.ToInt32(this.listView_RecipeList.Items[SelectedIndex].SubItems[0].Text);


            var result = Common.ShowMsgBox($"{RecipeNum.ToString("D4")} 에 저장 하시겠습니까?");

            if (result == DialogResult.OK)
            {
                bool bRet = false;
                bRet = GlobalInstance.Recipe[GlobalInstance.Mode].SaveRecipe(RecipeNum);

                if (bRet == false)
                {
                    Common.ShowMsgBox("레시피 저장에 실패했습니다.");
                }
                else
                {
                    Common.ShowMsgBox("레시피가 성공적으로 저장됐습니다.");
                }
            }            
        }

        private void Btn_LoadRecipe(object sender, EventArgs e)
        {
            int SelectedIndex = -1;
            if (listView_RecipeList.SelectedItems.Count != 0)
            {
                SelectedIndex = this.listView_RecipeList.SelectedItems[0].Index;
            }
            else
            {
                Common.ShowMsgBox("선택된 레시피가 없습니다.");
                return;
            }

            int RecipeNum = Convert.ToInt32(this.listView_RecipeList.Items[SelectedIndex].SubItems[0].Text);

            bool bRet = false;
            bRet = GlobalInstance.Recipe[GlobalInstance.Mode].LoadRecipe(RecipeNum);

            if (bRet == false)
            {
                Common.ShowMsgBox("레시피 로드에 실패했습니다.");
            }
            else
            {

                Common.ShowMsgBox("레시피가 성공적으로 로드됐습니다.");
                this.Hide();
            }
        }

        private void Btn_Close(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmRecipe_Load(object sender, EventArgs e)
        {
            
        }

        private void panel_window_MouseDown(object sender, MouseEventArgs e)
        {
            bMove = true;

            ptOffset.X = 0;
            ptOffset.Y = 0;

            ptStartPosition = e.Location;


        }

        private void panel_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMove)
            {
                ptOffset.X = e.X - ptStartPosition.X;
                ptOffset.Y = e.Y - ptStartPosition.Y;

                ptEndPosition.X = this.Location.X + ptOffset.X;
                ptEndPosition.Y = this.Location.Y + ptOffset.Y;

                this.Location = ptEndPosition;
            }
        }

        private void panel_window_MouseUp(object sender, MouseEventArgs e)
        {
            bMove = false;
        }
    }
}
