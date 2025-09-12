using AutoMapper;
using AutoMapper.QueryableExtensions;
using JesusEmNos.Domain.Entities.Base;
using JesusEmNos.Domain.Exceptions;
using JesusEmNos.Domain.Interfaces.Repositories.Base;
using JesusEmNos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JesusEmNos.Infrastructure.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private JesusEmNosContext _context { get; set; }
        private IMapper _mapper;
        private MapperConfiguration _mapperConfiguration;
        public BaseRepository(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<JesusEmNosContext>();
            _mapper = serviceProvider.GetRequiredService<IMapper>();
            _mapperConfiguration = (MapperConfiguration)_mapper.ConfigurationProvider;
        }

        public async Task<bool> VerificarConexaoAsync() => await _context.Database.CanConnectAsync();

        #region Métodos de Criação

        public async Task<long> CriarAsync(TEntity obj, CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(obj);
                await _context.SaveChangesAsync(cancellationToken = default);
                return obj.Id;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task CriarAsync(TEntity[] obj, CancellationToken cancellationToken = default)
        {
            try
            {
                foreach (var entity in obj)
                {
                    await _context.Set<TEntity>().AddAsync(entity);
                }
                await _context.SaveChangesAsync(cancellationToken = default);
                return;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task AtualizarAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync(cancellationToken = default);
                return;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task AtualizarAsync(TEntity[] entity, CancellationToken cancellationToken = default)
        {
            try
            {
                _context.Set<TEntity>().UpdateRange(entity);
                await _context.SaveChangesAsync(cancellationToken = default);
                return;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task RemoverAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync(cancellationToken = default);
                return;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task RemoverAsync(TEntity[] obj, CancellationToken cancellationToken = default)
        {
            try
            {
                foreach (var entity in obj)
                {
                    _context.Remove(entity);
                }
                await _context.SaveChangesAsync(cancellationToken = default);
                return;
            }
            catch (Exception ex)
            {
                _context.ChangeTracker.Clear();
                throw new DataBaseException(ex.Message, ex);
            }
        }

        #endregion

        #region Métodos de Listagem

        public async Task<IEnumerable<TDto>> ObterListaAsync<TDto>(
            Expression<Func<TEntity, bool>> expression,
            string? includes = null,
            string? orderBy = null,
            int? pageSize = null, int? page = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);
                set = ApplyPagination(set, pageSize, page);

                var result = await set
                    .AsNoTracking()
                    .ProjectTo<TDto>(_mapperConfiguration)
                    .ToListAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<TDto>> ObterListaAsync<TDto>(
            Expression<Func<TEntity, bool>> expression,
            Expression<Func<TEntity, TDto>> select,
            string? includes = null,
            string? orderBy = null,
            int? pageSize = null, int? page = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);
                set = ApplyPagination(set, pageSize, page);

                var result = await set
                    .AsNoTracking()
                    .Select(select)
                    .ToListAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }


        public async Task<IEnumerable<TEntity>> ObterListaAsync(
            Expression<Func<TEntity, bool>> expression,
            string? includes = null,
            string? orderBy = null,
            int? pageSize = null, int? page = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);
                set = ApplyPagination(set, pageSize, page);

                var result = await set
                     .AsNoTracking()
                     .ToListAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<TEntity> ObterPorIdAsync(long id, string? includes = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                var result = await set
                    .Where(c => c.Id == id)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }
        public async Task<TDto> ObterPorIdAsync<TDto>(long id, string? includes = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                var result = await set
                    .Where(c => c.Id == id)
                    .AsNoTracking()
                    .ProjectTo<TDto>(_mapperConfiguration)
                    .FirstOrDefaultAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<TDto> ObterAsync<TDto>(
            Expression<Func<TEntity, bool>> expression,
            string? includes = null,
            string? orderBy = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);

                var result = await set.AsNoTracking().ProjectTo<TDto>(_mapperConfiguration).FirstOrDefaultAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<TDto> ObterAsync<TDto>(
            Expression<Func<TEntity, bool>> expression,
            Expression<Func<TEntity, TDto>> select,
            string? includes = null,
            string? orderBy = null,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);

                var result = await set.AsNoTracking().Select(select).FirstOrDefaultAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<TEntity> ObterAsync(Expression<Func<TEntity, bool>> expression, string? includes = null, string? orderBy = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);
                set = ApplySort(set, orderBy);

                var result = await set.AsNoTracking().FirstOrDefaultAsync(cancellationToken);

                return result;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        #endregion

        public async Task<long> CountAsync(Expression<Func<TEntity, bool>>? expression, CancellationToken cancellation)
            => expression is null ? await _context.Set<TEntity>().CountAsync(cancellation) : await _context.Set<TEntity>().CountAsync(expression, cancellation);

        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellation)
        {
            try
            {
                return await CountAsync(expression, cancellation) > 0;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        public async Task<TDto> ObterUnicoAsync<TDto>(Expression<Func<TEntity, bool>> expression, string? includes = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var set = _context.Set<TEntity>().AsQueryable();
                set = ApplyIncludes(set, includes);
                set = ApplyFilter(set, expression);

                var result = await set.AsNoTracking().ProjectTo<TDto>(_mapperConfiguration).SingleOrDefaultAsync(cancellationToken);

                return result!;
            }
            catch (Exception ex)
            {
                throw new DataBaseException(ex.Message, ex);
            }
        }

        #region Metodos Auxiliares

        private IQueryable<TEntity> ApplyIncludes(IQueryable<TEntity> set, string? includes)
        {
            if (string.IsNullOrEmpty(includes))
                return set;

            string[] incs = includes.Split(',').ToArray();
            foreach (var inc in incs)
                set = set.Include(inc.Trim());
            return set;

        }
        private static IQueryable<TDto> MapProjection<TDto>(IQueryable<TEntity> source)
        {
            var sourceProperties = typeof(TEntity).GetProperties().Where(p => p.CanRead);

            var destProperties = typeof(TDto).GetProperties().Where(p => p.CanWrite);

            var propertyMap = from d in destProperties
                              join s in sourceProperties on new { d.Name, d.PropertyType } equals new { s.Name, s.PropertyType }
                              select new { Source = s, Dest = d };

            var itemParam = Expression.Parameter(typeof(TEntity), "item");

            var memberBindings = propertyMap.Select(p => (MemberBinding)Expression.Bind(p.Dest, Expression.Property(itemParam, p.Source)));

            var newExpression = Expression.New(typeof(TDto));

            var memberInitExpression = Expression.MemberInit(newExpression, memberBindings);

            var projection = Expression.Lambda<Func<TEntity, TDto>>(memberInitExpression, itemParam);

            return source.Select(projection);
        }
        private IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> set, Expression<Func<TEntity, bool>> filter)
        {
            if (filter is not null)
                return set.Where(filter);
            return set;

        }
        private IQueryable<TEntity> ApplySort(IQueryable<TEntity> set, string? sortExpression)
        {
            if (string.IsNullOrEmpty(sortExpression))
                return set;

            var sortArray = PrepareSort(sortExpression);

            foreach (var item in sortArray)
            {
                string[] props = item.FieldName!.Split('.');
                Type type = typeof(TEntity);
                ParameterExpression arg = Expression.Parameter(type, "x");
                Expression expr = arg;
                foreach (string prop in props)
                {
                    PropertyInfo pi = type.GetProperty(prop)!;
                    expr = Expression.Property(expr, pi);
                    type = pi.PropertyType;
                }
                Type delegateType = typeof(Func<,>).MakeGenericType(typeof(TEntity), type);
                LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

                object? result = typeof(Queryable).GetMethods()
                    .Single(method => method.Name == item.Direction
                        && method.IsGenericMethodDefinition
                        && method.GetGenericArguments().Length == 2
                        && method.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(TEntity), type)
                    .Invoke(null, new object[] { set, lambda });
                set = (IOrderedQueryable<TEntity>)result!;
            }
            return set;
        }
        private IQueryable<TEntity> ApplyPagination(IQueryable<TEntity> set, int? pageSize, int? page)
        {
            if (pageSize.HasValue && page.HasValue)
                return set.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            return set;
        }
        private SortProperty[] PrepareSort(string sortExpression)
        {
            List<SortProperty> list = new List<SortProperty>();

            var sortList = sortExpression.Split(',');
            bool firstPass = true;
            foreach (string sort in sortList)
            {
                string[] item = sort.Trim().Split(' ');
                if (item.Length == 0)
                    continue;
                else if (item.Length == 1)
                    list.Add(new SortProperty(item[0], firstPass ? "OrderBy" : "ThenBy"));
                else if (item.Length == 2)
                {
                    if (item[1].ToUpper() == "DESC")
                        list.Add(new SortProperty(item[0], firstPass ? "OrderByDescending" : "ThenByDescending"));
                    else
                        list.Add(new SortProperty(item[0], firstPass ? "OrderBy" : "ThenBy"));
                }
                firstPass = false;
            }
            return list.ToArray();
        }

        internal class SortProperty
        {
            public SortProperty(string fieldName, string direction)
            {
                FieldName = fieldName;
                Direction = direction;
            }

            public string? FieldName { get; private set; }
            public string Direction { get; private set; }
        }

        #endregion
    }
}
