// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.EntityFrameworkCore.Internal
{
    public interface IWarningsAsErrorsOptionsExtension
    {
        bool WarningIsError(Enum eventId);
    }
}
