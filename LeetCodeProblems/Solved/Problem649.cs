using System;
namespace LeetCodeProblems
{
	public class Problem649: Solution
	{
		public Problem649()
		{
		}

        public void Run()
        {
            string actual = PredictPartyVictory("RD");
            string expected = "Radiant";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = PredictPartyVictory("RDD");
            expected = "Dire";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = PredictPartyVictory("RDDD");
            expected = "Dire";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = PredictPartyVictory("DRRDRDRDRDDRDRDR");
            expected = "Radiant";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public string PredictPartyVictory(string senate)
        {
            bool[] ignored = new bool[senate.Length];

            bool hasR = true;
            bool hasD = true;

            while (hasR && hasD)
            {
                hasR = false;
                hasD = false;
                for (int i = 0; i < senate.Length; i++)
                {
                    if (!ignored[i])
                    {
                        hasR = senate[i] == 'R' || hasR;
                        hasD = senate[i] == 'D' || hasD;

                        for (int j = i+1; j < senate.Length+i; j++)
                        {
                            int idx = j >= senate.Length ? j - senate.Length : j;
                            if (ignored[idx] || i == idx || senate[i] == senate[idx])
                            {
                                continue;
                            }
                            else
                            {
                                ignored[idx] = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (hasR)
            {
                return "Radiant";
            }
            return "Dire";
        }
    }
}

