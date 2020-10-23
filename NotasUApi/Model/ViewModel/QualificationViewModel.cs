using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model.ViewModel
{
    public class QualificationViewModel
    {
        public int Id { get; set; }
        public decimal TotalPartial { get; set; }
        public decimal TotalPercent { get; set; }
        public int Corte { get; set; }
        public decimal TotalActivityPercent { get; set; }
        public decimal Total { get; set; }

        public List<Activity> Activities { get; set; }
    }
}
