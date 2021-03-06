﻿#region credits
// ***********************************************************************
// Assembly	: DemoApplication.Infrastructure
// Author	: Rod Johnson
// Created	: 03-19-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-28-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Infrastructure.Profiles
{
    #region

    using System.Threading;
    using System.Web;
    using System.Web.Mvc;
    using Core.Interfaces.Service;
    using Core.Model;

    #endregion

    public class UserProfile
    {
        public static User Current
        {
            get
            {                
                var user = HttpContext.Current.Session["UserProfile"] as User;
                if (user == null)
                {
                    HttpContext.Current.Session["UserProfile"] = user =
                            DependencyResolver.Current.GetService<IUserAccountService>()
                                              .GetByUsername(Thread.CurrentPrincipal.Identity.Name);
                }
                return user;
            }
        }
    }
}