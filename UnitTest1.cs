using Xunit;

namespace Demo
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var csredis = new CSRedis.CSRedisClient("localhost:6379,defaultDatabase=13,poolsize=10");

            var pong = csredis.Ping();

            Assert.True(pong);

            var flag = csredis.Set("key", "123");

            Assert.True(flag);

            var val = csredis.Get("key");

            Assert.Equal("123", val);
        }

        [Fact]
        public void Test2()
        {
            var csredis = new CSRedis.CSRedisClient("localhost:6380,defaultDatabase=5,poolsize=10");

            var pong = csredis.Ping();

            Assert.True(pong);

            var flag = csredis.Set("key", "123");

            Assert.True(flag);

            var val = csredis.Get("key");

            Assert.Equal("123", val);
        }
    }
}
