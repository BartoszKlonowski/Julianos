using System;


namespace DesktopApp.Models
{
    public class BookModel
    {
        public int ID
        { get; set; }

        public string Name
        { get; set; }

        public string Author
        { get; set; }

        public string Url
        { get; set; }

        public string Image
        { get; set; }

        public decimal Rating
        { get; set; }

        public decimal Prize
        { get; set; }

        public DateTime BuyingDate
        { get; set; }
    }
}
