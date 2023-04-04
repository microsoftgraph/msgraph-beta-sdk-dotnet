using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EducationCsvDataProvider : EducationSynchronizationDataProvider, IParsable {
        /// <summary>Optional customizations to be applied to the synchronization profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationSynchronizationCustomizations? Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations?>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#nullable restore
#else
        public EducationSynchronizationCustomizations Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new EducationCsvDataProvider and sets the default values.
        /// </summary>
        public EducationCsvDataProvider() : base() {
            OdataType = "#microsoft.graph.educationCsvDataProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationCsvDataProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationCsvDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customizations", n => { Customizations = n.GetObjectValue<EducationSynchronizationCustomizations>(EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationCustomizations>("customizations", Customizations);
        }
    }
}
