using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Command : Entity, IParsable {
        /// <summary>The appServiceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppServiceName {
            get { return BackingStore?.Get<string?>("appServiceName"); }
            set { BackingStore?.Set("appServiceName", value); }
        }
#nullable restore
#else
        public string AppServiceName {
            get { return BackingStore?.Get<string>("appServiceName"); }
            set { BackingStore?.Set("appServiceName", value); }
        }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error {
            get { return BackingStore?.Get<string?>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#nullable restore
#else
        public string Error {
            get { return BackingStore?.Get<string>("error"); }
            set { BackingStore?.Set("error", value); }
        }
#endif
        /// <summary>The packageFamilyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageFamilyName {
            get { return BackingStore?.Get<string?>("packageFamilyName"); }
            set { BackingStore?.Set("packageFamilyName", value); }
        }
#nullable restore
#else
        public string PackageFamilyName {
            get { return BackingStore?.Get<string>("packageFamilyName"); }
            set { BackingStore?.Set("packageFamilyName", value); }
        }
#endif
        /// <summary>The payload property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayloadRequest? Payload {
            get { return BackingStore?.Get<PayloadRequest?>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#nullable restore
#else
        public PayloadRequest Payload {
            get { return BackingStore?.Get<PayloadRequest>("payload"); }
            set { BackingStore?.Set("payload", value); }
        }
#endif
        /// <summary>The permissionTicket property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PermissionTicket {
            get { return BackingStore?.Get<string?>("permissionTicket"); }
            set { BackingStore?.Set("permissionTicket", value); }
        }
#nullable restore
#else
        public string PermissionTicket {
            get { return BackingStore?.Get<string>("permissionTicket"); }
            set { BackingStore?.Set("permissionTicket", value); }
        }
#endif
        /// <summary>The postBackUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostBackUri {
            get { return BackingStore?.Get<string?>("postBackUri"); }
            set { BackingStore?.Set("postBackUri", value); }
        }
#nullable restore
#else
        public string PostBackUri {
            get { return BackingStore?.Get<string>("postBackUri"); }
            set { BackingStore?.Set("postBackUri", value); }
        }
#endif
        /// <summary>The responsepayload property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PayloadResponse? Responsepayload {
            get { return BackingStore?.Get<PayloadResponse?>("responsepayload"); }
            set { BackingStore?.Set("responsepayload", value); }
        }
#nullable restore
#else
        public PayloadResponse Responsepayload {
            get { return BackingStore?.Get<PayloadResponse>("responsepayload"); }
            set { BackingStore?.Set("responsepayload", value); }
        }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
