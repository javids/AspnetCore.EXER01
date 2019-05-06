using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Session08.StateManagement.Dal
{
  public static class DbContextUtilityExtentions
    {
        //remove all entity from Context.
        public static void RemoveAll<TEntity>( this DbContext context)where TEntity : class
        {
            //
            foreach (var entity in context.Set<TEntity>())
            {
                context.Entry(entity).State = EntityState.Deleted;
            }

        }
        //generic Update All Entity in parameter list 
        public static void Update<T>(this DbContext context, T entity, params Expression<Func<T, object>>[] updatedProperties) where T : class
        {

            //dbEntityEntry.State = EntityState.Modified; --- I cannot do this.
            // var Entities = ctx.Model.GetEntityTypes().Select(t => t.ClrType).ToList();
            //Ensure only modified fields are updated.
            var EntityEntry = context.Entry(entity);
            if (updatedProperties.Any() && entity != null)
            {
                //update explicitly mentioned properties
                foreach (var property in updatedProperties)
                {
                    EntityEntry.Property(property).IsModified = true;
                }
            }
            //else
            //{
            //    //no items mentioned, so find out the updated entries
            //    foreach (var property in dbEntityEntry.OriginalValues.Properties)
            //    {
            //        var original = dbEntityEntry.OriginalValues.GetValue<object>(property);
            //        var current = dbEntityEntry.CurrentValues.GetValue<object>(property);
            //        if (original != null && !original.Equals(current))
            //            dbEntityEntry.Property(property).IsModified = true;
            //    }
            //}
        }

    }
}
