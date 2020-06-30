using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompanyServices.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter the service name")]
        [Display(Name = "The service name")]
        public override string Title { get; set; }

        [Display(Name = "Short description of the service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description of the service")]
        public override string Text { get; set; }
    }
}
