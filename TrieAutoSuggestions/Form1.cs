/*
 
Programmer: Christian Francisco
Course: CptS 321
Date: 4/ 28/ 2017

Assignment: Trie
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrieAutoSuggestions
{
    public partial class Form1 : Form
    {
        Trie m_trie;

        public Form1()
        {
            InitializeComponent();

            m_trie = new Trie();                                //initiliaze trie data structure

            string[] words = File.ReadAllLines("wordsEn.txt");  //read all lines from dictionary into array of words

            foreach (string s in words)                         //add all words from the dictionary into the trie
                m_trie.AddString(s);
        }

        //description: update results when prefix box is changed
        //parameter: sender and event
        //return:
        private void PrefixInput_TextChanged(object sender, EventArgs e)
        {
            TrieNode n = m_trie.GetTrieNode(PrefixInput.Text);      //determine trie node of prefix

            if (n == null)                                          //if n is null set empty results
            {
                Results.Text = "";
                return;
            }

            List<string> w = n.GetPrefixWords(PrefixInput.Text);    //construct list of words beginning with prefix

            string x = "";                                          //initialize new string to set results to
                                                                    //NOTE: updating the results text directly slows down the program

            foreach (string s in w)                                 //add each word to the new string
            {
                x += s + "\r\n";
            }

            Results.Text = x;                                       //set results to the new string
        }
    }
}
