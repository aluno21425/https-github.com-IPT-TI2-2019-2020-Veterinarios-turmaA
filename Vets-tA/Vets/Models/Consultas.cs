﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vets.Models {
   public class Consultas {

      [Key]
      public int ID { get; set; }

      public DateTime Data { get; set; }

      public string Observacoes { get; set; }

      //**********************************************
      // definir FKs
      //**********************************************
      // FK ---> Animais
      [ForeignKey(nameof(Animal))] // nameof() -> devolve a designação (como string) do objeto que é colocado como parâmetro
      public int AnimalFK { get; set; }
      public Animais Animal { get; set; }

      // FK ---> Veterinários
      [ForeignKey(nameof(Veterinario))]
      public int VeterinarioFK { get; set; }
      public Veterinarios Veterinario { get; set; }


   }
}
