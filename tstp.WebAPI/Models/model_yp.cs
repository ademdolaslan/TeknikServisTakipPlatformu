using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;

namespace sunucu.Models
{
    public partial class yp : ApiController
    {
        public int parca_no { get; set; }
        public string parca_ismi { get; set; }
        public string parca_marka { get; set; }
        public string parca_model { get; set; }
        public int parca_stok { get; set; }
        public string parca_fiyat { get; set; }
        public string parca_tur { get; set; }
    }
}
