using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.WindowsUpdateForBusinessConfiguration.ExtendFeatureUpdatesPause;
using Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.WindowsUpdateForBusinessConfiguration.ExtendQualityUpdatesPause;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceConfigurations.Item.WindowsUpdateForBusinessConfiguration {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceConfigurations\{deviceConfiguration-id}\microsoft.graph.windowsUpdateForBusinessConfiguration</summary>
    public class WindowsUpdateForBusinessConfigurationRequestBuilder {
        /// <summary>The extendFeatureUpdatesPause property</summary>
        public ExtendFeatureUpdatesPauseRequestBuilder ExtendFeatureUpdatesPause { get =>
            new ExtendFeatureUpdatesPauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The extendQualityUpdatesPause property</summary>
        public ExtendQualityUpdatesPauseRequestBuilder ExtendQualityUpdatesPause { get =>
            new ExtendQualityUpdatesPauseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new WindowsUpdateForBusinessConfigurationRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WindowsUpdateForBusinessConfigurationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}/microsoft.graph.windowsUpdateForBusinessConfiguration";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new WindowsUpdateForBusinessConfigurationRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public WindowsUpdateForBusinessConfigurationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}/microsoft.graph.windowsUpdateForBusinessConfiguration";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
