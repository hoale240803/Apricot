using System.Linq.Expressions;

namespace Apricot.Core.Specification.Base
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        protected BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public List<string> IncludeStrings { get; } = new List<string>();

        public Expression<Func<T, object>> OrderBy { get; private set; }

        public Expression<Func<T, object>> OrderByDescending { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool isPagineEnabled { get; private set; } = false;

        protected virtual void AddInlude(Expression<Func<T, object>> include)
        {
            Includes.Add(include);
        }

        protected virtual void AddInlude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }

        protected virtual void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            isPagineEnabled = true;
        }

        protected virtual void ApplyOrderBy(Expression<Func<T, object>> orderExprestion)
        {
            OrderBy = orderExprestion;
        }

        protected virtual void ApplyOrderByDescending(Expression<Func<T, object>> orderExprestion)
        {
            OrderByDescending = orderExprestion;
        }
    }
}