// Guids.cs
// MUST match guids.h
using System;

namespace OnestopInternet.Onestop_Developer
{
    static class GuidList
    {
        public const string GuidOnestopDeveloperPkgString = "7fb56bd5-289a-4106-83d2-a9a6e9b67989";
        public const string GuidOnestopDeveloperCmdSetString = "2261bc43-67e0-48eb-8203-bf5b736fd9ae";

        public static readonly Guid GuidOnestopDeveloperCmdSet = new Guid(GuidOnestopDeveloperCmdSetString);
    };
}