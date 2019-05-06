using Microsoft.EntityFrameworkCore;
using Session08.StateManager;
using System;
using System.Linq;
using System.Reflection;
using Session08.StateManager.Entities.Utility;

namespace Session08.StateManagement.Dal
{
    public class Session08Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Initial Catalog=Session08Db;Integrated Security=True;");
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<JobData> Jobs { get; set; }
        /// <summary>
        /// ///apply yeke farsi to type of String Properties...
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            var Entities = ChangeTracker.Entries()
        .Where(p =>(p.State == EntityState.Modified)|| (p.State == EntityState.Added)).ToList();

            foreach (var entity in Entities)
            {
                var modifiedEntities = entity.Properties.Where(c => c.Metadata.PropertyInfo.PropertyType.Name=="String");
                
                foreach (var prop in modifiedEntities)
                {

                    prop.CurrentValue = prop.CurrentValue.ToString().ApplyCorrectYeKe();
                }
            }
            
           

                return base.SaveChanges();
           
        }
    }
}
