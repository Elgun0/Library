//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace k101LibForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader()
        {
            this.Book_To_Reader = new HashSet<Book_To_Reader>();
        }
    
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public Nullable<int> FacultyId { get; set; }
        public Nullable<int> IBN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_To_Reader> Book_To_Reader { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
