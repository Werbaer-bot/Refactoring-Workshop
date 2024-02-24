
var parrot1 = new Parrot.Parrot(Parrot.Parrot.ParrotTypeEnum.AFRICAN, 1, 100, false);
var parrot2 = new Parrot.Parrot(Parrot.Parrot.ParrotTypeEnum.EUROPEAN, 1, 100, false);
var parrot3 = new Parrot.Parrot(Parrot.Parrot.ParrotTypeEnum.NORWEGIAN_BLUE, 1, 100, true);
Console.WriteLine("Parrot1 Speed: " + parrot1.GetSpeed());
Console.WriteLine("Parrot1 Speed: " + parrot2.GetSpeed());
Console.WriteLine("Parrot1 Speed: " + parrot3.GetSpeed());
