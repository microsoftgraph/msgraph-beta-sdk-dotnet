using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationPowerSchoolDataProvider : EducationSynchronizationDataProvider, IParsable {
        /// <summary>Indicates whether the source has multiple identifiers for a single student or teacher.</summary>
        public bool? AllowTeachersInMultipleSchools {
            get { return BackingStore?.Get<bool?>(nameof(AllowTeachersInMultipleSchools)); }
            set { BackingStore?.Set(nameof(AllowTeachersInMultipleSchools), value); }
        }
        /// <summary>The client ID used to connect to PowerSchool.</summary>
        public string ClientId {
            get { return BackingStore?.Get<string>(nameof(ClientId)); }
            set { BackingStore?.Set(nameof(ClientId), value); }
        }
        /// <summary>The client secret to authenticate the connection to the PowerSchool instance.</summary>
        public string ClientSecret {
            get { return BackingStore?.Get<string>(nameof(ClientSecret)); }
            set { BackingStore?.Set(nameof(ClientSecret), value); }
        }
        /// <summary>The connection URL to the PowerSchool instance.</summary>
        public string ConnectionUrl {
            get { return BackingStore?.Get<string>(nameof(ConnectionUrl)); }
            set { BackingStore?.Set(nameof(ConnectionUrl), value); }
        }
        /// <summary>Optional customization to be applied to the synchronization profile.</summary>
        public EducationSynchronizationCustomizations Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations>(nameof(Customizations)); }
            set { BackingStore?.Set(nameof(Customizations), value); }
        }
        /// <summary>The list of schools to sync.</summary>
        public List<string> SchoolsIds {
            get { return BackingStore?.Get<List<string>>(nameof(SchoolsIds)); }
            set { BackingStore?.Set(nameof(SchoolsIds), value); }
        }
        /// <summary>The school year to sync.</summary>
        public string SchoolYear {
            get { return BackingStore?.Get<string>(nameof(SchoolYear)); }
            set { BackingStore?.Set(nameof(SchoolYear), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationPowerSchoolDataProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationPowerSchoolDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowTeachersInMultipleSchools", n => { AllowTeachersInMultipleSchools = n.GetBoolValue(); } },
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                {"connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                {"customizations", n => { Customizations = n.GetObjectValue<EducationSynchronizationCustomizations>(EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                {"schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"schoolYear", n => { SchoolYear = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowTeachersInMultipleSchools", AllowTeachersInMultipleSchools);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteStringValue("schoolYear", SchoolYear);
        }
    }
}
