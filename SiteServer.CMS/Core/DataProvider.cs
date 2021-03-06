using System.Collections.Generic;
using SiteServer.CMS.Data;
using SiteServer.CMS.Provider;
using SiteServer.Plugin;
using SiteServer.Utils;

namespace SiteServer.CMS.Core
{
    public class DataProvider
    {
        private static IDataApi _dataApi;
        public static IDataApi DataApi
        {
            get
            {
                if (_dataApi != null) return _dataApi;

                if (WebConfigUtils.DatabaseType == DatabaseType.MySql)
                {
                    _dataApi = new Data.MySql();
                }
                else if (WebConfigUtils.DatabaseType == DatabaseType.SqlServer)
                {
                    _dataApi = new SqlServer();
                }
                else if (WebConfigUtils.DatabaseType == DatabaseType.PostgreSql)
                {
                    _dataApi = new PostgreSql();
                }
                else if (WebConfigUtils.DatabaseType == DatabaseType.Oracle)
                {
                    _dataApi = new Data.Oracle();
                }

                return _dataApi;
            }
        }

        private static AdministratorDao _administratorDao;
        public static AdministratorDao AdministratorDao => _administratorDao ?? (_administratorDao = new AdministratorDao());

        private static AdministratorsInRolesDao _administratorsInRolesDao;
        public static AdministratorsInRolesDao AdministratorsInRolesDao => _administratorsInRolesDao ?? (_administratorsInRolesDao = new AdministratorsInRolesDao());

        private static AreaDao _areaDao;
        public static AreaDao AreaDao => _areaDao ?? (_areaDao = new AreaDao());

        private static ChannelDao _channelDao;
        public static ChannelDao ChannelDao => _channelDao ?? (_channelDao = new ChannelDao());

        private static ChannelGroupDao _channelGroupDao;
        public static ChannelGroupDao ChannelGroupDao => _channelGroupDao ?? (_channelGroupDao = new ChannelGroupDao());

        private static ConfigDao _configDao;
        public static ConfigDao ConfigDao => _configDao ?? (_configDao = new ConfigDao());

        private static ContentCheckDao _contentCheckDao;
        public static ContentCheckDao ContentCheckDao => _contentCheckDao ?? (_contentCheckDao = new ContentCheckDao());

        private static ContentDao _contentDao;
        public static ContentDao ContentDao => _contentDao ?? (_contentDao = new ContentDao());

        private static ContentGroupDao _contentGroupDao;
        public static ContentGroupDao ContentGroupDao => _contentGroupDao ?? (_contentGroupDao = new ContentGroupDao());

        private static CountDao _countDao;
        public static CountDao CountDao => _countDao ?? (_countDao = new CountDao());

        private static DatabaseDao _databaseDao;
        public static DatabaseDao DatabaseDao => _databaseDao ?? (_databaseDao = new DatabaseDao());

        private static DbCacheDao _dbCacheDao;
        public static DbCacheDao DbCacheDao => _dbCacheDao ?? (_dbCacheDao = new DbCacheDao());

        private static DepartmentDao _departmentDao;
        public static DepartmentDao DepartmentDao => _departmentDao ?? (_departmentDao = new DepartmentDao());

        private static ErrorLogDao _errorLogDao;
        public static ErrorLogDao ErrorLogDao => _errorLogDao ?? (_errorLogDao = new ErrorLogDao());

        private static KeywordDao _keywordDao;
        public static KeywordDao KeywordDao => _keywordDao ?? (_keywordDao = new KeywordDao());

        private static LogDao _logDao;
        public static LogDao LogDao => _logDao ?? (_logDao = new LogDao());

        private static PermissionsInRolesDao _permissionsInRolesDao;
        public static PermissionsInRolesDao PermissionsInRolesDao => _permissionsInRolesDao ?? (_permissionsInRolesDao = new PermissionsInRolesDao());

        private static PluginConfigDao _pluginConfigDao;
        public static PluginConfigDao PluginConfigDao => _pluginConfigDao ?? (_pluginConfigDao = new PluginConfigDao());

        private static PluginDao _pluginDao;
        public static PluginDao PluginDao => _pluginDao ?? (_pluginDao = new PluginDao());

        private static SiteDao _siteDao;
        public static SiteDao SiteDao => _siteDao ?? (_siteDao = new SiteDao());

        private static SiteLogDao _siteLogDao;
        public static SiteLogDao SiteLogDao => _siteLogDao ?? (_siteLogDao = new SiteLogDao());

        private static RecordDao _recordDao;
        public static RecordDao RecordDao => _recordDao ?? (_recordDao = new RecordDao());

        private static RelatedFieldDao _relatedFieldDao;
        public static RelatedFieldDao RelatedFieldDao => _relatedFieldDao ?? (_relatedFieldDao = new RelatedFieldDao());

        private static RelatedFieldItemDao _relatedFieldItemDao;
        public static RelatedFieldItemDao RelatedFieldItemDao => _relatedFieldItemDao ?? (_relatedFieldItemDao = new RelatedFieldItemDao());

        private static RoleDao _roleDao;
        public static RoleDao RoleDao => _roleDao ?? (_roleDao = new RoleDao());

        private static SitePermissionsDao _sitePermissionsDao;
        public static SitePermissionsDao SitePermissionsDao => _sitePermissionsDao ?? (_sitePermissionsDao = new SitePermissionsDao());

        private static TableDao _tableDao;
        public static TableDao TableDao => _tableDao ?? (_tableDao = new TableDao());

        private static TableMatchDao _tableMatchDao;
        public static TableMatchDao TableMatchDao => _tableMatchDao ?? (_tableMatchDao = new TableMatchDao());

        private static TableMetadataDao _tableMetadataDao;
        public static TableMetadataDao TableMetadataDao => _tableMetadataDao ?? (_tableMetadataDao = new TableMetadataDao());

        private static TableStyleDao _tableStyleDao;
        public static TableStyleDao TableStyleDao => _tableStyleDao ?? (_tableStyleDao = new TableStyleDao());

        private static TableStyleItemDao _tableStyleItemDao;
        public static TableStyleItemDao TableStyleItemDao => _tableStyleItemDao ?? (_tableStyleItemDao = new TableStyleItemDao());

        private static TagDao _tagDao;
        public static TagDao TagDao => _tagDao ?? (_tagDao = new TagDao());

        private static TemplateDao _templateDao;
        public static TemplateDao TemplateDao => _templateDao ?? (_templateDao = new TemplateDao());

        private static TemplateLogDao _templateLogDao;
        public static TemplateLogDao TemplateLogDao => _templateLogDao ?? (_templateLogDao = new TemplateLogDao());

        private static TemplateMatchDao _templateMatchDao;
        public static TemplateMatchDao TemplateMatchDao => _templateMatchDao ?? (_templateMatchDao = new TemplateMatchDao());

        private static UserDao _userDao;
        public static UserDao UserDao => _userDao ?? (_userDao = new UserDao());

        private static UserLogDao _userLogDao;
        public static UserLogDao UserLogDao => _userLogDao ?? (_userLogDao = new UserLogDao());

        public static List<DataProviderBase> AllProviders => new List<DataProviderBase>
        {
            AdministratorDao,
            AdministratorsInRolesDao,
            AreaDao,
            ChannelDao,
            ChannelGroupDao,
            ConfigDao,
            ContentCheckDao,
            ContentDao,
            ContentGroupDao,
            CountDao,
            DatabaseDao,
            DbCacheDao,
            DepartmentDao,
            ErrorLogDao,
            KeywordDao,
            LogDao,
            PermissionsInRolesDao,
            PluginConfigDao,
            PluginDao,
            SiteDao,
            SiteLogDao,
            RecordDao,
            RelatedFieldDao,
            RelatedFieldItemDao,
            RoleDao,
            SitePermissionsDao,
            TableDao,
            TableMatchDao,
            TableMetadataDao,
            TableStyleDao,
            TableStyleItemDao,
            TagDao,
            TemplateDao,
            TemplateLogDao,
            TemplateMatchDao,
            UserDao,
            UserLogDao
        };
    }
}
