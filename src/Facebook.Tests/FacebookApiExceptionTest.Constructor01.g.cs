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

namespace Facebook
{
    public partial class FacebookApiExceptionTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookApiExceptionTest))]
public void Constructor01111()
{
    FacebookApiException facebookApiException;
    facebookApiException = this.Constructor01((string)null, (string)null);
    Assert.IsNotNull((object)facebookApiException);
    Assert.AreEqual<string>((string)null, facebookApiException.ErrorType);
    Assert.IsNull(((Exception)facebookApiException).InnerException);
}
    }
}
