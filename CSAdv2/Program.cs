using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv2
{
    // 시험범위 : 처음부터 ~ 예외 + 인터페이스까지 / 메모장 GUI (간단한것)
    internal class Program
    {
        class TestClass : IBasic
        {
            public int TestProperty {
                get { return -1; }
                set { int n = value; }
            }

            public int TestInstanceMethod()
            {
                return -1;
            }
        }

        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dummy 객체의 Dispose() 호출");
            }
        }
        class Product : IComparable<Product>
        {
            public string Name { get; set; }
            public int Price { get; set; }

            // CompareTo() 구현
            public int CompareTo(Product other)
            {
                //return this.Price.CompareTo(other.Price);
                return this.Name.CompareTo(other.Name);
            }

            //ToString() 구현
            public override string ToString()
            {
                return string.Format("Name: {0}, Price: {1}", Name, Price);
            }
        }
        static void Main(string[] args)
        {
            // Product의 리스트를 생성하고 객체 예제 10개쯤 넣기
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 1000 }, 
                new Product() { Name = "고구마", Price = 1400 },
                new Product() { Name = "양파", Price = 1200 },
                new Product() { Name = "당근", Price = 1600 },
                new Product() { Name = "고추", Price = 1800 }
            };
            products.Sort();

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            using (Dummy dummy = new Dummy())
            {
                Console.WriteLine("Hello~");
            }

            IBasic basic = new TestClass();
        }
    }
}
