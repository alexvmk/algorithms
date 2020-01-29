using System;
using System.Collections.Generic;
using System.Text;

namespace Seattle
{
    public interface ISeattleTestsFixture : IDisposable
    {
        IServiceProvider ServiceProvider { get; }
    }
}
