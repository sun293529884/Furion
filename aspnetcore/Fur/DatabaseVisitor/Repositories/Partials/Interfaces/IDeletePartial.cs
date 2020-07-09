﻿using Fur.DatabaseVisitor.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fur.DatabaseVisitor.Repositories
{
    /// <summary>
    /// 泛型仓储 删除操作 分部接口
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public partial interface IRepositoryOfT<TEntity> where TEntity : class, IDbEntity, new()
    {
        #region 真删除操作 + EntityEntry<TEntity> Delete(TEntity entity)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> Delete(TEntity entity);
        #endregion

        #region 真删除操作 + void Delete(params TEntity[] entities)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        void Delete(params TEntity[] entities);
        #endregion

        #region 真删除操作 + void Delete(IEnumerable<TEntity> entities)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        void Delete(IEnumerable<TEntity> entities);
        #endregion

        #region 真删除操作 + Task<EntityEntry<TEntity>> DeleteAsync(TEntity entity)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> DeleteAsync(TEntity entity);
        #endregion

        #region 真删除操作 + Task DeleteAsync(params TEntity[] entities)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task DeleteAsync(params TEntity[] entities);
        #endregion

        #region 真删除操作 + Task DeleteAsync(IEnumerable<TEntity> entities)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns></returns>
        Task DeleteAsync(IEnumerable<TEntity> entities);
        #endregion

        #region 真删除操作 + EntityEntry<TEntity> Delete(object id)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> Delete(object id);
        #endregion

        #region 真删除操作 + Task<EntityEntry<TEntity>> DeleteAsync(object id)
        /// <summary>
        /// 真删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> DeleteAsync(object id);
        #endregion


        #region 真删除操作并立即执行 + EntityEntry<TEntity> DeleteSaveChanges(TEntity entity)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> DeleteSaveChanges(TEntity entity);
        #endregion

        #region 真删除操作并立即执行 + void DeleteSaveChanges(params TEntity[] entities)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        void DeleteSaveChanges(params TEntity[] entities);
        #endregion

        #region 真删除操作并立即执行 + void DeleteSaveChanges(IEnumerable<TEntity> entities)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        void DeleteSaveChanges(IEnumerable<TEntity> entities);
        #endregion

        #region 真删除操作并立即执行 + Task<EntityEntry<TEntity>> DeleteSaveChangesAsync(TEntity entity)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> DeleteSaveChangesAsync(TEntity entity);
        #endregion

        #region 真删除操作并立即执行 + Task DeleteSaveChangesAsync(params TEntity[] entities)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns><see cref="Task"/></returns>
        Task DeleteSaveChangesAsync(params TEntity[] entities);
        #endregion

        #region 真删除操作并立即执行 + Task DeleteSaveChangesAsync(IEnumerable<TEntity> entities)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns><see cref="Task"/></returns>
        Task DeleteSaveChangesAsync(IEnumerable<TEntity> entities);
        #endregion

        #region 真删除操作并立即执行 + Task<EntityEntry<TEntity>> DeleteSaveChangesAsync(object id)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> DeleteSaveChangesAsync(object id);
        #endregion

        #region 真删除操作并立即执行 + EntityEntry<TEntity> DeleteSaveChanges(object id)
        /// <summary>
        /// 真删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> DeleteSaveChanges(object id);
        #endregion


        #region 假删除操作 + EntityEntry<TEntity> FakeDelete(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDelete(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作 + void FakeDelete(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        void FakeDelete(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作 + Task<EntityEntry<TEntity>> FakeDeleteAsync(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="flagProperty">标识属性</param>
        /// <param name="flagValue">标识值</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteAsync(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作 + Task FakeDeleteAsync(IAsyncEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <param name="flagProperty">标识属性</param>
        /// <param name="flagValue">标识值</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task FakeDeleteAsync(IAsyncEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作 + EntityEntry<TEntity> FakeDelete(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDelete(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作 + Task<EntityEntry<TEntity>> FakeDeleteAsync(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteAsync(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion


        #region 假删除操作并立即执行 + EntityEntry<TEntity> FakeDeleteSaveChanges(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDeleteSaveChanges(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作并立即执行 + void FakeDeleteSaveChanges(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        void FakeDeleteSaveChanges(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作并立即执行 + Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns></returns>
        Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(TEntity entity, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作并立即执行 + Task FakeDeleteSaveChangesAsync(IAsyncEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <param name="flagProperty">标记属性</param>
        /// <param name="flagValue">标记值</param>
        /// <returns><see cref="Task"/></returns>
        Task FakeDeleteSaveChangesAsync(IAsyncEnumerable<TEntity> entities, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作并立即执行 + EntityEntry<TEntity> FakeDeleteSaveChanges(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="flagProperty">标识属性</param>
        /// <param name="flagValue">标识值</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDeleteSaveChanges(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion

        #region 假删除操作并立即执行 + Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="flagProperty">标识属性</param>
        /// <param name="flagValue">标识值</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(object id, Expression<Func<TEntity, object>> flagProperty, object flagValue);
        #endregion


        #region 假删除操作 + EntityEntry<TEntity> EntityEntry<TEntity> FakeDelete(TEntity entity)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDelete(TEntity entity);
        #endregion

        #region 假删除操作 + void FakeDelete(IEnumerable<TEntity> entities)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        void FakeDelete(IEnumerable<TEntity> entities);
        #endregion

        #region 假删除操作 + Task<EntityEntry<TEntity>> FakeDeleteAsync(TEntity entity)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteAsync(TEntity entity);
        #endregion

        #region 假删除操作 + Task FakeDeleteAsync(IAsyncEnumerable<TEntity> entities)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task FakeDeleteAsync(IAsyncEnumerable<TEntity> entities);
        #endregion

        #region 假删除操作 + EntityEntry<TEntity> FakeDelete(object id)
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDelete(object id);
        #endregion

        #region 假删除操作 + Task<EntityEntry<TEntity>>
        /// <summary>
        /// 假删除操作
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteAsync(object id);
        #endregion


        #region 假删除操作并立即执行 + EntityEntry<TEntity> EntityEntry<TEntity> FakeDeleteSaveChanges(TEntity entity)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDeleteSaveChanges(TEntity entity);
        #endregion

        #region 假删除操作并立即执行 + void FakeDeleteSaveChanges(IEnumerable<TEntity> entities)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        void FakeDeleteSaveChanges(IEnumerable<TEntity> entities);
        #endregion

        #region 假删除操作并立即执行 + Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(TEntity entity)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(TEntity entity);
        #endregion

        #region 假删除操作并立即执行 + Task FakeDeleteSaveChangesAsync(IAsyncEnumerable<TEntity> entities)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="entities">多个实体</param>
        /// <returns><see cref="Task"/></returns>
        Task FakeDeleteSaveChangesAsync(IAsyncEnumerable<TEntity> entities);
        #endregion

        #region 假删除操作并立即执行 + EntityEntry<TEntity> FakeDeleteSaveChanges(object id)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="EntityEntry(TEntity)"/></returns>
        EntityEntry<TEntity> FakeDeleteSaveChanges(object id);
        #endregion

        #region 假删除操作并立即执行 + Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(object id)
        /// <summary>
        /// 假删除操作并立即执行
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns><see cref="Task{TResult}"/></returns>
        Task<EntityEntry<TEntity>> FakeDeleteSaveChangesAsync(object id);
        #endregion
    }
}
