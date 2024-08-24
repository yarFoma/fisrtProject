using VolumeBot;



Soldier ivan;
Soldier petr = new Soldier();
Soldier sergey;
Soldier anatolyy;
Soldier gennady;
Soldier ashot;
Soldier vagan;


petr.Name = "Petrucho";
petr.Age = 20;
petr.IsDolboeb = true;


ivan = new Soldier();
ivan.Name = "Ivan";
ivan.Age = 22;
ivan.IsDolboeb = false;
ivan.KillEnemies();
ivan.AverageTape = 6;



sergey = new Soldier();
sergey.Name = "Sergey";
sergey.Age = 23;
sergey.IsDolboeb = false;
sergey.AverageTape = 5;
sergey.IsTyred = false;

anatolyy = new Soldier();
anatolyy.Name = "Anatoly";
anatolyy.Age = 23;
anatolyy.IsDolboeb = false;
anatolyy.AverageTape = 4;
anatolyy.IsTyred = false;

ashot = new Soldier();
ashot.Name = "AshotCumShot";
ashot.Age = 69;
ashot.IsDolboeb = true;
ashot.AverageTape = 9;

gennady = new Soldier();
gennady.Name = "Gennady";
gennady.Age = 29;
gennady.IsDolboeb = false;
gennady.KillEnemies();
gennady.AverageTape = 7;

vagan = new Soldier();
vagan.Name = "Vagan";
vagan.Age = 13;
vagan.IsDolboeb = true;
vagan.KillEnemies();
vagan.AverageTape = 10;

sergey.PrintDossie();
ivan.PrintDossie();
vagan.PrintDossie();
