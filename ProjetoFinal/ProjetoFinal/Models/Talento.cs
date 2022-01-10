using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Talento
    {
        public int Id { get; set; } //ok
        public string ImagemNome { get; set; }
        [NotMapped]
        public IFormFile Imagem { get; set; } //ok
        public string Nome { get; set; } //ok
        public string Localidade { get; set; } //ok
        public string Sobre { get; set; } //ok
        public string Profissao { get; set; } //ok
        public string Email { get; set; } //ok
        public string Telefone { get; set; } //ok
        public string Formacao { get; set; } //ok
        public string Local1 { get; set; } //ok
        public string Funcao1 { get; set; } //ok
        public string Atividade1 { get; set; } //ok
        public string Local2 { get; set; } //ok
        public string Funcao2 { get; set; } //ok
        public string Atividade2 { get; set; } //ok
        public string Instituicao1 { get; set; } //ok
        public string CargaHoraria1 { get; set; } //ok
        public string Instituicao2 { get; set; } //ok
        public string CargaHoraria2 { get; set; } //ok
        public string Aprendeu1 { get; set; } //ok
        public string Aprendeu2 { get; set; } //ok
        public string Habilidades { get; set; } //ok
        public string Area { get; set; }
        public string Nivel { get; set; }
    }
}