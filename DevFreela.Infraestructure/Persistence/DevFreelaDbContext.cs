using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infraestructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descrição de Projeto 1", 1,1,1000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descrição de Projeto 2", 2,2,2000),
                new("Meu projeto ASPNET Core 3", "Minha Descrição de Projeto 3", 2,2,3000),
                
            };

            Users = new List<User>
            {
                new User("Patric Fonseca", "patric.ccomp@gmail.com", new DateTime(1995, 04, 23)),
                new User("Jose", "jose.ccomp@gmail.com", new DateTime(1999, 05, 11)),
                new User("Maria", "maria232p@hotmail.com", new DateTime(1973, 04, 23)),
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
