using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class ParticipantEndpoint : Endpoint, IParsable {
        /// <summary>CPU number of cores used by the media endpoint.</summary>
        public int? CpuCoresCount {
            get { return BackingStore?.Get<int?>("cpuCoresCount"); }
            set { BackingStore?.Set("cpuCoresCount", value); }
        }
        /// <summary>CPU name used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CpuName {
            get { return BackingStore?.Get<string?>("cpuName"); }
            set { BackingStore?.Set("cpuName", value); }
        }
#nullable restore
#else
        public string CpuName {
            get { return BackingStore?.Get<string>("cpuName"); }
            set { BackingStore?.Set("cpuName", value); }
        }
#endif
        /// <summary>CPU processor speed used by the media endpoint.</summary>
        public int? CpuProcessorSpeedInMhz {
            get { return BackingStore?.Get<int?>("cpuProcessorSpeedInMhz"); }
            set { BackingStore?.Set("cpuProcessorSpeedInMhz", value); }
        }
        /// <summary>The feedback provided by the user of this endpoint about the quality of the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserFeedback? Feedback {
            get { return BackingStore?.Get<UserFeedback?>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#nullable restore
#else
        public UserFeedback Feedback {
            get { return BackingStore?.Get<UserFeedback>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#endif
        /// <summary>Identity associated with the endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentitySet? Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentitySet Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>Name of the device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ParticipantEndpoint and sets the default values.
        /// </summary>
        public ParticipantEndpoint() : base() {
            OdataType = "#microsoft.graph.callRecords.participantEndpoint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ParticipantEndpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cpuCoresCount", n => { CpuCoresCount = n.GetIntValue(); } },
                {"cpuName", n => { CpuName = n.GetStringValue(); } },
                {"cpuProcessorSpeedInMhz", n => { CpuProcessorSpeedInMhz = n.GetIntValue(); } },
                {"feedback", n => { Feedback = n.GetObjectValue<UserFeedback>(UserFeedback.CreateFromDiscriminatorValue); } },
                {"identity", n => { Identity = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("cpuCoresCount", CpuCoresCount);
            writer.WriteStringValue("cpuName", CpuName);
            writer.WriteIntValue("cpuProcessorSpeedInMhz", CpuProcessorSpeedInMhz);
            writer.WriteObjectValue<UserFeedback>("feedback", Feedback);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("identity", Identity);
            writer.WriteStringValue("name", Name);
        }
    }
}
