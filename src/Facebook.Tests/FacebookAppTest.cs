// <copyright file="FacebookAppTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookApp</summary>
    [PexClass(typeof(FacebookApp))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookAppTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public FacebookApp Constructor()
        {
            FacebookApp target = new FacebookApp();
            return target;
            // TODO: add assertions to method FacebookAppTest.Constructor()
        }

        /// <summary>Test stub for .ctor(IFacebookSettings)</summary>
        [PexMethod]
        public FacebookApp Constructor01(IFacebookSettings settings)
        {
            FacebookApp target = new FacebookApp(settings);
            return target;
            // TODO: add assertions to method FacebookAppTest.Constructor01(IFacebookSettings)
        }

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public FacebookApp Constructor02(string accessToken)
        {
            FacebookApp target = new FacebookApp(accessToken);
            return target;
            // TODO: add assertions to method FacebookAppTest.Constructor02(String)
        }

        /// <summary>Test stub for GetLoginStatusUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLoginStatusUrl(
            [PexAssumeUnderTest]FacebookApp target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLoginStatusUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppTest.GetLoginStatusUrl(FacebookApp, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for GetLoginUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLoginUrl(
            [PexAssumeUnderTest]FacebookApp target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLoginUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppTest.GetLoginUrl(FacebookApp, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for GetLogoutUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLogoutUrl(
            [PexAssumeUnderTest]FacebookApp target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLogoutUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppTest.GetLogoutUrl(FacebookApp, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for MaxRetries</summary>
        [PexMethod]
        public void MaxRetriesGetSet([PexAssumeUnderTest]FacebookApp target, int value)
        {
            target.MaxRetries = value;
            int result = target.MaxRetries;
            PexAssert.AreEqual<int>(value, result);
            // TODO: add assertions to method FacebookAppTest.MaxRetriesGetSet(FacebookApp, Int32)
        }

        /// <summary>Test stub for RetryDelay</summary>
        [PexMethod]
        public void RetryDelayGetSet([PexAssumeUnderTest]FacebookApp target, int value)
        {
            target.RetryDelay = value;
            int result = target.RetryDelay;
            PexAssert.AreEqual<int>(value, result);
            // TODO: add assertions to method FacebookAppTest.RetryDelayGetSet(FacebookApp, Int32)
        }

        /// <summary>Test stub for Session</summary>
        [PexMethod]
        public void SessionGetSet([PexAssumeUnderTest]FacebookApp target, FacebookSession value)
        {
            target.Session = value;
            FacebookSession result = target.Session;
            PexAssert.AreEqual<FacebookSession>(value, result);
            // TODO: add assertions to method FacebookAppTest.SessionGetSet(FacebookApp, FacebookSession)
        }

        /// <summary>Test stub for SignedRequest</summary>
        [PexMethod]
        public void SignedRequestGet([PexAssumeUnderTest]FacebookApp target)
        {
            FacebookSignedRequest result = target.SignedRequest;
            // TODO: add assertions to method FacebookAppTest.SignedRequestGet(FacebookApp)
        }
    }
}
