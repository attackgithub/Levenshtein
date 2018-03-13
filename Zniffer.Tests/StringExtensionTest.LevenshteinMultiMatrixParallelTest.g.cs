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
public void LevenshteinMultiMatrixParallelTest491()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("", (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest119()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("h", "h", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest443()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("\b", "\b", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest528()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("\0", "\0", 0, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest654()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("\0", "\0", 2, false, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(2, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest854()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("\0", "\0", 2, true, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest204()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("h\0", "h\0", 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest823()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinMultiMatrixParallelTest("\0", (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void LevenshteinMultiMatrixParallelTestThrowsArgumentOutOfRangeException86101()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixParallelTest
                             (new string('h', 255), new string('h', 243), 0, false, false);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest244()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixParallelTest
                             ("\0\0\0\0\0\0", "\0", int.MinValue, true, true);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(8, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(6, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinMultiMatrixParallelTest203()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinMultiMatrixParallelTest
                             ((string)null, (string)null, 0, false, false);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNull((object)(levenshteinMatches.foundMatches));
}
    }
}
