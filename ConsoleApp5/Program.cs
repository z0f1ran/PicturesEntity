using ConsoleApp5.Model;
using ConsoleApp5.Model.Entity;
using ConsoleApp5.Service;

using (ApplicationDbContext adc = new ApplicationDbContext()){
    PirctureDbService pds = new PirctureDbService();
    AuthorDbService ads = new AuthorDbService();
    ads.AddAuthor(new Author() { Name = "Vincent Villiam Vangog", YearOfBorn = 1853 });
    Author? Vangog = adc.Author_p.FirstOrDefault(i => i.Name == "Vincent Villiam Vangog");
    Console.WriteLine(Vangog);
    pds.AddPicture(new Picture() { Name_p = "Zvezdnaya Noch", Year_p = 1889, AuthorId = Vangog.Id});
    pds.AddPicture(new Picture()
    {
        Name_p = "Avtoportret",
        Year_p = 1889,
        AuthorId = Vangog.Id
    });
    pds.AddPicture(new Picture()
    {
        Name_p = "Irisi",
        Year_p = 1889,
        AuthorId = Vangog.Id
    });
    Author Vinci = new Author() { Name = "Leoanrdo da Vinci", YearOfBorn = 1452 };
    ads.AddAuthor(Vinci);
    pds.AddPicture(new Picture() { Name_p = "Tainaya vecherya", Year_p = 1498, AuthorId = Vinci.Id });
    pds.AddPicture(new Picture() { Name_p = "Spasitel mira", Year_p = 1500, AuthorId = Vinci.Id });
    pds.AddPicture(new Picture() { Name_p = "Dama s gornostaem", Year_p = 1489, AuthorId = Vinci.Id });
    var PictureList = pds.ListAll();
    foreach (var picture in PictureList)
    {
        Console.WriteLine(picture);
    }
    var AuthorsList = ads.ListAll();
    foreach (var author in AuthorsList)
    {
        Console.WriteLine(author);
    }
}