using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Http;

namespace sunucu.Models
{
    public partial class tk : ApiController
    {
        [Key]
        public int ariza_no { get; set; }
        public string musteri_adi { get; set; }
        public string musteri_soyadi { get; set; }
        public int musteri_telefon { get; set; }
        public string ariza_tanim { get; set; }
        public string ariza_cozum { get; set; }
        public string ariza_cihaz { get; set; }
        public string personel_adi { get; set; }
        public string personel_soyadi { get; set; }
    }

    
}