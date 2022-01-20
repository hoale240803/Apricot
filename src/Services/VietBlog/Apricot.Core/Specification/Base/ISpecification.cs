using System.Linq.Expressions;

namespace Apricot.Core.Specification.Base
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }

        List<Expression<Func<T, object>>> Includes { get; }

        List<string> IncludeStrings { get; }

        Expression<Func<T, object>> OrderBy { get; }

        Expression<Func<T, object>> OrderByDescending { get; }

        int Take { get; }

        int Skip { get; }

        bool isPagineEnabled { get; }
    }
}