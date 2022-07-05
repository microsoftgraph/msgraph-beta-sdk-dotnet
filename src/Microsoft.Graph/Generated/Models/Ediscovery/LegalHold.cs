using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class LegalHold : Entity, IParsable {
        /// <summary>KQL query that specifies content to be held in the specified locations. To learn more, see Keyword queries and search conditions for Content Search and eDiscovery.  To hold all content in the specified locations, leave contentQuery blank.</summary>
        public string ContentQuery {
            get { return BackingStore?.Get<string>(nameof(ContentQuery)); }
            set { BackingStore?.Set(nameof(ContentQuery), value); }
        }
        /// <summary>The user who created the legal hold.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date and time the legal hold was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The legal hold description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the legal hold.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Lists any errors that happened while placing the hold.</summary>
        public List<string> Errors {
            get { return BackingStore?.Get<List<string>>(nameof(Errors)); }
            set { BackingStore?.Set(nameof(Errors), value); }
        }
        /// <summary>Indicates whether the hold is enabled and actively holding content.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsEnabled)); }
            set { BackingStore?.Set(nameof(IsEnabled), value); }
        }
        /// <summary>the user who last modified the legal hold.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The date and time the legal hold was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Data source entity for SharePoint sites associated with the legal hold.</summary>
        public List<SiteSource> SiteSources {
            get { return BackingStore?.Get<List<SiteSource>>(nameof(SiteSources)); }
            set { BackingStore?.Set(nameof(SiteSources), value); }
        }
        /// <summary>The status of the legal hold. Possible values are: Pending, Error, Success, UnknownFutureValue.</summary>
        public LegalHoldStatus? Status {
            get { return BackingStore?.Get<LegalHoldStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The unifiedGroupSources property</summary>
        public List<UnifiedGroupSource> UnifiedGroupSources {
            get { return BackingStore?.Get<List<UnifiedGroupSource>>(nameof(UnifiedGroupSources)); }
            set { BackingStore?.Set(nameof(UnifiedGroupSources), value); }
        }
        /// <summary>Data source entity for a the legal hold. This is the container for a mailbox and OneDrive for Business site.</summary>
        public List<UserSource> UserSources {
            get { return BackingStore?.Get<List<UserSource>>(nameof(UserSources)); }
            set { BackingStore?.Set(nameof(UserSources), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LegalHold CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LegalHold();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentQuery", n => { ContentQuery = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errors", n => { Errors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<SiteSource>(SiteSource.CreateFromDiscriminatorValue).ToList(); } },
                {"status", n => { Status = n.GetEnumValue<LegalHoldStatus>(); } },
                {"unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<UnifiedGroupSource>(UnifiedGroupSource.CreateFromDiscriminatorValue).ToList(); } },
                {"userSources", n => { UserSources = n.GetCollectionOfObjectValues<UserSource>(UserSource.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("contentQuery", ContentQuery);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("errors", Errors);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteEnumValue<LegalHoldStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
