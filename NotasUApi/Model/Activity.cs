using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0,5)]
        public decimal Note { get; set; }
        [Range(0,1)]
        public decimal Percent { get; set; }

        public decimal Value { get => Note * Percent; set { } }

    }
}
