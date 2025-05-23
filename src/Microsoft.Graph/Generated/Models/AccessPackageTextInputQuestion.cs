// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AccessPackageTextInputQuestion : global::Microsoft.Graph.Beta.Models.AccessPackageQuestion, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the answer will be in single or multiple line format.</summary>
        public bool? IsSingleLineQuestion
        {
            get { return BackingStore?.Get<bool?>("isSingleLineQuestion"); }
            set { BackingStore?.Set("isSingleLineQuestion", value); }
        }
        /// <summary>The regex pattern that the corresponding text answer must follow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegexPattern
        {
            get { return BackingStore?.Get<string?>("regexPattern"); }
            set { BackingStore?.Set("regexPattern", value); }
        }
#nullable restore
#else
        public string RegexPattern
        {
            get { return BackingStore?.Get<string>("regexPattern"); }
            set { BackingStore?.Set("regexPattern", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageTextInputQuestion"/> and sets the default values.
        /// </summary>
        public AccessPackageTextInputQuestion() : base()
        {
            OdataType = "#microsoft.graph.accessPackageTextInputQuestion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageTextInputQuestion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AccessPackageTextInputQuestion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AccessPackageTextInputQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isSingleLineQuestion", n => { IsSingleLineQuestion = n.GetBoolValue(); } },
                { "regexPattern", n => { RegexPattern = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isSingleLineQuestion", IsSingleLineQuestion);
            writer.WriteStringValue("regexPattern", RegexPattern);
        }
    }
}
#pragma warning restore CS0618
