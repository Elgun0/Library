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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Book_To_Reader = new HashSet<Book_To_Reader>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> PublishHouseID { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_To_Reader> Book_To_Reader { get; set; }
        public virtual PubliShHouse PubliShHouse { get; set; }
    }
}
