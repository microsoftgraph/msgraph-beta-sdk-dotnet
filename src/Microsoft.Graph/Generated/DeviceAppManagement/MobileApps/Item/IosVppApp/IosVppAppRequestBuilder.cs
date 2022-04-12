using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.IosVppApp.RevokeAllLicenses;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.IosVppApp.RevokeDeviceLicense;
using Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.IosVppApp.RevokeUserLicense;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.IosVppApp {
    /// <summary>Builds and executes requests for operations under \deviceAppManagement\mobileApps\{mobileApp-id}\microsoft.graph.iosVppApp</summary>
    public class IosVppAppRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The revokeAllLicenses property</summary>
        public RevokeAllLicensesRequestBuilder RevokeAllLicenses { get =>
            new RevokeAllLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revokeDeviceLicense property</summary>
        public RevokeDeviceLicenseRequestBuilder RevokeDeviceLicense { get =>
            new RevokeDeviceLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revokeUserLicense property</summary>
        public RevokeUserLicenseRequestBuilder RevokeUserLicense { get =>
            new RevokeUserLicenseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new IosVppAppRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public IosVppAppRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/microsoft.graph.iosVppApp";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new IosVppAppRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public IosVppAppRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement/mobileApps/{mobileApp%2Did}/microsoft.graph.iosVppApp";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
