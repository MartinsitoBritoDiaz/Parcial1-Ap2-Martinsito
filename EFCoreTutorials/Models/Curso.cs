﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorials.Models
{
    public class Curso
    {
        [Key]
        public int cursoId { get; set; }

        [Required(ErrorMessage ="Debe de introducir este campo")]
        public string nombre { get; set; }
    }
}
