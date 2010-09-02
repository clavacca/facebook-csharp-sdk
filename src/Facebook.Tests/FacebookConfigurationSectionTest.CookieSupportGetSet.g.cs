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
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Exceptions;

namespace Facebook
{
    public partial class FacebookConfigurationSectionTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookConfigurationSectionTest))]
public void CookieSupportGetSet147()
{
    FacebookConfigurationSection facebookConfigurationSection;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    this.CookieSupportGetSet(facebookConfigurationSection, false);
    Assert.IsNotNull((object)facebookConfigurationSection);
    Assert.IsNotNull
        (((ConfigurationSection)facebookConfigurationSection).SectionInformation);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .SectionName);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .Name);
    Assert.AreEqual<ConfigurationAllowDefinition>
        (ConfigurationAllowDefinition.Everywhere, 
         ((ConfigurationSection)facebookConfigurationSection).SectionInformation
           .AllowDefinition);
    Assert.AreEqual<ConfigurationAllowExeDefinition>
        (ConfigurationAllowExeDefinition.MachineToApplication, 
         ((ConfigurationSection)facebookConfigurationSection).SectionInformation
           .AllowExeDefinition);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .ConfigSource);
    Assert.AreEqual<string>((string)null, 
                            ((ConfigurationSection)facebookConfigurationSection).SectionInformation
                              .Type);
    Assert.AreEqual<bool>
        (false, ((ConfigurationElement)facebookConfigurationSection).LockItem);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookConfigurationSectionTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void CookieSupportGetSetThrowsPexAssertFailedException149()
{
    FacebookConfigurationSection facebookConfigurationSection;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    this.CookieSupportGetSet
        (facebookConfigurationSection, PexSafeHelpers.ByteToBoolean((byte)128));
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookConfigurationSectionTest))]
public void CookieSupportGetSet272()
{
    FacebookConfigurationSection facebookConfigurationSection;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = true;
    this.CookieSupportGetSet(facebookConfigurationSection, false);
    Assert.IsNotNull((object)facebookConfigurationSection);
    Assert.IsNotNull
        (((ConfigurationSection)facebookConfigurationSection).SectionInformation);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .SectionName);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .Name);
    Assert.AreEqual<ConfigurationAllowDefinition>
        (ConfigurationAllowDefinition.Everywhere, 
         ((ConfigurationSection)facebookConfigurationSection).SectionInformation
           .AllowDefinition);
    Assert.AreEqual<ConfigurationAllowExeDefinition>
        (ConfigurationAllowExeDefinition.MachineToApplication, 
         ((ConfigurationSection)facebookConfigurationSection).SectionInformation
           .AllowExeDefinition);
    Assert.AreEqual<string>
        ("", ((ConfigurationSection)facebookConfigurationSection).SectionInformation
               .ConfigSource);
    Assert.AreEqual<string>((string)null, 
                            ((ConfigurationSection)facebookConfigurationSection).SectionInformation
                              .Type);
    Assert.AreEqual<bool>
        (true, ((ConfigurationElement)facebookConfigurationSection).LockItem);
}
    }
}
