using FluentValidation;

namespace F1sh.Web.Framework.Validators
{
    public abstract class BaseF1shValidator<T> : AbstractValidator<T> where T : class
    {
        protected BaseF1shValidator()
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