using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class Case : Entity, IParsable {
        /// <summary>The user who closed the case.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet ClosedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(ClosedBy)); }
            set { BackingStore?.Set(nameof(ClosedBy), value); }
        }
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ClosedDateTime)); }
            set { BackingStore?.Set(nameof(ClosedDateTime), value); }
        }
        /// <summary>The date and time when the entity was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Returns a list of case custodian objects for this case.  Nullable.</summary>
        public List<Custodian> Custodians {
            get { return BackingStore?.Get<List<Custodian>>(nameof(Custodians)); }
            set { BackingStore?.Set(nameof(Custodians), value); }
        }
        /// <summary>The case description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The case name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The external case number for customer reference.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>(nameof(ExternalId)); }
            set { BackingStore?.Set(nameof(ExternalId), value); }
        }
        /// <summary>The last user who modified the entity.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The latest date and time when the case was modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Returns a list of case legalHold objects for this case.  Nullable.</summary>
        public List<LegalHold> LegalHolds {
            get { return BackingStore?.Get<List<LegalHold>>(nameof(LegalHolds)); }
            set { BackingStore?.Set(nameof(LegalHolds), value); }
        }
        /// <summary>Returns a list of case noncustodialDataSource objects for this case.  Nullable.</summary>
        public List<NoncustodialDataSource> NoncustodialDataSources {
            get { return BackingStore?.Get<List<NoncustodialDataSource>>(nameof(NoncustodialDataSources)); }
            set { BackingStore?.Set(nameof(NoncustodialDataSources), value); }
        }
        /// <summary>Returns a list of case operation objects for this case. Nullable.</summary>
        public List<CaseOperation> Operations {
            get { return BackingStore?.Get<List<CaseOperation>>(nameof(Operations)); }
            set { BackingStore?.Set(nameof(Operations), value); }
        }
        /// <summary>Returns a list of reviewSet objects in the case. Read-only. Nullable.</summary>
        public List<ReviewSet> ReviewSets {
            get { return BackingStore?.Get<List<ReviewSet>>(nameof(ReviewSets)); }
            set { BackingStore?.Set(nameof(ReviewSets), value); }
        }
        /// <summary>The settings property</summary>
        public CaseSettings Settings {
            get { return BackingStore?.Get<CaseSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>Returns a list of sourceCollection objects associated with this case.</summary>
        public List<SourceCollection> SourceCollections {
            get { return BackingStore?.Get<List<SourceCollection>>(nameof(SourceCollections)); }
            set { BackingStore?.Set(nameof(SourceCollections), value); }
        }
        /// <summary>The case status. Possible values are unknown, active, pendingDelete, closing, closed, and closedWithError. For details, see the following table.</summary>
        public CaseStatus? Status {
            get { return BackingStore?.Get<CaseStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>Returns a list of tag objects associated to this case.</summary>
        public List<Tag> Tags {
            get { return BackingStore?.Get<List<Tag>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Case CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Case();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"closedBy", n => { ClosedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodians", n => { Custodians = n.GetCollectionOfObjectValues<Custodian>(Custodian.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<LegalHold>(LegalHold.CreateFromDiscriminatorValue).ToList(); } },
                {"noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>(NoncustodialDataSource.CreateFromDiscriminatorValue).ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<ReviewSet>(ReviewSet.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<CaseSettings>(CaseSettings.CreateFromDiscriminatorValue); } },
                {"sourceCollections", n => { SourceCollections = n.GetCollectionOfObjectValues<SourceCollection>(SourceCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<CaseStatus>(); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<Custodian>("custodians", Custodians);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LegalHold>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<NoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ReviewSet>("reviewSets", ReviewSets);
            writer.WriteObjectValue<CaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<SourceCollection>("sourceCollections", SourceCollections);
            writer.WriteEnumValue<CaseStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<Tag>("tags", Tags);
        }
    }
}
