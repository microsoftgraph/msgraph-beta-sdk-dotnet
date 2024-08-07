// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class EdiscoverySearch : Microsoft.Graph.Beta.Models.Security.Search, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Adds an additional source to the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.DataSource>? AdditionalSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.DataSource>?>("additionalSources"); }
            set { BackingStore?.Set("additionalSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.DataSource> AdditionalSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.DataSource>>("additionalSources"); }
            set { BackingStore?.Set("additionalSources", value); }
        }
#endif
        /// <summary>Adds the results of the eDiscovery search to the specified reviewSet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation? AddToReviewSetOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation?>("addToReviewSetOperation"); }
            set { BackingStore?.Set("addToReviewSetOperation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation AddToReviewSetOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation"); }
            set { BackingStore?.Set("addToReviewSetOperation", value); }
        }
#endif
        /// <summary>Custodian sources that are included in the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.DataSource>? CustodianSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.DataSource>?>("custodianSources"); }
            set { BackingStore?.Set("custodianSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.DataSource> CustodianSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.DataSource>>("custodianSources"); }
            set { BackingStore?.Set("custodianSources", value); }
        }
#endif
        /// <summary>When specified, the collection spans across a service for an entire workload. Possible values are: none, allTenantMailboxes, allTenantSites, allCaseCustodians, allCaseNoncustodialDataSources.</summary>
        public Microsoft.Graph.Beta.Models.Security.DataSourceScopes? DataSourceScopes
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DataSourceScopes?>("dataSourceScopes"); }
            set { BackingStore?.Set("dataSourceScopes", value); }
        }
        /// <summary>The last estimate operation associated with the eDiscovery search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation? LastEstimateStatisticsOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation?>("lastEstimateStatisticsOperation"); }
            set { BackingStore?.Set("lastEstimateStatisticsOperation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation LastEstimateStatisticsOperation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation"); }
            set { BackingStore?.Set("lastEstimateStatisticsOperation", value); }
        }
#endif
        /// <summary>noncustodialDataSource sources that are included in the eDiscovery search</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>? NoncustodialSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>?>("noncustodialSources"); }
            set { BackingStore?.Set("noncustodialSources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource> NoncustodialSources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>>("noncustodialSources"); }
            set { BackingStore?.Set("noncustodialSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.EdiscoverySearch"/> and sets the default values.
        /// </summary>
        public EdiscoverySearch() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoverySearch";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.EdiscoverySearch"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.EdiscoverySearch CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.EdiscoverySearch();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToReviewSetOperation", n => { AddToReviewSetOperation = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation>(Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation.CreateFromDiscriminatorValue); } },
                { "additionalSources", n => { AdditionalSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.DataSource>(Microsoft.Graph.Beta.Models.Security.DataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "custodianSources", n => { CustodianSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.DataSource>(Microsoft.Graph.Beta.Models.Security.DataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                { "dataSourceScopes", n => { DataSourceScopes = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.DataSourceScopes>(); } },
                { "lastEstimateStatisticsOperation", n => { LastEstimateStatisticsOperation = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation>(Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation.CreateFromDiscriminatorValue); } },
                { "noncustodialSources", n => { NoncustodialSources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>(Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.DataSource>("additionalSources", AdditionalSources);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryAddToReviewSetOperation>("addToReviewSetOperation", AddToReviewSetOperation);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.DataSource>("custodianSources", CustodianSources);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.DataSourceScopes>("dataSourceScopes", DataSourceScopes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.EdiscoveryEstimateOperation>("lastEstimateStatisticsOperation", LastEstimateStatisticsOperation);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>("noncustodialSources", NoncustodialSources);
        }
    }
}
