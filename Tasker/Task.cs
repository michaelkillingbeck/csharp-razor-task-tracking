namespace Tasker
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Task
    {
        [MinLength(10)]
        [Required]
        public String Description { get; set; }

        public Int32 Id { get; set; }

        [Range(1, 5)]
        [Required]
        public Int32 Priority { get; set; }

        [Required]
        public String Title { get; set; }
    }
}
