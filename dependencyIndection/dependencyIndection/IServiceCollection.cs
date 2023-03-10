// See https://aka.ms/new-console-template for more information
internal interface IServiceCollection
{
    void AddScoped<T1, T2>();
    void AddTransient<T1, T2>();
}