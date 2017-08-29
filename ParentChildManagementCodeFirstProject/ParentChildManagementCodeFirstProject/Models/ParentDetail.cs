using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParentChildManagementCodeFirstProject.Models
{
    public class ParentDetail
    {

        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int? NumberOfChild { get; set; }

    }
}