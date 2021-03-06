using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zniffer.Levenshtein;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace CustomExtensions.Tests
{
    public partial class StringExtensionTest {

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest432()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("", "", 0, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest280()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ((string)null, (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest26()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("", "\0", 0, true, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest823()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ("\0", (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest349()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("", "\0", 2, true, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest382()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ("\0\0", "", int.MinValue, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest235()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("HIH", "i", 2, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(3, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest400()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("HIH", "i", 2, true, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest502()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ("\0h\0\0\0\0", "\b", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest628()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ("\0h\0\0\0\0", "h", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest13()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("Eh", "d", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixSingleThreadTest194()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixSingleThreadTest("IHh", "h", 0, true, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(2, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(OverflowException))]
public void LevenshteinMultiMatrixSingleThreadTestThrowsOverflowException52401()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixSingleThreadTest
                             ("\0h\0\0\0\0", "\b\b\b\b\b\b", 0, false, false);
}
    }
}
