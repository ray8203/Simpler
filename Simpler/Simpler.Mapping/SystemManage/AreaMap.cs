/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
using Simpler.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;

namespace Simpler.Mapping.SystemManage
{
    public class AreaMap : EntityTypeConfiguration<AreaEntity>
    {
        public AreaMap()
        {
            this.ToTable("Sys_Area");
            this.HasKey(t => t.F_Id);
        }
    }
}
