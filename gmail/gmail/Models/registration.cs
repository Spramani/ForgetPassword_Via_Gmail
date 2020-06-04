using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gmail.Models
{
    
        public class registration
        {
            public int id { get; set; }

            public string user_name { get; set; }

            public string user_name_id { get; set; }
            public string user_email { get; set; }

            public string user_password { get; set; }



            public string user_Conpassword { get; set; }

            public string user_gender { get; set; }
            public string user_contect { get; set; }
            public string user_website { get; set; }
            public string user_dateofbirth { get; set; }
            public string user_coverphoto { get; set; }
            public string user_profilephoto { get; set; }
            public string user_bio { get; set; }
            public string user_birthplace { get; set; }
            public string user_livesin { get; set; }
            public string user_occupation { get; set; }
            public string user_is_private { get; set; }
            public string user_status { get; set; }
            public string user_merriage_status { get; set; }

            public HttpPostedFileWrapper ImageFile { get; internal set; }

        
    }
}