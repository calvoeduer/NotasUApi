using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model.ViewModel
{
    public class SubjectInputModel : SubjectEditModel
    {
        public string Code { get; set; }

        public string UserId { get; set; }
    }
}
