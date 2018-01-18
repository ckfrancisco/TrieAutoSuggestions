/*
 
Programmer: Christian Francisco
Course: CptS 321
Date: 4/ 28/ 2017

Assignment: Trie
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieAutoSuggestions
{
    public class TrieNode
    {
        public char m_data;
        public Dictionary<char, TrieNode> m_child;

        //description: trie node constructor
        //parameter: trie node char
        //return: trie node
        public TrieNode(char c)
        {
            m_data = c;
            m_child = new Dictionary<char, TrieNode>();
        }

        //description: add or get a trie node child
        //parameter: char to add or get
        //return: trie node containing the char
        public TrieNode AddOrGetChild(char c)
        {
            if (!m_child.ContainsKey(c))        //determine if trie node contains the char
                m_child[c] = new TrieNode(c);   //if not add trie node with char to children

            return m_child[c];                  //return child trie node containing char
        }

        //description: create list of all words starting from trie node
        //parameter: prefix
        //return: list of words
        public List<string> GetPrefixWords(string prefix)
        {
            List<string> w = new List<string>();

            GetPrefixWordsHelp(this, prefix, w);    //add words found from trie node

            return w;
        }

        //description: recursively determine all words from trie node
        //parameter: trie node, current string, list of words
        //return: 
        public void GetPrefixWordsHelp(TrieNode n, string s, List<string> w)
        {
            foreach (KeyValuePair<char, TrieNode> c in n.m_child)   //for each child trie node
            {
                string x = s;                                       //initialize new current string
                if (c.Key == 0)                                     //if the child trie node char is null then add current string
                    w.Add(s);

                else
                    GetPrefixWordsHelp(c.Value, x += c.Key, w);     //else recursively call with child trie node and extended string
            }
        }
    }

    public class Trie
    {
        public TrieNode m_root;

        //description: trie constructor
        //parameter: 
        //return: 
        public Trie()
        {
            m_root = new TrieNode('\0');    //initialize root
        }

        //description: add string to trie
        //parameter: string
        //return: 
        public void AddString(string s)
        {
            TrieNode n = m_root;            //begin from root trie node

            foreach(char c in s)            //for each char in string add or get the trie node
            {
                n = n.AddOrGetChild(c);
            }

            n.AddOrGetChild('\0');          //null terminate string within trie
        }

        //description: find the trie node that a string leads to
        //parameter: string
        //return:  trie node of string
        public TrieNode GetTrieNode(string s)
        {
            if (s == null || s == "")               //if string is null or empty then return null
                return null;

            TrieNode n = m_root;                    //begin from root trie node

            foreach (char c in s)                   //for each char in string iterate to the next trie node
            {
                if (!n.m_child.ContainsKey(c))      //if the current trie node does not contain the current char then return null
                    return null;
                   
                n = n.m_child[c];                   //iterate to child trie node
            }

            return n;                               //return child trie node
        }
    }
}
