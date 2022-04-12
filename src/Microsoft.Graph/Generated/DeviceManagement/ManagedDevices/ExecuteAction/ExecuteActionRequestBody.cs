using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.ExecuteAction {
    /// <summary>Provides operations to call the executeAction method.</summary>
    public class ExecuteActionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The actionName property</summary>
        public ManagedDeviceRemoteAction? ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The carrierUrl property</summary>
        public string CarrierUrl { get; set; }
        /// <summary>The deprovisionReason property</summary>
        public string DeprovisionReason { get; set; }
        /// <summary>The deviceIds property</summary>
        public List<string> DeviceIds { get; set; }
        /// <summary>The deviceName property</summary>
        public string DeviceName { get; set; }
        /// <summary>The keepEnrollmentData property</summary>
        public bool? KeepEnrollmentData { get; set; }
        /// <summary>The keepUserData property</summary>
        public bool? KeepUserData { get; set; }
        /// <summary>The notificationBody property</summary>
        public string NotificationBody { get; set; }
        /// <summary>The notificationTitle property</summary>
        public string NotificationTitle { get; set; }
        /// <summary>The organizationalUnitPath property</summary>
        public string OrganizationalUnitPath { get; set; }
        /// <summary>The persistEsimDataPlan property</summary>
        public bool? PersistEsimDataPlan { get; set; }
        /// <summary>
        /// Instantiates a new executeActionRequestBody and sets the default values.
        /// </summary>
        public ExecuteActionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExecuteActionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExecuteActionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetEnumValue<ManagedDeviceRemoteAction>(); } },
                {"carrierUrl", n => { CarrierUrl = n.GetStringValue(); } },
                {"deprovisionReason", n => { DeprovisionReason = n.GetStringValue(); } },
                {"deviceIds", n => { DeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"keepEnrollmentData", n => { KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", n => { KeepUserData = n.GetBoolValue(); } },
                {"notificationBody", n => { NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", n => { NotificationTitle = n.GetStringValue(); } },
                {"organizationalUnitPath", n => { OrganizationalUnitPath = n.GetStringValue(); } },
                {"persistEsimDataPlan", n => { PersistEsimDataPlan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ManagedDeviceRemoteAction>("actionName", ActionName);
            writer.WriteStringValue("carrierUrl", CarrierUrl);
            writer.WriteStringValue("deprovisionReason", DeprovisionReason);
            writer.WriteCollectionOfPrimitiveValues<string>("deviceIds", DeviceIds);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteBoolValue("keepEnrollmentData", KeepEnrollmentData);
            writer.WriteBoolValue("keepUserData", KeepUserData);
            writer.WriteStringValue("notificationBody", NotificationBody);
            writer.WriteStringValue("notificationTitle", NotificationTitle);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteBoolValue("persistEsimDataPlan", PersistEsimDataPlan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
