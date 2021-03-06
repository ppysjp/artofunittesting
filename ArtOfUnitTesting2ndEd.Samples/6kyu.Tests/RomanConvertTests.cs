using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _6kyu.Tests
{

	[TestFixture]
	public class RomanConvertTests
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(7, "VII")]
		[TestCase(8, "VIII")]
		[TestCase(9, "IX")]
		[TestCase(10, "X")]
		[TestCase(11, "XI")]
		[TestCase(12, "XII")]
		[TestCase(13, "XIII")]
		[TestCase(14, "XIV")]
		[TestCase(15, "XV")]
		[TestCase(16, "XVI")]
		[TestCase(17, "XVII")]
		[TestCase(18, "XVIII")]
		[TestCase(19, "XIX")]
		[TestCase(20, "XX")]
		[TestCase(21, "XXI")]
		[TestCase(22, "XXII")]
		[TestCase(23, "XXIII")]
		[TestCase(24, "XXIV")]
		[TestCase(25, "XXV")]
		[TestCase(26, "XXVI")]
		[TestCase(27, "XXVII")]
		[TestCase(28, "XXVIII")]
		[TestCase(29, "XXIX")]
		[TestCase(30, "XXX")]
		[TestCase(31, "XXXI")]
		[TestCase(32, "XXXII")]
		[TestCase(33, "XXXIII")]
		[TestCase(34, "XXXIV")]
		[TestCase(35, "XXXV")]
		[TestCase(36, "XXXVI")]
		[TestCase(37, "XXXVII")]
		[TestCase(38, "XXXVIII")]
		[TestCase(39, "XXXIX")]
		[TestCase(40, "XL")]
		[TestCase(41, "XLI")]
		[TestCase(42, "XLII")]
		[TestCase(43, "XLIII")]
		[TestCase(44, "XLIV")]
		[TestCase(45, "XLV")]
		[TestCase(46, "XLVI")]
		[TestCase(47, "XLVII")]
		[TestCase(48, "XLVIII")]
		[TestCase(49, "XLIX")]
		[TestCase(50, "L")]
		[TestCase(51, "LI")]
		[TestCase(52, "LII")]
		[TestCase(53, "LIII")]
		[TestCase(54, "LIV")]
		[TestCase(55, "LV")]
		[TestCase(56, "LVI")]
		[TestCase(57, "LVII")]
		[TestCase(58, "LVIII")]
		[TestCase(59, "LIX")]
		[TestCase(60, "LX")]
		[TestCase(61, "LXI")]
		[TestCase(62, "LXII")]
		[TestCase(63, "LXIII")]
		[TestCase(64, "LXIV")]
		[TestCase(65, "LXV")]
		[TestCase(66, "LXVI")]
		[TestCase(67, "LXVII")]
		[TestCase(68, "LXVIII")]
		[TestCase(69, "LXIX")]
		[TestCase(70, "LXX")]
		[TestCase(71, "LXXI")]
		[TestCase(72, "LXXII")]
		[TestCase(73, "LXXIII")]
		[TestCase(74, "LXXIV")]
		[TestCase(75, "LXXV")]
		[TestCase(76, "LXXVI")]
		[TestCase(77, "LXXVII")]
		[TestCase(78, "LXXVIII")]
		[TestCase(79, "LXXIX")]
		[TestCase(80, "LXXX")]
		[TestCase(81, "LXXXI")]
		[TestCase(82, "LXXXII")]
		[TestCase(83, "LXXXIII")]
		[TestCase(84, "LXXXIV")]
		[TestCase(85, "LXXXV")]
		[TestCase(86, "LXXXVI")]
		[TestCase(87, "LXXXVII")]
		[TestCase(88, "LXXXVIII")]
		[TestCase(89, "LXXXIX")]
		[TestCase(90, "XC")]
		[TestCase(91, "XCI")]
		[TestCase(92, "XCII")]
		[TestCase(93, "XCIII")]
		[TestCase(94, "XCIV")]
		[TestCase(95, "XCV")]
		[TestCase(96, "XCVI")]
		[TestCase(97, "XCVII")]
		[TestCase(98, "XCVIII")]
		[TestCase(99, "XCIX")]
		[TestCase(100, "C")]

        public void Test(int value, string expected)
		{
			Assert.AreEqual(expected, RomanConvertKata.Solution(value));
		}
	}
}
