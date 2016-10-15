using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ViewModels
{
    public class ClientLoginViewModel
    {
        [Required]
        [StringLength(10)]
        [DisplayName("名")]
        public string FirstName { get; set; }
        [StringLength(10, ErrorMessage = "{0} 最大不得超過 {1} 個字元")]
        [DisplayName("中間名")]
        [Required]
        public string MiddleName { get; set; }
        [StringLength(5)]
        [Required]
        [DisplayName("姓")]
        public string LastName { get; set; }

        [DisplayName("生日")]
        [DisplayFormat(DataFormatString = "{0 : MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
    }
}