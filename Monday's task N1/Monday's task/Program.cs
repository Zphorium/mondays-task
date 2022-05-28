
string generalvalueAzn = "Ümumi mebleğ (AZN)";
int valueManat = 10000 ;

string generalvalueUsd = "ABŞ dolları (USD)"; //1.7Man =1Usd that is why the valueManat is divided into 1.7
float valueUsd =(float)(valueManat / 1.7);

string generalvalueRub = "Rusiya rublu (RUB)"; //0.0265Man =1Rub that is why the valueManat is divided into 0.0265
float valueRub = (float) (valueManat / 0.0265) ;

string generalvalueEur = "Avro (EUR)";
float valueEUR = (float)(valueManat / 1.8282); //1.8282Man =1Usd that is why the valueManat is divided into 1.8282

Console.WriteLine(generalvalueAzn);
Console.WriteLine(valueManat);

Console.WriteLine(generalvalueUsd);
Console.WriteLine(valueUsd);

Console.WriteLine(generalvalueRub);
Console.WriteLine(valueRub);

Console.WriteLine(generalvalueEur);
Console.WriteLine(valueEUR);
