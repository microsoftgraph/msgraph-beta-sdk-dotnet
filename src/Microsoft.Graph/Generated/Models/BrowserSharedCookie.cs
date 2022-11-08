using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class BrowserSharedCookie : Entity, IParsable {
        /// <summary>The comment for the shared cookie.</summary>
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
        /// <summary>The date and time when the shared cookie was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time when the shared cookie was deleted.</summary>
        public DateTimeOffset? DeletedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deletedDateTime"); }
            set { BackingStore?.Set("deletedDateTime", value); }
        }
        /// <summary>The name of the cookie.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The history of modifications applied to the cookie.</summary>
        public List<BrowserSharedCookieHistory> History {
            get { return BackingStore?.Get<List<BrowserSharedCookieHistory>>("history"); }
            set { BackingStore?.Set("history", value); }
        }
        /// <summary>Controls whether a cookie is a host-only or domain cookie.</summary>
        public bool? HostOnly {
            get { return BackingStore?.Get<bool?>("hostOnly"); }
            set { BackingStore?.Set("hostOnly", value); }
        }
        /// <summary>The URL of the cookie.</summary>
        public string HostOrDomain {
            get { return BackingStore?.Get<string>("hostOrDomain"); }
            set { BackingStore?.Set("hostOrDomain", value); }
        }
        /// <summary>The user who last modified the cookie.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
        /// <summary>The date and time when the cookie was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The path of the cookie.</summary>
        public string PathObject {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
        /// <summary>The sourceEnvironment property</summary>
        public BrowserSharedCookieSourceEnvironment? SourceEnvironment {
            get { return BackingStore?.Get<BrowserSharedCookieSourceEnvironment?>("sourceEnvironment"); }
            set { BackingStore?.Set("sourceEnvironment", value); }
        }
        /// <summary>The status property</summary>
        public BrowserSharedCookieStatus? Status {
            get { return BackingStore?.Get<BrowserSharedCookieStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new browserSharedCookie and sets the default values.
        /// </summary>
        public BrowserSharedCookie() : base() {
            OdataType = "#microsoft.graph.browserSharedCookie";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BrowserSharedCookie CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSharedCookie();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<BrowserSharedCookieHistory>(BrowserSharedCookieHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostOnly", n => { HostOnly = n.GetBoolValue(); } },
                {"hostOrDomain", n => { HostOrDomain = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"path", n => { PathObject = n.GetStringValue(); } },
                {"sourceEnvironment", n => { SourceEnvironment = n.GetEnumValue<BrowserSharedCookieSourceEnvironment>(); } },
                {"status", n => { Status = n.GetEnumValue<BrowserSharedCookieStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<BrowserSharedCookieHistory>("history", History);
            writer.WriteBoolValue("hostOnly", HostOnly);
            writer.WriteStringValue("hostOrDomain", HostOrDomain);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("path", PathObject);
            writer.WriteEnumValue<BrowserSharedCookieSourceEnvironment>("sourceEnvironment", SourceEnvironment);
            writer.WriteEnumValue<BrowserSharedCookieStatus>("status", Status);
        }
    }
}
