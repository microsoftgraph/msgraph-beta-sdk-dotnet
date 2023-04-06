using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class IndustryDataRunActivity : Entity, IParsable {
        /// <summary>The flow that was run by this activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataActivity? Activity {
            get { return BackingStore?.Get<IndustryDataActivity?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public IndustryDataActivity Activity {
            get { return BackingStore?.Get<IndustryDataActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>An error object to diagnose critical failures in an activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PublicError? BlockingError {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError?>("blockingError"); }
            set { BackingStore?.Set("blockingError", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PublicError BlockingError {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError>("blockingError"); }
            set { BackingStore?.Set("blockingError", value); }
        }
#endif
        /// <summary>The name of the running flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The status property</summary>
        public IndustryDataActivityStatus? Status {
            get { return BackingStore?.Get<IndustryDataActivityStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IndustryDataRunActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.industryData.inboundFlowActivity" => new InboundFlowActivity(),
                "#microsoft.graph.industryData.outboundFlowActivity" => new OutboundFlowActivity(),
                _ => new IndustryDataRunActivity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<IndustryDataActivity>(IndustryDataActivity.CreateFromDiscriminatorValue); } },
                {"blockingError", n => { BlockingError = n.GetObjectValue<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<IndustryDataActivityStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IndustryDataActivity>("activity", Activity);
            writer.WriteEnumValue<IndustryDataActivityStatus>("status", Status);
        }
    }
}
