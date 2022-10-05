using DataAccessLibrary.Model;
using DataAccessLibrary.Service;
using ResultHelper;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccessLibrary.Repository
{
    internal class ReferenceRepository : IReference
    {
        private Reference _record;

        public Reference Record{ 
            get => _record; 
            set => _record= value; 
        }
        public Result result { get ; set; }
        
        public List<Reference> SelectAll(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.References.ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
        public Result Add(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                db.References.Add(_record);
                db.SaveChanges();

                result.Code = true;
                result.Message = "Added a new Reference Record successfully.";
            }
                return result;
        }

        public Result Delete(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {

                db.Entry(_record).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Deleted a Reference Record successfully.";

                return result;
            }
        }
        public Result Edit(){
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                //var recordToEdit = db.References.SingleOrDefault(t => t.Id == _record.Id);
                //db.References.Attach(recordToEdit);
                db.Entry(_record).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                result.Code = true;
                result.Message = "Updated a Reference Record successfully.";
                return result;
            }
        }

        public List<Reference> SelectByCategoryId(int paramId)
        {
            result = new Result();
            using (var db = new X2MO_InSysEntities())
            {
                var record = db.References.Where(p=>p.CategoryID==paramId).ToList();

                result.Code = true;
                result.Message = String.Empty;

                return record;
            }
        }
    }
}
