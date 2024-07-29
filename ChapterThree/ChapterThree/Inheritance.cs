using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Inheritance:/
 * Types:
 * Single Inheritance: class B to class A
 * Multilevel Inheritance: Class C to class B to class A
 * Hierarchical Inheritance Class B and Class C to Class A
 * Multiple inheritance: By defailt doesnot support multiple inheritance
 * public class A{
 * }
 * public class B{}
 * public class c:A,B{}
 * above code will not work instead we can use interface to achieve multiple inheritance 
 * 
 * Hybrid Inheritance
 *  public class BaseClass{}
 *  public interface inter{}
 *  public class DerivedClass: BaseClass,inter{}
 */
namespace ChapterThree
{
    public class BaseClass 
    {
        public int PublicMember;
        protected int ProtectedMember;
        private int PrivateMember;
        internal int InternalMember;
    }
    public class Inheritance : BaseClass
    {
        public void AccessMembers()
        {
            PublicMember = 1;
            ProtectedMember = 2;
           // PrivateMember = 3;
            InternalMember = 4;
        }
        static void Main(string[] args){
            Inheritance obj = new Inheritance();
            Console.WriteLine(obj.ProtectedMember);
            
        }

    }
}
