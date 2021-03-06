﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchulDb.Model
{
    [Table("Religion")]
    public partial class Religion
    {
        public Religion()
        {
            Schuelers = new HashSet<Schueler>();
        }

        [Key]
        [Column("Rel_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  // Für SQL Server, sonst glaubt EF Core es ist ein Autowert.
        public int RelId { get; set; }
        [Required]
        [Column("Rel_Nr")]
        [StringLength(50)]
        public string RelNr { get; set; }
        [Column("Rel_Name")]
        [StringLength(255)]
        public string RelName { get; set; }
        [Column("Rel_Gesetzlichanerkannt")]
        public bool RelGesetzlichanerkannt { get; set; }
        [Column("Rel_Staatlicheingetragen")]
        public bool RelStaatlicheingetragen { get; set; }

        [InverseProperty(nameof(Schueler.SReligionNavigation))]
        public virtual ICollection<Schueler> Schuelers { get; set; }
    }
}