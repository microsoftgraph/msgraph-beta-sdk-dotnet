using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Represents an ADMX listBox element and an ADMX list element.
    /// </summary>
    public class GroupPolicyPresentationListBox : GroupPolicyUploadedPresentation, IParsable {
        /// <summary>If this option is specified true the user must specify the registry subkey value and the registry subkey name. The list box shows two columns, one for the name and one for the data. The default value is false.</summary>
        public bool? ExplicitValue {
            get { return BackingStore?.Get<bool?>("explicitValue"); }
            set { BackingStore?.Set("explicitValue", value); }
        }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValuePrefix {
            get { return BackingStore?.Get<string?>("valuePrefix"); }
            set { BackingStore?.Set("valuePrefix", value); }
        }
#nullable restore
#else
        public string ValuePrefix {
            get { return BackingStore?.Get<string>("valuePrefix"); }
            set { BackingStore?.Set("valuePrefix", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new groupPolicyPresentationListBox and sets the default values.
        /// </summary>
        public GroupPolicyPresentationListBox() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentationListBox";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationListBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationListBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"explicitValue", n => { ExplicitValue = n.GetBoolValue(); } },
                {"valuePrefix", n => { ValuePrefix = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("explicitValue", ExplicitValue);
            writer.WriteStringValue("valuePrefix", ValuePrefix);
        }
    }
}
