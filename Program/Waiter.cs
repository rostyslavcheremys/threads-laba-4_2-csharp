namespace Program;

public class Waiter
{
    private readonly SemaphoreSlim _permission = new (2); 

    public void RequestPermission() => _permission.Wait();

    public void ReleasePermission() => _permission.Release();
 
}
