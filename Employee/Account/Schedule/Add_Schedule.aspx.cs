﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee.Account.Schedule
{
    public partial class Add_Schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string currentDate = DateTime.Today.ToShortDateString();
                //Assign the value to compare here
                cmpdate.ValueToCompare = currentDate;
                
            }
        }
    }
}