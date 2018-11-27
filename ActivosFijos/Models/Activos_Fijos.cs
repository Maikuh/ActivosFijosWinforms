//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivosFijos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activos_Fijos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activos_Fijos()
        {
            this.Calculo_Depreciacion = new HashSet<Calculo_Depreciacion>();
        }
    
        public int Codigo_Activo { get; set; }
        public string Descripcion { get; set; }
        public int Codigo_Departamento { get; set; }
        public int Codigo_Ubicacion { get; set; }
        public int Codigo_TipoActivo { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public decimal Valor_Compra { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual Tipo_Activo Tipo_Activo { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calculo_Depreciacion> Calculo_Depreciacion { get; set; }
    }
}
