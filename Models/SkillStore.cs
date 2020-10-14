using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Models
{
    public class SkillStore
    {
        public static List<Skill> SkillGroup(String type) {
            List<Skill> l = new List<Skill>();
            switch (type) {
                case "Java_Developer":
                    l.Add(new Skill { id = 1, name = "Java Core" });
                    l.Add(new Skill { id = 2, name = "Angular" });
                    l.Add(new Skill { id = 3, name = "Spring Boot" });
                    break;
                case "Dotnet_Developer":
                    l.Add(new Skill { id = 4, name = "C Sharp" });
                    l.Add(new Skill { id = 2, name = "Angular" });
                    l.Add(new Skill { id = 6, name = "Asp.net" });
                    break;
                case "Web_Developer":
                default:
                    l.Add(new Skill { id = 7, name = "Javascript" });
                    l.Add(new Skill { id = 2, name = "Angular" });
                    l.Add(new Skill { id = 8, name = "CSS" });
                    break;

            }


            return l;

        }
    }
}
