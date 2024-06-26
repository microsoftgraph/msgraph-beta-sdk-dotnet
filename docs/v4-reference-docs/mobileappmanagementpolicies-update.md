---
title: "Update mobileAppManagementPolicy"
description: "Update the properties of a mobile app management policy object."
author: "ravennMSFT"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# Update mobileAppManagementPolicy

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [mobilityManagementPolicy](../resources/mobilitymanagementpolicy.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.ReadWrite.MobilityManagement|
|Delegated (personal Microsoft account) | Not supported.|
|Application | Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
PATCH /policies/mobileAppManagementPolicies/{id}
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [mobilityManagementPolicy](../resources/mobilitymanagementpolicy.md) object.

In the request body, supply the values for fields listed below that should be updated. **Note:** You cannot use `PATCH` operation for `appliesTo` with the other properties.

|Property|Type|Description|
|:---|:---|:---|
|appliesTo|policyScope|Determines the groups this policy setting applies to. Possible values are: `none`, `all`, `selected` **Important:** `selected` cannot be used when specifying this property. Use [includedGroups](../api/mobileappmanagementpolicies-post-includedgroups.md) to add specific groups.|
|complianceUrl|String|Compliance URL of the mobility management application|
|discoveryUrl|String|Discovery URL of the mobility management application|
|termsOfUseUrl|String|Terms of Use URL of the mobility management application|

## Response

If successful, this method returns a `200 OK` response code and an updated [mobilityManagementPolicy](../resources/mobilitymanagementpolicy.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_mobilitymanagementpolicy_for_ID"
}
-->

``` http
PATCH https://graph.microsoft.com/beta/policies/mobileAppManagementPolicies/ab90bacf-55a3-4a3e-839a-aa4b74e4f020
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.mobilityManagementPolicy",
  "complianceUrl": "https://portal.mg.contoso.com/?portalAction=Compliance",
  "discoveryUrl": "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc",
  "termsOfUseUrl": "https://portal.mg.contoso.com/TermsofUse.aspx"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var mobilityManagementPolicy = new MobilityManagementPolicy
{
	ComplianceUrl = "https://portal.mg.contoso.com/?portalAction=Compliance",
	DiscoveryUrl = "https://enrollment.mg.contoso.com/enrollmentserver/discovery.svc",
	TermsOfUseUrl = "https://portal.mg.contoso.com/TermsofUse.aspx"
};

await graphClient.Policies.MobileAppManagementPolicies["{mobilityManagementPolicy-id}"]
	.Request()
	.UpdateAsync(mobilityManagementPolicy);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true
}
-->

``` http
HTTP/1.1 204 No Content
```
