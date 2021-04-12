using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDC.Data
{
    public class DayCareFacility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Teacher> Teachers{ get; set; }
        public virtual List<ClassRoom> ClassRooms{ get; set; }
    }
}
