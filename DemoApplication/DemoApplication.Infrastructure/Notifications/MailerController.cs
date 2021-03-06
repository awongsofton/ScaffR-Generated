﻿#region credits
// ***********************************************************************
// Assembly	: DemoApplication.Infrastructure
// Author	: Rod Johnson
// Created	: 03-26-2013
// 
// Last Modified By : Rod Johnson
// Last Modified On : 03-28-2013
// ***********************************************************************
#endregion
namespace DemoApplication.Infrastructure.Notifications
{
    #region

    using System.Web;
    using ActionMailer.Net.Standalone;
    using Core.Model;

    #endregion

    public class MailerController : RazorMailerBase
    {
        public override string ViewPath
        {
            get
            {
                var path = HttpContext.Current.Server.MapPath("~/Views/Templates");
                return path;
            }
        }

        public RazorEmailResult SendAccountCreate(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Account Created";
            return Email("SendAccountCreate", model);            
        }

        public RazorEmailResult SendAccountVerified(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Account Verification";
            return Email("SendAccountVerified", model); 
        }

        public RazorEmailResult SendPasswordReset(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Password Reset";
            return Email("SendPasswordReset", model);
        }

        public RazorEmailResult SendAccountNameReminder(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Here's your missing Username";
            return Email("SendAccountNameReminder", model);
        }

        public RazorEmailResult SendPasswordChangeNotice(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Your Password has been updated";
            return Email("SendPasswordChangeNotice", model);
        }

        public RazorEmailResult SendAccountDelete(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Delete Account";
            return Email("SendAccountDelete", model);
        }

        public RazorEmailResult SendChangeEmailRequestNotice(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Email Request Notice";
            return Email("SendChangeEmailRequestNotice", model);
        }

        public RazorEmailResult SendEmailChangedNotice(User model)
        {
            To.Add(model.Email);
            From = "noreply@scaffr.com";
            Subject = "Email Changed Notification";
            return Email("SendEmailChangedNotice", model);
        }

    }
}
