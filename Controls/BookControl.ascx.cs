﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_BookControl : System.Web.UI.UserControl
{
    public Book Book { get; set; }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> source = new List<string>();

        foreach(string genre in Book.Genre)
        {
            source.Add(genre);
        }

        genreRep.DataSource = source;
        genreRep.DataBind();
    }
}