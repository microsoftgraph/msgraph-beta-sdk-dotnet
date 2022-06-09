using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSExtensionsConfiguration : DeviceConfiguration, IParsable {
        /// <summary>All kernel extensions validly signed by the team identifiers in this list will be allowed to load.</summary>
        public List<string> KernelExtensionAllowedTeamIdentifiers {
            get { return BackingStore?.Get<List<string>>(nameof(KernelExtensionAllowedTeamIdentifiers)); }
            set { BackingStore?.Set(nameof(KernelExtensionAllowedTeamIdentifiers), value); }
        }
        /// <summary>If set to true, users can approve additional kernel extensions not explicitly allowed by configurations profiles.</summary>
        public bool? KernelExtensionOverridesAllowed {
            get { return BackingStore?.Get<bool?>(nameof(KernelExtensionOverridesAllowed)); }
            set { BackingStore?.Set(nameof(KernelExtensionOverridesAllowed), value); }
        }
        /// <summary>A list of kernel extensions that will be allowed to load. . This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSKernelExtension> KernelExtensionsAllowed {
            get { return BackingStore?.Get<List<MacOSKernelExtension>>(nameof(KernelExtensionsAllowed)); }
            set { BackingStore?.Set(nameof(KernelExtensionsAllowed), value); }
        }
        /// <summary>Gets or sets a list of allowed macOS system extensions. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSSystemExtension> SystemExtensionsAllowed {
            get { return BackingStore?.Get<List<MacOSSystemExtension>>(nameof(SystemExtensionsAllowed)); }
            set { BackingStore?.Set(nameof(SystemExtensionsAllowed), value); }
        }
        /// <summary>Gets or sets a list of allowed team identifiers. Any system extension signed with any of the specified team identifiers will be approved.</summary>
        public List<string> SystemExtensionsAllowedTeamIdentifiers {
            get { return BackingStore?.Get<List<string>>(nameof(SystemExtensionsAllowedTeamIdentifiers)); }
            set { BackingStore?.Set(nameof(SystemExtensionsAllowedTeamIdentifiers), value); }
        }
        /// <summary>Gets or sets a list of allowed macOS system extension types. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSSystemExtensionTypeMapping> SystemExtensionsAllowedTypes {
            get { return BackingStore?.Get<List<MacOSSystemExtensionTypeMapping>>(nameof(SystemExtensionsAllowedTypes)); }
            set { BackingStore?.Set(nameof(SystemExtensionsAllowedTypes), value); }
        }
        /// <summary>Gets or sets whether to allow the user to approve additional system extensions not explicitly allowed by configuration profiles.</summary>
        public bool? SystemExtensionsBlockOverride {
            get { return BackingStore?.Get<bool?>(nameof(SystemExtensionsBlockOverride)); }
            set { BackingStore?.Set(nameof(SystemExtensionsBlockOverride), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSExtensionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSExtensionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"kernelExtensionAllowedTeamIdentifiers", n => { KernelExtensionAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"kernelExtensionOverridesAllowed", n => { KernelExtensionOverridesAllowed = n.GetBoolValue(); } },
                {"kernelExtensionsAllowed", n => { KernelExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSKernelExtension>(MacOSKernelExtension.CreateFromDiscriminatorValue).ToList(); } },
                {"systemExtensionsAllowed", n => { SystemExtensionsAllowed = n.GetCollectionOfObjectValues<MacOSSystemExtension>(MacOSSystemExtension.CreateFromDiscriminatorValue).ToList(); } },
                {"systemExtensionsAllowedTeamIdentifiers", n => { SystemExtensionsAllowedTeamIdentifiers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"systemExtensionsAllowedTypes", n => { SystemExtensionsAllowedTypes = n.GetCollectionOfObjectValues<MacOSSystemExtensionTypeMapping>(MacOSSystemExtensionTypeMapping.CreateFromDiscriminatorValue).ToList(); } },
                {"systemExtensionsBlockOverride", n => { SystemExtensionsBlockOverride = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
