using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public abstract class BaseModel<TModel> where TModel : BaseModel<TModel>
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ActiveSince { get; set; }
        public DateTime? ActiveLast { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // Navigation Properties
        public Guid? ParentId { get; set; }
        public TModel Parent { get; set; }
        public IEnumerable<TModel> Children { get; set; }

        public BaseModel()
        {
            this.Created = DateTime.Now;
            this.ActiveSince = this.Created;
            this.IsActive = true;
            this.Title = this.GetType().Name;
            this.Description = $"{this.GetType().Name} Item #{this.GetHashCode()}";
        }
    }
}
