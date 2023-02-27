---
title: "tenantRelationship: findTenantInformationByTenantId"
description: "Given a tenant ID, search for a tenant and read its tenantInformation."
author: "adimitui"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# tenantRelationship: findTenantInformationByTenantId

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Given a tenant ID, search for a tenant and read its [tenantInformation](../resources/tenantInformation.md). You can use this API to validate tenant information and use their **tenantId** to [configure cross-tenant cross-tenant access settings between you and the tenant](../resources/crosstenantaccesspolicyconfigurationpartner.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|CrossTenantInformation.ReadBasic.All|
|Delegated (personal Microsoft account)|None|
|Application|CrossTenantInformation.ReadBasic.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/findTenantInformationByTenantId(tenantId='{id}')
```

## Function parameters

In the request URL, provide the following query parameters with values. The following table shows the parameters that must be used with this function.

|Parameter|Type|Description|
|:---|:---|:---|
| tenantId | String | Unique tenant identifier of an Azure AD tenant. |

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [tenantInformation](../resources/tenantinformation.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "tenantrelationshiprootthis.findtenantinformationbytenantid"
}
-->

``` http
GET https://graph.microsoft.com/beta/tenantRelationships/findTenantInformationByTenantId(tenantId='6babcaad-604b-40ac-a9d7-9fd97c0b779f')
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantInformation = await graphClient.TenantRelationships
	.FindTenantInformationByTenantId("6babcaad-604b-40ac-a9d7-9fd97c0b779f")
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.tenantInformation"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.tenantInformation",
    "tenantId": "6babcaad-604b-40ac-a9d7-9fd97c0b779f",
    "federationBrandName": null,
    "displayName": "Contoso, Ltd",
    "defaultDomainName": "CONTOSO18839.onmicrosoft.com"
}
```
