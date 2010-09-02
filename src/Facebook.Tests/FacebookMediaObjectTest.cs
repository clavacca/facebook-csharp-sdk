// <copyright file="FacebookMediaObjectTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookMediaObject</summary>
    [PexClass(typeof(FacebookMediaObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookMediaObjectTest
    {
        /// <summary>Test stub for ContentType</summary>
        [PexMethod]
        public void ContentTypeGetSet([PexAssumeUnderTest]FacebookMediaObject target, string value)
        {
            target.ContentType = value;
            string result = target.ContentType;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookMediaObjectTest.ContentTypeGetSet(FacebookMediaObject, String)
        }

        /// <summary>Test stub for FileName</summary>
        [PexMethod]
        public void FileNameGetSet([PexAssumeUnderTest]FacebookMediaObject target, string value)
        {
            target.FileName = value;
            string result = target.FileName;
            PexAssert.AreEqual<string>(value, result);
            // TODO: add assertions to method FacebookMediaObjectTest.FileNameGetSet(FacebookMediaObject, String)
        }

        /// <summary>Test stub for Value</summary>
        [PexMethod]
        public void ValueGetSet([PexAssumeUnderTest]FacebookMediaObject target, byte[] value)
        {
            target.Value = value;
            byte[] result = target.Value;
            PexAssert.AreEqual<byte[]>(value, result);
            // TODO: add assertions to method FacebookMediaObjectTest.ValueGetSet(FacebookMediaObject, Byte[])
        }
    }
}
