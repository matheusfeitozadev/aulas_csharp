//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssemblyProperty
    {
        public int Id { get; set; }
        public int FK_Assembly { get; set; }
        public int FK_Property { get; set; }
        public string PropertyValue { get; set; }
    
        public virtual Assembly Assembly { get; set; }
        public virtual Property Property { get; set; }
    }
}
