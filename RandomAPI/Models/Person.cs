﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// User first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Take a wild guess
        /// </summary>
        public string LastName { get; set; } = "";


    }
}