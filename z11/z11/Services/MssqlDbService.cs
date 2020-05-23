using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using z11.Modeles;

namespace z11.Services
{
    public class MssqlDbService : IDbService
    {
        private readonly CodeFirstContext _db;
        public MssqlDbService(CodeFirstContext db)
        {
            _db = db;
        }
        public void AddDoctor(Doctor doctor)
        {
            _db.Add(doctor);
            _db.SaveChanges();
        }

        public void DeleteDoctor(Doctor doctor)
        {
            _db.Remove(doctor);
            _db.SaveChanges();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _db.Doctor.ToList();
        }

        public void MidifyDoctor(Doctor doctor)
        {
            _db.Update(doctor);
            _db.SaveChanges();
        }
    }
}
