using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Configuration;
using OnlineTestDO;
using OnlineTestBL;

namespace OnlineTest.Content.Handlers
{
    /// <summary>
    /// Summary description for ImageUploadDataHandler
    /// </summary>
    public class ImageUploadDataHandler : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            string strJson = new StreamReader(context.Request.InputStream).ReadToEnd();
            ImageDocument obImageDocument = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<ImageDocument>(strJson);

            if(obImageDocument != null)
            {
                obImageDocument.CreatedBy = Convert.ToInt32(context.Session["UserId"]);
                obImageDocument.UserId = Convert.ToInt32(context.Session["UserId"]);
                obImageDocument.DocumentType = "1";
                obImageDocument.ImageId = 0; 
                obImageDocument.location = string.Empty;
                obImageDocument.CreatedDate = DateTime.Now;
                Byte[] bitmapData = Convert.FromBase64String(obImageDocument.imageRawData);
                MemoryStream streamBitmap = new MemoryStream(bitmapData);
                Bitmap bitImage = new Bitmap(Image.FromStream(streamBitmap));
                streamBitmap.Dispose();
                streamBitmap = null;
                string filename = Guid.NewGuid().ToString() + ".jpg";
                string filepath = "";
                filepath = ConfigurationManager.AppSettings["GEOTAGGEDIMAGE_FOLDER"] + "\\" + Convert.ToInt32(context.Session["InstanceId"])+ "\\" +context.Session["UserId"]+ "\\" + ConfigurationManager.AppSettings["GEOTAGGEDIMAGE_PRACTICAL_FOLDER_NAME"];
               // filepath = Path.Combine(context.Server.MapPath("~/Content/GeoImages/") + Convert.ToInt32(context.Session["InstanceId"]) + "\\" + context.Session["UserId"]);
                obImageDocument.ImagePath = filepath;
                if(System.IO.Directory.Exists(filepath) == false){
                    System.IO.Directory.CreateDirectory(filepath);
                }

                // bitImage.Save(filepath + "\\" + filename);
                bitImage.Save(filepath + "\\" + filename);
                obImageDocument.ImageName = filename;

                ImageUploadDO imgDO = new ImageUploadDO();
                imgDO.UserId = obImageDocument.UserId;
                imgDO.DocumentType =Convert.ToInt32(obImageDocument.DocumentType);
                imgDO.CreatedBy = obImageDocument.CreatedBy;
                imgDO.DocumentId = obImageDocument.ImageId;
                imgDO.Latitude = obImageDocument.latitude;
                imgDO.Longitude = obImageDocument.longitude;
                imgDO.Location = obImageDocument.location;
                imgDO.Timestamp = obImageDocument.timestamp;
                imgDO.ImageName = obImageDocument.ImageName;
                imgDO.ImagePath = obImageDocument.ImagePath;

                ImageUploadBL objBL = new ImageUploadBL();
                int returnREsult = 0;
                returnREsult = objBL.InsertImagesOfUsers(imgDO);

            }
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }


    public class ImageDocument
    {
        public string DocumentType { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string imageRawData { get; set; }
        public string DocumentSize { get; set; }
        public int ImageId { get; set; }
        public string location { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
    }
}