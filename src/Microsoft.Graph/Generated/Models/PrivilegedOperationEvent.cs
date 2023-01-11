using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedOperationEvent : Entity, IParsable {
        /// <summary>Detailed human readable information for the event.</summary>
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
        /// <summary>Indicates the time when the event is created.</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>This is only used when the requestType is Activate, and it indicates the expiration time for the role activation.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Incident/Request ticket number during role activation. The value is presented only if the ticket number is provided during role activation.</summary>
        public string ReferenceKey {
            get { return BackingStore?.Get<string>("referenceKey"); }
            set { BackingStore?.Set("referenceKey", value); }
        }
        /// <summary>Incident/Request ticketing system provided during tole activation. The value is presented only if the ticket system is provided during role activation.</summary>
        public string ReferenceSystem {
            get { return BackingStore?.Get<string>("referenceSystem"); }
            set { BackingStore?.Set("referenceSystem", value); }
        }
        /// <summary>The user id of the requestor who initiates the operation.</summary>
        public string RequestorId {
            get { return BackingStore?.Get<string>("requestorId"); }
            set { BackingStore?.Set("requestorId", value); }
        }
        /// <summary>The user name of the requestor who initiates the operation.</summary>
        public string RequestorName {
            get { return BackingStore?.Get<string>("requestorName"); }
            set { BackingStore?.Set("requestorName", value); }
        }
        /// <summary>The request operation type. The requestType value can be: Assign (role assignment), Activate (role activation), Unassign (remove role assignment), Deactivate (role deactivation), ScanAlertsNow (scan security alerts), DismissAlert (dismiss security alert), FixAlertItem (fix a security alert issue),  AccessReview_Review (review an Access Review), AccessReview_Create (create an Access Review) , AccessReview_Update (update an Access Review), AccessReview_Delete (delete an Access Review).</summary>
        public string RequestType {
            get { return BackingStore?.Get<string>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
        /// <summary>The id of the role that is associated with the operation.</summary>
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
        /// <summary>The name of the role.</summary>
        public string RoleName {
            get { return BackingStore?.Get<string>("roleName"); }
            set { BackingStore?.Set("roleName", value); }
        }
        /// <summary>The tenant (organization) id.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The id of the user that is associated with the operation.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>The user&apos;s email.</summary>
        public string UserMail {
            get { return BackingStore?.Get<string>("userMail"); }
            set { BackingStore?.Set("userMail", value); }
        }
        /// <summary>The user&apos;s display name.</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedOperationEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedOperationEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"referenceKey", n => { ReferenceKey = n.GetStringValue(); } },
                {"referenceSystem", n => { ReferenceSystem = n.GetStringValue(); } },
                {"requestorId", n => { RequestorId = n.GetStringValue(); } },
                {"requestorName", n => { RequestorName = n.GetStringValue(); } },
                {"requestType", n => { RequestType = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleName", n => { RoleName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userMail", n => { UserMail = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("referenceKey", ReferenceKey);
            writer.WriteStringValue("referenceSystem", ReferenceSystem);
            writer.WriteStringValue("requestorId", RequestorId);
            writer.WriteStringValue("requestorName", RequestorName);
            writer.WriteStringValue("requestType", RequestType);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleName", RoleName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userMail", UserMail);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
