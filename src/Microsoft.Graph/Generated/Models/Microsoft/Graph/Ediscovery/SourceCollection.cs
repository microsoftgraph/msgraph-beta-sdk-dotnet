using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class SourceCollection : Entity, IParsable {
        /// <summary>Adds an additional source to the sourceCollection.</summary>
        public List<DataSource> AdditionalSources { get; set; }
        /// <summary>Adds the results of the sourceCollection to the specified reviewSet.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation AddToReviewSetOperation { get; set; }
        /// <summary>The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery. You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date>=06/01/2016 AND Date<=07/01/2016.</summary>
        public string ContentQuery { get; set; }
        /// <summary>The user who created the sourceCollection.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The date and time the sourceCollection was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Custodian sources that are included in the sourceCollection.</summary>
        public List<DataSource> CustodianSources { get; set; }
        /// <summary>When specified, the collection will span across a service for an entire workload. Possible values are: none, allTenantMailboxes, allTenantSites, allCaseCustodians, allCaseNoncustodialDataSources.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.DataSourceScopes? DataSourceScopes { get; set; }
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SourceCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SourceCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"additionalSources", (o,n) => { (o as SourceCollection).AdditionalSources = n.GetCollectionOfObjectValues<DataSource>(DataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"addToReviewSetOperation", (o,n) => { (o as SourceCollection).AddToReviewSetOperation = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation.CreateFromDiscriminatorValue); } },
                {"contentQuery", (o,n) => { (o as SourceCollection).ContentQuery = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as SourceCollection).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as SourceCollection).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodianSources", (o,n) => { (o as SourceCollection).CustodianSources = n.GetCollectionOfObjectValues<DataSource>(DataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"dataSourceScopes", (o,n) => { (o as SourceCollection).DataSourceScopes = n.GetEnumValue<DataSourceScopes>(); } },
                {"description", (o,n) => { (o as SourceCollection).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SourceCollection).DisplayName = n.GetStringValue(); } },
                {"lastEstimateStatisticsOperation", (o,n) => { (o as SourceCollection).LastEstimateStatisticsOperation = n.GetObjectValue<EstimateStatisticsOperation>(EstimateStatisticsOperation.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", (o,n) => { (o as SourceCollection).LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as SourceCollection).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"noncustodialSources", (o,n) => { (o as SourceCollection).NoncustodialSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>(NoncustodialDataSource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.AddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DataSource>("custodianSources", CustodianSources);
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
