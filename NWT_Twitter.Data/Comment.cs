//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NWT_Twitter.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public Nullable<int> Tweet { get; set; }
        public Nullable<int> Author { get; set; }
    
        public virtual User User { get; set; }
        public virtual Tweet Tweet1 { get; set; }
    }
}