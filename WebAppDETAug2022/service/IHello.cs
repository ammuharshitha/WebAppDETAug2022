namespace WebAppDETAug2022.service
{
    public interface IHello
    {
        string SayHello(string name);

    }
    public class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello {name},Welcome to Sonata software LTD";
        }
        public class Hello2 : IHello
        {
            public string SayHello(string name)
            {
                return $"Hello {name},Welcome to Designing Dept";
            }
        }
    }
}
