﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;
using System.Runtime.CompilerServices;

namespace App_Facultate.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesDisplayController : ControllerBase
    {
        private readonly FacultateContext _context;

        public GradesDisplayController(FacultateContext context)
        {
            _context = context;
        }

    
        // GET: api/GradesDisplay
        [HttpGet("ViewGradesTeacher")]
        public async Task<ActionResult<IEnumerable<Materii>>> GetMaterii(string denumire_materie)
        {
            var grades = _context.Materii.Where(w => w.denumire_materie.Equals(denumire_materie))
                .Join(_context.Calificative,
                u => u.id_materie,
                s => s.id_materie,
                (u, s) => new
                { s, u }).Join(_context.Studenti,
                x => x.s.id_student,
                y => y.id_student,
                (x,y) => new {x,y}).Join(_context.Utilizatori,
                a=> a.y.id_utilizator,
                b=> b.id_utilizator,(a,b) => new {a,b}).Select(z=> new { id_grade = z.a.x.s.id_Calificativ, grade = z.a.x.s.nota, current_date = z.a.x.s.CurrentDateGrade, name = z.b.nume,surname=z.b.prenume, id_user=z.a.x.s.id_student }).ToList();


             return Ok(grades);
        }

        // GET: api/GradesDisplay
        [HttpGet("ViewGradesStudent")]
        public async Task<ActionResult<IEnumerable<Materii>>> GetCalificative(string username, string denumire_materie)
        {
            var id_student = _context.Utilizatori.Where(x => x.username.Equals(username)).
                Join(_context.Studenti,
                s => s.id_utilizator,
                w => w.id_utilizator,
                (s,w)=> new {s,w}).Select(y => new {id_student=y.w.id_student}).ToList();

            var grades_student = _context.Calificative.Where(w => w.id_student.Equals(id_student.First().id_student))
                  .Join(_context.Materii,
                u => u.id_materie,
                s => s.id_materie,
                (u, s) => new { u, s }).Where(y => y.s.denumire_materie.Equals(denumire_materie))
                .Select(z => new { nota = z.u.nota, denumire_materie = z.s.denumire_materie, data = z.u.CurrentDateGrade }).ToList();


            return Ok(grades_student);
        } 

        [HttpGet("ViewSubjects")]
        public async Task<ActionResult<IEnumerable<Materii>>> GetAllSujects(string username)
        {
            var id_student = _context.Utilizatori.Where(w => w.username.Equals(username))
                         .Join(_context.Studenti,
                         a => a.id_utilizator,
                         b => b.id_utilizator,
                        (a, b) => new { a, b })
                         .Select(e => new { id_student = e.b.id_student }).ToList();

            var subjects = _context.Materii.Where(w=> w.id_student.Equals(id_student.First().id_student)).
                Select(z => new {denumire_materie = z.denumire_materie});

            return Ok(subjects);
        }
    }
}