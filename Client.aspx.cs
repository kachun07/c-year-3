using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;

namespace WebRole1
{
    public partial class Client : System.Web.UI.Page
    {
        static int index = 0, count = 0;
        static ProductDataServiceContext svc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["userName"]))
            {
                TextBox1.Text = Request.QueryString["userName"];
            }
            else
            {
                TextBox1.Text = "NO DATA PROVIDED";
            }
            string value = "UseDevelopmentStorage=true";
            CloudStorageAccount cloudStorageAccount =
                                       CloudStorageAccount.Parse(value);
            CloudTableClient cloudTableClient
                                    = cloudStorageAccount.CreateCloudTableClient();

            cloudStorageAccount.CreateCloudTableClient().
                              CreateTableIfNotExist("ProductTable2");

            svc = new ProductDataServiceContext(cloudStorageAccount.
                           TableEndpoint.ToString(), cloudStorageAccount.Credentials);
            //TextBox2.Text = "No Item";
            count = 5;
            display_item(0);
        }

        public Album getObject(int ind)
        {
            //string searchString = TextBox7.Text;
            var q = from c in svc.CreateQuery<Album>("ProductTable2")
                    select c;
            int mycount = 0;
            index = ind;
            foreach (var p in q)
            {
                if (mycount == ind)
                {
                    return (Album)p;
                }
                //if (p.Item.Equals(searchString)) mycount++;
            }
            return null;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int makeBid = Convert.ToInt32(TextBox11.Text);
            string Newbidder = TextBox1.Text;
            Album p = getObject(index);
            if (makeBid <= p.bid)
            {
                Response.Redirect("~/TooLow.aspx");
            }
            else if (p != null)
            {
                p.bidder = Newbidder;
                p.bid = makeBid;
                p.status = "Bidding";
            }
            svc.UpdateObject(p);
            svc.SaveChanges();
            display_item(index);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (index > 0) index--;
            display_item(index);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (index < count - 1) index++;
            display_item(index);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox12.Text == "Sold" || TextBox12.Text == "Bidding" || TextBox12.Text == "Pending")
            {
                Response.Redirect("~/Sold.aspx");
            }
            else
            {
                string name = TextBox1.Text;
                Album p = getObject(index);
                if (p != null)
                {
                    p.status = "Pending";
                    p.bidder = name;
                }
                svc.UpdateObject(p);
                svc.SaveChanges();
                display_item(index);
            }
        }

        public void display_item(int ind)
        {
            //string searchString = TextBox2.Text;
            var q = from c in svc.CreateQuery<Album>("ProductTable2")
                    select c;
            int mycount = 0;
            index = ind;

            foreach (var p in q)
            {
                if (mycount == ind)
                {
                    //TextBox1.Text = "" + p.Seller;
                    TextBox9.Text = "" + p.id;
                    TextBox2.Text = "" + p.seller;
                    TextBox3.Text = "" + p.name;
                    TextBox4.Text = "" + p.artist;
                    TextBox5.Text = "" + p.year;
                    TextBox6.Text = "" + p.formatType;
                    TextBox7.Text = "" + p.startPrice;
                    TextBox8.Text = "" + p.bid;
                    TextBox10.Text = "" + p.genre;
                    TextBox12.Text = "" + p.status;

                }
                mycount++;
            }

        }
    }
}