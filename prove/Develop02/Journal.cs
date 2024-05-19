// using System;
// using System.Collections.Generic;
// using System.IO;

// public class Journal
// {
//     protected List<string> entries = new List<string>();

//     public void AnswerPrompts(int promptCount);

//     public void DisplayJournal()
//     {
//         Console.WriteLine("\nJournal Entries:");
//         for (int i = 0; i < entries.Count; i++)
//         {
//             Console.WriteLine($"Entry {i + 1}: {entries[i]}\n");
//         }
//     }

//     public void LoadEntries(string filename)
//     {
//         using (StreamReader sr = new StreamReader(filename))
//         {
//             entries.Clear();
//             string line;
//             while ((line = sr.ReadLine()) != null)
//             {
//                 entries.Add(line);
//             }
//         }
//         Console.WriteLine("Entries loaded successfully.");
    
//     }

//     public void SaveEntries(string filename)
//     {
//         using (StreamWriter sw = new StreamWriter(filename))
//         {
//             foreach (string entry in entries)
//             {
//                 sw.WriteLine(entry);
//             }
//         }
//         Console.WriteLine("Entries saved successfully.");
        
        
//     }
// }