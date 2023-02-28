---
title: "Get cloudPcCrossCloudGovernmentOrganizationMapping"
description: "Read the properties and relationships of a cloudPcCrossCloudGovernmentOrganizationMapping object."
author: "SuyliuMS"
ms.localizationpriority: medium
ms.prod: "cloud-pc"
doc_type: apiPageType
---

# Get cloudPcCrossCloudGovernmentOrganizationMapping
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [cloudPcCrossCloudGovernmentOrganizationMapping](../resources/cloudpccrosscloudgovernmentorganizationmapping.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CloudPC.Read.All, CloudPC.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /deviceManagement/virtualEndpoint/crossCloudGovernmentOrganizationMapping
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|X-MS-CloudPC-USGovCloudTenantAADToken|{token}. Required. Represents the Azure AD token of the government cloud tenant.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [cloudPcCrossCloudGovernmentOrganizationMapping](../resources/cloudpccrosscloudgovernmentorganizationmapping.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_cloudpccrosscloudgovernmentorganizationmapping"
}
-->
``` http
GET https://graph.microsoft.com/beta/deviceManagement/virtualEndpoint/crossCloudGovernmentOrganizationMapping
X-MS-CloudPC-USGovCloudTenantAADToken: {token}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var cloudPcCrossCloudGovernmentOrganizationMapping = await graphClient.DeviceManagement.VirtualEndpoint.CrossCloudGovernmentOrganizationMapping
	.Request()
	.Header("X-MS-CloudPC-USGovCloudTenantAADToken","{token}")
	.GetAsync();

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
  "value": {
    "@odata.type": "#microsoft.graph.cloudPcCrossCloudGovernmentOrganizationMapping",
    "id": "7e6e7d5b-8dd5-5078-16cf-d1e488be48a8",
    "organizationIdsInUSGovCloud": [
      "String"
    ]
  }
}
```

