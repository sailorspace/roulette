namespace bmsgateway.repository
{
    using bmsgateway.models;
    public interface IEmployeeRepository
    {
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task<List<Employee>> GetEmployeeListAsync();
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int key);
        Task<Employee> GetEmployeeAsync(int id);
    }
}