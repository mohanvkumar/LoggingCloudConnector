using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;

namespace EloquaStepCanvas
{
    public partial class DownloadLog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = Server.MapPath("default.aspx"); 
            Response.Write("Path : " + Server.MapPath("."));

            //hypDownloadLog.NavigateUrl = Server.MapPath("PhilipsEloqua.log");
            //string path = string.Empty;
            //path = Server.MapPath("PhilipsEloqua.log");
            //if (File.Exists(path))
            //{
            //    Response.Write("File Exists in Path 1 : " + path);
            //    HyperLink1.NavigateUrl = path;
            //}
            //else
            //{
            //    Response.Write("File is diffenence Souce");
            //    path = Server.MapPath(".") + "\\PhilipsEloqua.log";
            //    if (File.Exists(path))
            //    {
            //        Response.Write("File Exists in Path 2 : " + path);
            //        HyperLink1.Text = "Path2";
            //        HyperLink1.NavigateUrl = path;
            //    }
            //    else
            //    {
            //        Response.Write("File not found");
            //        path = Server.MapPath("..") + "\\PhilipsEloqua.log";
            //        if (File.Exists(path))
            //        {
            //            Response.Write("File Exists in Path 3 : " + path);
            //            HyperLink1.Text = "Path2";
            //            HyperLink1.NavigateUrl = path;
            //        }
            //    }

            //string[] filePaths = Directory.GetFiles(Server.MapPath("."), "*.log",
            //                             SearchOption.AllDirectories);

            //foreach (string s in filePaths)
            //{
            //    Response.Write(s + "<br>");
            //}
            
            

            
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {

            //var fileInBytes = Encoding.UTF8.GetBytes("PhilipsEloqua.log");
            //using (var stream = new MemoryStream(fileInBytes))
            //{
            //    long dataLengthToRead = stream.Length;
            //    Response.Clear();
            //    Response.ClearContent();
            //    Response.ClearHeaders();
            //    Response.BufferOutput = true;
            //    Response.ContentType = "text/xml"; /// if it is text or xml
            //    Response.AddHeader("Content-Disposition", "attachment; filename=" + "yourfilename");
            //    Response.AddHeader("Content-Length", dataLengthToRead.ToString());
            //    stream.WriteTo(Response.OutputStream);
            //    Response.Flush();
            //    Response.Close();
            //}
            //Response.End();

            
        }

    }
}