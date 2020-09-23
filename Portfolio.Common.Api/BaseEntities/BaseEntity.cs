using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Common.Api.BaseEntities
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Copy other entity's values to this entity
        /// </summary>
        /// <param name="other">Other entity to copy</param>
        public abstract void Copy(BaseEntity other);
    }
}
