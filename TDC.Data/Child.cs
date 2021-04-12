using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TDC.Data
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(ClassRoom))]
        public int ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom{ get; set; }
    }
}