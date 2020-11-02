using System;
using System.Collections.Generic;


namespace DesktopApp.Models
{
    public class OrderModel
    {
        public int ID
        { get; set; }

        public string Name
        { get; set; }

        public DateTime DeliveryDate
        { get; set; }

        public DateTime CreationDate
        { get; set; }

        public string Description
        { get; set; }

        public decimal Cost
        { get; set; }

        virtual public List<ToolModel> Tools
        { get; set; }
    }
}
