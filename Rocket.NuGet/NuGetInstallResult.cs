﻿using NuGet.Packaging.Core;

namespace Rocket.NuGet
{
    public class NuGetInstallResult
    {
        public PackageIdentity Identity { get; }

        public NuGetInstallResult(NuGetInstallCode code)
        {
            Code = code;
        }

        public NuGetInstallResult(PackageIdentity identity)
        {
            Identity = identity;
            Code = NuGetInstallCode.Success;
        }

        public NuGetInstallCode Code { get; set; }
    }

    public enum NuGetInstallCode
    {
        Success,
        VersionNotFound,
        PackageNotFound,
        RepositoryNotFound,
        MultipleMatch,
        DependencyFail
    }
}