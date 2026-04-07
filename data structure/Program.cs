namespace data_structure_linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleLinkedList

            /*DoubleLinkedList dll = new DoubleLinkedList();

            dll.AddNode(1, "habiba", 25000);
            dll.AddNode(2, "Ahmed", 75000);
            dll.AddNode(3, "Basma", 30000);

            dll.PrintList();

            Console.WriteLine($"total node: {dll.CountNode()}");

            // search
            dll.SearchNodeByName("habiba");

            //insert
            Employee e = new Employee(5, "sara", 20000);
            if (dll.InsertNode(e, 2))
            {
                Console.WriteLine("inserted succesfully");
                dll.PrintList();
            }
            else
            {
                Console.WriteLine("failed to insert");
            }

            // delete
            if (dll.DeleteNode(2))
            {
                Console.WriteLine("deleted succesfully");
                dll.PrintList();
            }
            else
            {
                Console.WriteLine("failed to delete");
            }*/

            #endregion

            #region stackArray

            /*Stack_Array sa = new Stack_Array(5);
            sa.Push(1);
            sa.Push(2);
            sa.Push(3);
            sa.Push(4);
            sa.Push(5);

            Console.WriteLine("after push in the array");
            sa.PrintStackArray();

            sa.Pop();

            Console.WriteLine("after pop in the array");
            sa.PrintStackArray();*/

            #endregion

            #region QueueLL

            /*Queue_LL qll = new Queue_LL();
            qll.EnQueue(5);
            qll.EnQueue(8);
            qll.EnQueue(9);
            qll.EnQueue(6);
            Console.WriteLine("After enqueue in ll");
            qll.PrintQ();

            qll.DeQueue();
            Console.WriteLine("After dequeue in ll");
            qll.PrintQ();*/

            #endregion

            #region StackLL
            /*StackLL s = new StackLL();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            Console.WriteLine("after push in the StackLL");
            s.PrintSLL();

            s.Pop();
*/
            /*Console.WriteLine("after pop in the StackLL");
            s.PrintSLL();*/
            #endregion

            #region QueueArr
            /* Queue_Arr qarr = new Queue_Arr(6);
             qarr.EnQueue(5);
             qarr.EnQueue(8);
             qarr.EnQueue(9);
             qarr.EnQueue(6);
             Console.WriteLine("After enqueue in the QueueArr");
             qarr.PrintQArr();

             qarr.DeQueue();
             Console.WriteLine("After dequeue in the QueueArr");
             qarr.PrintQArr(); */
            #endregion

            #region BinaryTree
            /* BinaryTree tree = new BinaryTree();

             tree.Root = new TreeNode(10);

             tree.Root.Left = new TreeNode(5);
             tree.Root.Right = new TreeNode(20);

             tree.Root.Left.Left = new TreeNode(3);
             tree.Root.Left.Right = new TreeNode(7);

             tree.Root.Right.Left = new TreeNode(15);

             Console.Write("InOrder: "); //(Left → Root → Right)
             tree.InOrder();
             Console.WriteLine();

             Console.Write("PreOrder: "); //Root → Left → Right
             tree.PreOrder();
             Console.WriteLine();

             Console.Write("PostOrder: "); //Left → Right → Root
             tree.PostOrder();
             Console.WriteLine();*/
            #endregion

            #region MergeSort & InsertionSort & BinarySearch

            int[] arr = new int[] { 10, 5, 8, 2, 7, 4 };
            int[] arrForMerge = (int[])arr.Clone();
            int[] arrForInsertion = (int[])arr.Clone();

            Console.WriteLine("original array: " + string.Join(",", arr));

            SortingHelper.MergeSort(arrForMerge, 0, 5);
            Console.WriteLine("After MergeSort: " + string.Join(",", arrForMerge));


            SortingHelper.InsertionSort(arrForInsertion, 0, 5);
            Console.WriteLine("After InsertionSort: " + string.Join(",", arrForInsertion));



            int loc = SearchingHelper.BinarySearch(arrForMerge, 0, 5, 7);
            Console.Write("Location of key '7': ");
            Console.WriteLine(loc);
            #endregion

        }
    }
}
