// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Seattle
{
    public class SeattleTestsFixture : ISeattleTestsFixture
    {
        public IServiceProvider ServiceProvider;

        IServiceProvider ISeattleTestsFixture.ServiceProvider => throw new NotImplementedException();

        public void Dispose()
        {
        }
    }
}
