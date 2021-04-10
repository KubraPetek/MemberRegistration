using DevFramework.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.DataAccess.Concreate.EntityFramework
{
   public  class EfMemberDal:EfEntityRepositoryBase<Member,MembershipContext>,IMemberDal
    {
    }
}
