using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class Command : Entity, IParsable {
        /// <summary>The appServiceName property</summary>
        public string AppServiceName {
            get { return BackingStore?.Get<string>(nameof(AppServiceName)); }
            set { BackingStore?.Set(nameof(AppServiceName), value); }
        }
        /// <summary>The error property</summary>
        public string Error {
            get { return BackingStore?.Get<string>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
        }
        /// <summary>The packageFamilyName property</summary>
        public string PackageFamilyName {
            get { return BackingStore?.Get<string>(nameof(PackageFamilyName)); }
            set { BackingStore?.Set(nameof(PackageFamilyName), value); }
        }
        /// <summary>The payload property</summary>
        public PayloadRequest Payload {
            get { return BackingStore?.Get<PayloadRequest>(nameof(Payload)); }
            set { BackingStore?.Set(nameof(Payload), value); }
        }
        /// <summary>The permissionTicket property</summary>
        public string PermissionTicket {
            get { return BackingStore?.Get<string>(nameof(PermissionTicket)); }
            set { BackingStore?.Set(nameof(PermissionTicket), value); }
        }
        /// <summary>The postBackUri property</summary>
        public string PostBackUri {
            get { return BackingStore?.Get<string>(nameof(PostBackUri)); }
            set { BackingStore?.Set(nameof(PostBackUri), value); }
        }
        /// <summary>The responsepayload property</summary>
        public PayloadResponse Responsepayload {
            get { return BackingStore?.Get<PayloadResponse>(nameof(Responsepayload)); }
            set { BackingStore?.Set(nameof(Responsepayload), value); }
        }
        /// <summary>The status property</summary>
        public string Status {
            get { return BackingStore?.Get<string>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appServiceName", n => { AppServiceName = n.GetStringValue(); } },
                {"error", n => { Error = n.GetStringValue(); } },
                {"packageFamilyName", n => { PackageFamilyName = n.GetStringValue(); } },
                {"payload", n => { Payload = n.GetObjectValue<PayloadRequest>(PayloadRequest.CreateFromDiscriminatorValue); } },
                {"permissionTicket", n => { PermissionTicket = n.GetStringValue(); } },
                {"postBackUri", n => { PostBackUri = n.GetStringValue(); } },
                {"responsepayload", n => { Responsepayload = n.GetObjectValue<PayloadResponse>(PayloadResponse.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
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
