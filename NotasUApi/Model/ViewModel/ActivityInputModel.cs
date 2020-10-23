using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model.ViewModel
{
    public class ActivityInputModel : SubjectEditModel
    {
        [Required]
        public int QualificationId { get; set; }
    }
}
