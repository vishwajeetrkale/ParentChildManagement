using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentChildManagementCodeFirstProject.Models
{
    public class ParentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParentDetail()
        {
            ChildDetails = new HashSet<ChildDetail>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int? NumberOfChild { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildDetail> ChildDetails { get; set; }

    }
}