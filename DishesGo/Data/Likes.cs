//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DishesGo.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Likes
    {
        public int id_like { get; set; }
        public Nullable<int> id_recipe { get; set; }
        public Nullable<int> id_user { get; set; }
    
        public virtual Recipes Recipes { get; set; }
        public virtual Users Users { get; set; }
    }
}
