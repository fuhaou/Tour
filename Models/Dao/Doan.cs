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
    
    public partial class Doan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doan()
        {
            this.CTDoanKhaches = new HashSet<CTDoanKhach>();
            this.CTDoanNVs = new HashSet<CTDoanNV>();
        }
    
        public int DoanId { get; set; }
        public string DoanCode { get; set; }
        public string DoanTen { get; set; }
        public Nullable<System.DateTime> DoanNgayDi { get; set; }
        public Nullable<System.DateTime> DoanNgayVe { get; set; }
        public int FkTour { get; set; }
        public Nullable<double> DoanHotelCost { get; set; }
        public Nullable<double> DoanFoodCost { get; set; }
        public Nullable<double> DoanVehicleCost { get; set; }
        public Nullable<double> DoanAdditionalCost { get; set; }
        public Nullable<double> DoanTourPrice { get; set; }
        public Nullable<System.DateTime> DoanNgayTao { get; set; }
        public Nullable<int> DoanTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDoanKhach> CTDoanKhaches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDoanNV> CTDoanNVs { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
