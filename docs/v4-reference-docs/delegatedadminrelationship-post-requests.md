---
title: "Create requests"
description: "Create a new delegatedAdminRelationshipRequest object."
author: "adtangir"
ms.localizationpriority: medium
ms.prod: "customer-relationship-management"
doc_type: apiPageType
---

# Create requests
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [delegatedAdminRelationshipRequest](../resources/delegatedadminrelationshiprequest.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)| DelegatedAdminRelationship.ReadWrite.All |
|Delegated (personal Microsoft account)| Not supported. |
|Application| Not supported. |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationshipId}/requests
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [delegatedAdminRelationshipRequest](../resources/delegatedadminrelationshiprequest.md) object.

You can specify the following properties when creating a **delegatedAdminRelationshipRequest**.

|Property|Type|Description|
|:---|:---|:---|
|action|delegatedAdminRelationshipRequestAction|The action to be performed on the delegated admin relationship. Required. The possible values are: `lockForApproval`, `terminate`.|

## Response

If successful, this method returns a `201 Created` response code and a [delegatedAdminRelationshipRequest](../resources/delegatedadminrelationshiprequest.md) object in the response body. The response contains a **Location** header which contains a URL to the created delegated admin relationship request.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_delegatedadminrelationshiprequest_from_",
  "sampleKeys": ["5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836"]
}
-->
``` http
POST https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships/5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836/requests
Content-Type: application/json

{
  "action": "lockForApproval"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delegatedAdminRelationshipRequest = new DelegatedAdminRelationshipRequestObject
{
	Action = DelegatedAdminRelationshipRequestAction.LockForApproval
};

await graphClient.TenantRelationships.DelegatedAdminRelationships["{delegatedAdminRelationship-id}"].Requests
	.Request()
	.AddAsync(delegatedAdminRelationshipRequest);

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
HTTP/1.1 201 Created
Content-Type: application/json
Location: https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships/c45e5ffb-3de2-4938-a214-b7eed802db66-4be56058-bb48-4a8e-8282-6cf0e98e6c9d/requests/5a6666c9-7282-0a41-67aa-25a5a3fbf339

{
  "@odata.type": "#microsoft.graph.delegatedAdminRelationshipRequest",
  "@odata.context": "https://graph.microsoft.com/beta/tenantRelationships/$metadata#requests",
  "id": "5a6666c9-7282-0a41-67aa-25a5a3fbf339",
  "action": "lockForApproval",
  "status": "created",
  "createdDateTime": "2022-02-10T10:55:47.1180588Z",
  "lastModifiedDateTime": "2022-02-10T10:55:47.1180588Z"
}
```

