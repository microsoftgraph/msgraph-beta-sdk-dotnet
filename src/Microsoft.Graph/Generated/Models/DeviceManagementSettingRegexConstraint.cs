using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingRegexConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The RegEx pattern to match against</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Regex {
            get { return BackingStore?.Get<string?>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#nullable restore
#else
        public string Regex {
            get { return BackingStore?.Get<string>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementSettingRegexConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingRegexConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingRegexConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingRegexConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingRegexConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"regex", n => { Regex = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("regex", Regex);
        }
    }
}
