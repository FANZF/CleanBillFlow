using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanupApproval
{
    class ConstSQLs
    {
        public const string updateDJSql =
            "delete t1 from BillFlowNotification t1 join Billflowhistory t2 on t1.BillFlowHistoryID = t2.BillFlowHistoryID join BillFlow t3 on t2.BillFlowID = t3.BillFlowID where t3.BillID in ({0}) \r\n" +
            "delete t1 from BillFlowHistory t1 join BillFlow on t1.BillFlowID=BillFlow.BillFlowID where BillFlow.BillID in ({0});\r\n" +
            "delete t1 from BillFlowTrack t1 join BillFlow on t1.BillFlowID=BillFlow.BillFlowID where BillFlow.BillID in ({0});\r\n" +
            "delete from BillFlow where BillFlow.BillID in ({0});\r\n" +
            "update DJ set SHBZ=0, SHYJ=null, SPRQ=null, SPR=null, DJZT='未审批', SXBZ=0 where DJID in ({0});\r\n" +
            "update DJ_FJ set SXBZ=0 where DJID in ({0});\r\n";

        public const string updateMaserTable = "update {0} set SXBZ=0 where SXBZ = 1 and DJID in ({1});";

        public const string queryDJSql =
             "SELECT DJ.DJID, DJ.DJBH, DJ.BZRQ, u.Name AS BZR, Org.Name AS BZJG, DJ.DJZT, DJ.JZBZ, DJ.JSBZ, b.Name as MKMC FROM DJ\r\n" +
             "JOIN [USER] u ON u.USERID = DJ.BZRID\r\n" +
             "JOIN Org ON Org.OrgID = DJ.BZJGID\r\n" +
             "JOIN BizType b ON b.BizTypeID = DJ.BizTypeID\r\n" +
             "WHERE DJ.BizTypeID = {0}\r\n";

        public const string queryOrgs = "select OrgID, Name from Org where Type in (1, 4) order by Name;";

        public const string queryMKs = "select distinct m.BizTypeID ,md.Name from module m \r\n" +
            "join ModuleDeploy md ON m.ModuleID = md.ModuleID \r\n" +
            "where biztypeid in (select distinct BizTypeID from DJ) \r\n" +
            "and md.name <> '' and m.isBill = 1 and Visible = 1 and md.name not like '【作废】%' order by Name";

        public const string queryMasterTables = "select object_name(a.parent_object_id) from sys.foreign_keys a \r\n" +
            "where a.referenced_object_id=object_id('[DJ]') and object_name(a.parent_object_id) in \r\n" +
            "(select [name] from sysobjects where [id] in (select[id] from syscolumns where [name] = 'SXBZ'))";

        public const string queryCatalogs = "select * from sys.databases where name not in ('master','msdb','tempdb','model') order by Name";

        public const string queryDJJZData = "select DJBH, B.Name as DJLX, BZRQ, U.Name AS BZR, Org.Name AS BZJG from dj \r\n" +
            "join BizType B on B.BizTypeID = dj.BizTypeID \r\n" +
            "join Org ON Org.OrgID = DJ.BZJGID \r\n" +
            "Join [User] U On U.UserID = DJ.BZRID \r\n" +
            "where djid in (select jzdjid from djjzmx where djid = {0})";

        public const string beginQuery = "begin tran";

        public const string endQuery = "rollback";
    }
}
