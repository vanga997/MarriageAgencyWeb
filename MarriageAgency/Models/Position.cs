using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MarriageAgency.Models
{
    public partial class Position
    {
        public Position()
        {
            Worker = new HashSet<Worker>();
        }
        public long PostId { get; set; }
        [Key]
        public string PostName { get; set; }
        public long Salary { get; set; }
        public string Responsiblity { get; set; }
        public string Requirements { get; set; }

        public virtual ICollection<Worker> Worker { get; set; }
    }
}