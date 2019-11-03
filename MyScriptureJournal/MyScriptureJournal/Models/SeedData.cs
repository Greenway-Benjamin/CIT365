using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book
                    {
                        ID = 1,
                        Name = "Genesis"
                    },
                    new Book
                    {
                        ID = 2,
                        Name = "Exodus"
                    },
                    new Book
                    {
                        ID = 3,
                        Name = "Leviticus"
                    },
                    new Book
                    {
                        ID = 4,
                        Name = "Numbers"
                    },
                    new Book
                    {
                        ID = 5,
                        Name = "Deuteronomy"
                    },
                    new Book
                    {
                        ID = 6,
                        Name = "Joshua"
                    },
                    new Book
                    {
                        ID = 7,
                        Name = "Judges"
                    },
                    new Book
                    {
                        ID = 8,
                        Name = "Ruth"
                    },
                    new Book
                    {
                        ID = 9,
                        Name = "1 Samuel"
                    },
                    new Book
                    {
                        ID = 10,
                        Name = "2 Samuel"
                    },
                    new Book
                    {
                        ID = 11,
                        Name = "1 Kings"
                    },
                    new Book
                    {
                        ID = 12,
                        Name = "2 Kings"
                    },
                    new Book
                    {
                        ID = 13,
                        Name = "1 Chronicles"
                    },
                    new Book
                    {
                        ID = 14,
                        Name = "2 Chronicles"
                    },
                    new Book
                    {
                        ID = 15,
                        Name = "Ezra"
                    },
                    new Book
                    {
                        ID = 16,
                        Name = "Nehemiah"
                    },
                    new Book
                    {
                        ID = 17,
                        Name = "Esther"
                    },
                    new Book
                    {
                        ID = 18,
                        Name = "Job"
                    },
                    new Book
                    {
                        ID = 19,
                        Name = "Psalms"
                    },
                    new Book
                    {
                        ID = 20,
                        Name = "Proverbs"
                    },
                    new Book
                    {
                        ID = 21,
                        Name = "Ecclesiastes"
                    },
                    new Book
                    {
                        ID = 22,
                        Name = "Song of Solomon"
                    },
                    new Book
                    {
                        ID = 23,
                        Name = "Isaiah"
                    },
                    new Book
                    {
                        ID = 24,
                        Name = "Jeremiah"
                    },
                    new Book
                    {
                        ID = 25,
                        Name = "Lamentations"
                    },
                    new Book
                    {
                        ID = 26,
                        Name = "Ezekiel"
                    },
                    new Book
                    {
                        ID = 27,
                        Name = "Daniel"
                    },
                    new Book
                    {
                        ID = 28,
                        Name = "Hosea"
                    },
                    new Book
                    {
                        ID = 29,
                        Name = "Joel"
                    },
                    new Book
                    {
                        ID = 30,
                        Name = "Amos"
                    },
                    new Book
                    {
                        ID = 31,
                        Name = "Obadiah"
                    },
                    new Book
                    {
                        ID = 32,
                        Name = "Jonah"
                    },
                    new Book
                    {
                        ID = 33,
                        Name = "Micah"
                    },
                    new Book
                    {
                        ID = 34,
                        Name = "Nahum"
                    },
                    new Book
                    {
                        ID = 35,
                        Name = "Habakkuk"
                    },
                    new Book
                    {
                        ID = 36,
                        Name = "Zephaniah"
                    },
                    new Book
                    {
                        ID = 37,
                        Name = "Haggai"
                    },
                    new Book
                    {
                        ID = 38,
                        Name = "Zechariah"
                    },
                    new Book
                    {
                        ID = 39,
                        Name = "Malachi"
                    },



                    new Book
                    {
                        ID = 40,
                        Name = "Matthew"
                    },
                    new Book
                    {
                        ID = 41,
                        Name = "Mark"
                    },
                    new Book
                    {
                        ID = 42,
                        Name = "Luke"
                    },
                    new Book
                    {
                        ID = 43,
                        Name = "John"
                    },
                    new Book
                    {
                        ID = 44,
                        Name = "Acts"
                    },
                    new Book
                    {
                        ID = 45,
                        Name = "Romans"
                    },
                    new Book
                    {
                        ID = 46,
                        Name = "1 Corinthians"
                    },
                    new Book
                    {
                        ID = 47,
                        Name = "2 Corinthians"
                    },
                    new Book
                    {
                        ID = 48,
                        Name = "Galatians"
                    },
                    new Book
                    {
                        ID = 49,
                        Name = "Ephesians"
                    },
                    new Book
                    {
                        ID = 50,
                        Name = "Philippians"
                    },
                    new Book
                    {
                        ID = 51,
                        Name = "Colossians"
                    },
                    new Book
                    {
                        ID = 52,
                        Name = "1 Thessalonians"
                    },
                    new Book
                    {
                        ID = 53,
                        Name = "2 Thessalonians"
                    },
                    new Book
                    {
                        ID = 54,
                        Name = "1 Timothy"
                    },
                    new Book
                    {
                        ID = 55,
                        Name = "2 Timothy"
                    },
                    new Book
                    {
                        ID = 56,
                        Name = "Titus"
                    },
                    new Book
                    {
                        ID = 57,
                        Name = "Philemon"
                    },
                    new Book
                    {
                        ID = 58,
                        Name = "Hebrews"
                    },
                    new Book
                    {
                        ID = 59,
                        Name = "James"
                    },
                    new Book
                    {
                        ID = 60,
                        Name = "1 Peter"
                    },
                    new Book
                    {
                        ID = 61,
                        Name = "2 Peter"
                    },
                    new Book
                    {
                        ID = 62,
                        Name = "1 John"
                    },
                    new Book
                    {
                        ID = 63,
                        Name = "2 John"
                    },
                    new Book
                    {
                        ID = 64,
                        Name = "3 John"
                    },
                    new Book
                    {
                        ID = 65,
                        Name = "Jude"
                    },
                    new Book
                    {
                        ID = 66,
                        Name = "Revelation"
                    },


                    new Book
                    {
                        ID = 67,
                        Name = "1 Nephi"
                    },
                    new Book
                    {
                        ID = 68,
                        Name = "2 Nephi"
                    },
                    new Book
                    {
                        ID = 69,
                        Name = "Jacob"
                    },
                    new Book
                    {
                        ID = 70,
                        Name = "Enos"
                    },
                    new Book
                    {
                        ID = 71,
                        Name = "Jarom"
                    },
                    new Book
                    {
                        ID = 72,
                        Name = "Omni"
                    },
                    new Book
                    {
                        ID = 73,
                        Name = "Words of Mormon"
                    },
                    new Book
                    {
                        ID = 74,
                        Name = "Mosiah"
                    },
                    new Book
                    {
                        ID = 75,
                        Name = "Alma"
                    },
                    new Book
                    {
                        ID = 76,
                        Name = "Helaman"
                    },
                    new Book
                    {
                        ID = 77,
                        Name = "3 Nephi"
                    },
                    new Book
                    {
                        ID = 78,
                        Name = "4 Nephi"
                    },
                    new Book
                    {
                        ID = 79,
                        Name = "Mormon"
                    },
                    new Book
                    {
                        ID = 80,
                        Name = "Ether"
                    },
                    new Book
                    {
                        ID = 81,
                        Name = "Moroni"
                    },


                    new Book
                    {
                        ID = 82,
                        Name = "Doctrine and Covenants"
                    },


                    new Book
                    {
                        ID = 83,
                        Name = "Moses"
                    },
                    new Book
                    {
                        ID = 84,
                        Name = "Abraham"
                    },
                    new Book
                    {
                        ID = 85,
                        Name = "Joseph Smith History"
                    },
                    new Book
                    {
                        ID = 86,
                        Name = "Articles of Faith"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
