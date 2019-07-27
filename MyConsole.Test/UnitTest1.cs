using System.Reflection;
using Xunit;

namespace MyConsole.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestMyPrivateInstanceMethod()
        {
            var myClass = new MyClass();
            var method = myClass.GetType().GetMethod("GetHelloMessage", BindingFlags.NonPublic | BindingFlags.Instance);
            var result = (string)method.Invoke(myClass, new object[] { "Chen" });
            Assert.Equal("Hello, Chen!", result);
        }

        [Fact]
        public void TestMyPrivateStaticMethod()
        {
            var method = typeof(MyClass).GetMethod("Sum", BindingFlags.NonPublic | BindingFlags.Static);
            var result = (int)method.Invoke(null, new object[] { 2, 3 });
            Assert.Equal(5, result);
        }
    }
}
