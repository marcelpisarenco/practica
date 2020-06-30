using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompanyServices.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page title")]
        public override string Title { get; set; } = "Informative page";

        [Display(Name = "Page Content")]
        public override string Text { get; set; } = "Content filled by the administrator";
    }
}
