---
title: "Get template"
description: "Retrieve the properties and relationships of a conditionalAccessTemplate object."
author: "lisaychuang"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Get conditionalAccessTemplate
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Read the properties and relationships of a [conditionalAccessTemplate](../resources/conditionalaccesstemplate.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type                        | Permissions (from least to most privileged)                                       |
|:--------------------------------------|:----------------------------------------------------------------------------------|
|Delegated (work or school account)     | Policy.Read.All |
|Delegated (personal Microsoft account) | Not supported.  |
|Application                            | Policy.Read.All |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /identity/conditionalAccess/templates/{id}
```

## Optional query parameters
This method supports the `$select` OData query parameter to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
| Name            |Description|
|:----------------|:----------|
| Authorization   | Bearer {token} |
| Accept-Language | Language. Optional. |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [conditionalAccessTemplate](../resources/conditionalaccesstemplate.md) object in the response body.

## Examples

### Example 1: Get the properties a template by ID

#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_conditionalaccesstemplate"
}
-->
``` http
GET https://graph.microsoft.com/beta/identity/conditionalAccess/templates/c7503427-338e-4c5e-902d-abe252abfb43
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conditionalAccessTemplate = await graphClient.Identity.ConditionalAccess.Templates["{conditionalAccessTemplate-id}"]
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.conditionalAccessTemplate"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/conditionalAccess/templates/$entity",
    "name": "Require multifactor authentication for admins",
    "description": "Require multifactor authentication for privileged administrative accounts to reduce risk of compromise. This policy will target the same roles as Security Default.",
    "id": "c7503427-338e-4c5e-902d-abe252abfb43",
    "scenarios": "secureFoundation,zeroTrust,protectAdmins",
    "details": {
        "sessionControls": null,
        "conditions": {
            "userRiskLevels": [],
            "signInRiskLevels": [],
            "clientAppTypes": [
                "all"
            ],
            "servicePrincipalRiskLevels": [],
            "platforms": null,
            "locations": null,
            "signInRiskDetections": null,
            "times": null,
            "deviceStates": null,
            "devices": null,
            "clientApplications": null,
            "applications": {
                "includeApplications": [
                    "All"
                ],
                "excludeApplications": [],
                "includeUserActions": [],
                "includeAuthenticationContextClassReferences": [],
                "applicationFilter": null,
                "networkAccess": null
            },
            "users": {
                "includeUsers": [],
                "excludeUsers": [
                    "Current administrator will be excluded"
                ],
                "includeGroups": [],
                "excludeGroups": [],
                "includeRoles": [
                    "62e90394-69f5-4237-9190-012177145e10",
                    "194ae4cb-b126-40b2-bd5b-6091b380977d"
                ],
                "excludeRoles": [],
                "includeGuestsOrExternalUsers": null,
                "excludeGuestsOrExternalUsers": null
            }
        },
        "grantControls": {
            "operator": "OR",
            "builtInControls": [
                "mfa"
            ],
            "customAuthenticationFactors": [],
            "termsOfUse": [],
            "authenticationStrength": null
        }
    }
}
```

### Example 2: Select details of a template

#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_conditionalaccesstemplate_select"
}
-->
``` http
GET https://graph.microsoft.com/beta/identity/conditionalAccess/templates/c7503427-338e-4c5e-902d-abe252abfb43?$select=details
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conditionalAccessTemplate = await graphClient.Identity.ConditionalAccess.Templates["{conditionalAccessTemplate-id}"]
	.Request()
	.Select("details")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.conditionalAccessTemplate"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/conditionalAccess/templates(details)/$entity",
    "details": {
        "sessionControls": null,
        "conditions": {
            "userRiskLevels": [],
            "signInRiskLevels": [],
            "clientAppTypes": [
                "all"
            ],
            "servicePrincipalRiskLevels": [],
            "platforms": null,
            "locations": null,
            "signInRiskDetections": null,
            "times": null,
            "deviceStates": null,
            "devices": null,
            "clientApplications": null,
            "applications": {
                "includeApplications": [
                    "All"
                ],
                "excludeApplications": [],
                "includeUserActions": [],
                "includeAuthenticationContextClassReferences": [],
                "applicationFilter": null,
                "networkAccess": null
            },
            "users": {
                "includeUsers": [],
                "excludeUsers": [
                    "Current administrator will be excluded"
                ],
                "includeGroups": [],
                "excludeGroups": [],
                "includeRoles": [
                    "62e90394-69f5-4237-9190-012177145e10",
                    "194ae4cb-b126-40b2-bd5b-6091b380977d"
                ],
                "excludeRoles": [],
                "includeGuestsOrExternalUsers": null,
                "excludeGuestsOrExternalUsers": null
            }
        },
        "grantControls": {
            "operator": "OR",
            "builtInControls": [
                "mfa"
            ],
            "customAuthenticationFactors": [],
            "termsOfUse": [],
            "authenticationStrength": null
        }
    }
}
```
