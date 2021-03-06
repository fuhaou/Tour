//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.CTTours = new HashSet<CTTour>();
            this.Doans = new HashSet<Doan>();
        }
    
        public int TourId { get; set; }
        public string TourCode { get; set; }
        public string TourTen { get; set; }
        public int FkLoaiHinhDulich { get; set; }
        public Nullable<double> TourPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTTour> CTTours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doan> Doans { get; set; }
        public virtual LoaiHinhDulich LoaiHinhDulich { get; set; }
    }
}
