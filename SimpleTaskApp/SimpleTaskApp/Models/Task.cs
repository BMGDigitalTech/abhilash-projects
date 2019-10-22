using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleTaskApp.Models
{
    [Table("AppTasks")]
    public class Task
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024;

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        // public TaskState State { get; set; }

        public Task()
        {
           //  CreationTime = Clock.Now;
                // State = TaskState.Open

        }

    }
}
