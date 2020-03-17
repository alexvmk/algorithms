// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle
{
    [CollectionDefinition(SeattleCollectionFixtureName)]
    public class SeattleCollectionFixture : ICollectionFixture<SeattleTestsFixture>
    {
        public const string SeattleCollectionFixtureName = "SeattleCollectionFixture";

        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
