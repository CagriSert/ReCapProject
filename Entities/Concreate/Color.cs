using Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concreate
{
    public class Color : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
