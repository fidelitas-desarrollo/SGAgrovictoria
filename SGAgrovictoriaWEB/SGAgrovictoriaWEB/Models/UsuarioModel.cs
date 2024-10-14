﻿
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SGAgrovictoriaWEB.Entities;
using SGAgrovictoriaWEB.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace SGAgrovictoriaWEB.Models

{
    public class UsuarioModel
    {

        [Key]
        public long IdCredencial { get; set; }
        public long IdEmpleado { get; set; }
        public long IdTipoCredencial { get; set; }
        public bool Estado { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }

    }


}

