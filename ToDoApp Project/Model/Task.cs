//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoApp_Project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int CreatorId { get; set; }
        public System.DateTime LastChanged { get; set; }
        public int LastChangeUserId { get; set; }
        public int ToDoId { get; set; }
    
        public virtual ToDo ToDo { get; set; }
    }
}