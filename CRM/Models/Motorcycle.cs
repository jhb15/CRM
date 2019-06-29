using System.Buffers.Text;

namespace CRM.Models
{
    public class Motorcycle : Vehicle
    {
        public bool HasHelmetStorage { get; set; }

        public override string ToString()
        {
            return base.ToString() 
                   + $", HasHelmetStorage: {HasHelmetStorage}";
        }
    }
}