using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class CloudApplicationEvidence : AlertEvidence, IParsable {
        /// <summary>The appId property</summary>
        public long? AppId {
            get { return BackingStore?.Get<long?>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The instanceId property</summary>
        public long? InstanceId {
            get { return BackingStore?.Get<long?>(nameof(InstanceId)); }
            set { BackingStore?.Set(nameof(InstanceId), value); }
        }
        /// <summary>The instanceName property</summary>
        public string InstanceName {
            get { return BackingStore?.Get<string>(nameof(InstanceName)); }
            set { BackingStore?.Set(nameof(InstanceName), value); }
        }
        /// <summary>The saasAppId property</summary>
        public long? SaasAppId {
            get { return BackingStore?.Get<long?>(nameof(SaasAppId)); }
            set { BackingStore?.Set(nameof(SaasAppId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudApplicationEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudApplicationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appId", n => { AppId = n.GetLongValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"instanceId", n => { InstanceId = n.GetLongValue(); } },
                {"instanceName", n => { InstanceName = n.GetStringValue(); } },
                {"saasAppId", n => { SaasAppId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteLongValue("instanceId", InstanceId);
            writer.WriteStringValue("instanceName", InstanceName);
            writer.WriteLongValue("saasAppId", SaasAppId);
        }
    }
}
