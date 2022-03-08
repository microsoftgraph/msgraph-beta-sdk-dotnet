using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the securityActions property of the microsoft.graph.security entity.</summary>
    public class SecurityAction : Entity, IParsable {
        /// <summary>Reason for invoking this action.</summary>
        public string ActionReason { get; set; }
        /// <summary>The Application ID of the calling application that submitted (POST) the action. The appId should be extracted from the auth token and not entered manually by the calling application.</summary>
        public string AppId { get; set; }
        /// <summary>Azure tenant ID of the entity to determine which tenant the entity belongs to (multi-tenancy support). The azureTenantId should be extracted from the auth token and not entered manually by the calling application.</summary>
        public string AzureTenantId { get; set; }
        public string ClientContext { get; set; }
        /// <summary>Timestamp when the action was completed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>Timestamp when the action is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Error info when the action fails.</summary>
        public ResultInfo ErrorInfo { get; set; }
        /// <summary>Timestamp when this action was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>Action name.</summary>
        public string Name { get; set; }
        /// <summary>Collection of parameters (key-value pairs) necessary to invoke the action, for example, URL or fileHash to block.). Required.</summary>
        public List<KeyValuePair> Parameters { get; set; }
        /// <summary>Collection of securityActionState to keep the history of an action.</summary>
        public List<SecurityActionState> States { get; set; }
        /// <summary>Status of the action. Possible values are: NotStarted, Running, Completed, Failed.</summary>
        public OperationStatus? Status { get; set; }
        /// <summary>The user principal name of the signed-in user that submitted  (POST) the action. The user should be extracted from the auth token and not entered manually by the calling application.</summary>
        public string User { get; set; }
        /// <summary>Complex Type containing details about the Security product/service vendor, provider, and sub-provider (for example, vendor=Microsoft; provider=Windows Defender ATP; sub-provider=AppLocker).</summary>
        public SecurityVendorInformation VendorInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionReason", (o,n) => { (o as SecurityAction).ActionReason = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as SecurityAction).AppId = n.GetStringValue(); } },
                {"azureTenantId", (o,n) => { (o as SecurityAction).AzureTenantId = n.GetStringValue(); } },
                {"clientContext", (o,n) => { (o as SecurityAction).ClientContext = n.GetStringValue(); } },
                {"completedDateTime", (o,n) => { (o as SecurityAction).CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as SecurityAction).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"errorInfo", (o,n) => { (o as SecurityAction).ErrorInfo = n.GetObjectValue<ResultInfo>(ResultInfo.CreateFromDiscriminatorValue); } },
                {"lastActionDateTime", (o,n) => { (o as SecurityAction).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as SecurityAction).Name = n.GetStringValue(); } },
                {"parameters", (o,n) => { (o as SecurityAction).Parameters = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"states", (o,n) => { (o as SecurityAction).States = n.GetCollectionOfObjectValues<SecurityActionState>(SecurityActionState.CreateFromDiscriminatorValue).ToList(); } },
                {"status", (o,n) => { (o as SecurityAction).Status = n.GetEnumValue<OperationStatus>(); } },
                {"user", (o,n) => { (o as SecurityAction).User = n.GetStringValue(); } },
                {"vendorInformation", (o,n) => { (o as SecurityAction).VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionReason", ActionReason);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ResultInfo>("errorInfo", ErrorInfo);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("parameters", Parameters);
            writer.WriteCollectionOfObjectValues<SecurityActionState>("states", States);
            writer.WriteEnumValue<OperationStatus>("status", Status);
            writer.WriteStringValue("user", User);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
