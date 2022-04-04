using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MatchingLabel : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The applicationMode property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ApplicationMode? ApplicationMode { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The isEndpointProtectionEnabled property</summary>
        public bool? IsEndpointProtectionEnabled { get; set; }
        /// <summary>The labelActions property</summary>
        public List<LabelActionBase> LabelActions { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The policyTip property</summary>
        public string PolicyTip { get; set; }
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The toolTip property</summary>
        public string ToolTip { get; set; }
        /// <summary>
        /// Instantiates a new matchingLabel and sets the default values.
        /// </summary>
        public MatchingLabel() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MatchingLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MatchingLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationMode", (o,n) => { (o as MatchingLabel).ApplicationMode = n.GetEnumValue<ApplicationMode>(); } },
                {"description", (o,n) => { (o as MatchingLabel).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MatchingLabel).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as MatchingLabel).Id = n.GetStringValue(); } },
                {"isEndpointProtectionEnabled", (o,n) => { (o as MatchingLabel).IsEndpointProtectionEnabled = n.GetBoolValue(); } },
                {"labelActions", (o,n) => { (o as MatchingLabel).LabelActions = n.GetCollectionOfObjectValues<LabelActionBase>(LabelActionBase.CreateFromDiscriminatorValue).ToList(); } },
                {"name", (o,n) => { (o as MatchingLabel).Name = n.GetStringValue(); } },
                {"policyTip", (o,n) => { (o as MatchingLabel).PolicyTip = n.GetStringValue(); } },
                {"priority", (o,n) => { (o as MatchingLabel).Priority = n.GetIntValue(); } },
                {"toolTip", (o,n) => { (o as MatchingLabel).ToolTip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ApplicationMode>("applicationMode", ApplicationMode);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEndpointProtectionEnabled", IsEndpointProtectionEnabled);
            writer.WriteCollectionOfObjectValues<LabelActionBase>("labelActions", LabelActions);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("policyTip", PolicyTip);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("toolTip", ToolTip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
