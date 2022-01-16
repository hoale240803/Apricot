using System;

namespace Apricot.Domain.Abstract
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; set; }
    }

    public abstract class EntityBase<Tkey> : IEntityBase<Tkey>
    {
        public virtual Tkey Id { get; set; }
    }

    public interface IAudit
    {
         DateTime CreatedAt { get; set; }

         DateTime UpdatedAt { get; set; }

         string CreatedBy { get; set; }

         string UpdatedBy { get; set; }

         string DeleteBy { get; set; }

         DateTime DeletedAt { get; set; }
    }

    public class Audit : IAudit
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeleteBy { get; set; }
        public DateTime DeletedAt { get; set; }
    }


}