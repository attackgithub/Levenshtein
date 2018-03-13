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
public void LevenshteinThreeDimMatrixCPUTest401()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\0", "\0\0\0", 0, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest64()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\b\b\b", "\b", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest605()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("", "", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest280()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinThreeDimMatrixCPUTest
                             ((string)null, (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest823()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\0", (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest803()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinThreeDimMatrixCPUTest
                             ("\b", "\b\b\b", int.MinValue, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest665()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\b\b(", "\b", 2, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest833()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("", "\0", 2, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(2, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinThreeDimMatrixCPUTest854()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\b\b\b\b", "\b", 2, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(8, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(5, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(IndexOutOfRangeException))]
public void LevenshteinThreeDimMatrixCPUTestThrowsIndexOutOfRangeException11301()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\0h", "hH", 0, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(IndexOutOfRangeException))]
public void LevenshteinThreeDimMatrixCPUTestThrowsIndexOutOfRangeException98101()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("h", "\0h", int.MinValue, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(OverflowException))]
public void LevenshteinThreeDimMatrixCPUTestThrowsOverflowException36101()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinThreeDimMatrixCPUTest("\0h", "\0h\0\0\0\0", 0, false, false);
}
    }
}
