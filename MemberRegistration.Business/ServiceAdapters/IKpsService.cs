using MemberRegistration.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Business.ServiceAdapters
{
    public interface IKpsService //Kps'in anlamı kimlik paylaşım sistemi
    {
        bool ValidateUser(Member member);

    }
}
