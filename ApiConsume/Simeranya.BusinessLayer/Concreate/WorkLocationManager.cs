﻿using Simeranya.BusinessLayer.Abstract;
using Simeranya.DataAccessLayer.Abstract;
using Simeranya.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simeranya.BusinessLayer.Concreate
{
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void TDelete(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation TGetByID(int id)
        {
            return _workLocationDal.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
