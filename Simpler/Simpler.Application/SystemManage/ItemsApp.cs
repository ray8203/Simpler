/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
using Simpler.Domain.Entity.SystemManage;
using Simpler.Domain.IRepository.SystemManage;
using Simpler.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simpler.Application.SystemManage
{
    public class ItemsApp
    {
        private IItemsRepository service = new ItemsRepository();

        public List<ItemsEntity> GetList()
        {
            return service.IQueryable().ToList();
        }
        public ItemsEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("删除失败！操作的对象包含了下级数据。");
            }
            else
            {
                service.Delete(t => t.F_Id == keyValue);
            }
        }
        public void SubmitForm(ItemsEntity itemsEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsEntity.Modify(keyValue);
                service.Update(itemsEntity);
            }
            else
            {
                itemsEntity.Create();
                service.Insert(itemsEntity);
            }
        }
    }
}
