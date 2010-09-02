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
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Facebook
{
    public partial class FacebookAsyncResultTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookAsyncResultTest))]
public void CompletedSynchronouslyGet962()
{
    FacebookAsyncResult facebookAsyncResult;
    object s0 = new object();
    facebookAsyncResult =
      new FacebookAsyncResult((object)null, s0, (WaitHandle)null, 
                              false, false, (FacebookApiException)null);
    this.CompletedSynchronouslyGet(facebookAsyncResult);
    Assert.IsNotNull((object)facebookAsyncResult);
    Assert.IsNull(facebookAsyncResult.Error);
    Assert.IsNull(facebookAsyncResult.Result);
    Assert.IsNotNull(facebookAsyncResult.AsyncState);
    Assert.IsNull(facebookAsyncResult.AsyncWaitHandle);
    Assert.AreEqual<bool>(false, facebookAsyncResult.CompletedSynchronously);
    Assert.AreEqual<bool>(false, facebookAsyncResult.IsCompleted);
}
    }
}
