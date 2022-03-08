using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class SideLoadingKey : Entity, IParsable {
        /// <summary>Side Loading Key description displayed to the ITPro Admins..</summary>
        public string Description { get; set; }
        /// <summary>Side Loading Key Name displayed to the ITPro Admins.</summary>
        public string DisplayName { get; set; }
        /// <summary>Side Loading Key Last Updated Date displayed to the ITPro Admins.</summary>
        public string LastUpdatedDateTime { get; set; }
        /// <summary>Side Loading Key Total Activation displayed to the ITPro Admins.</summary>
        public int? TotalActivation { get; set; }
        /// <summary>Side Loading Key Value, it is 5x5 value, seperated by hiphens.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SideLoadingKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SideLoadingKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as SideLoadingKey).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SideLoadingKey).DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as SideLoadingKey).LastUpdatedDateTime = n.GetStringValue(); } },
                {"totalActivation", (o,n) => { (o as SideLoadingKey).TotalActivation = n.GetIntValue(); } },
                {"value", (o,n) => { (o as SideLoadingKey).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("totalActivation", TotalActivation);
            writer.WriteStringValue("value", Value);
        }
    }
}
