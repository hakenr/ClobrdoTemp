using Clobrdo;

HraciDeska hraciDeska = new HraciDeska(2);
Hra hra = new Hra(hraciDeska);

Hrac hracRobert = new Hrac("Robert");
Hrac hracKarel = new Hrac("Karel");
Hrac hracMartin = new Hrac("Martin");

hra.PridejHrace(hracRobert);
hra.PridejHrace(hracKarel);
hra.PridejHrace(hracMartin);

