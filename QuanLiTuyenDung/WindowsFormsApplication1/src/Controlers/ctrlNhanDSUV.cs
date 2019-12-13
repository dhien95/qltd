using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.src.Controlers
{
    class ctrlNhanDSUV: src.Services.connDB
    {
        public ctrlNhanDSUV()
        {
            db.Connection.Open();
        }

        public List<src.Entitys.clsWeb> GetThongTinWeb()
        {
            List<src.Entitys.clsWeb> lstWeb = new List<Entitys.clsWeb>();
            var query = db.tblWEBs.Select(w => w).ToList();
            foreach (var item in query)
            {
                src.Entitys.clsWeb web = new Entitys.clsWeb((int)item.MaWeb, item.TenWeb, item.Link);
                lstWeb.Add(web);

            }
            return lstWeb;
        }
    }
}
