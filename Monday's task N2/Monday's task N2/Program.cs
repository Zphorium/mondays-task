


string nameBudget = "Büdce :";
double yBudgetAzerbaijan = 20000000000;

Console.WriteLine(nameBudget);
Console.WriteLine(yBudgetAzerbaijan);

string nameBudgetMudafiyeN = "Müdafie Nazirliyine :";
double yBudgetMudafiyeN = (yBudgetAzerbaijan * 20)/ 100 ;
Console.WriteLine(nameBudgetMudafiyeN);
Console.WriteLine(yBudgetMudafiyeN);

string nameBudgetYuksekT = "Yüksek Texnologiyalar Nazirliyine :";
double yBudgetYüksəkTexn = (yBudgetAzerbaijan * 10) / 100;
Console.WriteLine(nameBudgetYuksekT);
Console.WriteLine(yBudgetYüksəkTexn);


string nameBudgetLastbudget = "Yerde qalan büdce :";
double lastBudgetAzerbaijan = yBudgetAzerbaijan - (yBudgetMudafiyeN + yBudgetYüksəkTexn);
Console.WriteLine(nameBudgetLastbudget);
Console.WriteLine(lastBudgetAzerbaijan);

