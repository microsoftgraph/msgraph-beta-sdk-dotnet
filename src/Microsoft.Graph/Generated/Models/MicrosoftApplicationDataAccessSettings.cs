using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftApplicationDataAccessSettings : Entity, IParsable {
        /// <summary>The disabledForGroup property</summary>
        public string DisabledForGroup { get; set; }
        /// <summary>The isEnabledForAllMicrosoftApplications property</summary>
        public bool? IsEnabledForAllMicrosoftApplications { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftApplicationDataAccessSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftApplicationDataAccessSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"disabledForGroup", (o,n) => { (o as MicrosoftApplicationDataAccessSettings).DisabledForGroup = n.GetStringValue(); } },
                {"isEnabledForAllMicrosoftApplications", (o,n) => { (o as MicrosoftApplicationDataAccessSettings).IsEnabledForAllMicrosoftApplications = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("disabledForGroup", DisabledForGroup);
            writer.WriteBoolValue("isEnabledForAllMicrosoftApplications", IsEnabledForAllMicrosoftApplications);
        }
    }
}
