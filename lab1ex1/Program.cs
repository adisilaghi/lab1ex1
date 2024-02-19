/*Ex1 Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui*/


Console.WriteLine("Introduceti lungimea");
int lungime = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti latime");
int latime = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti inaltime");
int inaltime = Convert.ToInt32(Console.ReadLine());

int volum = (lungime * latime * inaltime);
Console.WriteLine("Volumul paralelipedului este:"+volum);

