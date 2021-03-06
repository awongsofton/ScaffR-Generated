﻿#region credits
// ***********************************************************************
// Assembly	: DemoApplication
// Author	: Rod Johnson
// Created	: 02-24-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-28-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Filters
{
    #region

    using System.Web.Mvc;

    #endregion

    public class ShowBreadcrumb : ActionFilterAttribute
    {
        private readonly bool _show;

        public ShowBreadcrumb(bool show = true)
        {
            _show = show;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.ShowBreadcrumb = _show;

            base.OnActionExecuted(filterContext);
        }
    }
}