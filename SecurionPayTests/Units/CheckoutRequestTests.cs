﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurionPay;
using SecurionPay.Request;
using SecurionPay.Request.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurionPayTests.Units
{
    [TestClass]
    public class CheckoutRequestTests :BaseUnitTestsSet
    {
        //TODO have to tests - one for sign service and one for this endpoint
        [TestMethod]
        public void TestCheckoutRequest()
        {
            var gateway = new SecurionPayGateway("pr_test_tXHm9qV9qV9bjIRHcQr9PLPa");
            var checkoutRequest = new CheckoutRequest()
            {
                Charge=new CheckoutRequestCharge()
                {
                    Amount=499,
                    Currency="EUR"
                }
            };
            var signedCheckout=gateway.SignCheckoutRequest(checkoutRequest);
            Assert.AreEqual("Y2Y5Y2UyZDgzMzFjNTMxZjgzODlhNjE2YTE4Zjk1NzhjMTM0Yjc4NGRhYjVjYjdlNGI1OTY0ZTc3OTBmMTczY3x7ImNoYXJnZSI6eyJhbW91bnQiOjQ5OSwiY3VycmVuY3kiOiJFVVIifX0=", signedCheckout);
        }
    }
}
