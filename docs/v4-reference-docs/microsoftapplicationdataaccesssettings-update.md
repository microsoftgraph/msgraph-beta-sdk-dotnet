---
title: "Update microsoftApplicationDataAccessSettings"
description: "Update the properties of a microsoftApplicationDataAccessSettings object."
author: "ttomi"
ms.localizationpriority: medium
ms.prod: "insights"
doc_type: apiPageType
---

# Update microsoftApplicationDataAccessSettings

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the settings in a [microsoftApplicationDataAccessSettings](../resources/microsoftapplicationdataaccesssettings.md) object that specify access from Microsoft applications to Microsoft 365 user data in an organization.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Organization.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
PATCH /organization/{organizationId}/settings/microsoftApplicationDataAccess
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

|Property|Type|Description|
|:---|:---|:---|
|isEnabledForAllMicrosoftApplications|Boolean|When set to `true`, all users in the organization can access in a Microsoft app any Microsoft 365 data that the user has been authorized to access. The Microsoft app can be a Microsoft 365 app (e.g., Excel, Outlook) or non-Microsoft 365 app (e.g., Edge). The default is `true`. <br> It is possible to disable this access for a subset of users in an Azure Active Directory (Azure AD) security group, by specifying the group in the **disabledForGroup** property. <br> When set to `false`, users can access authorized Microsoft 365 data only in a Microsoft 365 app.|
|disabledForGroup|String|The ID of an Azure AD security group whose members are allowed to access Microsoft 365 data using only Microsoft 365 apps, but not other Microsoft apps such as Edge. <br> This is only applicable if **isEnabledForAllMicrosoftApplications** is set to `true`.|

## Response

If successful, this method returns a `200 OK` response code and an updated [microsoftApplicationDataAccessSettings](../resources/microsoftapplicationdataaccesssettings.md) object in the response body.

## Examples

### Request

The following example request shows how an admin updates the **disabledForGroup** privacy setting in order to prohibit users in a particular Azure AD group from accessing Microsoft 365 data using Microsoft applications that are not part of Microsoft 365.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_microsoftapplicationdataaccesssettings"
}
-->
``` http
PATCH https://graph.microsoft.com/beta/organization/{organizationId}/settings/microsoftApplicationDataAccess
Content-Type: application/json

{
  "disabledForGroup": "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var microsoftApplicationDataAccessSettings = new MicrosoftApplicationDataAccessSettings
{
	DisabledForGroup = "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
};

await graphClient.Organization["{organization-id}"].Settings.MicrosoftApplicationDataAccess
	.Request()
	.UpdateAsync(microsoftApplicationDataAccessSettings);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.microsoftApplicationDataAccessSettings",
  "name": "update_microsoftapplicationdataaccesssettings"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "@odata.type": "#microsoft.graph.microsoftApplicationDataAccessSettings",
  "isEnabledForAllMicrosoftApplications": true,
  "disabledForGroup": "edbfe4fb-ec70-4300-928f-dbb2ae86c981"
}
```
