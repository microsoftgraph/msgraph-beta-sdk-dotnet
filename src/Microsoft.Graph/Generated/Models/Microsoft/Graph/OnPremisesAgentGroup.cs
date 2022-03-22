using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OnPremisesAgentGroup : Entity, IParsable {
        /// <summary>List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
        public List<OnPremisesAgent> Agents { get; set; }
        /// <summary>Display name of the onPremisesAgentGroup.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.</summary>
        public List<PublishedResource> PublishedResources { get; set; }
        /// <summary>Possible values are: applicationProxy, exchangeOnline, authentication, provisioning, adAdministration.</summary>
        public OnPremisesPublishingType? PublishingType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OnPremisesAgentGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAgentGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"agents", (o,n) => { (o as OnPremisesAgentGroup).Agents = n.GetCollectionOfObjectValues<OnPremisesAgent>(OnPremisesAgent.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as OnPremisesAgentGroup).DisplayName = n.GetStringValue(); } },
                {"isDefault", (o,n) => { (o as OnPremisesAgentGroup).IsDefault = n.GetBoolValue(); } },
                {"publishedResources", (o,n) => { (o as OnPremisesAgentGroup).PublishedResources = n.GetCollectionOfObjectValues<PublishedResource>(PublishedResource.CreateFromDiscriminatorValue).ToList(); } },
                {"publishingType", (o,n) => { (o as OnPremisesAgentGroup).PublishingType = n.GetEnumValue<OnPremisesPublishingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnPremisesAgent>("agents", Agents);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteCollectionOfObjectValues<PublishedResource>("publishedResources", PublishedResources);
            writer.WriteEnumValue<OnPremisesPublishingType>("publishingType", PublishingType);
        }
    }
}
