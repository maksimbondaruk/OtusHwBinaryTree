// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using OtusHwBinaryTree;

internal class Program
{
    public static void Main(string[] args)
    {
        //Node root = null;
        var bst = new BinaryTree();
        bool newTreeFlag = false;
        while (true)
        {
            if (!newTreeFlag)
            {
                #region Filing tree

                var employeeName = " ";
                var locBst = new BinaryTree();
                while (true)
                {
                    Console.WriteLine("Введите имя сотрудника, а затем его зарплату");
                    employeeName = Console.ReadLine();
                    if (string.IsNullOrEmpty(employeeName))
                    {
                        break;
                    }
                     
                    int.TryParse(Console.ReadLine(), out var employeeSalary);
                    locBst.AddNode(new Node
                    {
                        Emp = (employeeName, employeeSalary)
                    });
                }

                #endregion

                #region Inorder print

                bst.Inorder(locBst.ReturnRoot());

                #endregion

                bst = locBst;
            }

            #region Find node
            Console.WriteLine();
            if (bst.root == null)
            {
                Console.WriteLine("Дерево пустое!");
            }
            else
            {
                Console.WriteLine("Введите размер зарплаты запрашиваемого сотрудника");
                int.TryParse(Console.ReadLine(), out var searchSalary);
                Console.WriteLine(bst.FindNode(bst.ReturnRoot(), searchSalary));    
            }
            
            #endregion

            #region set flags

            Console.WriteLine("Для ввода нового дерева наберите 0, для поиска другого сотрудника в текущем дереве наберите 1");
            newTreeFlag = int.Parse(Console.ReadLine()) == 1;
            #endregion
            
        }
    }
}