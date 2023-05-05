/*  ITERATORS:
 *    Aplicate an operation
 *    List a customized list
 *    LINQ - > QUERYs
 *    Channel data to other process
 */



List<string> list = new List<string> { "item 1", "item 2" };

//  Sync
foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}

/*  Async (the foreach can be async)
foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}
*/

IEnumerable<int> intNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
}

IEnumerabl<int> WriteIntNumbers()
{
    int index = 0;
    while (index < 3)
        yield return index++;
}