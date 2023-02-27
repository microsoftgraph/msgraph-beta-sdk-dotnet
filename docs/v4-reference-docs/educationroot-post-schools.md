---
title: "Create educationSchool"
description: "Create a school."
author: "mmast-msft"
ms.localizationpriority: medium
ms.prod: "education"
doc_type: apiPageType
---

# Create educationSchool

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a school.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | Not supported.                              |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | EduRoster.ReadWrite.All                     |

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /education/schools
```

## Request headers

| Header        | Value                     |
| :------------ | :------------------------ |
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json          |

## Request body

In the request body, supply a JSON representation of an [educationSchool](../resources/educationschool.md) object.

## Response

If successful, this method returns a `201 Created` response code and an [educationSchool](../resources/educationschool.md) object in the response body.

## Example

##### Request

The following is an example of the request.

# [HTTP](#tab/http)

<!-- {
  "blockType": "request",
  "name": "create_educationschool_from_educationroot"
}-->
```http
POST https://graph.microsoft.com/beta/education/schools
Content-type: application/json

{
  "displayName": "Fabrikam High School",
  "description": "Magnate school for the arts. Los Angeles School District",
  "externalSource": "String",
  "principalEmail": "AmyR@fabrikam.com",
  "principalName": "Amy Roebuck",
  "externalPrincipalId": "14007",
  "highestGrade": "12",
  "lowestGrade": "9",
  "schoolNumber": "10002",
  "address": {
    "city": "Los Angeles",
    "countryOrRegion": "United States",
    "postalCode": "98055",
    "state": "CA",
    "street": "12345 Main St."
  },
  "externalId": "10002",
  "phone": "+1 (253) 555-0102",
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var educationSchool = new EducationSchool
{
	DisplayName = "Fabrikam High School",
	Description = "Magnate school for the arts. Los Angeles School District",
	ExternalSource = EducationExternalSource.Sis,
	PrincipalEmail = "AmyR@fabrikam.com",
	PrincipalName = "Amy Roebuck",
	ExternalPrincipalId = "14007",
	HighestGrade = "12",
	LowestGrade = "9",
	SchoolNumber = "10002",
	Address = new PhysicalAddress
	{
		City = "Los Angeles",
		CountryOrRegion = "United States",
		PostalCode = "98055",
		State = "CA",
		Street = "12345 Main St."
	},
	ExternalId = "10002",
	Phone = "+1 (253) 555-0102"
};

await graphClient.Education.Schools
	.Request()
	.AddAsync(educationSchool);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

