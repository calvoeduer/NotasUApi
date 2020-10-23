using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model.ViewModel
{
    public class ActivityEditModel
    {
        public string Name { get; set; }
        [Range(0, 5)]
        public decimal Note { get; set; }
        [Range(0, 1)]
        public decimal Percent { get; set; }
    }
}
