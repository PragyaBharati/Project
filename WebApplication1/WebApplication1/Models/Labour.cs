using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Labour
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pswd { get; set; }
        public string Cnfrmpswd { get; set; }
        public string Profession { get; set; }
        public string CityAddress { get; set; }
        public string StateL { get; set; }
        public int? DailyWages { get; set; }
        public DateTime? TimeDate { get; set; }
        public string Available { get; set; }
        public string Lcontact { get; set; }
        public string Ppic { get; set; }

        [NotMapped]
        [DisplayName("upload profile pic")]
        public IFormFile PPicFile { get; set; }
    }
}
