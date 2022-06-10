using System.Collections.Generic;

namespace JobService.Components
{
    public interface ConvertVideo
    {
        string GroupId { get; }
        int Index { get; }
        int Count { get; }
        string Path { get; }

        List<Foo> Foos { get; }
    }

    public class Foo
    {
        public string FooId { get; set; }
    }
}