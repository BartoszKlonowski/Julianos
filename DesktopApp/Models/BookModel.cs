using System;
using System.Windows.Media;

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

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public Brush RatingColor
        {
            get
            {
                switch( Rating )
                {
                    case 1:
                    case 2:
                        return new SolidColorBrush( Colors.Brown );
                    case 3:
                    case 4:
                        return new SolidColorBrush( Colors.Silver );
                    case 5:
                        return new SolidColorBrush( Colors.Gold );
                    default:
                        return new SolidColorBrush( Colors.White );
                }
            }
        }
    }
}
