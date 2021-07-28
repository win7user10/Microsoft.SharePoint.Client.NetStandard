﻿namespace Microsoft.SharePoint.Client.NetStandard
{
    public enum PermissionKind
    {
        EmptyMask,
        ViewListItems,
        AddListItems,
        EditListItems,
        DeleteListItems,
        ApproveItems,
        OpenItems,
        ViewVersions,
        DeleteVersions,
        CancelCheckout,
        ManagePersonalViews,
        ManageLists = 12,
        ViewFormPages,
        AnonymousSearchAccessList,
        Open = 17,
        ViewPages,
        AddAndCustomizePages,
        ApplyThemeAndBorder,
        ApplyStyleSheets,
        ViewUsageData,
        CreateSSCSite,
        ManageSubwebs,
        CreateGroups,
        ManagePermissions,
        BrowseDirectories,
        BrowseUserInfo,
        AddDelPrivateWebParts,
        UpdatePersonalWebParts,
        ManageWeb,
        AnonymousSearchAccessWebLists,
        UseClientIntegration = 37,
        UseRemoteAPIs,
        ManageAlerts,
        CreateAlerts,
        EditMyUserInfo,
        EnumeratePermissions = 63,
        FullMask = 65
    }
}
