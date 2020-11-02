using System;


namespace DesktopApp.Models
{
    public class ToolModel
    {
        public int ID
        { get; set; }

        public string Name
        { get; set; }

        public decimal Value
        { get; set; }

        public string Manufacturer
        { get; set; }

        public int NumberOfUses
        { get; set; }

        public string Description
        { get; set; }

        public DateTime DateOfPurchase
        { get; set; }
    }
}
