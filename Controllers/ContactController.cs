using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using React_UserApp.Models;

namespace React_UserApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        [Route("contactdetails")]
        public ActionResult<List<Contact>> getUser()
        {
            var user = new List<Contact>()
            {
                new Contact{userName = "pnangeelil", firstName = "Praphul", lastName = "Nangeelil",
                    dob = new DateTime(1991,4,25), email="pforpraphul@gmail.com", phone = "+911110000000", mobile = "+919000000000"},
                new Contact{userName = "snamboothiri", firstName = "Sreeraj", lastName = "R Namboothiri",
                    dob = new DateTime(1980,1,25), email="test1@test.com", phone = "+911110000001", mobile = "+919000000001"},
                new Contact{userName = "sabdul", firstName = "Shamnad", lastName = "V Abdul",
                    dob = new DateTime(1970,2,25), email="test2@test.com", phone = "+911110000002", mobile = "+919000000002"},
                new Contact{userName = "vrajendran", firstName = "Vishnu", lastName = "Rajendran",
                    dob = new DateTime(1975,3,25), email="test3@test.com", phone = "+911110000003", mobile = "+919000000003"},
                new Contact{userName = "ggeorge", firstName = "Georgekutty", lastName = "George",
                    dob = new DateTime(1960,4,25), email="test4@test.com", phone = "+911110000004", mobile = "+919000000004"},
                new Contact{userName = "sratheesh", firstName = "Surya", lastName = "Ratheesh",
                    dob = new DateTime(1985,4,25), email="test5@test.com", phone = "+911110000005", mobile = "+919000000005"},
                new Contact{userName = "rmshaji", firstName = "Renjith", lastName = "M Shaji",
                    dob = new DateTime(1990,4,25), email="test6@test.com", phone = "+911110000006", mobile = "+919000000006"}
            };
            return Ok(user);
        }
    }
}