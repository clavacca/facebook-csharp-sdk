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
    public partial class FacebookOAuthExceptionTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookOAuthExceptionTest))]
public void Constructor03682()
{
    FacebookOAuthException facebookOAuthException;
    facebookOAuthException =
      this.Constructor03((string)null, (string)null, (Exception)null);
    Assert.IsNotNull((object)facebookOAuthException);
    Assert.AreEqual<string>
        ((string)null, ((FacebookApiException)facebookOAuthException).ErrorType);
    Assert.IsNull(((Exception)facebookOAuthException).InnerException);
}
    }
}
