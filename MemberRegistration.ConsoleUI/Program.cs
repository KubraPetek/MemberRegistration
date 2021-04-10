using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member {Email="kubrapetek@gmail.com", FirstName = "Kubra", LastName = "Petek", DateOfBirth = new DateTime(1995, 3, 30), TcNo = "17075218810" }); //Kontrolü mernis üzerinden yaptığı için kullancı bilgileri doğru olmak zorunda
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
