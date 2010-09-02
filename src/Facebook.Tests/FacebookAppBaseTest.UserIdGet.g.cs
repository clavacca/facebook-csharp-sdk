// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using System.Configuration;

namespace Facebook
{
    public partial class FacebookAppBaseTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
public void UserIdGet295()
{
    FacebookApp facebookApp;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    this.UserIdGet((FacebookAppBase)facebookApp);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
public void UserIdGet599()
{
    FacebookApp facebookApp;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = true;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    this.UserIdGet((FacebookAppBase)facebookApp);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
public void UserIdGet207()
{
    FacebookSession facebookSession;
    FacebookApp facebookApp;
    facebookSession = new FacebookSession();
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = facebookSession;
    this.UserIdGet((FacebookAppBase)facebookApp);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
public void UserIdGet837()
{
    FacebookConfigurationSection facebookConfigurationSection;
    FacebookApp facebookApp;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    facebookApp = new FacebookApp((IFacebookSettings)facebookConfigurationSection);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    this.UserIdGet((FacebookAppBase)facebookApp);
}
    }
}
