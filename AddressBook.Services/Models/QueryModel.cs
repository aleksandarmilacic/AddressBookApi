﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBook.Services.Models
{
    public class QueryModel
    {
        [Required]
        public string Property { get; set; }

        public string Value { get; set; }
    }
}
