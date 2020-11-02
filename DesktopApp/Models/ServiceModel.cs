using System;
using System.Collections.Generic;


namespace DesktopApp.Models
{
    public class ServiceModel
    {
        public int ID
        { get; set; }

        public string CustomerNameAndSurname
        { get; set; }

        public DateTime DateOfService
        { get; set; }

        public string ServiceManager
        { get; set; }

        public string Description
        { get; set; }

        public bool IsSuccessfull
        { get; set; }

        public decimal InvoicedAmount
        { get; set; }

        virtual public List<ToolModel> Tools
        { get; set; }
    }
}
