// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;

namespace Seattle
{
    public interface ISeattleTestsFixture : IDisposable
    {
        IServiceProvider ServiceProvider { get; }
    }
}
