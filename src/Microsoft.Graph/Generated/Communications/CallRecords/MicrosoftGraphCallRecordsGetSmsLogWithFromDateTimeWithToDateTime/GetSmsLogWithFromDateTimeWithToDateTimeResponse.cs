// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Communications.CallRecords.MicrosoftGraphCallRecordsGetSmsLogWithFromDateTimeWithToDateTime {
    [Obsolete("This class is obsolete. Use GetSmsLogWithFromDateTimeWithToDateTimeGetResponse instead.")]
    public class GetSmsLogWithFromDateTimeWithToDateTimeResponse : GetSmsLogWithFromDateTimeWithToDateTimeGetResponse, IParsable 
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GetSmsLogWithFromDateTimeWithToDateTimeResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetSmsLogWithFromDateTimeWithToDateTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSmsLogWithFromDateTimeWithToDateTimeResponse();
        }
    }
}
