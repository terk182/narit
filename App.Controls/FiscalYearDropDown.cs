using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controls
{
    public class FiscalYearDropDown
    {

        private string yearSelectedValue = string.Empty;
        private bool autoPostBack = true;
        //public event EventHandler OnSelectedIndexChanged;

        //public string SelectedYear
        //{
        //    get { return fiscalYearDropDownList.SelectedValue; }
        //    //set { this.yearSelectedValue = value; }
        //}

        //public bool AutoPostBack
        //{
        //    get { return autoPostBack; }
        //    set { this.autoPostBack = value; }
        //}

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    fiscalYearDropDownList.AutoPostBack = autoPostBack;
        //    if (!Page.IsPostBack && (fiscalYearDropDownList.Items.Count == 0)) this.FirstLoad();
        //    if (yearSelectedValue != string.Empty)
        //    {
        //        if (fiscalYearDropDownList.Items.FindByValue(yearSelectedValue) != null)
        //        {
        //            fiscalYearDropDownList.SelectedItem.Selected = false;
        //            fiscalYearDropDownList.Items.FindByValue(yearSelectedValue).Selected = true;
        //        }
        //    }
        //}

        //public void SetSelectedYear(string yearText)
        //{
        //    if (fiscalYearDropDownList.Items.FindByValue(yearText) != null)
        //    {
        //        fiscalYearDropDownList.ClearSelection();
        //        fiscalYearDropDownList.Items.FindByValue(yearText).Selected = true;
        //    }
        //}

        //private void AddYearItem(int yearNC, int yearNB, int downNum, int upNum)
        //{
        //    for (int i = downNum; i >= 0; i--)
        //    {
        //        ListItem liM = new ListItem((yearNB - i).ToString(), (yearNC - i).ToString());
        //        fiscalYearDropDownList.Items.Add(liM);
        //    }
        //    for (int m = 1; m <= upNum; m++)
        //    {
        //        ListItem liA = new ListItem((yearNB + m).ToString(), (yearNC + m).ToString());
        //        fiscalYearDropDownList.Items.Add(liA);
        //    }
        //    fiscalYearDropDownList.SelectedIndex = downNum;
        //}

        public void FirstLoad()
        {
            int yearNowC = DateTime.Today.Year + 543;
            if (DateTime.Today.Month > 9) yearNowC += 1;
            int yearNowB;
            if (yearNowC < 2550) yearNowB = yearNowC + 543;
            else yearNowB = yearNowC;
          //  this.AddYearItem(yearNowC, yearNowB, 6, 1);
        }

       
    }
}
