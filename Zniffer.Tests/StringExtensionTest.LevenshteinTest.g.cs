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
public void LevenshteinTest718()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā", 0, false, false, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest522()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā\0", 0, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest367()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("ā", "āĀ", 2, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest970()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinTest("Ā", "Ā", 0, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest770()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("ā", "Ā\0", 0, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest431()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "h", 0, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest537()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "ĀĀ", 0, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest298()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "\0\0", 1, false, true, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest295()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā", 0, false, false, LevenshteinMode.MultiMatrixParallelCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest577()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("Ā", "Ā", int.MinValue, 
                                              false, false, LevenshteinMode.MultiMatrixParallelCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest421()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinTest("Ā", "Ā", 0, false, true, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest562()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā\0\0", 0, false, true, LevenshteinMode.ThreeDimMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest548()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā", int.MinValue, false, true, LevenshteinMode.ThreeDimMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest891()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("\0iĀ\0", "\0iĀ\0", 0, false, false, LevenshteinMode.SingleMatixCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest812()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "h", 0, false, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest39()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("»Ā", "»", 0, false, false, LevenshteinMode.SingleMatixCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest586()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "\b\b\b\bဈ\b", 0, false, false, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNull((object)levenshteinMatches);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest400()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("õiI\0", "P", int.MinValue, 
                                              false, false, LevenshteinMode.ThreeDimMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest32()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("#>»\0", "#>»", int.MinValue, 
                                              false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest41()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinTest("", "", 0, false, false, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest173()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", (string)null, 0, false, false, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest580()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "\0\0", 2, false, true, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest783()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "hh", 0, true, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest673()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "h", 1, false, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest882()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("ā", "āĀ", int.MinValue, false, true, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest990()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("Ā", "Ā", int.MinValue, 
                                              false, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest198()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("a À", "a\0\0À", int.MinValue, false, true, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest01()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "h", 1, true, false, LevenshteinMode.MultiMatrixParallelCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest246()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("õiI\0", "P", 0, false, false, LevenshteinMode.MultiMatrixParallelCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest76()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("ĀĀ ", "Ā", 0, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest247()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest((string)null, (string)null, 0, 
                                              false, false, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest949()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā", 1, false, true, LevenshteinMode.ThreeDimMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(2, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest120()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "»", 0, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest311()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("", "»", 0, false, false, LevenshteinMode.SingleMatixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest661()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("耈Ā ", "耈", 4, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest471()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("ĀĀ\0 }", "Ā", 0, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest306()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("ĀĀ\0 }", "Ā", 2147483646, 
                                              false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(4, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(1, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest963()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("", "»", 0, false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest385()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("", "»", 0, false, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest54802()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("", "»", 0, false, false, LevenshteinMode.MultiMatrixParallelCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest549()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinTest("", "»", 0, false, false, LevenshteinMode.SplitDualRowCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest708()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("", "»", 0, false, false, LevenshteinMode.ThreeDimMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
public void LevenshteinTest757()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest(" ĀĀ\0", "#", int.MinValue, 
                                              false, false, LevenshteinMode.SplitForSingleMatrixCPU);
    Assert.IsNotNull((object)levenshteinMatches);
    Assert.IsNotNull((object)(levenshteinMatches.foundMatches));
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Capacity);
    Assert.AreEqual<int>(0, levenshteinMatches.foundMatches.Count);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void LevenshteinTestThrowsArgumentOutOfRangeException716()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest("ࠀ", 
                                              "ࠀ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0", 
                                              0, false, false, LevenshteinMode.MultiMatrixParallelCPU);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(IndexOutOfRangeException))]
public void LevenshteinTestThrowsIndexOutOfRangeException757()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "Ā\0", 0, false, true, LevenshteinMode.ThreeDimMatrixCPU);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(IndexOutOfRangeException))]
public void LevenshteinTestThrowsIndexOutOfRangeException682()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "ĀĀ", 0, false, true, LevenshteinMode.ThreeDimMatrixCPU);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(NotImplementedException))]
public void LevenshteinTestThrowsNotImplementedException692()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches =
      this.LevenshteinTest("Ā", "Ā", int.MinValue, false, true, (LevenshteinMode)6);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(OverflowException))]
public void LevenshteinTestThrowsOverflowException284()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā\0", "Ā»\0\0\0", 0, false, true, LevenshteinMode.ThreeDimMatrixCPU);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionTest))]
[ExpectedException(typeof(OverflowException))]
public void LevenshteinTestThrowsOverflowException575()
{
    LevenshteinMatches levenshteinMatches;
    levenshteinMatches = this.LevenshteinTest
                             ("Ā", "hhh", 0, false, false, LevenshteinMode.MultiMatrixSingleThreadCPU);
}
    }
}
