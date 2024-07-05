using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        INewsletterDal _newsLetterDal;

        public NewsletterManager(INewsletterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void AddNewsletter(Newsletter newsletter)
        {
            _newsLetterDal.Insert(newsletter);
        }
    }
}
