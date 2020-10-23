using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model.ViewModel
{
    public class ActivityViewModel : ActivityInputModel
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
    }
}
