using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Assignment_4;

namespace Assignment_4_Unit_Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CheckStringSplitsIntoSingleWords()
		{
			MainWindow mw = new MainWindow();
			List<string> expected = new List<string>() { "The", "dog", "jumped", "over", "the", "log" };
			List<string> actual = new List<string>();

			string text = "The dog jumped over the log";

			mw.PerformStringSplit(actual, text);
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CheckPuntuation()
		{
			MainWindow mw = new MainWindow();
			List<string> list = new List<string>() { "The", "dog", "jumped,", "over", "the", "log" };
			List<string> expected = new List<string>() { "The", "dog", "jumped", "over", "the", "log" };

			mw.PunctuationClean(list, 2);

			CollectionAssert.AreEqual(expected, list);
		}

		[TestMethod]
		public void TextFromFile_AssignedWordByWord_ToList()
		{
			MainWindow mw = new MainWindow();
			List<string> actual = new List<string>();
			List<string> expected = new List<string>() { "The", "dog", "jumped", "over", "the", "log", "log" };
			string link = "C:\\Users\\admin\\Desktop\\Assignment_4\\txt.txt";

			actual = mw.ReadTextFromFile(link);

			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check_FirstLetterOfStringHasBeenChanged_ToLowerCase()
		{
			MainWindow mw = new MainWindow();
			List<string> list = new List<string>() { "The", "dog", "jumped", "Over", "the", "Log", "log" };
			List<string> expected = new List<string>() { "the", "dog", "jumped", "over", "the", "log", "log" };
			mw.ListClean(list);

			CollectionAssert.AreEqual(expected, list);
		}

		[TestMethod]
		public void Check_DictoraryHasBuiltCorrectly()
		{
			MainWindow mw = new MainWindow();
			List<string> list = new List<string>() { "The", "dog", "jumped", "over", "the", "Log", "log" };
			Dictionary<string, int> expected = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 2 } };

			Dictionary<string, int> actual = mw.ListToDictionary(list);
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Return_NumberOfCommonWordAppearances()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };
			int expected = 4;

			int actual = mw.ReturnMostCommonWordCount(dic);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Return_MostCommonWord()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 4 }, {"jumped", 5 }, {"over", 1 }, {"log", 5 } };
			string expected = "jumped, log, ";

			string actual = mw.ReturnMostCommonWord(dic);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check_LongestWordCount()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };
			int expected = 6;
			int actual = mw.LongestWordCount(dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Return_LongestWord()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };

			string expected = "jumped";
			string actual = mw.LongestWord(dic);

			Assert.AreEqual(expected, actual);			
		}

		[TestMethod]
		public void Check_ShortestWordCount()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };
			int expected = 3;
			int actual = mw.ShortestWordCount(dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Return_ShortestWord()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };

			string expected = "the, dog, log";
			string actual = mw.ShortestWord(dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check_AverageWordLength()
		{
			MainWindow mw = new MainWindow();
			List<string> list = new List<string>() { "The", "dog", "jumped", "over", "the", "log", "log" };
			double expected = 3.57;
			double actual = mw.CalculateAverageWordLength(list);

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Return_NumberOfAppearances_ForSearchedWord()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 4 }, {"jumped", 5 }, {"over", 1 }, {"log", 1 } };
			string word = "the";
			int expected = 2;

			int actual = mw.FindSearchedWord(word, dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Return_NumberOfWords_SpecificLength()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 4 }, {"jumped", 5 }, {"over", 1 }, {"log", 1 } };
			int length = 3;
			string expected = "the, dog, log, ";

			string actual = mw.FindSearchedLength(length, dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PrintEntireFile()
		{
			MainWindow mw = new MainWindow();
			Dictionary<string, int> dic = new Dictionary<string, int>
			{ { "the", 2 }, { "dog", 1 }, {"jumped", 1 }, {"over", 1 }, {"log", 4 } };
			string expected = "the, dog, jumped, over, log";
			string actual = mw.PrintFileToString(dic);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Check_DataIsCorrectlyPassedToGraph()
		{
			
		}
	}
}

