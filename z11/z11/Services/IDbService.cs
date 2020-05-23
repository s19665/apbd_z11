using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using z11.Modeles;

namespace z11.Services
{
    public interface IDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void AddDoctor(Doctor doctor);
        public void MidifyDoctor(Doctor doctor);
        public void DeleteDoctor(Doctor doctor);
    }
}
