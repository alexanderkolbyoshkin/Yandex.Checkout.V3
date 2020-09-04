namespace Yandex.Checkout.V3
{
    public interface IClient
    {
        string UserAgent { get; }
        string ApiUrl { get; }
        string Authorization { get; }

        /// <summary>
        /// Payment creation
        /// </summary>
        /// <param name="payment">Payment information, <see cref="NewPayment"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Payment CreatePayment(NewPayment payment, string idempotenceKey = null);

        /// <summary>
        /// Payment capture
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Payment CapturePayment(string id, string idempotenceKey = null);

        /// <summary>
        /// Payment capture, can be used to change payment amount.
        /// If you do not need to make any changes in payment use <see cref="CapturePayment(string,string)"/>
        /// </summary>
        /// <param name="payment">New payment data</param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Payment CapturePayment(Payment payment, string idempotenceKey = null);

        /// <summary>
        /// Query payment state
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <returns><see cref="Payment"/></returns>
        Payment GetPayment(string id);

        /// <summary>
        /// Payment cancelation
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Payment CancelPayment(string id, string idempotenceKey = null);

        /// <summary>
        /// Refund creation
        /// </summary>
        /// <param name="refund">Refund data</param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="NewRefund"/></returns>
        Refund CreateRefund(NewRefund refund, string idempotenceKey = null);

        /// <summary>
        /// Query refund
        /// </summary>
        /// <param name="id">Refund id</param>
        /// <returns><see cref="NewRefund"/></returns>
        Refund GetRefund(string id);
    }
}
