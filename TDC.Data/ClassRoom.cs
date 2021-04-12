using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDC.Data
{
    public class ClassRoom
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(DayCareFacility))]
        public int DayCareFacilityId { get; set; }
        public virtual DayCareFacility DayCareFacility { get; set; }

        public virtual List<Child> Children { get; set; }
        public virtual List<Teacher> Teachers{ get; set; }


    }
}