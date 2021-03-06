using System.Data.Entity.ModelConfiguration;

namespace F1sh.Core.Domain
{
    public abstract class GoqEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected GoqEntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }
    }
}