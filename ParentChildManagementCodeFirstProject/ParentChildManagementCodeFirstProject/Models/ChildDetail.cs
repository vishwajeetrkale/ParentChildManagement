using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentChildManagementCodeFirstProject.Models
{
    public class ChildDetail
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int ParentId {get; set;}

        public virtual ParentDetail ParentDetail { get; set; }

    }
}