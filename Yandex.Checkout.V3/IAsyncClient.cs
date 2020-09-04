using System.Threading;
using System.Threading.Tasks;

namespace Yandex.Checkout.V3
{
    public interface IAsyncClient
    {
        /// <summary>
        /// Payment creation
        /// </summary>
        /// <param name="payment">Payment information, <see cref="NewPayment"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Task<Payment> CreatePaymentAsync(NewPayment payment, string idempotenceKey = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Payment capture
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Task<Payment> CapturePaymentAsync(string id, string idempotenceKey = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Payment capture, can be used to change payment amount.
        /// If you do not need to make any changes to the payment use <see cref="CapturePaymentAsync(string,string,System.Threading.CancellationToken)"/>
        /// </summary>
        /// <param name="payment">New payment data</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Task<Payment> CapturePaymentAsync(Payment payment, string idempotenceKey = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query payment state
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Payment"/></returns>
        Task<Payment> GetPaymentAsync(string id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Payment cancellation
        /// </summary>
        /// <param name="id">Payment id, <see cref="Payment.Id"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Payment"/></returns>
        Task<Payment> CancelPaymentAsync(string id, string idempotenceKey = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Refund creation
        /// </summary>
        /// <param name="refund">Refund data</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <param name="idempotenceKey">Idempotence key, use <value>null</value> to generate a new one</param>
        /// <returns><see cref="Refund"/></returns>
        Task<Refund> CreateRefundAsync(NewRefund refund, string idempotenceKey = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query refund
        /// </summary>
        /// <param name="id">Refund id</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Refund"/></returns>
        Task<Refund> GetRefundAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
    }
}
