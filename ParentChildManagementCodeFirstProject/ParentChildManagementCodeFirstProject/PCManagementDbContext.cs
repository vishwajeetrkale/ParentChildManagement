using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ParentChildManagementCodeFirstProject.Models;

namespace ParentChildManagementCodeFirstProject
{
    public partial class PCManagementDbContext : DbContext
    {
        public virtual DbSet<ChildDetail> ChildDetails { get; set; }

        public virtual DbSet<ParentDetail> ParentDetails { get; set; }

    }
}