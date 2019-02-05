using CustomModelBinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinder
{
    public class MyModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // создаем новую или работаем с готовой моделью.
            MyModel model = (MyModel)bindingContext.Model ?? new MyModel();

            bool hasPrefix = bindingContext.ValueProvider.ContainsPrefix(bindingContext.ModelName);
            
            string searchPrefix = hasPrefix ? bindingContext.ModelName + "." : "";

            model.Prop1 = int.Parse(GetValue(bindingContext, searchPrefix, "Prop1"));
            model.Prop2 = GetValue(bindingContext, searchPrefix, "Prop2");

            return model;
        }

        private string GetValue(ModelBindingContext bindingContext, string prefix, string key)
        {
            ValueProviderResult vpr = bindingContext.ValueProvider.GetValue(prefix + key);
            return vpr == null ? null : vpr.AttemptedValue;
        }
    }
}