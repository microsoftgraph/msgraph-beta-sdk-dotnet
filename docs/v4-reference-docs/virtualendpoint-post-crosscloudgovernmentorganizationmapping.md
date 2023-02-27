---
title: "Create cloudPcCrossCloudGovernmentOrganizationMapping"
description: "Create a new cloudPcCrossCloudGovernmentOrganizationMapping object."
author: "SuyliuMS"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Create cloudPcCrossCloudGovernmentOrganizationMapping
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [cloudPcCrossCloudGovernmentOrganizationMapping](../resources/cloudpccrosscloudgovernmentorganizationmapping.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /deviceManagement/virtualEndpoint/crossCloudGovernmentOrganizationMapping
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|
|X-MS-CloudPC-USGovCloudTenantAADToken|{token}. Required. Represents the Azure AD token of the government cloud tenant.|

## Request body
The request body is an empty JSON string.

## Response

If successful, this method returns a `200 OK` response code and a [cloudPcCrossCloudGovernmentOrganizationMapping](../resources/cloudpccrosscloudgovernmentorganizationmapping.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_cloudpccrosscloudgovernmentorganizationmapping_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/crossCloudGovernmentOrganizationMapping
Content-Type: application/json
X-MS-CloudPC-USGovCloudTenantAADToken: {token}

{}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcCrossCloudGovernmentOrganizationMapping = new CloudPcCrossCloudGovernmentOrganizationMapping
{
};

await graphClient.DeviceManagement.VirtualEndpoint.CrossCloudGovernmentOrganizationMapping
	.Request()
	.Header("X-MS-CloudPC-USGovCloudTenantAADToken","{token}")
	.AddAsync(cloudPcCrossCloudGovernmentOrganizationMapping);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.cloudPcCrossCloudGovernmentOrganizationMapping"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.cloudPcCrossCloudGovernmentOrganizationMapping",
  "id": "7e6e7d5b-8dd5-5078-16cf-d1e488be48a8",
  "organizationIdsInUSGovCloud": [
    "String"
  ]
}
```

