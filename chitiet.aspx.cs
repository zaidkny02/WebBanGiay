﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class chitiet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string prod_id = Request.Form["hiddenfield"];
        if (prod_id != null)
            ValueHiddenField.Value = prod_id;
    }
}