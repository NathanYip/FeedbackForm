using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FeedbackForm
{

    public partial class Feedback : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["FeedbackConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(txtName.Text)) || (string.IsNullOrWhiteSpace(txtAddress.Text)) || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtComment.Text)))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Some fields are empty" + "');", true);

            }
            else
            {
                insertData();
                Response.Redirect("SubmitSuccess.aspx");
            }


        }

        private void insertData()
        {
            //open connection
            sqlConnection.Open();

            // insert data into database
            string query = "Insert into Feedback (Name,Address,Email,Comments) Values (@name,@address,@email,@comments)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            // supply query with values
            sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@address", txtAddress.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@comments", txtComment.Text);

            // execute query
            sqlCommand.ExecuteNonQuery();

            //close connection
            sqlConnection.Close();

        }
    }
}