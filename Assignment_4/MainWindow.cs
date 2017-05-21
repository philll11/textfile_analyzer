using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment_4
{
	public partial class MainWindow : Form
	{
		/// <summary>
		///		I have added multiple white space and punctuation robustness.
		/// </summary>
		private string _path = "";
		private bool _state = false;
		private List<string> _myList = new List<string>();
		private Dictionary<string, int> _myDir = new Dictionary<string, int>();

		public MainWindow()
		{
			InitializeComponent();
		}
		

		private void OpnFileClick(object sender, EventArgs e)
		{
			Reset();
			_state = true;
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text files (*.txt)|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				_path = ofd.FileName;
				_myList = ReadTextFromFile(_path);
				_myDir = ListToDictionary(_myList);

				commonLtBx.Items.Add("Frequency: " + ReturnMostCommonWordCount(_myDir) + " times");
				commonLtBx.Items.Add(ReturnMostCommonWord(_myDir));

				longLtBx.Items.Add("Longes: " + LongestWordCount(_myDir) + " letters.");
				longLtBx.Items.Add(LongestWord(_myDir));

				shortLtBx.Items.Add("Shortest: " + ShortestWordCount(_myDir) + " letters.");
				shortLtBx.Items.Add(ShortestWord(_myDir));

				averageLtBx.Items.Add(CalculateAverageWord(_myDir).ToString());

				UpdateGraph(_myDir);

				aveWordLbl.Text = CalculateAverageWordLength(_myList).ToString();
				wordCountLbl.Text = _myList.Count.ToString();

				uniqueTxBx.Text = PrintFileToString(_myDir);
			}			
		}
		
		private void WordBtnClick(object sender, EventArgs e)
		{
			if (!wordTxtBx.Text.All(char.IsDigit) && _state)
			{
				wordLtBx.Items.Clear();
				wordLtBx.Items.Add("Number of occurrences: " + FindSearchedWord(wordTxtBx.Text, _myDir));
				wordError.Visible = false;
			}
			else
			{
				wordError.Visible = true;
			}
		}

		private void LengthBtnClick(object sender, EventArgs e)
		{
			if (int.TryParse(lengthTxtBx.Text, out int value) && _state)
			{
				lengthTxBx.Text = "";
				lengthTxBx.Text = FindSearchedLength(value, _myDir);
				lengthError.Visible = false;
			}
			else
			{
				lengthError.Visible = true;
			}
		}


		/// <summary>
		///		Logic methods.
		/// </summary>
		/// 
		//	Splits a string and prepares it for the list.
		public void PerformStringSplit(List<string> aList, string text)
		{
			string[] tempArray = text.Split(' ');
			foreach (string word in tempArray)
			{
				aList.Add(word);
			}
		}

		//	Pulls text from a file and place each word at each index of a list.
		public List<string> ReadTextFromFile(string path)
		{
			List<string> list = new List<string>();
			StreamReader sr = new StreamReader(path);
			while (!sr.EndOfStream)
			{
				PerformStringSplit(list, sr.ReadLine().ToString());
			}
			return list;			
		}

		//	Removes punctuation.
		public void PunctuationClean(List<string> aList, int i)
		{
			if (aList[i].Contains(","))
			{
				aList[i] = aList[i].Replace(",", "");
			}
			else if (aList[i].Contains(","))
			{
				aList[i] = aList[i].Replace(".", "");
			}
		}

		//	Changes capital words with lowercase.
		public void ListClean(List<string> aList)
		{
			for (int i = 0; i < aList.Count; i++)
			{
				PunctuationClean(aList, i);

				if (aList[i] != "")
				{
					char[] letter = aList[i].Substring(0, 1).ToCharArray();
					if (Char.IsUpper(letter[0]))
					{
						aList[i] = aList[i].ToLower();
					}
				}
				else
				{
					aList.RemoveAt(i);
					i--;
				}
			}
		}
		
		//	Converts a list to a dictionary.
		public Dictionary<string, int> ListToDictionary(List<string> aList)
		{
			ListClean(aList);

			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (string word in aList)
			{
				if (dictionary.ContainsKey(word))
				{
					dictionary[word]++;
				}
				else
				{
					dictionary.Add(word, 1);
				}
			}
			return dictionary;
		}

		//	Finds the highest value.
		public int ReturnMostCommonWordCount(Dictionary<string, int> aDic)
		{
			return aDic.Values.Max();
		}

		//	Finds all the values with the highest count
		public string ReturnMostCommonWord(Dictionary<string, int> aDic)
		{
			int maxNum = ReturnMostCommonWordCount(aDic);
			string longWords = "";

			foreach (KeyValuePair<string, int> item in aDic)
			{
				if (item.Value == maxNum)
				{
					longWords += item.Key + ", ";
				}
			}
			return longWords;
		}

		//	Returns the length of the longest word.
		public int LongestWordCount(Dictionary<string, int> aDic)
		{
			List<string> tempList = aDic.Keys.ToList();
			string tempItem = tempList[0];
			foreach (string item in tempList)
			{
				if (item.Length > tempItem.Length)
				{
					tempItem = item;
				}
			}
			return tempItem.Length;
		}

		//	Returns a list of the longest words.
		public string LongestWord(Dictionary<string, int> aDic)
		{
			List<string> dicList = aDic.Keys.ToList();
			List<string> temp = new List<string>() { dicList[0] };
			for (int i = 0; i < dicList.Count - 1; i++)
			{
				if (temp[0].Length == dicList[i + 1].Length)
				{
					temp.Add(dicList[i + 1]);
				}
				else if (temp[0].Length <= dicList[i + 1].Length)
				{
					temp = new List<string>();
					temp.Add(dicList[i + 1]);
				}
			}
			return String.Join(", ", temp);
		}

		//	Returns the length of the shortest words
		public int ShortestWordCount(Dictionary<string, int> aDic)
		{
			List<string> dicList = aDic.Keys.ToList();
			string tempItem = dicList[0];
			foreach (string item in dicList)
			{
				if (item.Length < tempItem.Length)
				{
					tempItem = item;
				}
			}
			return tempItem.Length;
		}

		//	Returns a list of the shortest words.
		public string ShortestWord(Dictionary<string, int> aDic)
		{
			List<string> dicList = aDic.Keys.ToList();
			List<string> temp = new List<string>() { dicList[0] };
			for (int i = 0; i < dicList.Count - 1; i++)
			{
				if (temp[0].Length == dicList[i + 1].Length)
				{
					temp.Add(dicList[i + 1]);
				}
				else if (temp[0].Length >= dicList[i + 1].Length)
				{
					temp = new List<string>();
					temp.Add(dicList[i + 1]);
				}
			}
			return String.Join(", ", temp);
		}

		//	Calculates the average word length with repeated words removed.
		public double CalculateAverageWord(Dictionary<string, int> aDic)
		{
			double sum = 0;
			foreach (KeyValuePair<string, int> item in aDic)
			{
				sum += item.Key.Length;
			}
			return Math.Round((sum / aDic.Count), 2);
		}

		//	Calculates the average length of each word.
		public double CalculateAverageWordLength(List<string> aList)
		{
			double sum = 0;
			foreach (string item in aList)
			{
				sum += item.Length;
			}
			return Math.Round((sum / aList.Count), 2);
		}
		
		//	returns number of searched word appearances.
		public int FindSearchedWord(string word, Dictionary<string, int> aDic)
		{
			int count = 0;
			foreach (KeyValuePair<string, int> item in aDic)
			{
				if (item.Key == word)
				{
					count = item.Value;
				}
			}
			return count;
		}

		//	Takes a string parameter from the user and finds the number of appreanaces.
		public string FindSearchedLength(int length, Dictionary<string, int> aDic)
		{
			string words = ""; 
			foreach (KeyValuePair<string, int> item in aDic)
			{
				if (item.Key.Length == length)
				{
					words += item.Key + ", ";
				}
			}
			return words;
		}

		//	Takes the text from the file and concatinates into one string.
		public string PrintFileToString(Dictionary<string, int> aDic)
		{
			string stringConcat = String.Join(", ", aDic.Keys);
			return stringConcat;
		}
		
		public void UpdateGraph(Dictionary<string, int> aDic)
		{
			chart1.Series.Clear();
			chart1.Series.Add("Words");

			int limit = 0;

			KeyValuePair<string, int> item;			
			for (int i = 0; i < aDic.Count; i++)
			{
				item = aDic.ElementAt(i);				
				chart1.Series["Words"].Points.AddXY(item.Key, item.Value);
				limit++;
				if (limit == 50)
				{
					i = aDic.Count;
				}
			}
		}

		//	Resets all applicaion settings.
		public void Reset()
		{
			commonLtBx.Items.Clear();
			longLtBx.Items.Clear();
			shortLtBx.Items.Clear();
			averageLtBx.Items.Clear();
			lengthTxtBx.Text = "";
			lengthTxBx.Text = "";
			wordTxtBx.Text = "";
			wordLtBx.Items.Clear();
			uniqueTxBx.Text = "";
			aveWordLbl.Text = "0";
			wordCountLbl.Text = "0";
			wordError.Visible = false;
			lengthError.Visible = false;
			
		}		
	}
}
