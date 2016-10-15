//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5Course.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ClientId { get; set; }
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
        [Required]
        [DisplayName("性別")]
        [RegularExpression("[MF]", ErrorMessage = "Gender 欄位只能輸入 M 或是 F")]
        public string Gender { get; set; }
        [DisplayName("生日")]
        [DisplayFormat(DataFormatString = "{0 : MM/dd/yyyy}" , ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [DisplayName("信用評等")]
        public Nullable<double> CreditRating { get; set; }
        public string XCode { get; set; }
        public Nullable<int> OccupationId { get; set; }
        public string TelephoneNumber { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public string Notes { get; set; }
    
        public virtual Occupation Occupation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
