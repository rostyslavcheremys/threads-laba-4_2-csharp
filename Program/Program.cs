namespace Program;

static class Program
{
    static void Main()
    {
        Table table = new Table();
        Waiter waiter = new Waiter();

        for (int i = 0; i < 5; i++)
        {
            new Philosopher(i, table, waiter);
        }
    }
}