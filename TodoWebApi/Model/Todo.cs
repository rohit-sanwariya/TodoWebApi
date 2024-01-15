using System.ComponentModel.DataAnnotations;

namespace TodoWebApi.Model
{
    public class Todo
    {
        [Key]
        public int ID { get; set; }

        [Required] public string Title { get; set; } = string.Empty;

        public bool Description { get; set; } = false;
    }
}
