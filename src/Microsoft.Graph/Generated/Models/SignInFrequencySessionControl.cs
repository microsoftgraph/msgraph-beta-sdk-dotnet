using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SignInFrequencySessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>The possible values are primaryAndSecondaryAuthentication, secondaryAuthentication, unknownFutureValue.</summary>
        public SignInFrequencyAuthenticationType? AuthenticationType {
            get { return BackingStore?.Get<SignInFrequencyAuthenticationType?>("authenticationType"); }
            set { BackingStore?.Set("authenticationType", value); }
        }
        /// <summary>The possible values are timeBased, everyTime, unknownFutureValue.</summary>
        public SignInFrequencyInterval? FrequencyInterval {
            get { return BackingStore?.Get<SignInFrequencyInterval?>("frequencyInterval"); }
            set { BackingStore?.Set("frequencyInterval", value); }
        }
        /// <summary>The number of days or hours.</summary>
        public int? Value {
            get { return BackingStore?.Get<int?>("value"); }
            set { BackingStore?.Set("value", value); }
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
            writer.WriteIntValue("value", Value);
        }
    }
}
