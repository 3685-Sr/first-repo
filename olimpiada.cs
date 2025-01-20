int testSamples = int.Parse(Console.ReadLine());

        for (int i = 0; i <= testSamples; i++)
        {
            string input = Console.ReadLine();

            int[] array = input.Split().Select(int.Parse).ToArray();

            int chosenParticipants = array[0];
            int prizes = array[1];
            int allParticipants = array[2];
            int allPrizes = array[3];

            int factParticipants = allParticipants - chosenParticipants;
            int factPrizes = allPrizes - prizes;

            for (int n = chosenParticipants - 1; n > 0; n--)
            {
                chosenParticipants *= n;
            }

            for (int n1 = prizes - 1; n1 > 0; n1--)
            {
                prizes *= n1;
            }

            for (int n2 = allParticipants - 1; n2 > 0; n2--)
            {
                allParticipants *= n2;
            }

            for (int n3 = allPrizes - 1; n3 > 0; n3--)
            {
                allPrizes *= n3;
            }

            for (int n4 = factParticipants - 1; n4 > 0; n4--)
            {
                factParticipants *= n4;
            }

            for (int n5 = factPrizes - 1; n5 > 0; n5--)
            {
                factPrizes *= n5;
            }

            int combinationParticipants = allParticipants / (chosenParticipants * factParticipants);
            int combinationPrizes = allPrizes / (prizes * factPrizes);

            int allCombination = combinationParticipants * combinationPrizes;

            Console.WriteLine(allCombination);
        }
