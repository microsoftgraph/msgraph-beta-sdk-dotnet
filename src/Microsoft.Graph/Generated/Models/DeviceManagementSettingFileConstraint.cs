using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Constraint enforcing the file extension is acceptable for a given setting
    /// </summary>
    public class DeviceManagementSettingFileConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>Acceptable file extensions to upload for this setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedExtensions {
            get { return BackingStore?.Get<List<string>?>("supportedExtensions"); }
            set { BackingStore?.Set("supportedExtensions", value); }
        }
#nullable restore
#else
        public List<string> SupportedExtensions {
            get { return BackingStore?.Get<List<string>>("supportedExtensions"); }
            set { BackingStore?.Set("supportedExtensions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementSettingFileConstraint and sets the default values.
        /// </summary>
        public DeviceManagementSettingFileConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementSettingFileConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementSettingFileConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingFileConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"supportedExtensions", n => { SupportedExtensions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedExtensions", SupportedExtensions);
        }
    }
}
