﻿using Xunit;

namespace RadishV2.Server.Application.Command.Tests
{
    public class GetRedisKeyTests
    {
        [Fact()]
        public void GetRedisKeyTest()
        {
            GetRedisKey value = new GetRedisKey();
            Assert.NotNull(value);
        }
    }
}