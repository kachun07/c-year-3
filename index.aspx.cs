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
    public partial class index : System.Web.UI.Page
    {
        static ProductDataServiceContext svc;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //admin
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            string userName = TextBox1.Text;
            //Response.Redirect("~/Seller.aspx");
            if (TextBox1.Text == "Admin"|| TextBox1.Text =="admin")
                Response.Redirect("~/Admin.aspx?userName=" + userName);
            else
                Response.Redirect("~/Client.aspx?userName=" + userName);

        }

        /*client
        protected void Button2_Click(object sender, System.EventArgs e)
        {
            string userName = TextBox1.Text;
            //Response.Redirect("~/Buyer.aspx");

            Response.Redirect("~/Client.aspx?userName=" + userName);
        }*/

        //init
        protected void Button3_Click(object sender, System.EventArgs e)
        {
            string value = "UseDevelopmentStorage=true";
            CloudStorageAccount cloudStorageAccount =
                                       CloudStorageAccount.Parse(value);
            CloudTableClient cloudTableClient
                                    = cloudStorageAccount.CreateCloudTableClient();

            cloudStorageAccount.CreateCloudTableClient().
                              CreateTableIfNotExist("ProductTable2");

            var product1 = new Album() { id = 1, name = "the man", artist = "david", startPrice = 10, year = 1970, genre = "pop/rock", formatType ="MP3", bidder = "", bid = 0 , seller = "test", status= "available" };
            var product2 = new Album() { id = 2, name = "solo", artist = "lug", startPrice = 70, year = 2009, genre = "classical", formatType = "CD", bidder = "", bid = 0, seller = "test", status= "available" };
            var product3 = new Album() { id = 3, name = "Divnire", artist = "Ludovico Einaudi", startPrice = 30, year = 1997, genre = "classical", formatType = "CD", bidder = "", bid = 0, seller = "ka", status = "available" };
            var product4 = new Album() { id = 4, name = "shady lp", artist = "slim", startPrice = 15, year = 2004, genre = "rap", formatType = "MP3", bidder = "", bid = 0, seller = "test", status = "available" };
            var product5 = new Album() { id = 5, name = "mar lp", artist = "mars", startPrice = 12, year = 2000, genre = "rap", formatType = "CD", bidder = "", bid = 0, seller = "test", status = "available" };


            svc = new ProductDataServiceContext(cloudStorageAccount.
                           TableEndpoint.ToString(), cloudStorageAccount.Credentials);

            delete_all();
            svc.AddObject("ProductTable2", product1);
            svc.AddObject("ProductTable2", product2);
            svc.AddObject("ProductTable2", product3);
            svc.AddObject("ProductTable2", product4);
            svc.AddObject("ProductTable2", product5);

            svc.SaveChanges();
        }
        public void delete_all()
        {
            var q = from c in svc.CreateQuery<Album>("ProductTable2")
                    select c;

            foreach (var p in q)
            {
                svc.DeleteObject(p);
            }
            svc.SaveChanges();
        }


    }
}