using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace App2
{
    public class Comic
    {
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public ImageSource ImageSource
        {
            get
            {
                return new BitmapImage(new Uri(Thumbnail));
            }
        }

        public Comic(string title, string thumb)
        {
            Title = title;
            Thumbnail = thumb;
        }
    }

    public class ComicData
    {
        static ComicData()
        {
            ComicCollection.Clear();
            foreach(var c in Comics)
            {
                ComicCollection.Add(c);
            }
        }

        public static ObservableCollection<Comic> ComicCollection = new ObservableCollection<Comic>();

        public static Comic[] Comics = new Comic[]
            {
                new Comic("Silver Surfer (1968) #2", "ms-appx:///Assets/thumbnails/55cca22294d68.jpg")
, new Comic("Ant-Man: So (Trade Paperback)", "ms-appx:///Assets/thumbnails/4fe8cb51f32e0.jpg")
, new Comic("Scarlet (2010) #9", "ms-appx:///Assets/thumbnails/517aab576d132.jpg")
, new Comic("All-New Wolverine (2015) #1", "ms-appx:///Assets/thumbnails/5605795c57974.jpg")
, new Comic("S.H.I.E.L.D. (2014) #12", "ms-appx:///Assets/thumbnails/560596ef1e56d.jpg")
, new Comic("All-New, All-Different Avengers (2015) #1", "ms-appx:///Assets/thumbnails/560580639e7b8.jpg")
, new Comic("All-New X-Men (2015) #1", "ms-appx:///Assets/thumbnails/56059eba334fc.jpg")
, new Comic("Captain America: White (2015) #4", "ms-appx:///Assets/thumbnails/560585fe0f751.jpg")
, new Comic("Illuminati (2015) #1", "ms-appx:///Assets/thumbnails/5605a132a7a2d.jpg")
, new Comic("Darth Vader (2015) #12", "ms-appx:///Assets/thumbnails/56058d83bee22.jpg")
, new Comic("Ultimate End (2015) #5", "ms-appx:///Assets/thumbnails/559d6c882f535.jpg")
, new Comic("Kanan (2015) #8", "ms-appx:///Assets/thumbnails/560593beed422.jpg")
, new Comic("Amazing Spider-Man (2015) #1.1", "ms-appx:///Assets/thumbnails/56057e19ed7e9.jpg")
, new Comic("Spider-Man 2099 (2015) #3", "ms-appx:///Assets/thumbnails/5605999a2bffd.jpg")
, new Comic("Black Knight (2015) #1", "ms-appx:///Assets/thumbnails/55d34a42b4482.jpg")
, new Comic("Carnage (2015) #1", "ms-appx:///Assets/thumbnails/5603195067945.jpg")
, new Comic("All-New Hawkeye (2015) #1", "ms-appx:///Assets/thumbnails/55fc1eebb94be.jpg")
, new Comic("Blade: Undead by Daylight (2015) #1", "ms-appx:///Assets/thumbnails/55faf8ab4145b.jpg")
, new Comic("Uncanny Avengers Annual (2015) #1", "ms-appx:///Assets/thumbnails/5601a10b1db9a.jpg")
, new Comic("Groot (2015) #6", "ms-appx:///Assets/thumbnails/55fb11911ec3e.jpg")
, new Comic("Star-Lord (2015) #1", "ms-appx:///Assets/thumbnails/55e89d9bac7ee.jpg")
, new Comic("Venom: Space Knight (2015) #1", "ms-appx:///Assets/thumbnails/55e4a9193bf50.jpg")
, new Comic("Howard the Duck (2015) #1", "ms-appx:///Assets/thumbnails/55fb29b4221f0.jpg")
, new Comic("INVINCIBLE IRON MAN (2015) #3", "ms-appx:///Assets/thumbnails/56017a4ed088d.jpg")
, new Comic("Uncanny Avengers (2015) #2", "ms-appx:///Assets/thumbnails/56019daea50ba.jpg")
, new Comic("Ms. Marvel (2015) #1", "ms-appx:///Assets/thumbnails/560182d034862.jpg")
, new Comic("Avengers Vs Infinity (2015) #1", "ms-appx:///Assets/thumbnails/55faf03b1666c.jpg")
, new Comic("Figment 2 (2015) #3", "ms-appx:///Assets/thumbnails/55fb0de011adb.jpg")
, new Comic("Spider-Woman (2015) #1", "ms-appx:///Assets/thumbnails/55f82a1509128.jpg")
, new Comic("Contest of Champions (2015) #2", "ms-appx:///Assets/thumbnails/55fafb25b457f.jpg")
, new Comic("Hercules (2015) #1", "ms-appx:///Assets/thumbnails/55d6500b2e73c.jpg")
, new Comic("The Amazing Spider-Man (2015) #3", "ms-appx:///Assets/thumbnails/560198b076959.jpg")
, new Comic("Dark Tower: The Drawing of the Three - Lady of Shadows (2015) #3", "ms-appx:///Assets/thumbnails/55fb02b187d53.jpg")
, new Comic("Vision (2015) #1", "ms-appx:///Assets/thumbnails/5601adc553f1b.jpg")
, new Comic("Ultimates (2015) #1", "ms-appx:///Assets/thumbnails/56019ba95a678.jpg")
, new Comic("Deadpool (2015) #1", "ms-appx:///Assets/thumbnails/55d47d5bdafb8.jpg")
, new Comic("Miracleman by Gaiman & Buckingham (2015) #4", "ms-appx:///Assets/thumbnails/56017ebb300fd.jpg")
, new Comic("The Astonishing Ant-Man (2015) #2", "ms-appx:///Assets/thumbnails/55faed6243f73.jpg")
, new Comic("Drax (2015) #1", "ms-appx:///Assets/thumbnails/55fb062c10e31.jpg")
, new Comic("Silk (2015) #1", "ms-appx:///Assets/thumbnails/55e6ffac51996.jpg")
, new Comic("Star Wars (2015) #11", "ms-appx:///Assets/thumbnails/55f9c681a5adf.jpg")
, new Comic("What If? Infinity- Thanos (2015) #1", "ms-appx:///Assets/thumbnails/image_not_available.jpg")
, new Comic("House of M (2015) #4", "ms-appx:///Assets/thumbnails/55f8619e7f146.jpg")
, new Comic("Thors (2015) #4", "ms-appx:///Assets/thumbnails/55f9d5786a278.jpg")
, new Comic("Howling Commandos of S.H.I.E.L.D. (2015) #1", "ms-appx:///Assets/thumbnails/55f86463a81b0.jpg")
, new Comic("Squadron Sinister (2015) #4", "ms-appx:///Assets/thumbnails/55f9c39848513.jpg")
, new Comic("Captain America: Sam Wilson (2015) #2", "ms-appx:///Assets/thumbnails/image_not_available.jpg")
, new Comic("The Unbeatable Squirrel Girl (2015) #1", "ms-appx:///Assets/thumbnails/55f9d33c308f2.jpg")
, new Comic("Scarlet (2010) #8", "ms-appx:///Assets/thumbnails/5127c646dc39a.jpg")
, new Comic("Infinity Gauntlet (2015) #5", "ms-appx:///Assets/thumbnails/55f8670c2699b.jpg")
, new Comic("Secret Wars (2015) #7", "ms-appx:///Assets/thumbnails/559d464a94c7f.jpg")
, new Comic("1872 (2015) #4", "ms-appx:///Assets/thumbnails/55f6fbeeec959.jpg")
, new Comic("What If? Infinity- Thanos (2015) #1", "ms-appx:///Assets/thumbnails/55a406e5c9722.jpg")
, new Comic("Secret Wars: Agents of Atlas (2015) #1", "ms-appx:///Assets/thumbnails/55f7204cb5d00.jpg")
, new Comic("Angela: Queen of Hel (2015) #1", "ms-appx:///Assets/thumbnails/55d394f044452.jpg")
, new Comic("Brilliant (2011) #6", "ms-appx:///Assets/thumbnails/502912f2a8809.jpg")
, new Comic("Uncanny Inhumans (2015) #1", "ms-appx:///Assets/thumbnails/559179916a000.jpg")
, new Comic("Hail Hydra (2015) #4", "ms-appx:///Assets/thumbnails/55f71077c8890.jpg")
, new Comic("Karnak (2015) #1", "ms-appx:///Assets/thumbnails/55f718d34fb34.jpg")
, new Comic("Weirdworld (2015) #5", "ms-appx:///Assets/thumbnails/55f84faa7702c.jpg")
, new Comic("S.H.I.E.L.D. (2014) #11", "ms-appx:///Assets/thumbnails/55f71d39b5ba7.jpg")
, new Comic("Age of Apocalypse (2015) #5", "ms-appx:///Assets/thumbnails/55f7025e1c6c2.jpg")
, new Comic("The Amazing Spider-Man (2015) #2", "ms-appx:///Assets/thumbnails/55f82b55dafa3.jpg")
, new Comic("The Astonishing Ant-Man (2015) #1", "ms-appx:///Assets/thumbnails/55f70e5ecbe02.jpg")
, new Comic("INVINCIBLE IRON MAN (2015) #2", "ms-appx:///Assets/thumbnails/55f714c9967b3.jpg")
, new Comic("Marvel Zombies (2015) #4", "ms-appx:///Assets/thumbnails/image_not_available.jpg")
, new Comic("Captain America: White (2015) #3", "ms-appx:///Assets/thumbnails/55ef4b597bb9d.jpg")
, new Comic("New Avengers (2015) #1", "ms-appx:///Assets/thumbnails/55f068f6b2d95.jpg")
, new Comic("Deadpool Vs. Thanos (2015) #3", "ms-appx:///Assets/thumbnails/55f039366bb2f.jpg")
, new Comic("Figment 2 (2015) #2", "ms-appx:///Assets/thumbnails/55f03ede7143e.jpg")
, new Comic("Spider-Man 2099 (2015) #1", "ms-appx:///Assets/thumbnails/55d736022bd09.jpg")
, new Comic("Marvel Universe Avengers Assemble Season Two (2014) #12", "ms-appx:///Assets/thumbnails/55f04fe783ed1.jpg")
, new Comic("What If? Infinity- Thanos (2015) #1", "ms-appx:///Assets/thumbnails/image_not_available.jpg")
, new Comic("Captain America: Sam Wilson (2015) #1", "ms-appx:///Assets/thumbnails/55ef48bae2add.jpg")
, new Comic("Ms. Marvel (2014) #19", "ms-appx:///Assets/thumbnails/55f0657cb8ecc.jpg")
, new Comic("Civil War (2015) #5", "ms-appx:///Assets/thumbnails/55f036566b565.jpg")
, new Comic("Spider-Gwen (2015) #1", "ms-appx:///Assets/thumbnails/558ae0c40c269.jpg")
, new Comic("Extraordinary X-Men (2015) #1", "ms-appx:///Assets/thumbnails/55940417dcb5c.jpg")
, new Comic("Guardians of the Galaxy (2015) #1", "ms-appx:///Assets/thumbnails/55d6339659631.jpg")
, new Comic("Uncanny Avengers (2015) #1", "ms-appx:///Assets/thumbnails/55f6f4d7797cf.jpg")
, new Comic("Groot (2015) #5", "ms-appx:///Assets/thumbnails/55d23999c0bbc.jpg")
, new Comic("Uncanny X-Men (2013) #600", "ms-appx:///Assets/thumbnails/54d38a627e7ae.jpg")
, new Comic("Marvel Super Hero Contest of Champions (2015) #1", "ms-appx:///Assets/thumbnails/55d23f7878fb6.jpg")
, new Comic("1602 Witch Hunter Angela (2015) #4", "ms-appx:///Assets/thumbnails/5601855c253f1.jpg")
, new Comic("Secret Wars (2015) #8", "ms-appx:///Assets/thumbnails/55d4c140ee29d.jpg")
, new Comic("All-New, All-Different Avengers (2015)", "ms-appx:///Assets/thumbnails/56019395d3746.jpg")
, new Comic("Siege (2015) #4", "ms-appx:///Assets/thumbnails/55ef3bb7d126a.jpg")
, new Comic("Contest of Champions (2015) #1 (Brereton Kirby Monster Variant)", "ms-appx:///Assets/thumbnails/55f0a1836cc61.jpg")
, new Comic("Contest of Champions (2015) #1", "ms-appx:///Assets/thumbnails/56019b6694c9d.jpg")
, new Comic("The Amazing Spider-Man (2015) #1", "ms-appx:///Assets/thumbnails/56018e2b604d1.jpg")
, new Comic("Contest of Champions (2015) #1 (Lim Connecting Variant a)", "ms-appx:///Assets/thumbnails/55f0a04f68f5b.jpg")
, new Comic("Doctor Strange (2015) #1", "ms-appx:///Assets/thumbnails/5605a1db4b9a5.jpg")
, new Comic("Contest of Champions (2015) #1 (Bagley Classic Variant)", "ms-appx:///Assets/thumbnails/55f09e9470c29.jpg")
, new Comic("What If? Infinity- Thanos (2015) #1", "ms-appx:///Assets/thumbnails/5602ae2fa1e1b.jpg")
, new Comic("INVINCIBLE IRON MAN (2015) #1 (Wraparound Cover)", "ms-appx:///Assets/thumbnails/5575ed74293fc.jpg")
, new Comic("Contest of Champions (2015) #1 (Christopher Action Figure Variant)", "ms-appx:///Assets/thumbnails/55f09feb3bb6e.jpg")
, new Comic("Secret Wars (2015) #6", "ms-appx:///Assets/thumbnails/55786adc0074d.jpg")
, new Comic("ALL-NEW, ALL-DIFFERENT MARVEL POINT ONE  (2015) #1", "ms-appx:///Assets/thumbnails/55d22bcf906d3.jpg")
, new Comic("Darth Vader (2015) #10", "ms-appx:///Assets/thumbnails/56058d3ca3a22.jpg")
, new Comic("Spider-Island (2015) #5", "ms-appx:///Assets/thumbnails/55ef3efb5d1ef.jpg")

            };
    }
}