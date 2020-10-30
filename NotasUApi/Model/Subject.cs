using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

    }
}
