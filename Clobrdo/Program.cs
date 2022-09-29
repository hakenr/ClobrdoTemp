using Clobrdo;

HraciDeska hraciDeska = new LinearniHraciDeska(pocetPolicek: 10);
Hra hra = new Hra(hraciDeska);

Hrac hracRobert = new Hrac("Robert");
Hrac hracKarel = new Hrac("Karel");
Hrac hracMartin = new Hrac("Martin");

hra.PridejHrace(hracRobert);
hra.PridejHrace(hracKarel);
hra.PridejHrace(hracMartin);

hra.Start();

