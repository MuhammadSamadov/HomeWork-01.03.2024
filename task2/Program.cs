

using task2;

var ph=new PhotoBook(16);
System.Console.WriteLine(ph.GetNumberPages());

var bigph= new BigPhotoBook(24);
System.Console.WriteLine(bigph.GetNumberPages());

var phtest=new PhotoBookTest(64);
System.Console.WriteLine(phtest.GetNumberPages());