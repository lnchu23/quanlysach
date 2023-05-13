using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test.DAL;

namespace Test
{
    public partial class Sach : System.Web.UI.Page
    {
        Database ob = new Database();
        public void LoadData()
        {

            GridView1.DataSource = ob.Get_Sach();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/Hinhanhsp/" + FileUpload1.FileName;
            Sach1 ob1 = new Sach1(txtMasach.Text, txtTensach.Text, float.Parse(txtGiaban.Text),
            txtMota.Text, s, DateTime.Parse(txtNgaycapnhat.Text),
            int.Parse(txtSoluong.Text));
            ob.Insert_Sach(ob1);
            LoadData();
        }


        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            string masach = GridView1.Rows[e.RowIndex].Cells[0].Text;
            ob.Delete_Sach(masach);
            LoadData();
        }   

        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
            txtMasach.Text = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
            txtTensach.Text = (GridView1.Rows[e.NewEditIndex].Cells[1].Controls[0] as TextBox).Text;
            txtGiaban.Text = (GridView1.Rows[e.NewEditIndex].Cells[2].Controls[0] as TextBox).Text;
            txtMota.Text = (GridView1.Rows[e.NewEditIndex].Cells[3].Controls[0] as TextBox).Text;
            txtSoluong.Text = (GridView1.Rows[e.NewEditIndex].Cells[5].Controls[0] as TextBox).Text;
            txtNgaycapnhat.Text = (GridView1.Rows[e.NewEditIndex].Cells[4].Controls[0] as TextBox).Text;
        }

        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            string s = "~/Hinhanhsp/slider1.jpg" + FileUpload1.FileName;
            Sach1 ob1 = new Sach1(txtMasach.Text, txtTensach.Text, float.Parse(txtGiaban.Text),
                txtMota.Text, s, DateTime.Parse(txtNgaycapnhat.Text), int.Parse(txtSoluong.Text));
            ob.Update_Sach(ob1);
            LoadData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}