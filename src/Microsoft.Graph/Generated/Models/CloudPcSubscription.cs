using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcSubscription : Entity, IParsable {
        /// <summary>The ID of the subscription.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The name of the subscription.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionName {
            get { return BackingStore?.Get<string?>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#nullable restore
#else
        public string SubscriptionName {
            get { return BackingStore?.Get<string>("subscriptionName"); }
            set { BackingStore?.Set("subscriptionName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcSubscription CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcSubscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"subscriptionName", n => { SubscriptionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("subscriptionName", SubscriptionName);
        }
    }
}
