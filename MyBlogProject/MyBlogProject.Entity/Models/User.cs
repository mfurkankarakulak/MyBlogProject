using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBlogProject.Entity.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string EMailAdress { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int TryPasswordCount { get; set; }
        public DateTime RegisterTime { get; set; }
        public int Sex { get; set; }



    }
}
