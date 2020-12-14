﻿using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace RadishV2.Server.Application.Handler.Tests
{
    public class AddListKeyHandlerTests
    {
        [Fact()]
        public void AddListKeyHandlerTest()
        {
            var iLoggerMock = new Mock<ILogger<AddListKeyHandler>>();
            var handler = new AddListKeyHandler(iLoggerMock.Object);
            Assert.NotNull(handler);
        }
    }
}