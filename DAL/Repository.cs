using ngipf_backend.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using ngipf_backend.Helper;
using ngipf_backend.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace ngipf_backend.DAL
{
    public abstract class Repository<T, Tcontext> : IRepository<T> where T : class where Tcontext : DbContext
    {
        protected readonly Tcontext NgIpfDBContext = null;

        public Repository(Tcontext context)
        {
            this.NgIpfDBContext = context;
        }


        public bool IsTransactionRunning()
        {
            return this.NgIpfDBContext.Database.CurrentTransaction == null ? false : true;
        }
        private IDbContextTransaction BeginTran()
        {
            return this.NgIpfDBContext.Database.BeginTransaction();
        }



        public IExecutionStrategy GetExecutionStrategy()
        {
            return this.NgIpfDBContext.Database.CreateExecutionStrategy();
        }


        public IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> result = this.NgIpfDBContext.Set<T>();
            if (condition != null)
            {
                result = result.Where(condition);
            }

            return result;
        }

        public async Task<ICollection<T>> GetAllByConditionAsync(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> result = this.NgIpfDBContext.Set<T>();
            if (condition != null)
            {
                result = result.Where(condition);
            }

            return await result.ToListAsync();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> result = this.NgIpfDBContext.Set<T>();
            return result;
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            IQueryable<T> result = this.NgIpfDBContext.Set<T>();
            return await result.ToListAsync();
        }

        public async Task<ICollection<TResult>> GetSelectedColumnAsync<TResult>(Expression<Func<T, TResult>> selectExpression)
        {
            IQueryable<TResult> result = this.NgIpfDBContext.Set<T>().Select(selectExpression);
            return await result.ToListAsync();
        }
        public async Task<ICollection<TResult>> GetSelectedColumnByConditionAsync<TResult>(Expression<Func<T, bool>> filterExpression, Expression<Func<T, TResult>> selectExpression)
        {
            IQueryable<TResult> result = this.NgIpfDBContext.Set<T>()
                                    .Where(filterExpression)
                                    .Select(selectExpression);

            return await result.ToListAsync();
        }
        public async Task<ICollection<TResult>> GetSelectedColumnByConditionWithSortAsync<TResult>(Expression<Func<T, bool>> filterExpression, Expression<Func<T, TResult>> selectExpression, string orderByField = null,
            string orderByOrder = null)
        {
            IQueryable<T> query = this.NgIpfDBContext.Set<T>().Where(filterExpression);

            if (!string.IsNullOrWhiteSpace(orderByField))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, orderByField);
                var lambda = Expression.Lambda<Func<T, object>>(Expression.Convert(property, typeof(object)), parameter);

                if (orderByOrder == "ASC")
                {
                    query = query.OrderBy(lambda);
                }
                else
                {
                    query = query.OrderByDescending(lambda);
                }
            }
            var result = await query.Select(selectExpression).ToListAsync();
            return result;
        }
        public async Task<ICollection<TResult>> GetSelectedColumnByConditionAsync<TResult>(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, TResult>> selectExpression,
            DynamicListQueryParameters dynamicListQueryParameters
        )
        {
            int pageIndex = (dynamicListQueryParameters.PageIndex!=null)? dynamicListQueryParameters.PageIndex:0;
            int pageSize = (dynamicListQueryParameters.PageSize!=null)?dynamicListQueryParameters.PageSize:10;
            List<FilterParameter> dynamicFilters = dynamicListQueryParameters.filterParameters;
            string orderByField = (dynamicListQueryParameters.sortParameters != null) ? dynamicListQueryParameters.sortParameters.Field : null;
            string orderByOrder = (dynamicListQueryParameters.sortParameters != null) ? dynamicListQueryParameters.sortParameters.Order : null;
            IQueryable<T> query = this.NgIpfDBContext.Set<T>().Where(filterExpression);

            if (dynamicFilters != null && dynamicFilters.Any())
            {
                foreach (var filter in dynamicFilters)
                {
                    var dynimicFilterExpression = ExpressionHelper.GetFilterExpression<T>(filter.Field, filter.Value, filter.Operator);
                    query = query.Where(dynimicFilterExpression);
                }
            }
            // Dynamic order by expression
            if (!string.IsNullOrWhiteSpace(orderByField))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, orderByField);
                var lambda = Expression.Lambda<Func<T, object>>(Expression.Convert(property, typeof(object)), parameter);

                if (orderByOrder == "ASC")
                {
                    query = query.OrderBy(lambda);
                }
                else
                {
                    query = query.OrderByDescending(lambda);
                }
            }
            var result = await query.Select(selectExpression).ToListAsync();
            return result;
        }
        public async Task<ICollection<TResult>> GetSelectedColumnByConditionAsync<TResult>(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, TResult>> selectExpression,
            int pageIndex = 0,
            int pageSize = 10,
            List<FilterParameter> dynamicFilters = null,
            string orderByField = null,
            string orderByOrder = null
        )
        {
            IQueryable<T> query = this.NgIpfDBContext.Set<T>().Where(filterExpression);

            if (dynamicFilters != null && dynamicFilters.Any())
            {
                foreach (var filter in dynamicFilters)
                {
                    var dynimicFilterExpression = ExpressionHelper.GetFilterExpression<T>(filter.Field, filter.Value, filter.Operator);
                    query = query.Where(dynimicFilterExpression);
                }
            }
            // Dynamic order by expression
            if (!string.IsNullOrWhiteSpace(orderByField))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, orderByField);
                var lambda = Expression.Lambda<Func<T, object>>(Expression.Convert(property, typeof(object)), parameter);

                if (orderByOrder == "ASC")
                {
                    query = query.OrderBy(lambda);
                }
                else
                {
                    query = query.OrderByDescending(lambda);
                }
            }
            var result = await query.Select(selectExpression).Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
            return result;
        }
        public async Task<Dictionary<TKey, List<TResult>>> GetSelectedColumnGroupByConditionAsync<TKey, TResult>(
            Expression<Func<T, bool>> filterExpression,
            Expression<Func<T, TKey>> groupByKeySelector,
            Expression<Func<T, TResult>> selectExpression)
        {
            var data = await this.NgIpfDBContext.Set<T>()
            .Where(filterExpression)
            .ToListAsync();
            var groupedResult = data
                .GroupBy(groupByKeySelector.Compile())
                .ToDictionary(group => group.Key, group => group.Select(selectExpression.Compile()).ToList());

            return groupedResult;

        }
        public async Task<TResult> GetSingleSelectedColumnByConditionAsync<TResult>(
       Expression<Func<T, bool>> filterExpression,
       Expression<Func<T, TResult>> selectExpression)
        {
            TResult result = await this.NgIpfDBContext.Set<T>()
                                        .Where(filterExpression)
                                        .Select(selectExpression)
                                        .FirstOrDefaultAsync();

            return result;
        }
        public async Task<ICollection<TResult>> getallCommon<TResult>(
        DynamicListQueryParameters dynamicListQueryParameters,

        Expression<Func<T, TResult>> selectExpression
    )
        {
            
            List<FilterParameter> dynamicFilters = dynamicListQueryParameters.filterParameters;
            string orderByField = (dynamicListQueryParameters.sortParameters != null) ? dynamicListQueryParameters.sortParameters.Field : null;
            string orderByOrder = (dynamicListQueryParameters.sortParameters != null) ? dynamicListQueryParameters.sortParameters.Order : null;
            IQueryable<T> query = this.NgIpfDBContext.Set<T>();

            if (dynamicFilters != null && dynamicFilters.Any())
            {
                foreach (var filter in dynamicFilters)
                {
                    var dynimicFilterExpression = ExpressionHelper.GetFilterExpression<T>(filter.Field, filter.Value, filter.Operator);
                    query = query.Where(dynimicFilterExpression);
                }
            }
            // Dynamic order by expression
            if (!string.IsNullOrWhiteSpace(orderByField))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, orderByField);
                var lambda = Expression.Lambda<Func<T, object>>(Expression.Convert(property, typeof(object)), parameter);

                if (orderByOrder == "ASC")
                {
                    query = query.OrderBy(lambda);
                }
                else
                {
                    query = query.OrderByDescending(lambda);
                }
            }
            var result = await query.Select(selectExpression).ToListAsync();
            return result;
        }
        public T GetSingle(Expression<Func<T, bool>> condition)
        {
            return this.NgIpfDBContext.Set<T>().Where(condition).FirstOrDefault();
        }
        public async Task<T> GetSingleAysnc(Expression<Func<T, bool>> condition)
        {
            var retValue = await this.NgIpfDBContext.Set<T>().Where(condition).SingleOrDefaultAsync();

            return retValue;
        }
        public int CountWithCondition(Expression<Func<T, bool>> condition, List<FilterParameter> dynamicFilters = null)
        {
            IQueryable<T> query = this.NgIpfDBContext.Set<T>();

            if (dynamicFilters != null && dynamicFilters.Any())
            {
                foreach (var filter in dynamicFilters)
                {
                    var dynimicFilterExpression = ExpressionHelper.GetFilterExpression<T>(filter.Field, filter.Value, filter.Operator);
                    query = query.Where(dynimicFilterExpression);
                }
            }
            //var result = query.Select(selectExpression).ToListAsync();
            return query.Count(condition);
        }
        public int CountWithCondition(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> query = this.NgIpfDBContext.Set<T>();
            return query.Count(condition);
        }
        public async Task<int> CountWithConditionAsync(Expression<Func<T, bool>> condition)
        {
            IQueryable<T> query = this.NgIpfDBContext.Set<T>();
            return await query.CountAsync(condition);
        }
        public int Count()
        {
            return this.NgIpfDBContext.Set<T>().Count();
        }

        public async Task<object> ExecuteQuery(string sqlQuery, object parameters)
        {
            return await this.NgIpfDBContext.Database.ExecuteSqlRawAsync(sqlQuery, parameters);
        }


        public bool Add(T entity)
        {
            this.NgIpfDBContext.Set<T>().Add(entity);
            return true;
        }
        public void AddRange(IEnumerable<T> entities)
        {
            this.NgIpfDBContext.Set<T>().AddRange(entities);
        }

        public bool Update(T entity)
        {
            this.NgIpfDBContext.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public bool Delete(T entity)
        {
            this.NgIpfDBContext.Set<T>().Remove(entity);
            return true;
        }


        public void SaveChangesManaged()
        {
            this.NgIpfDBContext.SaveChanges();
        }
    }
}
