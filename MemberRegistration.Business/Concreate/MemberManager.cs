using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.KpsServiceReference;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
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
        IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }
        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();  ---Miktoservis miamarisine ters , servisin değişme ihtimali var 
            //client.TCKimlikNoDogrula();
            CheckIfMemberExists(member);
            CheckIfUserValidFromKps(member);
            _memberDal.Add(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            if (!_kpsService.ValidateUser(member))
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil!");
            }
        }

        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == member.TcNo) != null)//Daha önce aynı tc no ile işlem yapılmış mı ?
            {
                throw new Exception("Bu kullanıcı daha önce kayıt olmuştur!");
            }
        }
    }
}
