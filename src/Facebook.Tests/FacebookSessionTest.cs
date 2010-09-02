// <copyright file="FacebookSessionTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookSession</summary>
    [PexClass(typeof(FacebookSession))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookSessionTest
    {
        /// <summary>Test stub for AccessToken</summary>
        [PexMethod]
        public void AccessTokenGetSet([PexAssumeUnderTest]FacebookSession target, string value)
        {
            target.AccessToken = value;
            string result = target.AccessToken;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSessionTest.AccessTokenGetSet(FacebookSession, String)
        }

        /// <summary>Test stub for BaseDomain</summary>
        [PexMethod]
        public void BaseDomainGetSet([PexAssumeUnderTest]FacebookSession target, string value)
        {
            target.BaseDomain = value;
            string result = target.BaseDomain;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSessionTest.BaseDomainGetSet(FacebookSession, String)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public FacebookSession Constructor()
        {
            FacebookSession target = new FacebookSession();
            return target;
            // TODO: add assertions to method FacebookSessionTest.Constructor()
        }

        /// <summary>Test stub for Dictionary</summary>
        [PexMethod]
        public void DictionaryGet([PexAssumeUnderTest]FacebookSession target)
        {
            IDictionary<string, string> result = target.Dictionary;
            // TODO: add assertions to method FacebookSessionTest.DictionaryGet(FacebookSession)
        }

        /// <summary>Test stub for Expires</summary>
        [PexMethod]
        public void ExpiresGetSet([PexAssumeUnderTest]FacebookSession target, DateTime value)
        {
            target.Expires = value;
            DateTime result = target.Expires;
            PexAssert.AreEqual<DateTime>(value, result);
            // TODO: add assertions to method FacebookSessionTest.ExpiresGetSet(FacebookSession, DateTime)
        }

        /// <summary>Test stub for Secret</summary>
        [PexMethod]
        public void SecretGetSet([PexAssumeUnderTest]FacebookSession target, string value)
        {
            target.Secret = value;
            string result = target.Secret;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSessionTest.SecretGetSet(FacebookSession, String)
        }

        /// <summary>Test stub for SessionKey</summary>
        [PexMethod]
        public void SessionKeyGetSet([PexAssumeUnderTest]FacebookSession target, string value)
        {
            target.SessionKey = value;
            string result = target.SessionKey;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSessionTest.SessionKeyGetSet(FacebookSession, String)
        }

        /// <summary>Test stub for Signature</summary>
        [PexMethod]
        public void SignatureGetSet([PexAssumeUnderTest]FacebookSession target, string value)
        {
            target.Signature = value;
            string result = target.Signature;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookSessionTest.SignatureGetSet(FacebookSession, String)
        }

        /// <summary>Test stub for UserId</summary>
        [PexMethod]
        public void UserIdGetSet([PexAssumeUnderTest]FacebookSession target, long value)
        {
            target.UserId = value;
            long result = target.UserId;
            PexAssert.AreEqual<long>(value, result);
            // TODO: add assertions to method FacebookSessionTest.UserIdGetSet(FacebookSession, Int64)
        }
    }
}
