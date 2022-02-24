using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Command : Entity, IParsable {
        public string AppServiceName { get; set; }
        public string Error { get; set; }
        public string PackageFamilyName { get; set; }
        public PayloadRequest Payload { get; set; }
        public string PermissionTicket { get; set; }
        public string PostBackUri { get; set; }
        public PayloadResponse Responsepayload { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appServiceName", (o,n) => { (o as Command).AppServiceName = n.GetStringValue(); } },
                {"error", (o,n) => { (o as Command).Error = n.GetStringValue(); } },
                {"packageFamilyName", (o,n) => { (o as Command).PackageFamilyName = n.GetStringValue(); } },
                {"payload", (o,n) => { (o as Command).Payload = n.GetObjectValue<PayloadRequest>(); } },
                {"permissionTicket", (o,n) => { (o as Command).PermissionTicket = n.GetStringValue(); } },
                {"postBackUri", (o,n) => { (o as Command).PostBackUri = n.GetStringValue(); } },
                {"responsepayload", (o,n) => { (o as Command).Responsepayload = n.GetObjectValue<PayloadResponse>(); } },
                {"status", (o,n) => { (o as Command).Status = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Command).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appServiceName", AppServiceName);
            writer.WriteStringValue("error", Error);
            writer.WriteStringValue("packageFamilyName", PackageFamilyName);
            writer.WriteObjectValue<PayloadRequest>("payload", Payload);
            writer.WriteStringValue("permissionTicket", PermissionTicket);
            writer.WriteStringValue("postBackUri", PostBackUri);
            writer.WriteObjectValue<PayloadResponse>("responsepayload", Responsepayload);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("type", Type);
        }
    }
}
