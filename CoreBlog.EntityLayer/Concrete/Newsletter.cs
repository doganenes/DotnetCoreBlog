using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.EntityLayer.Concrete
{
    public class Newsletter
    {
        [Key]
        public int MailID { get; set; }
        public String Mail { get; set; }
        public bool MailStatus { get; set; }

    }
}
