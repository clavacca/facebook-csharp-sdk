// <copyright file="DynamicDictionaryTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for DynamicDictionary</summary>
    [PexClass(typeof(DynamicDictionary))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DynamicDictionaryTest
    {
        /// <summary>Test stub for Add(String, Object)</summary>
        [PexMethod]
        public void Add(
            [PexAssumeUnderTest]DynamicDictionary target,
            string key,
            object value
        )
        {
            target.Add(key, value);
            // TODO: add assertions to method DynamicDictionaryTest.Add(DynamicDictionary, String, Object)
        }

        /// <summary>Test stub for Add(KeyValuePair`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public void Add01(
            [PexAssumeUnderTest]DynamicDictionary target,
            KeyValuePair<string, object> item
        )
        {
            target.Add(item);
            // TODO: add assertions to method DynamicDictionaryTest.Add01(DynamicDictionary, KeyValuePair`2<String,Object>)
        }

        /// <summary>Test stub for Clear()</summary>
        [PexMethod]
        public void Clear([PexAssumeUnderTest]DynamicDictionary target)
        {
            target.Clear();
            // TODO: add assertions to method DynamicDictionaryTest.Clear(DynamicDictionary)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public DynamicDictionary Constructor()
        {
            DynamicDictionary target = new DynamicDictionary();
            return target;
            // TODO: add assertions to method DynamicDictionaryTest.Constructor()
        }

        /// <summary>Test stub for Contains(KeyValuePair`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public bool Contains(
            [PexAssumeUnderTest]DynamicDictionary target,
            KeyValuePair<string, object> item
        )
        {
            bool result = target.Contains(item);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.Contains(DynamicDictionary, KeyValuePair`2<String,Object>)
        }

        /// <summary>Test stub for ContainsKey(String)</summary>
        [PexMethod]
        public bool ContainsKey([PexAssumeUnderTest]DynamicDictionary target, string key)
        {
            bool result = target.ContainsKey(key);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.ContainsKey(DynamicDictionary, String)
        }

        /// <summary>Test stub for CopyTo(KeyValuePair`2&lt;String,Object&gt;[], Int32)</summary>
        [PexMethod]
        public void CopyTo(
            [PexAssumeUnderTest]DynamicDictionary target,
            KeyValuePair<string, object>[] array,
            int arrayIndex
        )
        {
            target.CopyTo(array, arrayIndex);
            // TODO: add assertions to method DynamicDictionaryTest.CopyTo(DynamicDictionary, KeyValuePair`2<String,Object>[], Int32)
        }

        /// <summary>Test stub for Count</summary>
        [PexMethod]
        public void CountGet([PexAssumeUnderTest]DynamicDictionary target)
        {
            int result = target.Count;
            // TODO: add assertions to method DynamicDictionaryTest.CountGet(DynamicDictionary)
        }

        /// <summary>Test stub for GetDynamicMemberNames()</summary>
        [PexMethod]
        public IEnumerable<string> GetDynamicMemberNames([PexAssumeUnderTest]DynamicDictionary target)
        {
            IEnumerable<string> result = target.GetDynamicMemberNames();
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.GetDynamicMemberNames(DynamicDictionary)
        }

        /// <summary>Test stub for GetEnumerator()</summary>
        [PexMethod]
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator([PexAssumeUnderTest]DynamicDictionary target)
        {
            IEnumerator<KeyValuePair<string, object>> result = target.GetEnumerator();
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.GetEnumerator(DynamicDictionary)
        }

        /// <summary>Test stub for IsReadOnly</summary>
        [PexMethod]
        public void IsReadOnlyGet([PexAssumeUnderTest]DynamicDictionary target)
        {
            bool result = target.IsReadOnly;
            // TODO: add assertions to method DynamicDictionaryTest.IsReadOnlyGet(DynamicDictionary)
        }

        /// <summary>Test stub for Item</summary>
        [PexMethod]
        public void ItemGetSet(
            [PexAssumeUnderTest]DynamicDictionary target,
            string key,
            object value
        )
        {
            target[key] = value;
            object result = target[key];
            PexAssert.AreEqual<object>(value, result);
            // TODO: add assertions to method DynamicDictionaryTest.ItemGetSet(DynamicDictionary, String, Object)
        }

        /// <summary>Test stub for Keys</summary>
        [PexMethod]
        public void KeysGet([PexAssumeUnderTest]DynamicDictionary target)
        {
            ICollection<string> result = target.Keys;
            // TODO: add assertions to method DynamicDictionaryTest.KeysGet(DynamicDictionary)
        }

        /// <summary>Test stub for Remove(String)</summary>
        [PexMethod]
        public bool Remove([PexAssumeUnderTest]DynamicDictionary target, string key)
        {
            bool result = target.Remove(key);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.Remove(DynamicDictionary, String)
        }

        /// <summary>Test stub for Remove(KeyValuePair`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public bool Remove01(
            [PexAssumeUnderTest]DynamicDictionary target,
            KeyValuePair<string, object> item
        )
        {
            bool result = target.Remove(item);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.Remove01(DynamicDictionary, KeyValuePair`2<String,Object>)
        }

        /// <summary>Test stub for TryGetMember(GetMemberBinder, Object&amp;)</summary>
        [PexMethod]
        public bool TryGetMember(
            [PexAssumeUnderTest]DynamicDictionary target,
            GetMemberBinder binder,
            out object result
        )
        {
            bool result01 = target.TryGetMember(binder, out result);
            return result01;
            // TODO: add assertions to method DynamicDictionaryTest.TryGetMember(DynamicDictionary, GetMemberBinder, Object&)
        }

        /// <summary>Test stub for TryGetValue(String, Object&amp;)</summary>
        [PexMethod]
        public bool TryGetValue(
            [PexAssumeUnderTest]DynamicDictionary target,
            string key,
            out object value
        )
        {
            bool result = target.TryGetValue(key, out value);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.TryGetValue(DynamicDictionary, String, Object&)
        }

        /// <summary>Test stub for TrySetMember(SetMemberBinder, Object)</summary>
        [PexMethod]
        public bool TrySetMember(
            [PexAssumeUnderTest]DynamicDictionary target,
            SetMemberBinder binder,
            object value
        )
        {
            bool result = target.TrySetMember(binder, value);
            return result;
            // TODO: add assertions to method DynamicDictionaryTest.TrySetMember(DynamicDictionary, SetMemberBinder, Object)
        }

        /// <summary>Test stub for Values</summary>
        [PexMethod]
        public void ValuesGet([PexAssumeUnderTest]DynamicDictionary target)
        {
            ICollection<object> result = target.Values;
            // TODO: add assertions to method DynamicDictionaryTest.ValuesGet(DynamicDictionary)
        }
    }
}
