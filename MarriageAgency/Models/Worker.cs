using System;
using System.ComponentModel.DataAnnotations;

namespace MarriageAgency.Models
{
    public class Worker {
        public long WorkerID { get; set; }

        public string NameSurname { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }

        public string Passport { get; set; }

        public long PostID { get; set; }

        public virtual Position Position { get; set; }

    }
}