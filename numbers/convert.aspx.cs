using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace numbers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                resultList.Items.Clear();
                foreach (ListItem item in sourceList.Items)
                {
                    resultList.Items.Add(item);
                }
                resultList.Items.Remove(sourceList.SelectedItem);
            }
        }

        protected void calculate_btn_Click(object sender, EventArgs e)
        {
            String hexChars = "1234567890abcdeABCDE";
            String decChars = "0123456789";
            String octChars = "01234567";
            String binChars = "01";
            if (sourceNum.Text == "")
            {
                resultNum.Text = "Please input a <b>valid</b> number";
                return;
                //test comment
            } else if (sourceList.SelectedValue == "2")
            {
                foreach (char number in sourceNum.Text)
                {
                    if (!binChars.Contains(number))
                    {
                        resultNum.Text = "Input is not valid";
                        return;
                    }
                }
            }
            else if(sourceList.SelectedValue == "8")
            {
                foreach (char number in sourceNum.Text)
                {
                    if (!octChars.Contains(number))
                    {
                        resultNum.Text = "Input is not valid";
                        return;
                    }
                }
            } else if (sourceList.SelectedValue == "10")
            {
                foreach (char number in sourceNum.Text)
                {
                    if (!decChars.Contains(number))
                    {
                        resultNum.Text = "Input is not valid";
                        return;
                    }
                }
            } else if (sourceList.SelectedValue == "16")
            {
                foreach (char number in sourceNum.Text)
                {
                    if (!hexChars.Contains(number))
                    {
                        resultNum.Text = "Input is not valid";
                        return;
                    }
                }
            } 
            

                int fromBase;
            int toBase;
            Int32.TryParse(sourceList.SelectedValue, out fromBase);
            Int32.TryParse(resultList.SelectedValue, out toBase);


            resultNum.Text = Convert.ToString(Convert.ToInt32(sourceNum.Text, fromBase), toBase);
            
        }

        protected void clear_btn_Click(object sender, EventArgs e)
        {
            sourceNum.Text = "";
            resultNum.Text = "";
        }

        protected void sourceNum_TextChanged(object sender, EventArgs e)
        {
            //n/a
        }

        protected void sourceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            resultList.Items.Clear();
            foreach (ListItem item in sourceList.Items)
            {
                resultList.Items.Add(item);
            }
            resultList.Items.Remove(sourceList.SelectedItem);
            
        }
        
    }
}