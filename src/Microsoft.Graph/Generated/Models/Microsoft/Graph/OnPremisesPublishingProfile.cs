using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class OnPremisesPublishingProfile : Entity, IParsable {
        /// <summary>List of existing onPremisesAgentGroup objects. Read-only. Nullable.</summary>
        public List<OnPremisesAgentGroup> AgentGroups { get; set; }
        /// <summary>List of existing onPremisesAgent objects. Read-only. Nullable.</summary>
        public List<OnPremisesAgent> Agents { get; set; }
        /// <summary>List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.ConnectorGroup> ConnectorGroups { get; set; }
        /// <summary>List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.</summary>
        public List<Connector> Connectors { get; set; }
        /// <summary>Represents a hybridAgentUpdaterConfiguration object.</summary>
        public HybridAgentUpdaterConfiguration HybridAgentUpdaterConfiguration { get; set; }
        /// <summary>Represents if Azure AD Application Proxy is enabled for the tenant.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>List of existing publishedResource objects. Read-only. Nullable.</summary>
        public List<PublishedResource> PublishedResources { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agentGroups", (o,n) => { (o as OnPremisesPublishingProfile).AgentGroups = n.GetCollectionOfObjectValues<OnPremisesAgentGroup>().ToList(); } },
                {"agents", (o,n) => { (o as OnPremisesPublishingProfile).Agents = n.GetCollectionOfObjectValues<OnPremisesAgent>().ToList(); } },
                {"connectorGroups", (o,n) => { (o as OnPremisesPublishingProfile).ConnectorGroups = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ConnectorGroup>().ToList(); } },
                {"connectors", (o,n) => { (o as OnPremisesPublishingProfile).Connectors = n.GetCollectionOfObjectValues<Connector>().ToList(); } },
                {"hybridAgentUpdaterConfiguration", (o,n) => { (o as OnPremisesPublishingProfile).HybridAgentUpdaterConfiguration = n.GetObjectValue<HybridAgentUpdaterConfiguration>(); } },
                {"isEnabled", (o,n) => { (o as OnPremisesPublishingProfile).IsEnabled = n.GetBoolValue(); } },
                {"publishedResources", (o,n) => { (o as OnPremisesPublishingProfile).PublishedResources = n.GetCollectionOfObjectValues<PublishedResource>().ToList(); } },
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
            writer.WriteCollectionOfObjectValues<OnPremisesAgent>("agents", Agents);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ConnectorGroup>("connectorGroups", ConnectorGroups);
            writer.WriteCollectionOfObjectValues<Connector>("connectors", Connectors);
            writer.WriteObjectValue<HybridAgentUpdaterConfiguration>("hybridAgentUpdaterConfiguration", HybridAgentUpdaterConfiguration);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<PublishedResource>("publishedResources", PublishedResources);
        }
    }
}
