﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFS_FileProcessor
{
    public partial class PropertyApplication
    {
        public int PropertyApplicationID { get; set; }
        public int? PropertyID { get; set; }
        public int? ApplicationID { get; set; }

        public virtual Application Application { get; set; }
        public virtual Property Property { get; set; }
    }
}