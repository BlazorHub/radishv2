﻿using Xunit;

namespace RadishV2.Server.Application.Command.Tests
{
    public class AddStringKeyTests
    {
        [Fact()]
        public void AddStringKeyTest()
        {
            AddStringKey value = new AddStringKey();
            Assert.NotNull(value);
        }
    }
}