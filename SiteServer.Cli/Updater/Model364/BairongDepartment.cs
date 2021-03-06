﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;

namespace SiteServer.Cli.Updater.Model364
{
    public partial class BairongDepartment
    {
        [JsonProperty("departmentID")]
        public long DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("parentID")]
        public long ParentId { get; set; }

        [JsonProperty("parentsPath")]
        public string ParentsPath { get; set; }

        [JsonProperty("parentsCount")]
        public long ParentsCount { get; set; }

        [JsonProperty("childrenCount")]
        public long ChildrenCount { get; set; }

        [JsonProperty("isLastNode")]
        public string IsLastNode { get; set; }

        [JsonProperty("taxis")]
        public long Taxis { get; set; }

        [JsonProperty("addDate")]
        public DateTimeOffset AddDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("countOfAdmin")]
        public long CountOfAdmin { get; set; }

        [JsonProperty("countOfUser")]
        public long CountOfUser { get; set; }
    }

    public partial class BairongDepartment
    {
        public static readonly string NewTableName = DataProvider.DepartmentDao.TableName;

        public static readonly List<TableColumnInfo> NewColumns = DataProvider.DepartmentDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertDict =
            new Dictionary<string, string>
            {
                {nameof(DepartmentInfo.Id), nameof(DepartmentId)}
            };
    }
}
