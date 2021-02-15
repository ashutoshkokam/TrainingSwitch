using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingSwitch
{
    public class WordBoard
    {


        TrieNode TrieRoot;
        IList<string> Ans;
        char[,] Board;

        /// <summary>
        /// Time Complexity:
        //        O(MNL + LW) , where M is the row length in board and N is the column length.L is the average length of a word in the given word list and W is the number of words given word list.
        //       O(MNL) is to loop through each index in the board and then do the depth first search with L depth.
        //       O(LW) is to build the Trie
        //Space Complexity:
        //O(LW) to store the trie, where in worst case all paths are distict
        //However, no additional space to record the visited nodes while traversing thanks to awesome technique of temporarilty marking board[i][j] = '#' and reversing that.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public IList<string> FindWords(char[,] board, string[] words)
        {
            // Validations

            // Build a Trie based on the given words
            BuildTrie(words);
            Console.WriteLine(TrieRoot);
            Board = board;

            Ans = new List<string>();
            // Do a depth first search starting from each index
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                for (int col = 0; col < Board.GetLength(1); col++)
                {
                    Dfs(row, col, TrieRoot);
                }
            }

            return Ans;
        }

        private void Dfs(int row, int col, TrieNode node)
        {
            char c = Board[row, col];
            if (c == '#' || node.Children[c - 'a'] == null) return;
            node = node.Children[c - 'a'];
            if (node.Word != null)  // A word is present
            {
                Ans.Add(node.Word);
                node.Word = null; // To avoid duplication of the result
            }

            Board[row, col] = '#'; // Temporarity mark the position as visited
            if (row > 0) Dfs(row - 1, col, node);
            if (row < Board.GetLength(0) - 1) Dfs(row + 1, col, node);
            if (col > 0) Dfs(row, col - 1, node);
            if (col < Board.GetLength(1) - 1) Dfs(row, col + 1, node);
            Board[row, col] = c; // Undo the temporary mark 
        }

        private void BuildTrie(string[] words)
        {
            TrieRoot = new TrieNode();
            foreach (var word in words)
            {
                var currNode = TrieRoot;
                foreach (var c in word)
                {
                    int i = c - 'a';
                    if (currNode.Children[i] == null)
                    {
                        currNode.Children[i] = new TrieNode();
                    }

                    currNode = currNode.Children[i];
                }
                currNode.Word = word;
            }
        }


        public class TrieNode
        {
            public TrieNode[] Children;
            public string Word;

            public TrieNode()
            {
                Children = new TrieNode[26];
                Word = null;
            }
        }
    }
}
