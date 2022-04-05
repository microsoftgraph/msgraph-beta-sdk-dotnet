using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Command : Entity, IParsable {
        /// <summary>The appServiceName property</summary>
        public string AppServiceName { get; set; }
        /// <summary>The error property</summary>
        public string Error { get; set; }
        /// <summary>The packageFamilyName property</summary>
        public string PackageFamilyName { get; set; }
        /// <summary>The payload property</summary>
        public PayloadRequest Payload { get; set; }
        /// <summary>The permissionTicket property</summary>
        public string PermissionTicket { get; set; }
        /// <summary>The postBackUri property</summary>
        public string PostBackUri { get; set; }
        /// <summary>The responsepayload property</summary>
        public PayloadResponse Responsepayload { get; set; }
        /// <summary>The status property</summary>
        public string Status { get; set; }
        /// <summary>The type property</summary>
        public string Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Command CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Command();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appServiceName", (o,n) => { (o as Command).AppServiceName = n.GetStringValue(); } },
                {"error", (o,n) => { (o as Command).Error = n.GetStringValue(); } },
                {"packageFamilyName", (o,n) => { (o as Command).PackageFamilyName = n.GetStringValue(); } },
                {"payload", (o,n) => { (o as Command).Payload = n.GetObjectValue<PayloadRequest>(PayloadRequest.CreateFromDiscriminatorValue); } },
                {"permissionTicket", (o,n) => { (o as Command).PermissionTicket = n.GetStringValue(); } },
                {"postBackUri", (o,n) => { (o as Command).PostBackUri = n.GetStringValue(); } },
                {"responsepayload", (o,n) => { (o as Command).Responsepayload = n.GetObjectValue<PayloadResponse>(PayloadResponse.CreateFromDiscriminatorValue); } },
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
