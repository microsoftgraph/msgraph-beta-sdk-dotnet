---
title: "Create connectedOrganization"
description: "Create a new connectedOrganization."
author: "markwahl-msft"
ms.localizationpriority: medium
ms.prod: "governance"
doc_type: apiPageType
---

# Create connectedOrganization

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [connectedOrganization](../resources/connectedorganization.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
| Delegated (work or school account)     | EntitlementManagement.ReadWrite.All |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | EntitlementManagement.ReadWrite.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
```http
POST /identityGovernance/entitlementManagement/connectedOrganizations
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [connectedOrganization](../resources/connectedorganization.md) object.

The following table shows the properties that are required when you create the [connectedOrganization](../resources/connectedorganization.md).

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|The connected organization name. |
|description|String|The connected organization description.|
|identitySources|[identitySource](../resources/identitysource.md) collection|A collection with one element, the initial identity source in this connected organization.|
|state|connectedOrganizationState|The state of a connected organization defines whether assignment policies with requestor scope type `AllConfiguredConnectedOrganizationSubjects` are applicable or not. Possible values are: `configured`, `proposed`.|

The single member of the identitySources collection should be of either the [domainIdentitySource](../resources/domainidentitysource.md) or [externalDomainFederation](../resources/externaldomainfederation.md) type.  If the caller provides a domainIdentitySource, the call is successful, and the domain corresponds to a registered domain of an Azure Active Directory tenant, then the resulting connectedOrganization that is created will have an identitySources collection containing a single member of the [azureActiveDirectoryTenant](../resources/azureactivedirectorytenant.md) type.

## Response

If successful, this method returns a `201 Created` response code and a new [connectedOrganization](../resources/connectedorganization.md) object in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_connectedorganization_from_connectedorganizations"
}
-->
``` http
POST https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/connectedOrganizations/
Content-Type: application/json

{
  "displayName":"Connected organization name",
  "description":"Connected organization description",
  "identitySources": [
    {
      "@odata.type": "#microsoft.graph.domainIdentitySource",
      "domainName": "example.com",
      "displayName": "example.com"
      }
  ],
  "state":"proposed"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var connectedOrganization = new ConnectedOrganization
{
	DisplayName = "Connected organization name",
	Description = "Connected organization description",
	IdentitySources = new List<IdentitySource>()
	{
		new DomainIdentitySource
		{
			DomainName = "example.com",
			DisplayName = "example.com"
		}
	},
	State = ConnectedOrganizationState.Proposed
};

await graphClient.IdentityGovernance.EntitlementManagement.ConnectedOrganizations
	.Request()
	.AddAsync(connectedOrganization);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.connectedOrganization"
}
-->
``` http
HTTP/1.1 201 Created
Content-type: application/json

{
  "id": "006111db-0810-4494-a6df-904d368bd81b",
  "displayName":"Connected organization name",
  "description":"Connected organization description",
  "createdBy": "admin@contoso.com",
  "createdDateTime": "2020-06-08T20:13:53.7099947Z",
  "modifiedBy": "admin@contoso.com",
  "modifiedDateTime": "2020-06-08T20:13:53.7099947Z",
  "state":"proposed"
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create connectedOrganization",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


