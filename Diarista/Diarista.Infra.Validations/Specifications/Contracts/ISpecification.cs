using Diarista.Infra.Validations.Validations;

namespace Diarista.Infra.Validations.Specifications.Contracts
{
    public interface ISpecification
    {
        Contract Contract { get; }
    }
}