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
    public partial class EducationIdentityCreationConfiguration : global::Microsoft.Graph.Beta.Models.EducationIdentitySynchronizationConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The userDomains property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain>? UserDomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain>?>("userDomains"); }
            set { BackingStore?.Set("userDomains", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain> UserDomains
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain>>("userDomains"); }
            set { BackingStore?.Set("userDomains", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EducationIdentityCreationConfiguration"/> and sets the default values.
        /// </summary>
        public EducationIdentityCreationConfiguration() : base()
        {
            OdataType = "#microsoft.graph.educationIdentityCreationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EducationIdentityCreationConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EducationIdentityCreationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EducationIdentityCreationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "userDomains", n => { UserDomains = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain>(global::Microsoft.Graph.Beta.Models.EducationIdentityDomain.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.EducationIdentityDomain>("userDomains", UserDomains);
        }
    }
}
#pragma warning restore CS0618
