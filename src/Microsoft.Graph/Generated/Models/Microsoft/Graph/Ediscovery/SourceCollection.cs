using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Ediscovery {
    public class SourceCollection : Entity, IParsable {
        /// <summary>Adds an additional source to the sourceCollection.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource> AdditionalSources { get; set; }
        /// <summary>Adds the results of the sourceCollection to the specified reviewSet.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation AddToReviewSetOperation { get; set; }
        /// <summary>The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery. You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.</summary>
        public string ContentQuery { get; set; }
        /// <summary>The user who created the sourceCollection.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the sourceCollection was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Custodian sources that are included in the sourceCollection.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource> CustodianSources { get; set; }
        /// <summary>When specified, the collection will span across a service for an entire workload. Possible values are: none, allTenantMailboxes, allTenantSites, allCaseCustodians, allCaseNoncustodialDataSources.</summary>
        public DataSourceScopes? DataSourceScopes { get; set; }
        /// <summary>The description of the sourceCollection.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the sourceCollection.</summary>
        public string DisplayName { get; set; }
        /// <summary>The last estimate operation associated with the sourceCollection.</summary>
        public EstimateStatisticsOperation LastEstimateStatisticsOperation { get; set; }
        /// <summary>The last user who modified the sourceCollection.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The last date and time the sourceCollection was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>noncustodialDataSource sources that are included in the sourceCollection</summary>
        public List<NoncustodialDataSource> NoncustodialSources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"additionalSources", (o,n) => { (o as SourceCollection).AdditionalSources = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>().ToList(); } },
                {"addToReviewSetOperation", (o,n) => { (o as SourceCollection).AddToReviewSetOperation = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation>(); } },
                {"contentQuery", (o,n) => { (o as SourceCollection).ContentQuery = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as SourceCollection).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as SourceCollection).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodianSources", (o,n) => { (o as SourceCollection).CustodianSources = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>().ToList(); } },
                {"dataSourceScopes", (o,n) => { (o as SourceCollection).DataSourceScopes = n.GetEnumValue<DataSourceScopes>(); } },
                {"description", (o,n) => { (o as SourceCollection).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SourceCollection).DisplayName = n.GetStringValue(); } },
                {"lastEstimateStatisticsOperation", (o,n) => { (o as SourceCollection).LastEstimateStatisticsOperation = n.GetObjectValue<EstimateStatisticsOperation>(); } },
                {"lastModifiedBy", (o,n) => { (o as SourceCollection).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as SourceCollection).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"noncustodialSources", (o,n) => { (o as SourceCollection).NoncustodialSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Ediscovery.DataSource>("custodianSources", CustodianSources);
            writer.WriteEnumValue<DataSourceScopes>("dataSourceScopes", DataSourceScopes);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EstimateStatisticsOperation>("lastEstimateStatisticsOperation", LastEstimateStatisticsOperation);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<NoncustodialDataSource>("noncustodialSources", NoncustodialSources);
        }
    }
}
