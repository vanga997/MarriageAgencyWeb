using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarriageAgency.Models {

    public class Nationality {
        public long NationalityID { get; set; }

        public string NationalityName { get; set; }

        public string Comments { get; set;}


    }



}