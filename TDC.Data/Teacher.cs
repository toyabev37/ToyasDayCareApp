using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDC.Data
{
    public class Teacher
    {
        //foreign keys go on the child objects
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Classroom))]
        public int ClassRoomId { get; set; }
        public virtual ClassRoom Classroom{ get; set; }

        [ForeignKey(nameof(DayCareFacility))]
        public int DayCareFacilityId { get; set; }
        public virtual DayCareFacility DayCareFacility { get; set; }

    }
}