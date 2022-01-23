using System;
using System.Collections.Generic;
using System.Text;

namespace _6kyu
{
    public class WhoLikesItKata
    {
        public static string Likes(string[] name)
        {
            var likeFunctions = InitialiseLikeFunctions();
            var key = SetKey(name, likeFunctions);
            var ending = SetEndingSingularOrPlural(key);
            var likeFunction = likeFunctions[key];
            return likeFunction(name, ending);
        }

        private static Dictionary<int, Func<string[], string, string>> InitialiseLikeFunctions()
        {
            return new Dictionary<int, Func<string[], string, string>>
            {
                { 0, ZeroLikes },
                { 1, OneLike },
                { 2, TwoLike },
                { 3, ThreeLikes },
                { 4, MoreThanThreeLikes }
            };
        }

        private static string ZeroLikes(string[] name, string ending) => "no one " + ending;
        private static string OneLike(string[] name, string ending) => $"{name[0]} " + ending;
        private static string TwoLike(string[] name, string ending) => $"{name[0]} and {name[1]} " + ending;
        private static string ThreeLikes(string[] name, string ending) => $"{name[0]}, {name[1]} and {name[2]} " + ending;
        private static string MoreThanThreeLikes(string[] name, string ending) => $"{name[0]}, {name[1]} and {CountOthers(name)} others " + ending;
        private static int CountOthers(string[] name) => name.Length - 2;

        private static int SetKey(string[] name, Dictionary<int, Func<string[], string, string>> functionalDict) => (UseFinalFunction(name, functionalDict) ? FinalKeyValue(functionalDict) : NumberOfPeople(name));
        private static bool UseFinalFunction(string[] name, Dictionary<int, Func<string[], string, string>> functionalDict) => NumberOfPeople(name) > FinalKeyValue(functionalDict);
        private static int FinalKeyValue(Dictionary<int, Func<string[], string, string>> functionalDict) => functionalDict.Count - 1;
        private static int NumberOfPeople(string[] name) => name.Length;

        private static string SetEndingSingularOrPlural(int key) => key < 2 ? Singular() : Plural();
        private static string Singular() => "likes this";
        private static string Plural() => "like this";
    }
}
