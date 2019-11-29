using System.Linq;
using System.Web.Http;
using sunucu.Models;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;

namespace sunucu.Controllers
{


    public class DefaultController : ApiController
    {


        [HttpGet]
       public List<view_teknik_servis> tks()
        {
            using (var model = new otomEntities())
            {
                return model.view_teknik_servis.ToList();
            }
        }
        [HttpGet]
        public List<view_yedek_parca> ypc()
        {

            using (var model = new otomEntities())
            {
                
                return model.view_yedek_parca.ToList();
            }



        }
      



    }
}
