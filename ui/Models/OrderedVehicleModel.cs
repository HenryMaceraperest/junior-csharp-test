using System;

namespace ui.Models
{
    public class OrderedVehicleModel
    {
        public string VehicleNumber { get; set; }
        public OrderModel Order { get; set; }
        public ModelModel Model { get; set; }
        public TrimModel Trim { get; set; }
        public EngineModel Engine { get; set; }
        public string Colour { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime ActualDeliveryDate { get; set; }
    }
}
