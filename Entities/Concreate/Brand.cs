using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concreate
{
    public class Brand : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
