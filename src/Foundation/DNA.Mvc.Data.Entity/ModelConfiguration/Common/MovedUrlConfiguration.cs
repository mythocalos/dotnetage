﻿///  Copyright (c) 2009-2013 DotNetAge (http://www.dotnetage.com)
///  Licensed under the GPLv2: http://dotnetage.codeplex.com/license
///  Project owner : Ray Liang (csharp2002@hotmail.com)


using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace DNA.Web.Data.Entity.ModelConfiguration
{
    public class MovedUrlConfiguration : EntityTypeConfiguration<MovedUrl>
    {
        public MovedUrlConfiguration()
        {
            HasKey(a => a.ID).ToTable("dna_movedUrls");
            Property(a => a.Url).HasMaxLength(2048);
            Property(a => a.OriginalUrl).HasMaxLength(2048);
        }
    }
}

