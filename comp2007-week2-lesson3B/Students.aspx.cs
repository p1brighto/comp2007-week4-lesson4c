﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using comp2007_week4_lesson4c.Models;
using System.Web.ModelBinding;

namespace comp2007_week4_lesson4c
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if  loading page for the first time populate the student grid
            if(!IsPostBack)
            {
                //Get the student data
                this.GetStudents();
            }
        }
        /**
 * <summary>
 * This method gets the student data from the DB
 * </summary>
 * 
 * @method GetStudents
 * @returns {void}
 */
        protected void GetStudents()
        {
            // connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
                // query the Students Table using EF and LINQ
                var Students = (from allStudents in db.Students
                                select allStudents);

                // bind the result to the GridView
                StudentsGridView.DataSource = Students.ToList();
                StudentsGridView.DataBind();
            }
        }
    }
}