using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrivilegedOperationEvent : Entity, IParsable {
        /// <summary>Detailed human readable information for the event.</summary>
        public string AdditionalInformation { get; set; }
        /// <summary>Indicates the time when the event is created.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>This is only used when the requestType is Activate, and it indicates the expiration time for the role activation.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Incident/Request ticket number during role activation. The value is presented only if the ticket number is provided during role activation.</summary>
        public string ReferenceKey { get; set; }
        /// <summary>Incident/Request ticketing system provided during tole activation. The value is presented only if the ticket system is provided during role activation.</summary>
        public string ReferenceSystem { get; set; }
        /// <summary>The user id of the requestor who initiates the operation.</summary>
        public string RequestorId { get; set; }
        /// <summary>The user name of the requestor who initiates the operation.</summary>
        public string RequestorName { get; set; }
        /// <summary>The request operation type. The requestType value can be: Assign (role assignment), Activate (role activation), Unassign (remove role assignment), Deactivate (role deactivation), ScanAlertsNow (scan security alerts), DismissAlert (dismiss security alert), FixAlertItem (fix a security alert issue),  AccessReview_Review (review an Access Review), AccessReview_Create (create an Access Review) , AccessReview_Update (update an Access Review), AccessReview_Delete (delete an Access Review).</summary>
        public string RequestType { get; set; }
        /// <summary>The id of the role that is associated with the operation.</summary>
        public string RoleId { get; set; }
        /// <summary>The name of the role.</summary>
        public string RoleName { get; set; }
        /// <summary>The tenant (organization) id.</summary>
        public string TenantId { get; set; }
        /// <summary>The id of the user that is associated with the operation.</summary>
        public string UserId { get; set; }
        /// <summary>The user's email.</summary>
        public string UserMail { get; set; }
        /// <summary>The user's display name.</summary>
        public string UserName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"additionalInformation", (o,n) => { (o as PrivilegedOperationEvent).AdditionalInformation = n.GetStringValue(); } },
                {"creationDateTime", (o,n) => { (o as PrivilegedOperationEvent).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", (o,n) => { (o as PrivilegedOperationEvent).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"referenceKey", (o,n) => { (o as PrivilegedOperationEvent).ReferenceKey = n.GetStringValue(); } },
                {"referenceSystem", (o,n) => { (o as PrivilegedOperationEvent).ReferenceSystem = n.GetStringValue(); } },
                {"requestorId", (o,n) => { (o as PrivilegedOperationEvent).RequestorId = n.GetStringValue(); } },
                {"requestorName", (o,n) => { (o as PrivilegedOperationEvent).RequestorName = n.GetStringValue(); } },
                {"requestType", (o,n) => { (o as PrivilegedOperationEvent).RequestType = n.GetStringValue(); } },
                {"roleId", (o,n) => { (o as PrivilegedOperationEvent).RoleId = n.GetStringValue(); } },
                {"roleName", (o,n) => { (o as PrivilegedOperationEvent).RoleName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as PrivilegedOperationEvent).TenantId = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as PrivilegedOperationEvent).UserId = n.GetStringValue(); } },
                {"userMail", (o,n) => { (o as PrivilegedOperationEvent).UserMail = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as PrivilegedOperationEvent).UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
