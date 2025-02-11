using System.Collections.Generic;

namespace BookTracker.Services
{
    public class PublisherService
    {
        public List<string> GetPublishers()
        {
            return new List<string>
            {
                "Penguin Random House",
                "HarperCollins",
                "Macmillan",
                "Simon & Schuster",
                "Hachette Book Group",
                "Test Publisher",
            };
        }
    }
}
