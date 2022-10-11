using System;
using System.Collections.Generic;

namespace DesignPatterns.Proxy.Interfaces
{
    public interface IContentRepository
    {
        List<Content> GetContent();
    }
}
