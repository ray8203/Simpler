/*******************************************************************************
 * Copyright © 2016 Simpler.Framework 版权所有
 * Author: Simpler
 * Description: Simpler快速开发平台
 * Website：http://www.Simpler.cn
*********************************************************************************/
using Simpler.Code;
using Simpler.Data;
using Simpler.Data.Extensions;
using Simpler.Domain.Entity.SystemSecurity;
using Simpler.Domain.IRepository.SystemSecurity;
using Simpler.Repository.SystemSecurity;

namespace Simpler.Repository.SystemSecurity
{
    public class DbBackupRepository : RepositoryBase<DbBackupEntity>, IDbBackupRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                var dbBackupEntity = db.FindEntity<DbBackupEntity>(keyValue);
                if (dbBackupEntity != null)
                {
                    FileHelper.DeleteFile(dbBackupEntity.F_FilePath);
                }
                db.Delete<DbBackupEntity>(dbBackupEntity);
                db.Commit();
            }
        }
        public void ExecuteDbBackup(DbBackupEntity dbBackupEntity)
        {
            DbHelper.ExecuteSqlCommand(string.Format("backup database {0} to disk ='{1}'", dbBackupEntity.F_DbName, dbBackupEntity.F_FilePath));
            dbBackupEntity.F_FileSize = FileHelper.ToFileSize(FileHelper.GetFileSize(dbBackupEntity.F_FilePath));
            dbBackupEntity.F_FilePath = "/Resource/DbBackup/" + dbBackupEntity.F_FileName;
            this.Insert(dbBackupEntity);
        }
    }
}
