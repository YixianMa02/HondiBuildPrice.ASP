using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

/*
    Author: Yixian Ma
    Created at: 2021-10-22
*/

namespace HondiBuildPrice.ASP
{
    public partial class index : System.Web.UI.Page
    {
        static DataTable tbCar;
        static DataTable tbColor;
        static DataTable tbAccessories;
        static DataTable tbWarranty;

        protected void Page_Load(object sender, EventArgs e)
        {
            panFinalinfo.Visible = panPrice.Visible = false;

            tbCar = CreateCarTable();
            tbColor = CreateColorTable();
            tbAccessories = CreateAcessTable();
            tbWarranty = CreateWarrantyTable();

            if (!Page.IsPostBack)
            {
                lblPhone.Visible = txtPhone.Visible = false;

                cboCar.DataTextField = "Info";
                cboCar.DataValueField = "Price";
                cboCar.DataSource = tbCar;
                cboCar.DataBind();

                lstColor.DataTextField = "Info";
                lstColor.DataValueField = "Price";
                lstColor.DataSource = tbColor;
                lstColor.DataBind();
                lstColor.SelectedIndex = 0;

                chklstAccessories.DataTextField = "Info";
                chklstAccessories.DataValueField = "Price";
                chklstAccessories.DataSource = tbAccessories;
                chklstAccessories.DataBind();

                rdlstWarranty.DataTextField = "Info";
                rdlstWarranty.DataValueField = "Price";
                rdlstWarranty.DataSource = tbWarranty;
                rdlstWarranty.DataBind();
                rdlstWarranty.SelectedIndex = 0;
            }

            if (cboCar.SelectedIndex > 0)
            {
                calulatePrice();
            }

        }

        private DataTable CreateCarTable()
        {
            DataTable tbCar = new DataTable("Cars");

            tbCar.Columns.Add("Brand", typeof(String));
            tbCar.Columns.Add("Info", typeof(String));
            tbCar.Columns.Add("Price", typeof(Int32));

            DataRow myRow = tbCar.NewRow();
            myRow["Brand"] = "";
            myRow["Info"] = "Select a Car";
            myRow["Price"] = 0;
            tbCar.Rows.Add(myRow); 
            
            myRow = tbCar.NewRow();
            myRow["Brand"] = "Civoc";
            myRow["Info"] = "Civoc (+ $25000)";
            myRow["Price"] = 25000;
            tbCar.Rows.Add(myRow);

            myRow = tbCar.NewRow();
            myRow["Brand"] = "DR-V";
            myRow["Info"] = "DR-V (+ $30000)";
            myRow["Price"] = 30000;
            tbCar.Rows.Add(myRow);

            myRow = tbCar.NewRow();
            myRow["Brand"] = "Appord";
            myRow["Info"] = "Appord (+ $33000)";
            myRow["Price"] = 33000;
            tbCar.Rows.Add(myRow);

            myRow = tbCar.NewRow();
            myRow["Brand"] = "Cilot";
            myRow["Info"] = "Cilot (+ $45000)";
            myRow["Price"] = 45000;
            tbCar.Rows.Add(myRow);

            myRow = tbCar.NewRow();
            myRow["Brand"] = "Odyrrey";
            myRow["Info"] = "Odyrrey (+ $54000)";
            myRow["Price"] = 54000;
            tbCar.Rows.Add(myRow);

            return tbCar;
        }

        private DataTable CreateColorTable()
        {
            DataTable tbColor = new DataTable("Colors");

            tbColor.Columns.Add("Color", typeof(String));
            tbColor.Columns.Add("Info", typeof(String));
            tbColor.Columns.Add("Price", typeof(Int32));

            DataRow myRow = tbColor.NewRow();
            myRow["Color"] = "White";
            myRow["Info"] = "White (Free)";
            myRow["Price"] = 0;
            tbColor.Rows.Add(myRow);

            myRow = tbColor.NewRow();
            myRow["Color"] = "Dark";
            myRow["Info"] = "Dark (+ $300)";
            myRow["Price"] = 300;
            tbColor.Rows.Add(myRow);

            myRow = tbColor.NewRow();
            myRow["Color"] = "Pearl";
            myRow["Info"] = "Pearl(+ $900)";
            myRow["Price"] = 900;
            tbColor.Rows.Add(myRow);

            return tbColor;
        }

        private DataTable CreateAcessTable()
        {
            DataTable tbAcess = new DataTable("Accessories");

            tbAcess.Columns.Add("Name", typeof(String));
            tbAcess.Columns.Add("Info", typeof(String));
            tbAcess.Columns.Add("Price", typeof(Int32));

            DataRow myRow = tbAcess.NewRow();
            myRow["Name"] = "Aero Kit";
            myRow["Info"] = "Aero Kit (+ $1300)";
            myRow["Price"] = 1300;
            tbAcess.Rows.Add(myRow);

            myRow = tbAcess.NewRow();
            myRow["Name"] = "Film";
            myRow["Info"] = "Film (+ $600)";
            myRow["Price"] = 600;
            tbAcess.Rows.Add(myRow);

            myRow = tbAcess.NewRow();
            myRow["Name"] = "Cold Weather";
            myRow["Info"] = "Cold Weather (+ $900)";
            myRow["Price"] = 900;
            tbAcess.Rows.Add(myRow);

            myRow = tbAcess.NewRow();
            myRow["Name"] = "Hondi Emblem";
            myRow["Info"] = "Hondi Emblem (+ $150)";
            myRow["Price"] = 150;
            tbAcess.Rows.Add(myRow);

            myRow = tbAcess.NewRow();
            myRow["Name"] = "Snow Tire Package";
            myRow["Info"] = "Snow Tire Package (+ $1800)";
            myRow["Price"] = 1800;
            tbAcess.Rows.Add(myRow);

            return tbAcess;
        }

        private DataTable CreateWarrantyTable()
        {
            DataTable tbWarranty = new DataTable("Warranty");

            tbWarranty.Columns.Add("Name", typeof(String));
            tbWarranty.Columns.Add("Info", typeof(String));
            tbWarranty.Columns.Add("Price", typeof(Int32));

            DataRow myRow = tbWarranty.NewRow();
            myRow["Name"] = "3 Years";
            myRow["Info"] = "3 Years (Included)";
            myRow["Price"] = 0;
            tbWarranty.Rows.Add(myRow);

            myRow = tbWarranty.NewRow();
            myRow["Name"] = "5 Years";
            myRow["Info"] = "5 Years (+ $1000)";
            myRow["Price"] = 1000;
            tbWarranty.Rows.Add(myRow);

            myRow = tbWarranty.NewRow();
            myRow["Name"] = "7 years";
            myRow["Info"] = "7 Years (+ $1500)";
            myRow["Price"] = 1500;
            tbWarranty.Rows.Add(myRow);

            return tbWarranty;
        }

        private void calulatePrice()
        {
            int carPrice = 0, color = 0, acess = 0, warranty = 0, subtotal = 0, total = 0;

            carPrice = Convert.ToInt32(cboCar.SelectedItem.Value);
            color = Convert.ToInt32(lstColor.SelectedItem.Value);
            warranty = Convert.ToInt32(rdlstWarranty.SelectedItem.Value);

            foreach (ListItem item in chklstAccessories.Items) {
                acess += (item.Selected) ? Convert.ToInt32(item.Value) : 0;
            }

            subtotal = carPrice + color + warranty + acess;
            total = Convert.ToInt32(subtotal * 1.15);

            litPrice.Text = "<br>Car Price: $" + carPrice + "<br>Interior Color: $" + color
                + "<br>Acessories: $" + acess + "<br>Warranty: $" + warranty + "<br><br><br><br>Total without taxes: $"
                + subtotal + "<br>Total with taxes (15%): $" + total + "<br><br><br>";

            panPrice.Visible = true;
        }

        protected void cboCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void chkContact_CheckedChanged(object sender, EventArgs e)
        {
            lblPhone.Visible = txtPhone.Visible = chkContact.Checked;
        }

        protected void btnConclude_Click(object sender, EventArgs e)
        {
            panFinalinfo.Visible = true;

            foreach (DataRow myRow in tbCar.Rows) {
                if (myRow["Info"].ToString() == cboCar.SelectedItem.Text) {
                    litFinal.Text = "<br>Congratulation in obtain your new Hondi " + myRow["Brand"].ToString() + " in " + txtCity.Text + ", " + txtZipCode.Text + ".<br><br>";
                }
            }

            foreach (DataRow myRow in tbColor.Rows) {
                if (myRow["Info"].ToString() == lstColor.SelectedItem.Text) {
                    litFinal.Text += "Your car comes with " + myRow["Color"].ToString() + " Interior Color.<br>";
                }
            }

            foreach (ListItem item in chklstAccessories.Items) {
                if (item.Selected) {
                    foreach (DataRow myRow in tbAccessories.Rows){
                        if (myRow["Info"].ToString() == item.Text){
                            litFinal.Text += myRow["Name"].ToString() + ", ";
                        }
                    }
                }  
            }

            foreach (DataRow myRow in tbWarranty.Rows) {
                if (myRow["Info"].ToString() == rdlstWarranty.SelectedItem.Text) {
                    litFinal.Text += "<br><br>You choosed " + myRow["Name"].ToString() + " of warranty";
                }
            }

            if (chkContact.Checked)
            {
                litFinal.Text += " and our dealer will contact you by the phone number " + txtPhone.Text + ".";
            }
        }
    }
}