
// C# Program to Implement a Phone 
// Directory Using Trie Data Structure 
using System;
using System.Collections.Generic;

class TrieNode
{
    // Each Trie Node contains a Map 'child' 
    // where each alphabet points to a Trie 
    // Node. 
    public Dictionary<char, TrieNode> child;

    // 'isLast' is true if the node represents 
    // end of a contact 
    public bool isLast;

    // Default Constructor 
    public TrieNode()
    {
        child = new Dictionary<char, TrieNode>();

        // Initialize all the Trie nodes with NULL 
        for (char i = 'a'; i <= 'z'; i++)
            child.Add(i, null);

        isLast = false;
    }
}

class Trie
{
    public TrieNode root;

    // Insert all the Contacts into the Trie 
    public void insertIntoTrie(String[] contacts)
    {
        root = new TrieNode();
        int n = contacts.Length;
        for (int i = 0; i < n; i++)
        {
            insert(contacts[i]);
        }
    }

    // Insert a Contact into the Trie 
    public void insert(String s)
    {
        int len = s.Length;

        // 'itr' is used to iterate the Trie Nodes 
        TrieNode itr = root;
        for (int i = 0; i < len; i++)
        {
            // Check if the s[i] is already present in 
            // Trie 
            TrieNode nextNode = itr.child[s[i]];
            if (nextNode == null)
            {
                // If not found then create a new TrieNode 
                nextNode = new TrieNode();

                // Insert into the Dictionary 
                if (itr.child.ContainsKey(s[i]))
                    itr.child[s[i]] = nextNode;
                else
                    itr.child.Add(s[i], nextNode);
            }

            // Move the iterator('itr') ,to point to next 
            // Trie Node 
            itr = nextNode;

            // If its the last character of the string 's' 
            // then mark 'isLast' as true 
            if (i == len - 1)
                itr.isLast = true;
        }
    }

    // This function simply displays all dictionary words 
    // going through current node. String 'prefix' 
    // represents string corresponding to the path from 
    // root to curNode. 
    public void displayContactsUtil(TrieNode curNode,
                                    String prefix)
    {

        // Check if the string 'prefix' ends at this Node 
        // If yes then display the string found so far 
        if (curNode.isLast)
            Console.WriteLine(prefix);

        // Find all the adjacent Nodes to the current 
        // Node and then call the function recursively 
        // This is similar to performing DFS on a graph 
        for (char i = 'a'; i <= 'z'; i++)
        {
            TrieNode nextNode = curNode.child[i];
            if (nextNode != null)
            {
                displayContactsUtil(nextNode, prefix + i);
            }
        }
    }

    // Display suggestions after every character enter by 
    // the user for a given string 'str' 
    public void displayContacts(String str)
    {
        TrieNode prevNode = root;

        // 'flag' denotes whether the string entered 
        // so far is present in the Contact List 

        String prefix = "";
        int len = str.Length;

        // Display the contact List for string formed 
        // after entering every character 
        int i;
        for (i = 0; i < len; i++)
        {
            // 'str' stores the string entered so far 
            prefix += str[i];

            // Get the last character entered 
            char lastChar = prefix[i];

            // Find the Node corresponding to the last 
            // character of 'str' which is pointed by 
            // prevNode of the Trie 
            TrieNode curNode = prevNode.child[lastChar];

            // If nothing found, then break the loop as 
            // no more prefixes are going to be present. 
            if (curNode == null)
            {
                Console.WriteLine("\nNo Results Found for'"
                                           + prefix + "'");
                i++;
                break;
            }

            // If present in trie then display all 
            // the contacts with given prefix. 
            Console.WriteLine("Suggestions based on '"
                                  + prefix + "' are");
            displayContactsUtil(curNode, prefix);

            // Change prevNode for next prefix 
            prevNode = curNode;
        }

        for (; i < len; i++)
        {
            prefix += str[i];
            Console.WriteLine("\nNo Results Found for '"
                                        + prefix + "'");
        }
    }
}

// Driver code 
public class GFG
{
    public static void Main(String[] args)
    {
        Trie trie = new Trie();

        String[] contacts = { "gforgeeks", "geeksquiz" };

        trie.insertIntoTrie(contacts);

        String query = "gekk";

        // Note that the user will enter 'g' then 'e' so 
        // first display all the strings with prefix as 'g' 
        // and then all the strings with prefix as 'ge' 
        trie.displayContacts(query);
    }
}