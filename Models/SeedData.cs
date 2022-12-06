using Microsoft.EntityFrameworkCore;

namespace Final4360
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DBContext>>()))
            {
                // Look for any residents.
                if (!context.resident.Any())
                {
                    string email="mvhohmann1@buffs.wtamu.edu";
                    context.resident.AddRange(
                        new resident{FullName="Kittie Mousdall",Email=email,UnitNumber=101},
                        new resident{FullName="Claudette Rait",Email=email,UnitNumber=102},
                        new resident{FullName="Eliza Himsworth",Email=email,UnitNumber=103},
                        new resident{FullName="Emmit Gann",Email=email,UnitNumber=104},
                        new resident{FullName="Aurlie Pedycan",Email=email,UnitNumber=105},
                        new resident{FullName="Keriann Kettlesting",Email=email,UnitNumber=106},
                        new resident{FullName="Fiorenze Iacovuzzi",Email=email,UnitNumber=107},
                        new resident{FullName="Darlene Gravie",Email=email,UnitNumber=108},
                        new resident{FullName="Tomasine Challener",Email=email,UnitNumber=109},
                        new resident{FullName="Dotti Marple",Email=email,UnitNumber=110},
                        new resident{FullName="Gabriel Tofanelli",Email=email,UnitNumber=201},
                        new resident{FullName="Aldo Welldrake",Email=email,UnitNumber=202},
                        new resident{FullName="Ezmeralda Laydon",Email=email,UnitNumber=203},
                        new resident{FullName="Kale Lendrem",Email=email,UnitNumber=204},
                        new resident{FullName="Lenard Cubbit",Email=email,UnitNumber=205},
                        new resident{FullName="Dedie Caddies",Email=email,UnitNumber=206},
                        new resident{FullName="Nancy Janosevic",Email=email,UnitNumber=207},
                        new resident{FullName="Layne Whiterod",Email=email,UnitNumber=208},
                        new resident{FullName="Averell Labusch",Email=email,UnitNumber=209},
                        new resident{FullName="Gordan Raddon",Email=email,UnitNumber=210},
                        new resident{FullName="Deloria Johnes",Email=email,UnitNumber=301},
                        new resident{FullName="Emmett MacIllrick",Email=email,UnitNumber=302},
                        new resident{FullName="Sanderson Simoncelli",Email=email,UnitNumber=303},
                        new resident{FullName="Had Hapke",Email=email,UnitNumber=304},
                        new resident{FullName="Bellina Rodenburgh",Email=email,UnitNumber=305},
                        new resident{FullName="Portie Searle",Email=email,UnitNumber=306},
                        new resident{FullName="Ellsworth Richichi",Email=email,UnitNumber=307},
                        new resident{FullName="Orlando Mattholie",Email=email,UnitNumber=308},
                        new resident{FullName="Noby Phelp",Email=email,UnitNumber=309},
                        new resident{FullName="Wilow Caush",Email=email,UnitNumber=310},
                        new resident{FullName="Hesther Wincom",Email=email,UnitNumber=401},
                        new resident{FullName="Ferdie Jzhakov",Email=email,UnitNumber=402},
                        new resident{FullName="Cornelia Burlingham",Email=email,UnitNumber=403},
                        new resident{FullName="Rochella Childers",Email=email,UnitNumber=404},
                        new resident{FullName="Jennie Christensen",Email=email,UnitNumber=405},
                        new resident{FullName="Kalie Cropper",Email=email,UnitNumber=406},
                        new resident{FullName="Corinne Garrison",Email=email,UnitNumber=407},
                        new resident{FullName="Maybelle Pigne",Email=email,UnitNumber=408},
                        new resident{FullName="Wald Kuddyhy",Email=email,UnitNumber=409},
                        new resident{FullName="Blancha Ambrosoni",Email=email,UnitNumber=410},
                        new resident{FullName="Gussy Moiser",Email=email,UnitNumber=501},
                        new resident{FullName="Margette Symcock",Email=email,UnitNumber=502},
                        new resident{FullName="Cad Stearnes",Email=email,UnitNumber=503},
                        new resident{FullName="Juliann Sumner",Email=email,UnitNumber=504},
                        new resident{FullName="Esdras Bresland",Email=email,UnitNumber=505},
                        new resident{FullName="Alisha Laspee",Email=email,UnitNumber=506},
                        new resident{FullName="Yvon Jirusek",Email=email,UnitNumber=507},
                        new resident{FullName="Parrnell Halbeard",Email=email,UnitNumber=508},
                        new resident{FullName="Korrie Milesap",Email=email,UnitNumber=509},
                        new resident{FullName="Vivyan Petzold",Email=email,UnitNumber=510},
                        new resident{FullName="Angie Darben",Email=email,UnitNumber=101},
                        new resident{FullName="Eachelle Texton",Email=email,UnitNumber=102},
                        new resident{FullName="Lion Imlaw",Email=email,UnitNumber=103},
                        new resident{FullName="Delmore Cowhig",Email=email,UnitNumber=104},
                        new resident{FullName="Shaine Van Kruis",Email=email,UnitNumber=105},
                        new resident{FullName="Yehudi Jones",Email=email,UnitNumber=106},
                        new resident{FullName="Hamlen Gerrad",Email=email,UnitNumber=107},
                        new resident{FullName="Elisabetta Francescozzi",Email=email,UnitNumber=108},
                        new resident{FullName="Gusti Chinn",Email=email,UnitNumber=109},
                        new resident{FullName="Candace Hurlston",Email=email,UnitNumber=110},
                        new resident{FullName="Odey Butter",Email=email,UnitNumber=201},
                        new resident{FullName="Viva Bolletti",Email=email,UnitNumber=202},
                        new resident{FullName="Tallie Jubert",Email=email,UnitNumber=203},
                        new resident{FullName="Mary Vearnals",Email=email,UnitNumber=204},
                        new resident{FullName="Lona Dunbavin",Email=email,UnitNumber=205},
                        new resident{FullName="Osmond Bamlett",Email=email,UnitNumber=206},
                        new resident{FullName="Nomi Sollom",Email=email,UnitNumber=207},
                        new resident{FullName="Hildy Campana",Email=email,UnitNumber=208},
                        new resident{FullName="Emmanuel Getcliffe",Email=email,UnitNumber=209},
                        new resident{FullName="Danette Danieli",Email=email,UnitNumber=210},
                        new resident{FullName="Jan Witt",Email=email,UnitNumber=301},
                        new resident{FullName="Woodie Kertess",Email=email,UnitNumber=302},
                        new resident{FullName="Corine Cleevely",Email=email,UnitNumber=303},
                        new resident{FullName="Inez Mew",Email=email,UnitNumber=304},
                        new resident{FullName="Kathie Odd",Email=email,UnitNumber=305},
                        new resident{FullName="Mitch Friedlos",Email=email,UnitNumber=306},
                        new resident{FullName="Bambi Gostick",Email=email,UnitNumber=307},
                        new resident{FullName="Mellicent Roiz",Email=email,UnitNumber=308},
                        new resident{FullName="Sukey Avon",Email=email,UnitNumber=309},
                        new resident{FullName="Janina Kernan",Email=email,UnitNumber=310},
                        new resident{FullName="Jaynell Pitfield",Email=email,UnitNumber=401},
                        new resident{FullName="Ricki Hoppner",Email=email,UnitNumber=402},
                        new resident{FullName="Rinaldo Stable",Email=email,UnitNumber=403},
                        new resident{FullName="Tessy Tabour",Email=email,UnitNumber=404},
                        new resident{FullName="Helen Ferencz",Email=email,UnitNumber=405},
                        new resident{FullName="Korney Shakelade",Email=email,UnitNumber=406},
                        new resident{FullName="Tulley Reiner",Email=email,UnitNumber=407},
                        new resident{FullName="Myrle Mersh",Email=email,UnitNumber=408},
                        new resident{FullName="Carina Nelthorp",Email=email,UnitNumber=409},
                        new resident{FullName="Monte Trahmel",Email=email,UnitNumber=410},
                        new resident{FullName="Nate Zavattero",Email=email,UnitNumber=501},
                        new resident{FullName="Neddy Bucky",Email=email,UnitNumber=502},
                        new resident{FullName="Allissa Collyns",Email=email,UnitNumber=503},
                        new resident{FullName="Brianna Ruberry",Email=email,UnitNumber=504},
                        new resident{FullName="Roxane Wellen",Email=email,UnitNumber=505},
                        new resident{FullName="Ashbey Keddy",Email=email,UnitNumber=506},
                        new resident{FullName="Elvin Mico",Email=email,UnitNumber=507},
                        new resident{FullName="Nicolas Hanratty",Email=email,UnitNumber=508},
                        new resident{FullName="Gary Jochens",Email=email,UnitNumber=509},
                        new resident{FullName="Alexina Tarbard",Email=email,UnitNumber=510}
                    );
                    context.SaveChanges();
                }
                // Look for any staff.
                if (!context.staff.Any())
                {
                    context.staff.AddRange(
                        new staff{StaffUsername="alice",StaffPassword="alice123"},
                        new staff{StaffUsername="bob",StaffPassword="bob123"}
                    );
                    context.SaveChanges();
                }
                // Look for any staff.
                if (!context.posting.Any())
                {
                    context.posting.AddRange(
                        new posting{Service="FedEx"},
                        new posting{Service="USPS"},
                        new posting{Service="UPS"}
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}