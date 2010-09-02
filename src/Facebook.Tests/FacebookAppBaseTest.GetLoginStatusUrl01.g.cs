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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using System.Configuration;

namespace Facebook
{
    public partial class FacebookAppBaseTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetLoginStatusUrl01ThrowsInvalidOperationException709()
{
    FacebookApp facebookApp;
    Uri uri;
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
    uri = this.GetLoginStatusUrl01
              ((FacebookAppBase)facebookApp, (IDictionary<string, object>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetLoginStatusUrl01ThrowsInvalidOperationException351()
{
    FacebookConfigurationSection facebookConfigurationSection;
    FacebookApp facebookApp;
    Uri uri;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    facebookApp = new FacebookApp((IFacebookSettings)facebookConfigurationSection);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    uri = this.GetLoginStatusUrl01
              ((FacebookAppBase)facebookApp, (IDictionary<string, object>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppBaseTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetLoginStatusUrl01ThrowsInvalidOperationException701()
{
    FacebookApp facebookApp;
    Uri uri;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = true;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = -1;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    uri = this.GetLoginStatusUrl01
              ((FacebookAppBase)facebookApp, (IDictionary<string, object>)null);
}
    }
}
