---
title: "Get delegatedAdminRelationshipRequest"
description: "Read the properties and relationships of a delegatedAdminRelationshipRequest object."
author: "adtangir"
ms.localizationpriority: medium
ms.prod: "customer-relationship-management"
doc_type: apiPageType
---

# Get delegatedAdminRelationshipRequest
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [delegatedAdminRelationshipRequest](../resources/delegatedadminrelationshiprequest.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)| DelegatedAdminRelationship.Read.All, DelegatedAdminRelationship.ReadWrite.All |
|Delegated (personal Microsoft account)| Not supported. |
|Application| Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationshipId}/requests/{delegatedAdminRelationshipRequestId}
```

## Optional query parameters
This method supports the `$select` OData query parameter to retrieve specific user properties, including those that are not returned by default.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [delegatedAdminRelationshipRequest](../resources/delegatedadminrelationshiprequest.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_delegatedadminrelationshiprequest",
  "sampleKeys": ["5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836", "cf4a23c7-070c-4d1c-8be8-1e86085ac9d1"]
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships/5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836/requests/cf4a23c7-070c-4d1c-8be8-1e86085ac9d1
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delegatedAdminRelationshipRequest = await graphClient.TenantRelationships.DelegatedAdminRelationships["{delegatedAdminRelationship-id}"].Requests["{delegatedAdminRelationshipRequest-id}"]
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
  "@odata.type": "microsoft.graph.delegatedAdminRelationshipRequest"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.delegatedAdminRelationshipRequest",
  "@odata.context": "https://graph.microsoft.com/beta/tenantRelationships/$metadata#requests/$entity",
  "@odata.etag": "W/\"JyIxODAwZTY4My0wMDAwLTAyMDAtMDAwMC02MTU0OWFmMDAwMDAiJw==\"",
  "id": "cf4a23c7-070c-4d1c-8be8-1e86085ac9d1",
  "action": "lockForApproval",
  "status": "created",
  "createdDateTime": "2022-02-10T10:55:47.1180588Z",
  "lastModifiedDateTime": "2022-02-10T11:26:44.9941884Z"
}
```

