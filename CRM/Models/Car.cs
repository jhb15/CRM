using System.Buffers.Text;

namespace CRM.Models
{
    public class Car : Vehicle
    {
        public string InteriorColour { get; set; }

        public override string ToString()
        {
            return base.ToString() 
                   + $", InteriorColour: {InteriorColour}";
        }
    }
}