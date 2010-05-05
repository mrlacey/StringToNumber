//-----------------------------------------------------------------------
// <copyright file="CustomWords.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2010 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace StringToNumber
{
    public class CustomWords
    {
        public TypeOfWord WordType { get; set;}
        public string Word { get; set;}
        public long Value { get; set;}

        public CustomWords(TypeOfWord type, string word, long value)
        {
            this.WordType = type;
            this.Word = word;
            this.Value = value;
        }
    }
}