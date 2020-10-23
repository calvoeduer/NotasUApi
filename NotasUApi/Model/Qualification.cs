using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotasUApi.Model
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }
        [Range (1,3), Required]
        public int Cort { get; set; }

        public List<Activity> Activities { get; set; } = new List<Activity>();

        public decimal TotalPartial { get; set; }

        public decimal TotalPercent
        { 
            get
            {
                switch (Cort)
                {
                    case 1:
                    case 2:
                        return 0.3M;
                    case 3:
                        return 0.4M;

                    default: return 0.0M;

                }
            }
            set { }
        }

        public decimal TotalActivityPercent { get; set; }

        public decimal Total { get; set; }

        public bool AddActivity(Activity activity)
        {
            Calculate();
            if ((TotalActivityPercent + activity.Percent) > 1) return false;

            Activities.Add(activity);
            return true;
        }


        public void Calculate()
        {
            TotalActivityPercent = Activities.Sum(a => a.Percent);
            TotalPartial = Activities.Sum(a => a.Percent * a.Note);
            Total = TotalPartial * TotalPercent;
        }

    }
}
