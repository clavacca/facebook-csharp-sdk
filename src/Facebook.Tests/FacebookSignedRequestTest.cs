// <copyright file="FacebookSignedRequestTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookSignedRequest</summary>
    [PexClass(typeof(FacebookSignedRequest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookSignedRequestTest
    {
        /// <summary>Test stub for AccessToken</summary>
        [PexMethod]
        public void AccessTokenGetSet([PexAssumeUnderTest]FacebookSignedRequest target, string value)
        {
            target.AccessToken = value;
            string result = target.AccessToken;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSignedRequestTest.AccessTokenGetSet(FacebookSignedRequest, String)
        }

        /// <summary>Test stub for Algorithm</summary>
        [PexMethod]
        public void AlgorithmGetSet([PexAssumeUnderTest]FacebookSignedRequest target, string value)
        {
            target.Algorithm = value;
            string result = target.Algorithm;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSignedRequestTest.AlgorithmGetSet(FacebookSignedRequest, String)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public FacebookSignedRequest Constructor()
        {
            FacebookSignedRequest target = new FacebookSignedRequest();
            return target;
            // TODO: add assertions to method FacebookSignedRequestTest.Constructor()
        }

        /// <summary>Test stub for Dictionary</summary>
        [PexMethod]
        public void DictionaryGet([PexAssumeUnderTest]FacebookSignedRequest target)
        {
            IDictionary<string, string> result = target.Dictionary;
            // TODO: add assertions to method FacebookSignedRequestTest.DictionaryGet(FacebookSignedRequest)
        }

        /// <summary>Test stub for Expires</summary>
        [PexMethod]
        public void ExpiresGetSet(
            [PexAssumeUnderTest]FacebookSignedRequest target,
            DateTime value
        )
        {
            target.Expires = value;
            DateTime result = target.Expires;
            PexAssert.AreEqual<DateTime>(value, result);
            // TODO: add assertions to method FacebookSignedRequestTest.ExpiresGetSet(FacebookSignedRequest, DateTime)
        }

        /// <summary>Test stub for ProfileId</summary>
        [PexMethod]
        public void ProfileIdGetSet([PexAssumeUnderTest]FacebookSignedRequest target, long value)
        {
            target.ProfileId = value;
            long result = target.ProfileId;
            PexAssert.AreEqual<long>(value, result);
            // TODO: add assertions to method FacebookSignedRequestTest.ProfileIdGetSet(FacebookSignedRequest, Int64)
        }

        /// <summary>Test stub for UserId</summary>
        [PexMethod]
        public void UserIdGetSet([PexAssumeUnderTest]FacebookSignedRequest target, long value)
        {
            target.UserId = value;
            long result = target.UserId;
            PexAssert.AreEqual<long>(value, result);
            // TODO: add assertions to method FacebookSignedRequestTest.UserIdGetSet(FacebookSignedRequest, Int64)
        }
    }
}
