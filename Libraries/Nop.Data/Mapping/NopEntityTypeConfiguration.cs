using System.Data.Entity.ModelConfiguration;

namespace F1sh.Data.Mapping
{
    public abstract class F1shEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected F1shEntityTypeConfiguration()
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