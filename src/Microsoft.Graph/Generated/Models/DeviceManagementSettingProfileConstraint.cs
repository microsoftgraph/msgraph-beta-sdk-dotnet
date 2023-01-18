using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingProfileConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The source of the entity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Source {
            get { return BackingStore?.Get<string?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#else
        public string Source {
            get { return BackingStore?.Get<string>("source"); }
            set { BackingStore?.Set("source", value); }
        }
#endif
        /// <summary>A collection of types this entity carries</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? Types {
            get { return BackingStore?.Get<List<string>?>("types"); }
            set { BackingStore?.Set("types", value); }
        }
#else
        public List<string> Types {
            get { return BackingStore?.Get<List<string>>("types"); }
            set { BackingStore?.Set("types", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementSettingProfileConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingProfileConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingProfileConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingProfileConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingProfileConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"source", n => { Source = n.GetStringValue(); } },
                {"types", n => { Types = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("source", Source);
            writer.WriteCollectionOfPrimitiveValues<string>("types", Types);
        }
    }
}
