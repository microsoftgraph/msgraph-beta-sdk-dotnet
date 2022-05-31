using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class SignInFrequencySessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>The authenticationType property</summary>
        public SignInFrequencyAuthenticationType? AuthenticationType {
            get { return BackingStore?.Get<SignInFrequencyAuthenticationType?>(nameof(AuthenticationType)); }
            set { BackingStore?.Set(nameof(AuthenticationType), value); }
        }
        /// <summary>The frequencyInterval property</summary>
        public SignInFrequencyInterval? FrequencyInterval {
            get { return BackingStore?.Get<SignInFrequencyInterval?>(nameof(FrequencyInterval)); }
            set { BackingStore?.Set(nameof(FrequencyInterval), value); }
        }
        /// <summary>Possible values are: days, hours.</summary>
        public SigninFrequencyType? Type {
            get { return BackingStore?.Get<SigninFrequencyType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The number of days or hours.</summary>
        public int? Value {
            get { return BackingStore?.Get<int?>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SignInFrequencySessionControl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignInFrequencySessionControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationType", n => { AuthenticationType = n.GetEnumValue<SignInFrequencyAuthenticationType>(); } },
                {"frequencyInterval", n => { FrequencyInterval = n.GetEnumValue<SignInFrequencyInterval>(); } },
                {"type", n => { Type = n.GetEnumValue<SigninFrequencyType>(); } },
                {"value", n => { Value = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SignInFrequencyAuthenticationType>("authenticationType", AuthenticationType);
            writer.WriteEnumValue<SignInFrequencyInterval>("frequencyInterval", FrequencyInterval);
            writer.WriteEnumValue<SigninFrequencyType>("type", Type);
            writer.WriteIntValue("value", Value);
        }
    }
}
