using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSiSViT_1
{
    public class Parser
    {
        public static List<Tuple<string, int>> OperandParse(string input)
        {
            var operandCounts = new Dictionary<string, int>();
            var matches = Regex.Matches(input, @"[$]\w+");

            foreach (Match match in matches)
            {
                if (operandCounts.ContainsKey(match.Value))
                {
                    operandCounts[match.Value]++;
                }
                else
                {
                    operandCounts.Add(match.Value,0);
                }
            }

            var result = new List<Tuple<string, int>>();
            foreach (var pair in operandCounts)
            {
                result.Add(new Tuple<string, int>(pair.Key, pair.Value));
            }

            return result;
        }

        private static List<Tuple<string, int>> CountOperators(string code)
        {
            string[] operators = { "+", "-", "*", "/", "%", ">", "<", "==", "!=", "&&", "||", "**", "<>", "<=", ">=", "!", "++", "--", "." };
            Dictionary<string, int> operatorCounts = new Dictionary<string, int>();
            foreach (string line in code.Split('\n'))
                foreach (string op in operators)
                {
                    int count = CountOccurrences(line, op);
                    if (count > 0)
                    {
                        if (operatorCounts.ContainsKey(op))
                            operatorCounts[op] += count;
                        else
                            operatorCounts[op] = count;
                    }
                }
            List<Tuple<string, int>> result = operatorCounts
                .Select(kv => Tuple.Create(kv.Key, kv.Value))
                .ToList();

            return result;
        }

        private static int CountOccurrences(string text, string substr)
        {
            int count = 0;
            int index = text.IndexOf(substr, StringComparison.Ordinal);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(substr, index + 1, StringComparison.Ordinal);
            }
            return count;
        }

        private static List<Tuple<string, int>> CountPhpOperators(string phpCode)
        {
            var operatorCount = new List<Tuple<string, int>>();
            string pattern = @"\b(?:if|else|while|for|foreach|switch|case|break|continue|return|and|or|xor)\b";
            MatchCollection matches = Regex.Matches(phpCode, pattern);
            foreach (Match match in matches)
            {
                string operatorName = match.Value;
                var existingTuple = operatorCount.Find(t => t.Item1 == operatorName);
                if (existingTuple != null)
                {
                    var index = operatorCount.IndexOf(existingTuple);
                    operatorCount[index] = new Tuple<string, int>(operatorName, existingTuple.Item2 + 1);
                }
                else operatorCount.Add(new Tuple<string, int>(operatorName, 1));

            }
            return operatorCount;
        }

        private static List<Tuple<string, int>> cor(List<Tuple<string, int>> list)
        {
            int i1 = list.FindIndex(tuple => tuple.Item1 == "++");
            int i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "+=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "+");
            if (i1 != -1) list[i2] = new Tuple<string, int>("+", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == ">=");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<=");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == ">");
            if (i1 != -1) list[i2] = new Tuple<string, int>(">", list[i2].Item2 - list[i1].Item2);
            i1 = list.FindIndex(tuple => tuple.Item1 == "<>");
            i2 = list.FindIndex(tuple => tuple.Item1 == "<");
            if (i1 != -1) list[i2] = new Tuple<string, int>("<", list[i2].Item2 - list[i1].Item2);
            return list;
        }

        public static List<Tuple<string, int>> OperatorParse(string code)
        {
            var res1 = cor(CountOperators(code));
            var res2 = CountPhpOperators(code);
            foreach (var item in res2)
                res1.Add(item);
            return res1;
        }
    }
}
