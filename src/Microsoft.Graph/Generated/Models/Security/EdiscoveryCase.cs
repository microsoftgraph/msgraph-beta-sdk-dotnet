// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EdiscoveryCase : global::Microsoft.Graph.Beta.Models.Security.Case, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Returns a list of ediscoveryCaseMember objects associated to this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember>? CaseMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember>?>("caseMembers"); }
            set { BackingStore?.Set("caseMembers", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember> CaseMembers
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember>>("caseMembers"); }
            set { BackingStore?.Set("caseMembers", value); }
        }
#endif
        /// <summary>The user who closed the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? ClosedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("closedBy"); }
            set { BackingStore?.Set("closedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet ClosedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("closedBy"); }
            set { BackingStore?.Set("closedBy", value); }
        }
#endif
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>Returns a list of case ediscoveryCustodian objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>? Custodians
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>?>("custodians"); }
            set { BackingStore?.Set("custodians", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian> Custodians
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>>("custodians"); }
            set { BackingStore?.Set("custodians", value); }
        }
#endif
        /// <summary>The external case number for customer reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId
        {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId
        {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>Returns a list of case eDiscoveryHoldPolicy objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy>? LegalHolds
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy>?>("legalHolds"); }
            set { BackingStore?.Set("legalHolds", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy> LegalHolds
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy>>("legalHolds"); }
            set { BackingStore?.Set("legalHolds", value); }
        }
#endif
        /// <summary>Returns a list of case ediscoveryNoncustodialDataSource objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>? NoncustodialDataSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>?>("noncustodialDataSources"); }
            set { BackingStore?.Set("noncustodialDataSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource> NoncustodialDataSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>>("noncustodialDataSources"); }
            set { BackingStore?.Set("noncustodialDataSources", value); }
        }
#endif
        /// <summary>Returns a list of case caseOperation objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.CaseOperation>? Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.CaseOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.CaseOperation> Operations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.CaseOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Returns a list of eDiscoveryReviewSet objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet>? ReviewSets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet>?>("reviewSets"); }
            set { BackingStore?.Set("reviewSets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet> ReviewSets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet>>("reviewSets"); }
            set { BackingStore?.Set("reviewSets", value); }
        }
#endif
        /// <summary>Returns a list of eDiscoverySearch objects associated with this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch>? Searches
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch>?>("searches"); }
            set { BackingStore?.Set("searches", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch> Searches
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch>>("searches"); }
            set { BackingStore?.Set("searches", value); }
        }
#endif
        /// <summary>Returns a list of eDIscoverySettings objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings? Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings Settings
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Returns a list of ediscoveryReviewTag objects associated to this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>? Tags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag> Tags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase"/> and sets the default values.
        /// </summary>
        public EdiscoveryCase() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoveryCase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "caseMembers", n => { CaseMembers = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "closedBy", n => { ClosedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                { "custodians", n => { Custodians = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian.CreateFromDiscriminatorValue)?.AsList(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.CaseOperation>(global::Microsoft.Graph.Beta.Models.Security.CaseOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "searches", n => { Searches = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch>(global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch.CreateFromDiscriminatorValue)?.AsList(); } },
                { "settings", n => { Settings = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>(global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseMember>("caseMembers", CaseMembers);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCustodian>("custodians", Custodians);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryHoldPolicy>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryNoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewSet>("reviewSets", ReviewSets);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoverySearch>("searches", Searches);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryCaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
#pragma warning restore CS0618
