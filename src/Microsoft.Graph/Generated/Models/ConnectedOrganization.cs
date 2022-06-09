using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class ConnectedOrganization : Entity, IParsable {
        /// <summary>UPN of the user who created this resource. Read-only.</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description of the connected organization.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the connected organization. Supports $filter (eq).</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The externalSponsors property</summary>
        public List<DirectoryObject> ExternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(ExternalSponsors)); }
            set { BackingStore?.Set(nameof(ExternalSponsors), value); }
        }
        /// <summary>The identity sources in this connected organization, one of azureActiveDirectoryTenant, crossCloudAzureActiveDirectoryTenant, domainIdentitySource or externalDomainFederation. Read-only. Nullable. Supports $select and $filter(eq). To filter by the derived types, you must declare the resource using its full OData cast, for example, $filter=identitySources/any(is:is/microsoft.graph.azureActiveDirectoryTenant/tenantId eq &apos;bcfdfff4-cbc3-43f2-9000-ba7b7515054f&apos;).</summary>
        public List<IdentitySource> IdentitySources {
            get { return BackingStore?.Get<List<IdentitySource>>(nameof(IdentitySources)); }
            set { BackingStore?.Set(nameof(IdentitySources), value); }
        }
        /// <summary>The internalSponsors property</summary>
        public List<DirectoryObject> InternalSponsors {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(InternalSponsors)); }
            set { BackingStore?.Set(nameof(InternalSponsors), value); }
        }
        /// <summary>UPN of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>(nameof(ModifiedBy)); }
            set { BackingStore?.Set(nameof(ModifiedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ModifiedDateTime), value); }
        }
        /// <summary>The state of a connected organization defines whether assignment policies with requestor scope type AllConfiguredConnectedOrganizationSubjects are applicable or not. Possible values are: configured, proposed.</summary>
        public ConnectedOrganizationState? State {
            get { return BackingStore?.Get<ConnectedOrganizationState?>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConnectedOrganization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectedOrganization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalSponsors", n => { ExternalSponsors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"identitySources", n => { IdentitySources = n.GetCollectionOfObjectValues<IdentitySource>(IdentitySource.CreateFromDiscriminatorValue).ToList(); } },
                {"internalSponsors", n => { InternalSponsors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<ConnectedOrganizationState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("externalSponsors", ExternalSponsors);
            writer.WriteCollectionOfObjectValues<IdentitySource>("identitySources", IdentitySources);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("internalSponsors", InternalSponsors);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<ConnectedOrganizationState>("state", State);
        }
    }
}
