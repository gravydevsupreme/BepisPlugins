﻿using BepInEx;
using Sideloader.AutoResolver;
using System.Collections.Generic;

namespace Sideloader
{
    [BepInDependency(XUnity.ResourceRedirector.Constants.PluginData.Identifier)]
    [BepInDependency(ExtensibleSaveFormat.ExtendedSave.GUID)]
    [BepInPlugin(GUID, PluginName, Version)]
    public partial class Sideloader : BaseUnityPlugin
    {
        private static readonly string[] GameNameList = { "aigirl", "ai girl" };

        private readonly List<HeadPresetInfo> _gatheredHeadPresetInfos = new List<HeadPresetInfo>();
        private readonly List<FaceSkinInfo> _gatheredFaceSkinInfos = new List<FaceSkinInfo>();

        private static string FindKoiZipmodDir() => string.Empty;
    }
}
