﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlSugar
{
    public enum DbType
    {
        MySql ,
        SqlServer,
        Sqlite,
        Oracle,
        PostgreSQL,
        Dm,
        Kdbndp,
        Oscar,
        MySqlConnector,
        Access,
        OpenGauss,
        QuestDB,
        HG,
        ClickHouse,
        GBase,
        Custom =900
    }
}
