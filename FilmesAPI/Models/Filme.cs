﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required (ErrorMessage = "O campo Título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatório!")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O Gênero deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 600 minutos!")]
        public int Duracao { get; set; }

        public Filme(string titulo, string diretor, string genero, int duracao)
        {
            Titulo = titulo;
            Diretor = diretor;
            Genero = genero;
            Duracao = duracao;
        }
    }
}
