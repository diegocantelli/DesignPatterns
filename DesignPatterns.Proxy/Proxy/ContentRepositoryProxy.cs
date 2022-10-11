using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Proxy.Interfaces;
using DesignPatterns.Proxy.Repository;

namespace DesignPatterns.Proxy.Proxy
{
    // A classe proxy é a responsavel por executar lógicas adicionais, sem a necessidade
    // de alterar a classe principal
    public class ContentRepositoryProxy : IContentRepository
    {
        private readonly DeviceType _deviceType;
        private readonly ContentRepository _contentRepository = new ContentRepository();

        public ContentRepositoryProxy(DeviceType deviceType)
        {
            _deviceType = deviceType;
        }

        public List<Content> GetContent()
        {
            var contentList = _contentRepository.GetContent();

            switch (_deviceType)
            {
                case DeviceType.Mobile:
                    contentList.ForEach(x => { x.Advertisements = new List<Advertisement>(); });
                    break;
                case DeviceType.Web:
                    contentList = contentList.Where(x => x.CategoryEnum != CategoryEnum.Lifestyle).ToList();
                    break;
                default:
                    break;
            }

            return contentList;
        }
    }

    public enum DeviceType
    {
        Desktop = 1,
        Mobile = 2,
        Web = 3
    }
}
