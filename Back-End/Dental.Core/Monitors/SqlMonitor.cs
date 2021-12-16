using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dental.Core.Functions;
using Dental.Entities.Interface;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Where;

namespace Dental.Core.Monitors
{
    public class SqlMonitor<T> : IDisposable where T : class, IEntity, new()
    {
        private readonly SqlTableDependency<T> tableDepency;
        public RecordChangedEventArgs<T> ChangedRecord;
        public ErrorEventArgs DependencyError;
        public Action OnChange;

        public SqlMonitor(string tableName, Expression<Func<T, bool>> filter = null, DmlTriggerType monitoryType = DmlTriggerType.All)
        {
            tableDepency = new SqlTableDependency<T>(ConnectionStringInfo.Get(), tableName,
                filter: new SqlTableDependencyFilter<T>(filter), notifyOn: monitoryType);
            tableDepency.Stop();
            tableDepency.OnChanged += Changed;
            tableDepency.OnError += Error;
            tableDepency.Start();
        }

        private void Error(object sender, ErrorEventArgs e)
        {
            DependencyError = e;
            tableDepency.Stop();
            tableDepency.OnChanged -= Changed;
            tableDepency.OnChanged += Changed;
            tableDepency.Start();
        }

        private void Changed(object sender, RecordChangedEventArgs<T> e)
        {
            ChangedRecord = e;
            OnChange();

        }

        public void Dispose()
        {
            tableDepency.Stop();
            tableDepency?.Dispose();
        }
    }
}
