using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Mangas.Any())
                return;

            var mangas = new List<Manga>
            {
                new Manga
                {
                    Title = "Monster",
                    Description =
                        "Kenzou Tenma, a renowned Japanese neurosurgeon working in post-war Germany, faces a difficult choice: to operate on Johan Liebert, an orphan boy on the verge of death, or on the mayor of Düsseldorf. In the end, Tenma decides to gamble his reputation by saving Johan, effectively leaving the mayor for dead. As a consequence of his actions, hospital director Heinemann strips Tenma of his position, and Heinemann's daughter Eva breaks off their engagement. Disgraced and shunned by his colleagues, Tenma loses all hope of a successful career—that is, until the mysterious killing of Heinemann gives him another chance. Nine years later, Tenma is the head of the surgical department and close to becoming the director himself. Although all seems well for him at first, he soon becomes entangled in a chain of gruesome murders that have taken place throughout Germany. The culprit is a monster—the same one that Tenma saved on that fateful day nine years ago.",
                    Author = "Urasawa, Naoki",
                    Picture = "https://cdn.myanimelist.net/images/manga/3/258224.webp",
                    Status = "Finished",
                    Chapters = 162,
                    Volumes = 18,
                },
                new Manga
                {
                    Title = "Berserk",
                    Description =
                        "Guts, a former mercenary now known as the Black Swordsman, is out for revenge. After a tumultuous childhood, he finally finds someone he respects and believes he can trust, only to have everything fall apart when this person takes away everything important to Guts for the purpose of fulfilling his own desires. Now marked for death, Guts becomes condemned to a fate in which he is relentlessly pursued by demonic beings. Setting out on a dreadful quest riddled with misfortune, Guts, armed with a massive sword and monstrous strength, will let nothing stop him, not even death itself, until he is finally able to take the head of the one who stripped him—and his loved one—of their humanity.",
                    Author = "Miura, Kentarou",
                    Picture = "https://cdn.myanimelist.net/images/manga/1/157897.webp",
                    Status = "Publishing",
                    Chapters = 180,
                    Volumes = 22,
                },
                new Manga
                {
                    Title = "Hajime no Ippo",
                    Description =
                        "Makunouchi Ippo is a 16-year-old high school student who helps his mother run the family business. His hefty workload impedes on his social life, making him an easy target for bullies. One day, while being beaten up by a group of high school students, Ippo is saved by a boxer named Mamoru Takamura, and is brought to the Kamogawa Boxing Gym. This afterschool bullying session turns his life around for the better as Ippo discovers his latent talent for boxing and decides to practice the sport professionally. However, Mamoru doubts Ippo's determination and assigns him a task deemed impossible to complete, but the resolute Ippo trains tirelessly to fulfill his mission. Along the way, he finds out what it means to attain true strength while making new friends and fighting formidable foes.",
                    Author = "Morikawa, George",
                    Picture = "https://cdn.myanimelist.net/images/manga/2/250313.webp",
                    Status = "Publishing",
                    Chapters = 176,
                    Volumes = 20,
                },
            };

            await context.Mangas.AddRangeAsync(mangas);
            await context.SaveChangesAsync();
        }
    }
}
