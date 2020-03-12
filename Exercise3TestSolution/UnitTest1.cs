using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2Solution.Coupon;
using Exercise2Solution.FluentApiContext;

namespace Exercise3TestSolution
{
    /// <summary>
    /// Utilise moq to mock the data sorce
    /// Create async classes to deal with the async operations
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private Moke<DbSet<Coupon>> CreateMoqSetCoupon(IQueryable<Coupon> CouponData)
        {
            Mock<DbSet<Coupon>> mockSet = new Mock<DbSet<Coupon>>();

            mockSet.As<IAsyncEnumerable<Coupon>>()
                .Setup(m => m.GetEnumerator())
                .Returns(new TestAsyncEnumerator<Coupon>(CouponData.GetEnumerator()));

            mockSet.As<IQueryable<Coupon>>()
                .Setup(m => m.Provider)
                .Returns(new TestAsyncQueryProvider<Coupon>(CouponData.Provider));

            mockSet.As<IQueryable<Coupon>>().Setup(m => m.Expression).Returns(CouponData.Expression);
            mockSet.As<IQueryable<Coupon>>().Setup(m => m.ElementType).Returns(CouponData.ElementType);
            mockSet.As<IQueryable<Coupon>>().Setup(m => m.GetEnumerator()).Returns(() => CouponData.GetEnumerator());

            return mockSet;
        }

        private IQueryable<Coupon> CreateMoqCouponsData()
        {
            return new List<Coupon>
            {
                new Coupon { Id = 1, Status = 0, Title = "Teste Coupon001", MaxNumberPerUser = 3, MaxNumberAll = 100 },
                new Coupon { Id = 2, Status = 0, Title = "Teste Coupon002", MaxNumberPerUser = 4, MaxNumberAll = 200 },
                new Coupon { Id = 3, Status = 0, Title = "Teste Coupon003", MaxNumberPerUser = 5, MaxNumberAll = 300 },

            }.AsQueryable();
        }





        public UnitTest1()
        {

        }

        [TestMethod]
        public async Task CanRedeemCouponSuccess()
        {
            var mockSet = CreateMoqSetCoupon(CreateMoqCouponsData());
            var mockContext = new Mock<FluentApiContext>();
            mockContext.Setup(c => c.Coupon).Returns(mockSet.Object);

            //Sorry, that I can not complet this exercise and has to stop here.
            //var result = await CanRedeemCoupon(1, 1, ()=>)
            
        }
    }
}
