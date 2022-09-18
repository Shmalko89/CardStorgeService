﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStorageService.Data
{
    [Table("Clients")]
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Column]
        [StringLength(255)]
        public string? LastName { get; set; }

        [Column]
        [StringLength(255)]
        public string? Name { get; set; }

        [Column]
        [StringLength(255)]
        public string? Potronomyc { get; set; }

        public virtual ICollection<Card> Cards { get; set; } = new HashSet<Card>();
    }
}