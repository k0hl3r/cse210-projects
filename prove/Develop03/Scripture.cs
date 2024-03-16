using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random;

    public bool AllWordsHidden { get { return words != null && words.All(word => word.Hidden); } }

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();
        this.random = new Random();

        string[] tokens = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            bool isPunctuation = char.IsPunctuation(token[token.Length - 1]);
            string word = isPunctuation ? token.Substring(0, token.Length - 1) : token;
            string punctuation = isPunctuation ? token[token.Length - 1].ToString() : "";

            words.Add(new Word(word, punctuation));
        }
    }

    public void HideRandomWord()
    {
        if (words == null || words.Count == 0)
            return;

        int wordsToHide = random.Next(1, 4);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(0, words.Count);
            var word = words[index];

            if (!word.Hidden)
            {
                word.Hidden = true;
                word.HiddenText = new string('_', word.Text.Length);
            }
        }
    }

    public string GetHiddenScripture()
    {
        if (words == null || words.Count == 0)
            return "";

        string hiddenScripture = "";
        foreach (Word word in words)
        {
            hiddenScripture += word.Hidden ? word.HiddenText + word.Punctuation + " " : word.Text + word.Punctuation + " ";
        }
        return $"{reference}: {hiddenScripture}";
    }
}