﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models
{
    public class Profile
    {
        [Key]
        [Required]
        public int ProfileID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [MaxLength(150)]
        [EmailAddress(ErrorMessage = "Wrong e-mail address!")]
        public string UserName { get; set; }
        [Required]
        [Range(0,2)]
        public int AccountBan { get; set; }
        public int? CharacterID { get; set; }
        [ForeignKey("CharacterID"), Column(Order = 0)]
        public virtual Character.Character Character { get; set; }
    }
}
    