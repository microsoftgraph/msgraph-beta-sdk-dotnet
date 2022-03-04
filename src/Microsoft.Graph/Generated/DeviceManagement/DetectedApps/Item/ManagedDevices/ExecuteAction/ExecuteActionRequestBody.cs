using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.DetectedApps.Item.ManagedDevices.ExecuteAction {
    public class ExecuteActionRequestBody : IParsable {
        public ManagedDeviceRemoteAction? ActionName { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string CarrierUrl { get; set; }
        public string DeprovisionReason { get; set; }
        public List<string> DeviceIds { get; set; }
        public string DeviceName { get; set; }
        public bool? KeepEnrollmentData { get; set; }
        public bool? KeepUserData { get; set; }
        public string NotificationBody { get; set; }
        public string NotificationTitle { get; set; }
        public string OrganizationalUnitPath { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionName", (o,n) => { (o as ExecuteActionRequestBody).ActionName = n.GetEnumValue<ManagedDeviceRemoteAction>(); } },
                {"carrierUrl", (o,n) => { (o as ExecuteActionRequestBody).CarrierUrl = n.GetStringValue(); } },
                {"deprovisionReason", (o,n) => { (o as ExecuteActionRequestBody).DeprovisionReason = n.GetStringValue(); } },
                {"deviceIds", (o,n) => { (o as ExecuteActionRequestBody).DeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deviceName", (o,n) => { (o as ExecuteActionRequestBody).DeviceName = n.GetStringValue(); } },
                {"keepEnrollmentData", (o,n) => { (o as ExecuteActionRequestBody).KeepEnrollmentData = n.GetBoolValue(); } },
                {"keepUserData", (o,n) => { (o as ExecuteActionRequestBody).KeepUserData = n.GetBoolValue(); } },
                {"notificationBody", (o,n) => { (o as ExecuteActionRequestBody).NotificationBody = n.GetStringValue(); } },
                {"notificationTitle", (o,n) => { (o as ExecuteActionRequestBody).NotificationTitle = n.GetStringValue(); } },
                {"organizationalUnitPath", (o,n) => { (o as ExecuteActionRequestBody).OrganizationalUnitPath = n.GetStringValue(); } },
                {"persistEsimDataPlan", (o,n) => { (o as ExecuteActionRequestBody).PersistEsimDataPlan = n.GetBoolValue(); } },
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
