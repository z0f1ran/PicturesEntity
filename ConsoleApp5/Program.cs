using ConsoleApp5.Model;
using ConsoleApp5.Model.Entity;
using ConsoleApp5.Service;

using (ApplicationDbContext adc = new ApplicationDbContext()){
    PirctureDbService pds = new PirctureDbService();
    Console.WriteLine(pds.FindById(2));
    Console.WriteLine(pds.FindById(1));
    Console.WriteLine("-----------------------------------");
    if (adc.Picture_p.Where(i=>i.Name_p == "Italyanskoe utro").FirstOrDefault() == null)
    {
        pds.AddPicture(new Picture() { Name_p = "Italyanskoe utro", Year_p = 1866 });
    }
    var PictureList = pds.ListAll();
    foreach (var picture in PictureList)
    {
        Console.WriteLine(picture);
    }
}