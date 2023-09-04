namespace DependencyStore.Repositories.Contracts
{
    public interface IDeliveryFeeService
    {
        Task<decimal> GetDeliveryFeeAsync(string zipCode);
    }
}
