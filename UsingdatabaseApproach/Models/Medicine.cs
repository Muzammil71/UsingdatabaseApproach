using System.ComponentModel.DataAnnotations;

namespace UsingdatabaseApproach.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }
}
