using System;
using System.Collections.Generic;
using DesignPatterns.Proxy.Interfaces;

namespace DesignPatterns.Proxy.Repository
{
    public class ContentRepository : IContentRepository
    {
        public ContentRepository()
        {
        }

        public List<Content> GetContent()
        {
            var contentList = new List<Content>();
            var advertisements = new List<Advertisement>
            {
                new Advertisement { Product = "T-Shirt" },
                new Advertisement { Product = "Energy Drink" },
                new Advertisement { Product = "Game Ticket"}
            };

            var content1 = new Content();
            content1.News = new News
            {
                Title = "Football",
                Description = "Sports news description"
            };
            content1.CategoryEnum = CategoryEnum.Sports;
            content1.Advertisements = advertisements;

            var content2 = new Content();
            content1.News = new News
            {
                Title = "Book",
                Description = "Education news description"
            };
            content1.CategoryEnum = CategoryEnum.Education;
            content1.Advertisements = advertisements;

            var content3 = new Content();
            content1.News = new News
            {
                Title = "Lifestyle",
                Description = "Lifestyle news description"
            };
            content1.CategoryEnum = CategoryEnum.Lifestyle;
            content1.Advertisements = advertisements;

            contentList.Add(content1);
            contentList.Add(content2);
            contentList.Add(content3);

            return contentList;

        }
    }
}
