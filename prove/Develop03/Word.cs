class Word
{
    public string Text { get; }
    public string Punctuation { get; }
    public bool Hidden { get; set; }
    public string HiddenText {get; set; }

    public Word(string text, string punctuation)
    {
        Text = text;
        Punctuation = punctuation;
        Hidden = false;
        HiddenText = "";
    }
}