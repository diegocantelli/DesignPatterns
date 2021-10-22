using DesignPatterns.Composite.Component;

namespace DesignPatterns.Composite.Contracts
{
    public interface IManipulaEstruturaOrganizacional
    {
        void Add(EstruturaOrganizacional estruturaOrganizacional);
        void Remove(EstruturaOrganizacional estruturaOrganizacional);
    }
}
