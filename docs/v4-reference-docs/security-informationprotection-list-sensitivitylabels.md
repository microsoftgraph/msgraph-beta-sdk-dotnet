---
title: "List sensitivityLabels"
description: "Get the sensitivityLabel resources from the sensitivityLabels navigation property."
author: "tommoser"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# List sensitivityLabels

Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of [sensitivityLabel](../resources/security-sensitivitylabel.md) objects associated with a user or organization.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | InformationProtectionPolicy.Read            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | InformationProtectionPolicy.Read.All        |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
To get labels available to the signed-in user (delegated permission) or a specified user (application permission):

``` http
GET /users/{usersId}/security/informationProtection/sensitivityLabels
GET /me/security/informationProtection/sensitivityLabels
```

To get labels available to the organization as a service principal (application permission):

```http
GET /security/informationProtection/sensitivityLabels
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

| Name          | Description                                                                                                                                                                       |
| :------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Authorization | Bearer {token}. Required.                                                                                                                                                         |
| User-Agent    | Describes the name and version of the calling application. Details will surface in Azure Information Protection Analytics. Suggested format is `ApplicationName/Version`. Optional. |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [sensitivityLabel](../resources/security-sensitivitylabel.md) objects in the response body.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_sensitivitylabel",
  "sampleKeys": ["bob@contoso.com"]
}
-->

``` http
GET https://graph.microsoft.com/beta/users/bob@contoso.com/security/informationProtection/sensitivityLabels
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var sensitivityLabels = await graphClient.Users["{user-id}"].Security.InformationProtection.SensitivityLabels
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "name": "list_sensitivitylabel",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.sensitivityLabel",
  "isCollection": true
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#users('bob%40contoso.com')/security/informationProtection/sensitivityLabels",
  "value": [
    {
      "id": "0d39dc11-75ff-4309-8b32-ff94f0e41607",
      "name": "Any User (No Protection)",
      "description": "",
      "color": "",
      "sensitivity": 7,
      "tooltip": "The most sensitive information stored by Milt0rCorp; product plans, customer information, and other trade secrets. Data labeled for Any User will not be protected and should be used with caution and sparingly.",
      "isActive": true,
      "isAppliable": true,
      "contentFormats": [
        "file",
        "email",
        "schematizeddata"
      ],
      "hasProtection": false,
      "parent@odata.context": "https://graph.microsoft.com/beta/$metadata#users('bob%40constoso.com')/security/informationProtection/sensitivityLabels('0d39dc11-75ff-4309-8b32-ff94f0e41607')/parent/$entity",
      "parent": {
        "id": "566663c7-4d8d-4b8f-b280-784a31971dbe",
        "name": "Highly Confidential",
        "description": "",
        "color": "",
        "sensitivity": 7,
        "tooltip": "The most sensitive information at Milt0rCorp; product plans, customer information, data not shareable even under NDA.",
        "isActive": false,
        "isAppliable": false,
        "contentFormats": [
          "file",
          "email",
          "schematizeddata"
        ],
        "hasProtection": false,
        "parent@odata.context": "https://graph.microsoft.com/beta/$metadata#users('bob%40contoso.com')/security/informationProtection/sensitivityLabels('0d39dc11-75ff-4309-8b32-ff94f0e41607')/parent/parent/$entity",
        "parent": null
      }
    }
  ]
}
```

