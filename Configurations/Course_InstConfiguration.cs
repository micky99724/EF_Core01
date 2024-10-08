﻿using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core01.Configurations
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> ci)
        {
            ci.Property("Evaluate").IsRequired(true).HasMaxLength(100);
        }
    }
}
