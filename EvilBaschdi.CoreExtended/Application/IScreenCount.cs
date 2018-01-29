﻿using EvilBaschdi.Core;

namespace EvilBaschdi.CoreExtended.Application
{
    /// <inheritdoc />
    /// <summary>
    ///     Interface for classes that provide the count of current connected screens of the current device / session.
    /// </summary>
    public interface IScreenCount : IValue<int>
    {
    }
}