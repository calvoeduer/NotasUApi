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
        public Subject()
        {
            for (int i = 0; i < 3; ++i)
            {
                AddQualification(new Qualification { Cort = i + 1 });
            }
        }

        [Key, MaxLength(10)]
        public string Code { get; set; }
        public List<Qualification> Qualifications { get; set; }
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
