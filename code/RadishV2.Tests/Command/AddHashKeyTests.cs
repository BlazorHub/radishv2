﻿using Xunit;

namespace RadishV2.Server.Application.Command.Tests
{
    public class AddHashKeyTests
    {
        [Fact()]
        public void AddHashKeyTest()
        {
            AddHashKey value = new AddHashKey();
            Assert.NotNull(value);
        }
    }
}