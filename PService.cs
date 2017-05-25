using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YatinNiSite
{
    public class PService : DataService
    {
        public PService()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int StateID { get; set; }
        public string StateName { get; set; }

        public int CityID { get; set; }
        public string CityName { get; set; }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegDate { get; set; }

        public int PostID { get; set; }
        public string PostData { get; set; }
        public DateTime PostDate { get; set; }

        public int CommentID { get; set; }
        public string CommentData { get; set; }
        public DateTime CommentDate { get; set; }
    }
}