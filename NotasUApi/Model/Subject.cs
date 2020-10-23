using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace NotasUApi.Model
{
    public class Subject
    {
      

        [Key, MaxLength(10)]
        public string Code { get; set; }
        public List<Qualification> Qualifications { get; set; } = new List<Qualification>(3);
        public decimal Definitiva { get; set; }

        public string Name { get; set; }

        public bool AddQualification(Qualification qualification)
        {
            if (qualification is null) return false;
            if (qualification.Cort > 3 || qualification.Cort <= 0) return false;

            Qualifications[qualification.Cort - 1] = qualification;
            return true;

        }
    }
}
