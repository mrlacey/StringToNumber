//-----------------------------------------------------------------------
// <copyright file="NumberParser.WordsToNumber.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace StringToNumber
{
    public partial class NumberParser
    {
        internal Int64 WordsToNumber(string wordsNumber)
        {
            return this.WordsToNumber(wordsNumber, true);
        }

        internal Int64 WordsToNumber(string wordsNumber, bool throwOnError)
        {
            bool notUsed;

            return this.WordsToNumber(wordsNumber, throwOnError, out notUsed);
        }

        internal Int64 WordsToNumber(string wordsNumber, bool throwOnError, out bool suppressedErrorThrown)
        {
            if (wordsNumber == null)
            {
                if (throwOnError)
                {
                    throw new ArgumentNullException("wordsNumber");
                }
                else
                {
                    wordsNumber = string.Empty;
                }
            }

            // ToDo: allow multi word numbers (e.g. French has 'QUATRE VINGTS:80')

            // Make sure value passed in is treated as upper case
            string[] words = wordsNumber.ToUpper(this.converterCulture).Split(this.splitterChars, StringSplitOptions.RemoveEmptyEntries);
            Int64 result = 0;

            if (words.Length == 0)
            {
                if (throwOnError)
                {
                    throw new ArgumentException("No valid words detected.");
                }
                else
                {
                    suppressedErrorThrown = true;
                    return result;
                }
            }

            if ((words.Length == 1) && (this.zeros.Contains(words[0])))
            {
                // if only a single word
                //   - this is the only scenario where zero is valid 
                //   - until we add support for decimals! (e.g. five point two zero one five nine eight => 5.201598)

                // all other valid single words will be dealt with in the next section
                // zero is dealt with here as a special case, not covered by the REGEX
                suppressedErrorThrown = false;
                return 0;
            }
            else
            {
                string wordPattern;

                ArrayList parsedWords;

                ArrayList numerics;

                if (!this.ParseWords(words, throwOnError, out wordPattern, out parsedWords, out numerics))
                {
                    suppressedErrorThrown = true;
                    return result;
                }

                MatchCollection matches;
                if (this.WordPatternIsValid(wordPattern, out matches))
                {
                    string patternUnderOneHundred = matches[0].Groups["a"].Value;

                    int numericPosition = 0;

                    int parsedWordsPosition = parsedWords.Count - 1;

                    result = this.ProcessValueUnderOneHundred(patternUnderOneHundred, wordPattern, parsedWords, ref parsedWordsPosition, numerics, ref numericPosition);

                    if (wordPattern.Length > (patternUnderOneHundred.Length + (wordPattern.StartsWith(WordType.Negative.ToString(), false, this.converterCulture) ? 1 : 0)))
                    {
                        // ToDo: Make this understandable!!! - group b ?
                        // Do processing of numbers greater than 99
                        // Get part of input pattern that is not the negative indicator and not in the 'PatternUnderOneHundred'
                        string patternOverOneHundred =
                          wordPattern.Substring(wordPattern.StartsWith(WordType.Negative.ToString(), false, this.converterCulture) ? 1 : 0,
                                                wordPattern.Length - patternUnderOneHundred.Length -
                                                (wordPattern.Substring(
                                                   wordPattern.Length -
                                                   patternUnderOneHundred.Length - 1,
                                                   1) == WordType.And.ToString()
                                                   ? 1
                                                   : 0) - (wordPattern.StartsWith(WordType.Negative.ToString(), false, this.converterCulture) ? 1 : 0));

                        string thisGroup = String.Empty;
                        Int64 thisGroupAmount = 1;  // initialize to one so can multiply by group amounts correctly if no other multiplier provided
                        Int64 lastGroupAmount = 0;

                        // work RtoL through pattern until reach G after a non G (but not an and) or end.
                        for (int i = patternOverOneHundred.Length - 1; i >= 0; i--)
                        {
                            bool reachedEndOfPattern = (i == 0);
                            bool reachedEndOfGroup = (reachedEndOfPattern ||
                                //// (thisGroup.Contains(WordType.Group.ToString()) & 
                                //// (patternOverOneHundred[i] == WordType.And)) ||
                                                      ((patternOverOneHundred[i] != WordType.Group) &&
                                                       (patternOverOneHundred[i] != WordType.And) &&
                                                       (patternOverOneHundred[i - 1] == WordType.Group)));

                            // build group
                            thisGroup = patternOverOneHundred[i] + thisGroup;

                            if (reachedEndOfPattern || reachedEndOfGroup)
                            {
                                if (parsedWordsPosition - thisGroup.Length < 0)
                                {
                                    parsedWordsPosition += 1;
                                }

                                int groupWordTypesInThisGroup = 0;

                                // calculate group
                                for (int j = 0; j <= thisGroup.Length - 1; j++)
                                {
                                    int posInParsedWords = parsedWordsPosition - thisGroup.Length + j;

                                    if (posInParsedWords < 0)
                                    {
                                        posInParsedWords = 0;
                                    }

                                    switch (thisGroup[j])
                                    {
                                        case WordType.Single:
                                            thisGroupAmount = 1;
                                            break;
                                        case WordType.Unit:
                                            if (j == 0)
                                            {
                                                thisGroupAmount = Convert.ToInt64(this.units[parsedWords[posInParsedWords]], this.converterCulture);
                                            }
                                            else
                                            {
                                                thisGroupAmount += Convert.ToInt64(this.units[parsedWords[posInParsedWords]], this.converterCulture);
                                            }

                                            break;
                                        case WordType.Teen:
                                            thisGroupAmount = Convert.ToInt64(this.teens[parsedWords[posInParsedWords]], this.converterCulture);
                                            break;
                                        case WordType.Parsed:
                                            thisGroupAmount = Convert.ToInt64(numerics[numericPosition], this.converterCulture);
                                            numericPosition += 1;
                                            break;
                                        case WordType.MultipleOfTen:
                                            if (j == 0)
                                            {
                                                thisGroupAmount = Convert.ToInt64(this.multiplesOfTen[parsedWords[posInParsedWords]], this.converterCulture);
                                            }
                                            else
                                            {
                                                thisGroupAmount += Convert.ToInt64(this.multiplesOfTen[parsedWords[posInParsedWords]], this.converterCulture);
                                            }

                                            break;
                                        case WordType.Group:
                                            Int64 thisValue = Convert.ToInt64(this.groups[parsedWords[posInParsedWords]], this.converterCulture);

                                            // Check not got consecutive G's in wrong order
                                            // - e.g. don't allow "million hundred"
                                            //    but do allow "hundred million"
                                            if ((groupWordTypesInThisGroup > 0)
                                             && (thisGroupAmount > thisValue))
                                            {
                                                if (throwOnError)
                                                {
                                                    throw new InvalidCastException(wordsNumber);
                                                }
                                                else
                                                {
                                                    suppressedErrorThrown = true;
                                                    return result;
                                                }
                                            }

                                            thisGroupAmount *= thisValue;
                                            groupWordTypesInThisGroup += 1;
                                            break;
                                        case WordType.Zero:
                                            // zero isn't valid as part of a pattern
                                            if (throwOnError)
                                            {
                                                throw new InvalidCastException(wordsNumber);
                                            }
                                            else
                                            {
                                                suppressedErrorThrown = true;
                                                return result;
                                            }

                                        case WordType.And:
                                            // if in a group
                                            break;
                                        default: // case WordType.Single
                                            thisGroupAmount = 1;
                                            break;
                                    }
                                }

                                // check that group is larger than previously parsed group
                                if (lastGroupAmount > 0)
                                {
                                    if (lastGroupAmount > thisGroupAmount)
                                    {
                                        if (throwOnError)
                                        {
                                            throw new InvalidCastException(wordsNumber);
                                        }
                                        else
                                        {
                                            suppressedErrorThrown = true;
                                            return result;
                                        }
                                    }
                                }

                                // add to result
                                result += thisGroupAmount;

                                // reset looping variables
                                lastGroupAmount = thisGroupAmount;
                                thisGroupAmount = 1;
                                parsedWordsPosition -= thisGroup.Length;
                                thisGroup = string.Empty;
                            }
                        }
                    }

                    if (wordPattern.StartsWith(WordType.Negative.ToString(), true, this.converterCulture) ||
                        wordsNumber.StartsWith("-", true, this.converterCulture))
                    {
                        result = 0 - result;
                    }
                }

                if (result == 0)
                {
                    if (throwOnError)
                    {
                        throw new InvalidCastException(wordsNumber);
                    }
                    else
                    {
                        suppressedErrorThrown = true;
                        return result;
                    }
                }
            }

            suppressedErrorThrown = false;
            return result;
        }

        internal long ProcessValueUnderOneHundred(string patternUnderOneHundred, string wordPattern, ArrayList parsedWords, ref int parsedWordsPosition, ArrayList numerics, ref int numericPosition)
        {
            long result = 0;

            if (patternUnderOneHundred.Length > 0)
            {
                for (int i = wordPattern.Length - 1; i > wordPattern.Length - patternUnderOneHundred.Length - 1; i--)
                {
                    switch (wordPattern[i])
                    {
                        case WordType.Unit:
                            result += Convert.ToInt64(this.units[parsedWords[parsedWordsPosition]], this.converterCulture);
                            break;
                        case WordType.Teen:
                            result += Convert.ToInt64(this.teens[parsedWords[parsedWordsPosition]], this.converterCulture);
                            break;
                        case WordType.Parsed:
                            result = Convert.ToInt64(numerics[numericPosition], this.converterCulture);
                            numericPosition += 1;
                            break;
                        default: // case WordType.MultipleOfTen
                            result += Convert.ToInt64(this.multiplesOfTen[parsedWords[parsedWordsPosition]], this.converterCulture);
                            break;
                    }

                    parsedWordsPosition -= 1;
                }
            }
            else
            {
                parsedWordsPosition += 1;
            }

            return result;
        }

        /// <summary>
        /// Is the word pattern valid.
        /// Word pattern is the representation of valid word types.
        /// N.B. This does not consider Zeroes.
        /// </summary>
        /// <param name="pattern">The pattern to check.</param>
        /// <param name="matches">The MatchCollection for the pattern.</param>
        /// <returns>True if pattern is valid</returns>
        internal bool WordPatternIsValid(string pattern, out MatchCollection matches)
        {
            Regex strToNumb = new Regex("^(N)?(?<b>((T|S|((M)?(U)?))?G)(A)?)*(?<a>T|((M)?(U)?(P)?))?$");

            if (strToNumb.IsMatch(pattern))
            {
                matches = strToNumb.Matches(pattern);

                // check for possible false positives

                // last word is 'and'
                // just 'minus'
                if (pattern.EndsWith(WordType.And.ToString(), true, this.converterCulture) ||
                    pattern.Equals(WordType.Negative.ToString()))
                {
                    return false;
                }

                return true;
            }
            else
            {
                matches = null;
                return false;
            }
        }

        internal bool ParseWords(string[] words, bool throwOnError, out string wordPattern, out ArrayList parsedWords, out ArrayList numerics)
        {
            StringBuilder pattern = new StringBuilder(words.Length - 1);
            parsedWords = new ArrayList(words.Length);
            numerics = new ArrayList(words.Length);

            foreach (var word in words)
            {
                if (this.negatives.Contains(word))
                {
                    pattern.Append(WordType.Negative);
                    parsedWords.Add(word);
                }
                else if (this.ands.Contains(word))
                {
                    pattern.Append(WordType.And);
                    parsedWords.Add(word);
                }
                else if (this.units.Contains(word))
                {
                    pattern.Append(WordType.Unit);
                    parsedWords.Add(word);
                }
                else if (this.ones.Contains(word))
                {
                    pattern.Append(WordType.Single);
                    parsedWords.Add(word);
                }
                else if (this.teens.Contains(word))
                {
                    pattern.Append(WordType.Teen);
                    parsedWords.Add(word);
                }
                else if (this.multiplesOfTen.Contains(word))
                {
                    pattern.Append(WordType.MultipleOfTen);
                    parsedWords.Add(word);
                }
                else if (this.groups.Contains(word))
                {
                    pattern.Append(WordType.Group);
                    parsedWords.Add(word);
                }
                else
                {
                    Int64 parsedNumeric;
                    if (Int64.TryParse(word, NumberStyles.Integer, this.converterCulture, out parsedNumeric))
                    {
                        numerics.Add(parsedNumeric);
                        pattern.Append(WordType.Parsed);
                        parsedWords.Add(word);
                    }
                    else
                    {
                        // check for concatenation of multiplesOfTen and unit. e.g. seventyfour
                        foreach (string multiple in this.multiplesOfTen.Keys)
                        {
                            if (word.StartsWith(multiple, true, this.converterCulture)
                             && (multiple.Length < word.Length)
                             && this.units.Contains(word.Substring(multiple.Length)))
                            {
                                pattern.Append(WordType.D21ThruD99);
                                parsedWords.Add(multiple);
                                parsedWords.Add(word.Substring(multiple.Length));
                                break;
                            }
                        }
                    }

                    if (pattern.ToString().EndsWith(WordType.Parsed.ToString(), true, this.converterCulture)
                     || pattern.ToString().EndsWith(WordType.D21ThruD99, true, this.converterCulture))
                    {
                        continue;
                    }

                    if (throwOnError)
                    {
                        throw new InvalidCastException(String.Format(this.converterCulture, "'{0}' is unrecognised.", word));
                    }
                    else
                    {
                        wordPattern = pattern.ToString();
                        return false;
                    }
                }
            }

            wordPattern = pattern.ToString();

            return true;
        }
    }
}
