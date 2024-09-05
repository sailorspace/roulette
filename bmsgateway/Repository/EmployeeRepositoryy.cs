namespace bmsgateway.services
{
    using bmsgateway.DB;
    using bmsgateway.models;
    using bmsgateway.repository;

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbService _dbService;

        public EmployeeRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            var result =
                await _dbService.EditData(
                    @"INSERT INTO public.employee (id,name,address,email,dateofbirth) 
                    VALUES (@Id, @Name,@Address, @Email,@DateOfBirth)",
                    employee);
            employee.Id=result;
            return employee;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var employeeList = await _dbService.GetAll<Employee>("SELECT * FROM public.employee", new { });
            return employeeList;
        }


        public async Task<Employee> GetEmployeeAsync(int id)
        {
            var employeeList = await _dbService.GetAsync<Employee>("SELECT * FROM public.employee where id=@id", new { id });
            return employeeList;
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            var updateEmployee =
                await _dbService.EditData(
                    "Update public.employee SET name=@Name,address=@Address,email=@Email WHERE id=@Id",
                    employee);
            return employee;
        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            var deleteEmployee = await _dbService.EditData("DELETE FROM public.employee WHERE id=@Id", new { id });
            return true;
        }

       
    }
}