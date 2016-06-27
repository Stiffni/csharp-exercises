using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeRankSolutions
{
    internal class GradeRanking
    {
        private static int Main(string[] args)
        {
            int[] sampleGrades = {75, 75, 75, 75, 99, 50};
            int[] finalRankedGrades = new int[sampleGrades.Length];

            Dictionary<int, int> gradeRanks = RankGrades(sampleGrades);

            for (int i = 0; i < sampleGrades.Length; i++)
            {
                finalRankedGrades[i] = gradeRanks[sampleGrades[i]];
                Console.WriteLine("Grade " + i + ", Rank " + finalRankedGrades[i]);
            }

            return 0;
        }

        private static Dictionary<int, int> RankGrades(int[] grades)
        {
            Dictionary<int, int> rank = new Dictionary<int, int>();
            int[] gradesDescending = new int[grades.Length];
            Array.Copy(grades, gradesDescending, grades.Length);
            Array.Sort(gradesDescending);
            Array.Reverse(gradesDescending);

            for (int i = 0; i < gradesDescending.Length; i++)
            {
                if (!(rank.ContainsKey(gradesDescending[i])))
                    rank.Add(gradesDescending[i], rank.Count + 1);
            }

            return rank;
        }
    }

}
