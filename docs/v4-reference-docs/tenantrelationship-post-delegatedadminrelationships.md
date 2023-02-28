---
title: "Create delegatedAdminRelationship"
description: "Create a new delegatedAdminRelationship object."
author: "adtangir"
ms.localizationpriority: medium
ms.prod: "customer-relationship-management"
doc_type: apiPageType
---

# Create delegatedAdminRelationship
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [delegatedAdminRelationship](../resources/delegatedadminrelationship.md) object.

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
POST /tenantRelationships/delegatedAdminRelationships
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [delegatedAdminRelationship](../resources/delegatedadminrelationship.md) object.

You can specify the following properties when creating a **delegatedAdminRelationship**.

|Property|Type|Description|
|:---|:---|:---|
|accessDetails|[microsoft.graph.delegatedAdminAccessDetails](../resources/delegatedadminaccessdetails.md)|The identifiers of the administrative roles that the partner requests or has access to in the customer tenant. Required.|
|customer|[microsoft.graph.delegatedAdminRelationshipCustomerParticipant](../resources/delegatedadminrelationshipcustomerparticipant.md)|The display name and unique identifier of the customer of the relationship. Optional.|
|displayName|String|The display name of the relationship used for ease of identification. Must be unique across *all* delegated admin relationships of the partner. Required.|
|duration|Duration|The duration of the relationship in ISO 8601 format. Must be a value between `P1D` and `P2Y` inclusive. Required.|

## Response

If successful, this method returns a `201 Created` response code and a [delegatedAdminRelationship](../resources/delegatedadminrelationship.md) object in the response body.

The response contains a **Location** header which contains a URL to the created delegated admin relationship. Each **delegatedAdminRelationship** object contains an **@odata.etag** property as per RFC2616.
## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_delegatedadminrelationship_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships
Content-Type: application/json

{
  "displayName": "Contoso admin relationship",
  "duration": "P730D",
  "customer": {
    "tenantId": "4b827261-d21f-4aa9-b7db-7fa1f56fb163",
    "displayName": "Contoso subsidiary Inc"
  },
  "accessDetails": {
    "unifiedRoles": [
      {
        "roleDefinitionId": "29232cdf-9323-42fd-ade2-1d097af3e4de"
      },
      {
        "roleDefinitionId": "3a2c62db-5318-420d-8d74-23affee5d9d5"
      }
    ]
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var delegatedAdminRelationship = new DelegatedAdminRelationship
{
	DisplayName = "Contoso admin relationship",
	Duration = new Duration("P730D"),
	Customer = new DelegatedAdminRelationshipCustomerParticipant
	{
		TenantId = "4b827261-d21f-4aa9-b7db-7fa1f56fb163",
		DisplayName = "Contoso subsidiary Inc"
	},
	AccessDetails = new DelegatedAdminAccessDetails
	{
		UnifiedRoles = new List<UnifiedRole>()
		{
			new UnifiedRole
			{
				RoleDefinitionId = "29232cdf-9323-42fd-ade2-1d097af3e4de"
			},
			new UnifiedRole
			{
				RoleDefinitionId = "3a2c62db-5318-420d-8d74-23affee5d9d5"
			}
		}
	}
};

await graphClient.TenantRelationships.DelegatedAdminRelationships
	.Request()
	.AddAsync(delegatedAdminRelationship);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.delegatedAdminRelationship"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json
Location: https://graph.microsoft.com/beta/tenantRelationships/delegatedAdminRelationships/5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836

{
  "@odata.type": "#microsoft.graph.delegatedAdminRelationship",
  "@odata.context": "https://graph.microsoft.com/beta/tenantRelationships/$metadata#delegatedAdminRelationships",
  "@odata.etag": "W/\"JyIxODAwZTY4My0wMDAwLTAyMDAtMDAwMC02MTU0OWFmMDAwMDAiJw==\"",
  "id": "5d027261-d21f-4aa9-b7db-7fa1f56fb163-8777b240-c6f0-4469-9e98-a3205431b836",
  "displayName": "Contoso admin relationship",
  "duration": "P730D",
  "customer": {
    "tenantId": "4b827261-d21f-4aa9-b7db-7fa1f56fb163",
    "displayName": "Contoso subsidiary Inc"
  },
  "accessDetails": {
    "unifiedRoles": [
      {
        "roleDefinitionId": "29232cdf-9323-42fd-ade2-1d097af3e4de"
      },
      {
        "roleDefinitionId": "3a2c62db-5318-420d-8d74-23affee5d9d5"
      }
    ]
  },
  "status": "created",
  "createdDateTime": "2022-02-10T11:24:42.3148266Z",
  "lastModifiedDateTime": "2022-02-10T11:24:42.3148266Z",
  "activatedDateTime": "",
  "endDateTime": "2024-02-10T11:24:42.3148266Z"
}
```

