using QLBN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBN.BUS
{
    public class TinhTrangService
    {
        public List<TinhTrang> GetAll()
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.TinhTrangs.ToList();
        }

        public TinhTrang FindById(int maTT)
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.TinhTrangs.FirstOrDefault(x => x.MaTT == maTT);
        }

        public void InsertUpdate(TinhTrang s)
        {
            QLBNModel dbContext = new QLBNModel();
            dbContext.TinhTrangs.AddOrUpdate(s);
            dbContext.SaveChanges();
        }

        public void DeleteLoaiSach(int s)
        {
            using (QLBNModel dbContext = new QLBNModel())
            {
                var dbDelete = dbContext.TinhTrangs.Find(s);
                if (dbDelete != null)
                {
                    dbContext.TinhTrangs.Remove(dbDelete);
                    dbContext.SaveChanges();
                }
            }
        }

        public List<TinhTrang> GetAllTenLoaiSach(string tenTT)
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.TinhTrangs.Where(x => x.TenTT.StartsWith(tenTT)).ToList();
        }
    }
}
