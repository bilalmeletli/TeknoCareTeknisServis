using nypDönemSonuProje.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nypDönemSonuProje.Service
{
    internal class RaporlarService
    {
        RaporlarDAO _dao;

        public RaporlarService()
        {
            _dao = new RaporlarDAO();
        }

        public DataTable PersonelListesi()
        {
            return _dao.PersonelGetir();
        }

        public DataTable HizmetListesi()
        {
            return _dao.HizmetGetir();
        }

        public DataTable DurumRaporu()
        {
            return _dao.DurumDagilimiGetir();
        }
    }

}
