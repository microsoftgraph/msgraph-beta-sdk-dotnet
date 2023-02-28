---
title: "Create addresses"
description: "Create a new addresses object."
ms.localizationpriority: medium
author: "kevinbellinger"
ms.prod: "people"
doc_type: apiPageType
---

# Create addresses
Namespace: microsoft.graph

Create a new [itemAddress](../resources/itemaddress.md) object in a user's [profile](../resources/profile.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged)                                      |
|:---------------------------------------|:---------------------------------------------------------------------------------|
| Delegated (work or school account)     | User.ReadWrite, User.ReadWrite.All |
| Delegated (personal Microsoft account) | User.ReadWrite, User.ReadWrite.All |
| Application                            | User.ReadWrite.All                            |
## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /me/profile/addresses
POST /users/{id | userPrincipalName}/profile/addresses
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [itemAddress](../resources/itemaddress.md) object.

The following table shows the properties that are possible to set when creating a new [itemAddress](../resources/itemaddress.md) object in a user's [profile](../resources/profile.md).

|Property|Type|Description|
|:---|:---|:---|
|allowedAudiences|String|The audiences that are able to see the values contained within the entity. Inherited from [itemFacet](../resources/itemfacet.md). Possible values are: `me`, `family`, `contacts`, `groupMembers`, `organization`, `federatedOrganizations`, `everyone`, `unknownFutureValue`.|
|detail|[physicalAddress](../resources/physicaladdress.md)|Details about the address itself.|
|displayName|String|Friendly name the user has assigned to this address. |
|geoCoordinates|[geoCoordinates](../resources/geocoordinates.md)|The geocoordinates of the address.|
|inference|[inferenceData](../resources/inferencedata.md)|Contains inference detail if the entity is inferred by the creating or modifying application. Inherited from [itemFacet](../resources/itemfacet.md).|
|source|[personDataSource](../resources/persondatasource.md)|Where the values originated if synced from another service. Inherited from [itemFacet](../resources/itemfacet.md).|
## Response

If successful, this method returns a `201 Created` response code and an [itemAddress](../resources/itemaddress.md) object in the response body.

## Examples

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_itemaddress_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/me/profile/addresses
Content-Type: application/json

{
  "displayName": "Home",
  "detail": {
    "type": "home",
    "postOfficeBox": null,
    "street": "221B Baker Street",
    "city": "London",
    "state": null,
    "countryOrRegion": "United Kingdom",
    "postalCode": "E14 3TD"
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var itemAddress = new ItemAddress
{
	DisplayName = "Home",
	Detail = new PhysicalAddress
	{
		Type = PhysicalAddressType.Home,
		PostOfficeBox = null,
		Street = "221B Baker Street",
		City = "London",
		State = null,
		CountryOrRegion = "United Kingdom",
		PostalCode = "E14 3TD"
	}
};

await graphClient.Me.Profile.Addresses
	.Request()
	.AddAsync(itemAddress);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.itemAddress"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": "0fb4c1e3-c1e3-0fb4-e3c1-b40fe3c1b40f",
  "allowedAudiences": "organization",
  "inference": null,
  "createdDateTime": "2020-07-06T06:34:12.2294868Z",
  "createdBy": {
    "application": null,
    "device": null,
    "user": {
      "displayName": "Innocenty Popov",
      "id": "db789417-4ccb-41d1-a0a9-47b01a09ea49"
    }
  },
  "lastModifiedDateTime": "2020-07-06T06:34:12.2294868Z",
  "lastModifiedBy": {
    "application": null,
    "device": null,
    "user": {
      "displayName": "Innocenty Popov",
      "id": "db789417-4ccb-41d1-a0a9-47b01a09ea49"
    }
  },
  "source": null,
  "displayName": "Home",
  "detail": {
    "type": "home",
    "postOfficeBox": null,
    "street": "221B Baker Street",
    "city": "London",
    "state": null,
    "countryOrRegion": "United Kingdom",
    "postalCode": "E14 3TD"
  },
  "geoCoordinates": null
}
```


