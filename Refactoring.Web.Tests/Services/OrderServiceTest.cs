using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Web.DomainModels;
using Refactoring.Web.Services;

namespace Refactoring.Web.Tests.Services;

[TestClass]
[TestSubject(typeof(OrderService))]
public class OrderServiceTest
{
    [TestMethod]
    public void ShouldProcessOrder()
    {
        var orderService = new OrderService(new Order());

        orderService.ProcessOrder().ConfigureAwait(false);
        var order = orderService.GetOrder();
        
        Assert.IsNull(order.Status);
    }
}