//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace transport_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class fos_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fos_user()
        {
            this.courier = new HashSet<courier>();
            this.package = new HashSet<package>();
            this.package1 = new HashSet<package>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string username_canonical { get; set; }
        public string email { get; set; }
        public string email_canonical { get; set; }
        public bool enabled { get; set; }
        public string salt { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> last_login { get; set; }
        public string confirmation_token { get; set; }
        public Nullable<System.DateTime> password_requested_at { get; set; }
        public string roles { get; set; }
        public Nullable<int> address { get; set; }
        public Nullable<int> role { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> storage { get; set; }
    
        public virtual address address1 { get; set; }
        public virtual address address2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courier> courier { get; set; }
        public virtual user_role user_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package> package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package> package1 { get; set; }
    }
}