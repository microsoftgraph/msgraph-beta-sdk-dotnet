using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class EdiscoveryCase : Case, IParsable {
        /// <summary>The closedBy property</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet ClosedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(ClosedBy)); }
            set { BackingStore?.Set(nameof(ClosedBy), value); }
        }
        /// <summary>The closedDateTime property</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ClosedDateTime)); }
            set { BackingStore?.Set(nameof(ClosedDateTime), value); }
        }
        /// <summary>The custodians property</summary>
        public List<EdiscoveryCustodian> Custodians {
            get { return BackingStore?.Get<List<EdiscoveryCustodian>>(nameof(Custodians)); }
            set { BackingStore?.Set(nameof(Custodians), value); }
        }
        /// <summary>The externalId property</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>(nameof(ExternalId)); }
            set { BackingStore?.Set(nameof(ExternalId), value); }
        }
        /// <summary>The legalHolds property</summary>
        public List<EdiscoveryHoldPolicy> LegalHolds {
            get { return BackingStore?.Get<List<EdiscoveryHoldPolicy>>(nameof(LegalHolds)); }
            set { BackingStore?.Set(nameof(LegalHolds), value); }
        }
        /// <summary>The noncustodialDataSources property</summary>
        public List<EdiscoveryNoncustodialDataSource> NoncustodialDataSources {
            get { return BackingStore?.Get<List<EdiscoveryNoncustodialDataSource>>(nameof(NoncustodialDataSources)); }
            set { BackingStore?.Set(nameof(NoncustodialDataSources), value); }
        }
        /// <summary>The operations property</summary>
        public List<CaseOperation> Operations {
            get { return BackingStore?.Get<List<CaseOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>The reviewSets property</summary>
        public List<EdiscoveryReviewSet> ReviewSets {
            get { return BackingStore?.Get<List<EdiscoveryReviewSet>>(nameof(ReviewSets)); }
            set { BackingStore?.Set(nameof(ReviewSets), value); }
        }
        /// <summary>The searches property</summary>
        public List<EdiscoverySearch> Searches {
            get { return BackingStore?.Get<List<EdiscoverySearch>>(nameof(Searches)); }
            set { BackingStore?.Set(nameof(Searches), value); }
        }
        /// <summary>The settings property</summary>
        public EdiscoveryCaseSettings Settings {
            get { return BackingStore?.Get<EdiscoveryCaseSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>The tags property</summary>
        public List<EdiscoveryReviewTag> Tags {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EdiscoveryCase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryCase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"closedBy", n => { ClosedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodians", n => { Custodians = n.GetCollectionOfObjectValues<EdiscoveryCustodian>(EdiscoveryCustodian.CreateFromDiscriminatorValue).ToList(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<EdiscoveryHoldPolicy>(EdiscoveryHoldPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>(EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<EdiscoveryReviewSet>(EdiscoveryReviewSet.CreateFromDiscriminatorValue).ToList(); } },
                {"searches", n => { Searches = n.GetCollectionOfObjectValues<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EdiscoveryCaseSettings>(EdiscoveryCaseSettings.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<EdiscoveryCustodian>("custodians", Custodians);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<EdiscoveryHoldPolicy>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewSet>("reviewSets", ReviewSets);
            writer.WriteCollectionOfObjectValues<EdiscoverySearch>("searches", Searches);
            writer.WriteObjectValue<EdiscoveryCaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
