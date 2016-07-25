using System.Web.Mvc;

namespace F1sh.Web.Framework.Mvc
{
    public class F1shModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = base.BindModel(controllerContext, bindingContext);
            if (model is BaseF1shModel)
            {
                ((BaseF1shModel)model).BindModel(controllerContext, bindingContext);
            }
            return model;
        }
    }
}
