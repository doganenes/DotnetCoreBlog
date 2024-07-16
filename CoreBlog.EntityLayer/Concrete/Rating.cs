using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.EntityLayer.Concrete
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int BlogID { get; set; }
        public int TotalScore {  get; set; }
        public int RatingCount { get; set; }
    }
}
