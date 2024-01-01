using QLBN.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBN.BUS
{
    public class BenhNhanService
    {
        public List<BenhNhan> GetAll()
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.BenhNhans.ToList();
        }

        public BenhNhan FindById(string maBN)
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.BenhNhans.FirstOrDefault(x => x.MaBN == maBN);
        }

        public void InsertUpdate(BenhNhan s)
        {
            QLBNModel dbContext = new QLBNModel();
            dbContext.BenhNhans.AddOrUpdate(s);
            dbContext.SaveChanges();
        }

        public void DeleteSach(string s)
        {
            using (QLBNModel dbContext = new QLBNModel())
            {
                var dbDelete = dbContext.BenhNhans.Find(s);
                if (dbDelete != null)
                {
                    dbContext.BenhNhans.Remove(dbDelete);
                    dbContext.SaveChanges();
                }
            }
        }

        public List<BenhNhan> GetAllTenBenhNhan(string tenBN)
        {
            QLBNModel dbContext = new QLBNModel();
            return dbContext.BenhNhans.Where(x => x.TenBN.StartsWith(tenBN)).ToList();
        }

        public List<BenhNhan> FindBenhNhanInformation(string maBN, string tenBN, int maTT)
        {
            QLBNModel dbContext = new QLBNModel();
            if (!string.IsNullOrEmpty(maBN) && !string.IsNullOrEmpty(tenBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaBN == maBN && s.TenBN == tenBN && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN) && !string.IsNullOrEmpty(tenBN))
            {
                return dbContext.BenhNhans.Where(s => s.MaBN == maBN && s.TenBN == tenBN).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaBN == maBN && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(tenBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.TenBN == tenBN && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN))
            {
                return dbContext.BenhNhans.Where(s => s.MaBN == maBN).ToList();
            }
            else if (!string.IsNullOrEmpty(tenBN))
            {
                return dbContext.BenhNhans.Where(s => s.TenBN == tenBN).ToList();
            }
            else if (maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaTT == maTT).ToList();
            }
            return null;
        }

        public List<BenhNhan> FindBenhNhanInformationTextChanged(string maBN, string tenBN, int maTT)
        {
            QLBNModel dbContext = new QLBNModel();
            if (!string.IsNullOrEmpty(maBN) && !string.IsNullOrEmpty(tenBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaBN.StartsWith(maBN) && s.TenBN.StartsWith(tenBN) && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN) && !string.IsNullOrEmpty(tenBN))
            {
                return dbContext.BenhNhans.Where(s => s.MaBN.StartsWith(maBN) && s.TenBN.StartsWith(tenBN)).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaBN.StartsWith(maBN) && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(tenBN) && maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.TenBN.StartsWith(tenBN) && s.MaTT == maTT).ToList();
            }
            else if (!string.IsNullOrEmpty(maBN))
            {
                return dbContext.BenhNhans.Where(s => s.MaBN.StartsWith(maBN)).ToList();
            }
            else if (!string.IsNullOrEmpty(tenBN))
            {
                return dbContext.BenhNhans.Where(s => s.TenBN.StartsWith(tenBN)).ToList();
            }
            else if (maTT != -1)
            {
                return dbContext.BenhNhans.Where(s => s.MaTT == maTT).ToList();
            }
            return null;
        }
    }
}
