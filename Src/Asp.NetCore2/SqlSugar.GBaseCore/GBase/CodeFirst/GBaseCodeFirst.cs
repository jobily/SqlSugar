﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SqlSugar.GBase
{
    public class GBaseCodeFirst:CodeFirstProvider
    {
        protected override void ExistLogicEnd(List<EntityColumnInfo> dbColumns)
        {
             
        }
        protected override string GetTableName(EntityInfo entityInfo)
        {
            var table= this.Context.EntityMaintenance.GetTableName(entityInfo.EntityName);
            var tableArray = table.Split('.');
            var noFormat = table.Split(']').Length==1;
            if (tableArray.Length > 1 && noFormat)
            {
                var dbMain = new GBaseDbMaintenance() { Context = this.Context };
                return dbMain.SqlBuilder.GetTranslationTableName(table);
            }
            else
            {
                return table;
            }
        }
      }
}
