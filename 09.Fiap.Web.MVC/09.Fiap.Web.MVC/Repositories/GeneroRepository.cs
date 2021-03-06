﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _09.Fiap.Web.MVC.Models;
using _09.Fiap.Web.MVC.Persistencia;

namespace _09.Fiap.Web.MVC.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private GamesContext _context;

        public GeneroRepository(GamesContext context)
        {
            _context = context;
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }
    }
}