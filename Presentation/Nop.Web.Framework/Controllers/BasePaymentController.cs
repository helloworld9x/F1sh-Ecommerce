﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace F1sh.Web.Framework.Controllers
{
    /// <summary>
    /// Base controller for payment plugins
    /// </summary>
    public abstract class BasePaymentController : BasePluginController
    {
        public abstract IList<string> ValidatePaymentForm(FormCollection form);

        //public abstract ProcessPaymentRequest GetPaymentInfo(FormCollection form);
    }
}
