namespace BookApp.Migrations
{
    using BookApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookApp.Models.BookAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookApp.Models.BookAppContext context)
        {
            context.Books.AddOrUpdate(x => x.id,
                new Book() { title = "Pride and Prejudice" },
                new Book() { title = "Anna Karenina" },
                new Book() { title = "Crime and Punishmen" },
                new Book() { title = "The Great Gatsby" },
                new Book() { title = "1984" },
                new Book() { title = "Adventures of Huckleberry Finn" },
                new Book() { title = "The Brothers Karamazov" },
                new Book() { title = "Middlemarch" },
                new Book() { title = "One Hundred Years of Solitude" },
                new Book() { title = "The Sound and the Fury" },
                new Book() { title = "The Catcher in the Rye" },
                new Book() { title = "The Metamorphosis" },
                new Book() { title = "To the Lighthouse" },
                new Book() { title = "On the Road" },
                new Book() { title = "Gulliver's Travels" },
                new Book() { title = "The Portrait of a Lady" },
                new Book() { title = "The Illiad" },
                new Book() { title = "The Odyssey" },
                new Book() { title = "Catch-22" },
                new Book() { title = "Emma" },
                new Book() { title = "Brave New World" },
                new Book() { title = "To Kill a Mockingbird" },
                new Book() { title = "Jane Eyre" },
                new Book() { title = "Wuthering Heights" },
                new Book() { title = "Lord of the Flies" },
                new Book() { title = "The Aeneid" },
                new Book() { title = "The Call of the Wild" },
                new Book() { title = "Frankenstein" },
                new Book() { title = "The Sun Also Rises" },
                new Book() { title = "The Scarlet Letter" },
                new Book() { title = "A Farewell to Arms" },
                new Book() { title = "Great Expectations" },
                new Book() { title = "Candide" },
                new Book() { title = "The Picture of Dorian Gray" },
                new Book() { title = "Moby-Dick" },
                new Book() { title = "In Search of Lost Time" },
                new Book() { title = "Orlando" },
                new Book() { title = "The Age of Innocence" },
                new Book() { title = "Sense and Sensibility" },
                new Book() { title = "Slaughterhouse-Five" },
                new Book() { title = "Lolita" },
                new Book() { title = "Rebecca" },
                new Book() { title = "The Importance of Being Earnest" },
                new Book() { title = "East of Eden" },
                new Book() { title = "Madame Bovary" },
                new Book() { title = "A Clockwork Orange" },
                new Book() { title = "Heart of Darkness" },
                new Book() { title = "The Bell Jar" },
                new Book() { title = "The Canterbury Tales" },
                new Book() { title = "The Awakening" },
                new Book() { title = "The Crying of Lot 49" }
                );
        }
    }
}
