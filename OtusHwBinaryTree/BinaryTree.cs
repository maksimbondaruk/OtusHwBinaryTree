namespace OtusHwBinaryTree;

public class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        root = null;
    }

    public Node ReturnRoot() => root;
    
    public  void AddNode(Node toAdd)
    {
        if (root == null)
        {
            root = new Node()
            {
                Emp = (toAdd.Emp.employeeName, toAdd.Emp.employeeSalary)
            };
        }
        else
        {
            AddNodeRecursive(root, toAdd);
        }
    }
    static void AddNodeRecursive(Node root, Node toAdd)
    {
        if (toAdd.Emp.employeeSalary < root.Emp.employeeSalary)
        {
            //Идем в левое поддерево
            if (root.Left != null)
            {
                AddNodeRecursive(root.Left, toAdd);
            }
            else
            {
                root.Left = toAdd;
            }
        }
        else
        {
            //Идем в правое поддерево
            if (root.Right != null)
            {
                AddNodeRecursive(root.Right, toAdd);
            }
            else
            {
                root.Right = toAdd;
            }
        }
    }

    public void Inorder(Node locRoot)
    {
        if (locRoot != null)
        {
            Inorder(locRoot.Left);
            Console.WriteLine(locRoot.Emp.employeeName + " - " + locRoot.Emp.employeeSalary);
            Inorder(locRoot.Right);
        }
    }
    
    public string FindNode(Node root, int number)
    {
        if (number < root.Emp.employeeSalary)
        {
            //ищем в левом поддереве
            if (root.Left != null)
            {
                return FindNode(root.Left, number);
            }
            return ("такой сотрудник не найден");
        }
        if (number > root.Emp.employeeSalary)
        {
            //ищем в правом поддереве
            if (root.Right != null)
            {
                return FindNode(root.Right, number);
            }
            return ("такой сотрудник не найден");
        }
        return (root.Emp.employeeName);
    } 
    

}
