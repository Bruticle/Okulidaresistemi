//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Okulidaresistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ders()
        {
            this.OgrenciDers = new HashSet<OgrenciDers>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Kredisi { get; set; }
        public int OkulYonetimId { get; set; }
    
        public virtual OkulYonetim OkulYonetim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}
