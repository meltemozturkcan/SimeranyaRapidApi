﻿using Simeranya.DataAccessLayer.Abstract;
using Simeranya.DataAccessLayer.Concreate;
using Simeranya.DataAccessLayer.Repositories;
using Simeranya.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simeranya.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return values;
        }
    }
}
