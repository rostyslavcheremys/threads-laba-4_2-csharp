namespace Program;

public class Table
{
    private readonly SemaphoreSlim[] _forks = new SemaphoreSlim[5];

    public Table()
    {
        for (int i = 0; i < 5; i++)
        {
            _forks[i] = new SemaphoreSlim(1);
        }
    }

    public void GetFork(int id) => _forks[id].Wait();
    public void PutFork(int id) => _forks[id].Release();
}
