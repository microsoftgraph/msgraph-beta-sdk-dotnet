using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSExtensionsConfiguration : DeviceConfiguration, IParsable {
        /// <summary>All kernel extensions validly signed by the team identifiers in this list will be allowed to load.</summary>
        public List<string> KernelExtensionAllowedTeamIdentifiers {
            get { return BackingStore?.Get<List<string>>("kernelExtensionAllowedTeamIdentifiers"); }
            set { BackingStore?.Set("kernelExtensionAllowedTeamIdentifiers", value); }
        }
        /// <summary>If set to true, users can approve additional kernel extensions not explicitly allowed by configurations profiles.</summary>
        public bool? KernelExtensionOverridesAllowed {
            get { return BackingStore?.Get<bool?>("kernelExtensionOverridesAllowed"); }
            set { BackingStore?.Set("kernelExtensionOverridesAllowed", value); }
        }
        /// <summary>A list of kernel extensions that will be allowed to load. . This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSKernelExtension> KernelExtensionsAllowed {
            get { return BackingStore?.Get<List<MacOSKernelExtension>>("kernelExtensionsAllowed"); }
            set { BackingStore?.Set("kernelExtensionsAllowed", value); }
        }
        /// <summary>Gets or sets a list of allowed macOS system extensions. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSSystemExtension> SystemExtensionsAllowed {
            get { return BackingStore?.Get<List<MacOSSystemExtension>>("systemExtensionsAllowed"); }
            set { BackingStore?.Set("systemExtensionsAllowed", value); }
        }
        /// <summary>Gets or sets a list of allowed team identifiers. Any system extension signed with any of the specified team identifiers will be approved.</summary>
        public List<string> SystemExtensionsAllowedTeamIdentifiers {
            get { return BackingStore?.Get<List<string>>("systemExtensionsAllowedTeamIdentifiers"); }
            set { BackingStore?.Set("systemExtensionsAllowedTeamIdentifiers", value); }
        }
        /// <summary>Gets or sets a list of allowed macOS system extension types. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSSystemExtensionTypeMapping> SystemExtensionsAllowedTypes {
            get { return BackingStore?.Get<List<MacOSSystemExtensionTypeMapping>>("systemExtensionsAllowedTypes"); }
            set { BackingStore?.Set("systemExtensionsAllowedTypes", value); }
        }
        /// <summary>Gets or sets whether to allow the user to approve additional system extensions not explicitly allowed by configuration profiles.</summary>
        public bool? SystemExtensionsBlockOverride {
            get { return BackingStore?.Get<bool?>("systemExtensionsBlockOverride"); }
            set { BackingStore?.Set("systemExtensionsBlockOverride", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSExtensionsConfiguration and sets the default values.
        /// </summary>
        public MacOSExtensionsConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSExtensionsConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSExtensionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSExtensionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"kernelExtensionAllowedTeamIdentifiers", n => { KernelExtensionAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"kernelExtensionOverridesAllowed", n => { KernelExtensionOverridesAllowed = n.GetBoolValue(); } },
                {"kernelExtensionsAllowed", n => { KernelExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSKernelExtension>(MacOSKernelExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsAllowed", n => { SystemExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSSystemExtension>(MacOSSystemExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsAllowedTeamIdentifiers", n => { SystemExtensionsAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"systemExtensionsAllowedTypes", n => { SystemExtensionsAllowedTypes = n.GetCollectionOfObjectValues<MacOSSystemExtensionTypeMapping>(MacOSSystemExtensionTypeMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"systemExtensionsBlockOverride", n => { SystemExtensionsBlockOverride = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("kernelExtensionAllowedTeamIdentifiers", KernelExtensionAllowedTeamIdentifiers);
            writer.WriteBoolValue("kernelExtensionOverridesAllowed", KernelExtensionOverridesAllowed);
            writer.WriteCollectionOfObjectValues<MacOSKernelExtension>("kernelExtensionsAllowed", KernelExtensionsAllowed);
            writer.WriteCollectionOfObjectValues<MacOSSystemExtension>("systemExtensionsAllowed", SystemExtensionsAllowed);
            writer.WriteCollectionOfPrimitiveValues<string>("systemExtensionsAllowedTeamIdentifiers", SystemExtensionsAllowedTeamIdentifiers);
            writer.WriteCollectionOfObjectValues<MacOSSystemExtensionTypeMapping>("systemExtensionsAllowedTypes", SystemExtensionsAllowedTypes);
            writer.WriteBoolValue("systemExtensionsBlockOverride", SystemExtensionsBlockOverride);
        }
    }
}
