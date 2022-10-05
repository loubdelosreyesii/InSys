
using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repository
{
    internal class RaffleRepository : IRaffle
    {
        private Raffle _record;

        public Raffle Record
        {
            get => _record;
            set => _record = value;
        }
        public Result result { get; set; }

        public List<Raffle> SelectAll()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Raffles.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Raffle SelectById( int id)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Raffles.Where(p=>p.Id == id).SingleOrDefault();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Raffle Select()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.Raffles.Where(p => p.Id == _record.Id).SingleOrDefault();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }


        public Result Add()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Raffles.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Raffle Record successfully.";
            }
            return result;
        }

        public Result Delete()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a Raffle Record successfully.";

                return result;
            }
        }

        public Result Edit()
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a Raffle Record successfully.";
                return result;
            }
        }

        public sp_RaffleOverview_Result SelectRaffleOverview(int paramRaffleId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.sp_RaffleOverview(paramRaffleId).SingleOrDefault();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
