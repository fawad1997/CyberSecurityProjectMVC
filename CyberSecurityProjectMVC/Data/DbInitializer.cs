using CyberSecurityProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyberSecurityProjectMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(CyberSecurityContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Articles.Any())
            {
                return;   // DB has been seeded
            }

            var articles = new Article[]
            {
                new Article{Title="Singapore Military hack",Description="The Singaporean “I-net” System, a military’s air gapped dedicated web access system was attacked that...",PublishDate=DateTime.Parse("2017-09-01")},
                new Article{Title="Chelsea or Bradley Manning ",Description="A Military Intelligence Analyst in Iraq from November 2009 to May 2010 Arrested for handling...",PublishDate=DateTime.Parse("2017-09-01")},
                new Article{Title="Edward Snowden",Description="A government contractor who leaked classified NSA documents to overall media outlets was working for Booz Allen Hamilton in 2013",PublishDate=DateTime.Parse("2017-09-01")}
            };
            foreach (Article a in articles)
            {
                context.Articles.Add(a);
            }
            context.SaveChanges();
        }
    }
}
