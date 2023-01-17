
Random rnd = new Random();
int rnd_damage = rnd.Next(750,2000);

Plane uiobi = new Plane("Never", 1250, rnd_damage);
uiobi.War();