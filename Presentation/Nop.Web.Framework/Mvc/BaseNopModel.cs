using System.Collections.Generic;
using System.Web.Mvc;

namespace F1sh.Web.Framework.Mvc
{
    /// <summary>
    /// Base F1shCommerce model
    /// </summary>
    [ModelBinder(typeof(F1shModelBinder))]
    public partial class BaseF1shModel
    {
        public BaseF1shModel()
        {
            this.CustomProperties = new Dictionary<string, object>();
            PostInitialize();
        }

        public virtual void BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {
            
        }

        /// <summary>
        /// Use this property to store any custom value for your models. 
        /// </summary>
        public Dictionary<string, object> CustomProperties { get; set; }
    }

    /// <summary>
    /// Base F1shCommerce entity model
    /// </summary>
    public partial class BaseF1shEntityModel : BaseF1shModel
    {
        public virtual int Id { get; set; }
    }
}
