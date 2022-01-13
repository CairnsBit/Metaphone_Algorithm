using System;
using System.Linq;
using System.Text;

namespace Algorithm
{
    public class MetaphoneAlgorithm
    {
        public static string toPhonetic(string word)
        {

            bool diffFirst = false;
            var result = new StringBuilder();


            for (int i = 0; i < word.Length; i++)
            {
                //  Vowel letter first
                if (i == 0 & "aeiou".Contains(word[i]))
                {
                    result.Append(word[i]);
                    continue;
                }

                //  KN, GN, PN, AC or WR first
                else if (i == 0 & new[] { "kn", "gn", "pn", "ac", "wr" }.Contains(word.Substring(0, 2)))
                {
                    result.Append(word.Substring(1, 1));
                    diffFirst = true;
                    continue;
                }

                //  X first
                else if (i == 0 & word[i].Equals('x'))
                {
                    result.Append('s');
                    continue;
                }

                //  WH first
                else if (i == 0 && word.Substring(0,2).Equals("wh"))
                {
                    result.Append('w');
                    continue;
                }

                //  F, J, L, M, N, R
                if ("fjlmnr".Contains(word[i]))
                {
                    if (diffFirst)
                    {
                        diffFirst = false;
                        continue;
                    }
                    else
                    {
                        result.Append(word[i]);
                        continue;
                    }
                }

                //  B
                if (word[i].Equals('b'))
                {
                    if (i - 1 >= 0)
                    {
                        if (!word.Substring(i - 1, 2).Equals("mb"))
                        {
                            result.Append(word[i]);
                            continue;
                        }
                        else
                        {
                            result.Append('b');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('b');
                        continue;
                    }
                }

                //  C
                if (word[i].Equals('c'))
                {
                    if (i + 3 <= word.Length)
                    {
                        if (word.Substring(i, 3).Equals("cia"))
                        {
                            result.Append('x');
                            continue;
                        }
                        if (word.Substring(i, 2).Equals("ch"))
                        {
                            result.Append('x');
                            continue;
                        }
                        else if (word.Substring(i, 2).Equals("ci") | word.Substring(i, 2).Equals("ce") | word.Substring(i, 2).Equals("cy"))
                        {
                            result.Append('s');
                            continue;
                        }
                        else if (!word.Substring(i, 2).Equals("ck"))
                        {
                            result.Append('k');
                            continue;
                        }
                        else
                        {
                            result.Append('k');
                            continue;
                        }
                    }
                }

                //  D
                if (word[i].Equals('d'))
                {
                    if (i + 3 <= word.Length)
                    {
                        if (word.Substring(i, 3).Equals("dge") | word.Substring(i, 3).Equals("dgy") | word.Substring(i, 3).Equals("dgi"))
                        {
                            result.Append('j');
                            continue;
                        }
                        else
                        {
                            result.Append('t');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('t');
                        continue;
                    }
                }

                //  G
                if (word[i].Equals('g'))
                {
                    if (i + 2 <= word.Length)
                    {
                        if (!word.Substring(i, 2).Equals("gh") & !word.Substring(i, 2).Equals("gn") & !word.Substring(i, 2).Equals("gned") & !"aeiou".Contains(word[i + 1]) & i != word.Length)
                        {
                            if (word.Substring(i, 2).Equals("gi") | word.Substring(i, 2).Equals("ge") | word.Substring(i, 2).Equals("gy"))
                            {
                                result.Append('j');
                                continue;
                            }
                            else
                            {
                                result.Append('k');
                                continue;
                            }
                        }
                    }
                }

                //  H
                if (word[i].Equals('h'))
                {
                    if (i + 1 <= word.Length & i - 1 >= 0)
                    {
                        if (!"aeiou".Contains(word[i - 1]) & !"aeiou".Contains(word[i + 1]))
                        {
                            result.Append('h');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('h');
                        continue;
                    }
                }

                //  K
                if (word[i].Equals('k'))
                {
                    result.Append('k');
                    continue;
                }

                //  P
                if (word[i].Equals('p'))
                {
                    if (i + 1 <= word.Length)
                    {
                        if (word.Substring(i, 2).Equals("ph"))
                        {
                            result.Append('f');
                            continue;
                        }
                        else
                        {
                            result.Append('p');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('p');
                        continue;
                    }
                }

                //  Q
                if (word[i].Equals('q'))
                {
                    result.Append('k');
                    continue;
                }

                //  S
                if (word[i].Equals('s'))
                {
                    if (i + 3 <= word.Length)
                    {
                        if (word.Substring(i, 2).Equals("sh") | word.Substring(i, 3).Equals("sio") | word.Substring(i, 3).Equals("sia"))
                        {
                            result.Append('x');
                            continue;
                        }
                        else if (word.Substring(i, 3).Equals("sch"))
                        {
                            result.Append('k');
                            continue;
                        }
                        else
                        {
                            result.Append('s');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('s');
                        continue;
                    }
                }

                //  T
                if (word[i].Equals('t'))
                {
                    if (i + 3 <= word.Length)
                    {
                        if (word.Substring(i, 3).Equals("tia") | word.Substring(i, 3).Equals("tio"))
                        {
                            result.Append('x');
                            continue;
                        }
                        else if (word.Substring(i + 1, 1).Equals('h'))
                        {
                            result.Append('o');
                            continue;
                        }
                        else if (word.Substring(i, 3).Equals("tch"))
                        {
                            continue;
                        }
                        else
                        {
                            result.Append('t');
                            continue;
                        }
                    }
                    else
                    {
                        result.Append('t');
                        continue;
                    }
                }

                //  V
                if (word[i].Equals('v'))
                {
                    result.Append('f');
                    continue;
                }

                //  W - Out of range exception
                if (word[i].Equals('w'))
                {
                    if (i + 1 <= word.Length)
                    {
                        if (word.Substring(i, 2).Equals("wa") | word.Substring(i, 2).Equals("we") | word.Substring(i, 2).Equals("wi") | word.Substring(i, 2).Equals("wo") | word.Substring(i, 2).Equals("wu"))
                        {
                            result.Append('w');
                            continue;
                        }
                    }
                }

                //  X
                if (word[i].Equals('x'))
                {
                    result.Append("ks");
                    continue;
                }

                //  Y - Out of range exception
                if (word[i].Equals('y'))
                {
                    if (i + 1 <= word.Length)
                    {
                        if (word.Substring(i, 2).Equals("ya") | word.Substring(i, 2).Equals("ye") | word.Substring(i, 2).Equals("yi") | word.Substring(i, 2).Equals("yo") | word.Substring(i, 2).Equals("yu"))
                        {
                            result.Append('y');
                            continue;
                        }
                    }
                }

                // Z
                if (word[i].Equals('z'))
                {
                    result.Append('s');
                    continue;
                }
            }
            return result.ToString().ToUpper();
        }
        static void Main(string[] args)
        {
        }
    }
}
