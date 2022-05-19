using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
    public class OnPremisesAgent : Entity, IParsable {
        /// <summary>List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups {
            get { return BackingStore?.Get<List<OnPremisesAgentGroup>>(nameof(AgentGroups)); }
            set { BackingStore?.Set(nameof(AgentGroups), value); }
        }
        /// <summary>The external IP address as detected by the service for the agent machine. Read-only</summary>
        public string ExternalIp {
            get { return BackingStore?.Get<string>(nameof(ExternalIp)); }
            set { BackingStore?.Set(nameof(ExternalIp), value); }
        }
        /// <summary>The name of the machine that the aggent is running on. Read-only</summary>
        public string MachineName {
            get { return BackingStore?.Get<string>(nameof(MachineName)); }
            set { BackingStore?.Set(nameof(MachineName), value); }
        }
        /// <summary>Possible values are: active, inactive.</summary>
        public AgentStatus? Status {
            get { return BackingStore?.Get<AgentStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The supportedPublishingTypes property</summary>
        public List<string> SupportedPublishingTypes {
            get { return BackingStore?.Get<List<string>>(nameof(SupportedPublishingTypes)); }
            set { BackingStore?.Set(nameof(SupportedPublishingTypes), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnPremisesAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>(OnPremisesAgentGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"externalIp", n => { ExternalIp = n.GetStringValue(); } },
                {"machineName", n => { MachineName = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<AgentStatus>(); } },
                {"supportedPublishingTypes", n => { SupportedPublishingTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgentGroup>("agentGroups", AgentGroups);
            writer.WriteStringValue("externalIp", ExternalIp);
            writer.WriteStringValue("machineName", MachineName);
            writer.WriteEnumValue<AgentStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedPublishingTypes", SupportedPublishingTypes);
        }
    }
}
