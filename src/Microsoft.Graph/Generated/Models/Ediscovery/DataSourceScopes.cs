using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public enum DataSourceScopes {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "allTenantMailboxes")]
        AllTenantMailboxes,
        [EnumMember(Value = "allTenantSites")]
        AllTenantSites,
        [EnumMember(Value = "allCaseCustodians")]
        AllCaseCustodians,
        [EnumMember(Value = "allCaseNoncustodialDataSources")]
        AllCaseNoncustodialDataSources,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
