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
using Microsoft.Pex.Framework.Generated;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    public partial class DynamicDictionaryTest
    {
[TestMethod]
[PexGeneratedBy(typeof(DynamicDictionaryTest))]
public void GetEnumerator403()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      DynamicDictionary dynamicDictionary;
      IEnumerator<KeyValuePair<string, object>> iEnumerator;
      dynamicDictionary = new DynamicDictionary();
      iEnumerator = this.GetEnumerator(dynamicDictionary);
      disposables.Add((IDisposable)iEnumerator);
      disposables.Dispose();
      Assert.IsNotNull((object)dynamicDictionary);
      Assert.AreEqual<bool>(false, dynamicDictionary.IsReadOnly);
    }
}
    }
}
