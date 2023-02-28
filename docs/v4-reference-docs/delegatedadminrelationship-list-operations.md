---
title: "List operations"
description: "Get a list of the delegatedAdminRelationshipOperation objects and their properties."
author: "adtangir"
ms.localizationpriority: medium
ms.prod: "customer-relationship-management"
doc_type: apiPageType
---

# List operations
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [delegatedAdminRelationshipOperation](../resources/delegatedadminrelationshipoperation.md) objects and their properties.

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
GET /tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationshipId}/operations
```

## Optional query parameters
This method supports the `$expand`, `$select`, `$filter`, `$top`, `$count`, and `$skipToken`  [OData query parameters](/graph/query-parameters) to help customize the response.

`$top` supports up to 300 objects.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [delegatedAdminRelationshipOperation](../resources/delegatedadminrelationshipoperation.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_delegatedadminrelationshipoperation",
  "sampleKeys": ["5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836"]
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships/5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836/operations
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var operations = await graphClient.TenantRelationships.DelegatedAdminRelationships["{delegatedAdminRelationship-id}"].Operations
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
  "@odata.type": "Collection(microsoft.graph.delegatedAdminRelationshipOperation)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/tenantRelationships/$metadata#operations",
  "value": [
    {
      "@odata.type": "#microsoft.graph.delegatedAdminRelationshipOperation",
      "@odata.etag": "W/\"JyIwMzAwZTM0ZS0wMDAwLTAyMDAtMDAwMC02MTRjZjI1YzAwMDAiJw==\"",
      "id": "e7de9158-df46-478e-820c-d6eff099d27b",
      "operationType": "delegatedAdminAccessAssignmentUpdate",
      "data": "{\"id\":\"a97a9b4c-f43e-4c47-bbd6-50d8d3c88d94\",\"accessContainer\":{\"accessContainerId\":\"11cc3849-c298-455f-9a11-b7be350ef352\",\"accessContainerType\":\"securityGroup\"},\"accessDetails\":{\"unifiedRoles\":[{\"roleDefinitionId\":\"f2ef992c-3afb-46b9-b7cf-a126ee74c451\"},{\"roleDefinitionId\":\"62e90394-69f5-4237-9190-012177145e10\"}]},\"status\":\"active\"}",
      "status": "succeeded",
      "createdDateTime": "2022-02-09T22:17:43.9821847Z",
      "lastModifiedDateTime": "2022-02-09T22:17:43.9821847Z"
    },
    {
      "@odata.type": "#microsoft.graph.delegatedAdminRelationshipOperation",
      "@odata.etag": "W/\"JyIwMzAwZTM0ZS0wMKMh5TAyMDAtMDAwMC02MTRjZjI1YzAwMDAiJw==\"",
      "id": "f7a7dad4-8cc4-40d7-be44-dd3501b1f4e0",
      "operationType": "delegatedAdminAccessAssignmentUpdate",
      "data": "{\"id\":\"a97a9b4c-f43e-4c47-bbd6-50d8d3c88d94\",\"accessContainer\":{\"accessContainerId\":\"8d56bce3-440f-4b4f-b5c2-cc0bcbd0199c\",\"accessContainerType\":\"securityGroup\"},\"accessDetails\":{\"unifiedRoles\":[{\"roleDefinitionId\":\"29232cdf-9323-42fd-ade2-1d097af3e4de\"},{\"roleDefinitionId\":\"88d8e3e3-8f55-4a1e-953a-9b9898b8876b\"}]},\"status\":\"active\"}",
      "status": "succeeded",
      "createdDateTime": "2022-02-11T20:32:05.4659288Z",
      "lastModifiedDateTime": "2022-02-11T20:34:42.9202474Z"
    }
  ]
}
```

