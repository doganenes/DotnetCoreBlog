using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetListAll(x => x.Receiver == p);
        }

        public void TAdd(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message t)
        {
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetListAll();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
