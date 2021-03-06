﻿using System.Web.Mvc;
using Frapid.Areas;

namespace InitiativeNepal
{
    public class AreaRegistration : FrapidAreaRegistration
    {
        public override string AreaName => "InitiativeNepal";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.LowercaseUrls = true;
            context.Routes.MapMvcAttributeRoutes();
        }
    }
}