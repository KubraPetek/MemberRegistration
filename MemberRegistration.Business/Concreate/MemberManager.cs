using MemberRegistration.Business.Abstract;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.Concreate
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;
        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }
        public void Add(Member member)
        {
            _memberDal.Add(member);
        }
    }
}
