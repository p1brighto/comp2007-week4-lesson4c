using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * @author: Brighto Paul
 * @date: May 26, 2016
 */

namespace comp2007_week2_lesson3B
{
    public partial class Navbar : System.Web.UI.UserControl
    {
           protected void Page_Load(object sender, EventArgs e)
            {
                SetActivePage();
            }

            /**
             * This method adds a css class of "active" to list items related
             * to navigation links of each page 
             * 
             * @method SetActivePage
             * @return {void}
             */
            private void SetActivePage()
            {
                switch (Page.Title)
                {
                    case "Home Page":
                        home.Attributes.Add("class", "active");
                        break;
                    case "Contact":
                        contact.Attributes.Add("class", "active");
                        break;
                }
            }
        }
    }