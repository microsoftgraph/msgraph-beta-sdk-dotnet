// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Groups.Item.GetPasswordSingleSignOnCredentials {
    [Obsolete("This class is obsolete. Use GetPasswordSingleSignOnCredentialsPostResponse instead.")]
    public class GetPasswordSingleSignOnCredentialsResponse : GetPasswordSingleSignOnCredentialsPostResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetPasswordSingleSignOnCredentialsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetPasswordSingleSignOnCredentialsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetPasswordSingleSignOnCredentialsResponse();
        }
    }
}
