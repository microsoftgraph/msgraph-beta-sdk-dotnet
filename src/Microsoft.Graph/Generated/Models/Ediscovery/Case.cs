using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class Case : Entity, IParsable {
        /// <summary>The user who closed the case.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet ClosedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("closedBy"); }
            set { BackingStore?.Set("closedBy", value); }
        }
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>The date and time when the entity was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Returns a list of case custodian objects for this case.  Nullable.</summary>
        public List<Custodian> Custodians {
            get { return BackingStore?.Get<List<Custodian>>("custodians"); }
            set { BackingStore?.Set("custodians", value); }
        }
        /// <summary>The case description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The case name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The external case number for customer reference.</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
        /// <summary>The last user who modified the entity.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The latest date and time when the case was modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Returns a list of case legalHold objects for this case.  Nullable.</summary>
        public List<LegalHold> LegalHolds {
            get { return BackingStore?.Get<List<LegalHold>>("legalHolds"); }
            set { BackingStore?.Set("legalHolds", value); }
        }
        /// <summary>Returns a list of case noncustodialDataSource objects for this case.  Nullable.</summary>
        public List<NoncustodialDataSource> NoncustodialDataSources {
            get { return BackingStore?.Get<List<NoncustodialDataSource>>("noncustodialDataSources"); }
            set { BackingStore?.Set("noncustodialDataSources", value); }
        }
        /// <summary>Returns a list of case operation objects for this case. Nullable.</summary>
        public List<CaseOperation> Operations {
            get { return BackingStore?.Get<List<CaseOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
        /// <summary>Returns a list of reviewSet objects in the case. Read-only. Nullable.</summary>
        public List<ReviewSet> ReviewSets {
            get { return BackingStore?.Get<List<ReviewSet>>("reviewSets"); }
            set { BackingStore?.Set("reviewSets", value); }
        }
        /// <summary>The settings property</summary>
        public CaseSettings Settings {
            get { return BackingStore?.Get<CaseSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
        /// <summary>Returns a list of sourceCollection objects associated with this case.</summary>
        public List<SourceCollection> SourceCollections {
            get { return BackingStore?.Get<List<SourceCollection>>("sourceCollections"); }
            set { BackingStore?.Set("sourceCollections", value); }
        }
        /// <summary>The case status. Possible values are unknown, active, pendingDelete, closing, closed, and closedWithError. For details, see the following table.</summary>
        public CaseStatus? Status {
            get { return BackingStore?.Get<CaseStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Returns a list of tag objects associated to this case.</summary>
        public List<Tag> Tags {
            get { return BackingStore?.Get<List<Tag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"custodians", n => { Custodians = n.GetCollectionOfObjectValues<Custodian>(Custodian.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<LegalHold>(LegalHold.CreateFromDiscriminatorValue)?.ToList(); } },
                {"noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<NoncustodialDataSource>(NoncustodialDataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<ReviewSet>(ReviewSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<CaseSettings>(CaseSettings.CreateFromDiscriminatorValue); } },
                {"sourceCollections", n => { SourceCollections = n.GetCollectionOfObjectValues<SourceCollection>(SourceCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<CaseStatus>(); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<Tag>(Tag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
