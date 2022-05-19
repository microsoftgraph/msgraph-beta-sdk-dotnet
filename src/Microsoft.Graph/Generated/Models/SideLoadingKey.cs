using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>SideLoadingKey entity is required for Windows 8 and 8.1 devices to intall Line Of Business Apps for a tenant.</summary>
    public class SideLoadingKey : Entity, IParsable {
        /// <summary>Side Loading Key description displayed to the ITPro Admins..</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Side Loading Key Name displayed to the ITPro Admins.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Side Loading Key Last Updated Date displayed to the ITPro Admins.</summary>
        public string LastUpdatedDateTime {
            get { return BackingStore?.Get<string>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>Side Loading Key Total Activation displayed to the ITPro Admins.</summary>
        public int? TotalActivation {
            get { return BackingStore?.Get<int?>(nameof(TotalActivation)); }
            set { BackingStore?.Set(nameof(TotalActivation), value); }
        }
        /// <summary>Side Loading Key Value, it is 5x5 value, seperated by hiphens.</summary>
        public string Value {
            get { return BackingStore?.Get<string>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetStringValue(); } },
                {"totalActivation", n => { TotalActivation = n.GetIntValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
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
