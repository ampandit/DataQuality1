using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataQuality1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TableList()
        {
            ViewBag.Message = "List of entities.";
            string json = "C:/Users/AXP6230/Downloads/getEntities_Response.json";
            // TODO: Debug this line
            JObject o1 = JObject.Parse(System.IO.File.ReadAllText(json));
            // dynamic jObj = JsonConvert.DeserializeObject(json);
            foreach (JProperty res in o1.Properties())
            {
                Console.WriteLine(res.Name);
            }
            return View();
        }


        public ActionResult Reviews()
        {
            ViewBag.Message = "Comments and reviews.";

     /*      private string conString = ConfigurationManager.ConnectionStrings["constrtest"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
    
        {
            bool IsPostBack = false;
            if (!IsPostBack)
            {
                this.GetData();
            }
        }

        private void GetData()
        {
            string conString = ConfigurationManager.ConnectionStrings["constrtest"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("SELECT [Name],[Comment],[CreateDate] FROM [UserComments]", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dlMessage.DataSource = dt;
            dlMessage.DataBind();
        }

        protected void btnShare_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["constrtest"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("INSERT INTO UserComments Values(@Name,@Comment,@CreateddDate)", con);
            cmd.Parameters.AddWithValue("@Name", "Test");
            cmd.Parameters.AddWithValue("@Comment", txtshare.Text.Trim());
            cmd.Parameters.AddWithValue("@CreateddDate", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            this.GetData();
        }
        */
            return View();
        }

   
    }
}