using Simeranya.BusinessLayer.Abstract;
using Simeranya.DataAccessLayer.Abstract;
using Simeranya.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simeranya.BusinessLayer.Concreate
{
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void TDelete(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public MessageCategory TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategory> TGetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void TInsert(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MessageCategory t)
        {
            throw new NotImplementedException();
        }
    }
}
