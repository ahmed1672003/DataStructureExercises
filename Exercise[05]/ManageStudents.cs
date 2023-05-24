namespace Exercise_05_;

public class ManageStudents
{
    public static LinkedList<Student> students = new();

    public static LinkedListNode<Student> Add(Student student) => students.AddLast(student);


    public static LinkedList<Student> OrderByTotalDegrees(LinkedList<Student> students)
    {
        if (students.Count == 0)
            return students;

        LinkedList<Student> orderList = new();
        LinkedListNode<Student> current = students.First;
        while (current != null)
        {
            var insert = orderList.First;

            while (insert != null && insert.Value.TotalDegrees < current.Value.TotalDegrees)
                insert = insert.Next;

            if (insert != null)
                orderList.AddBefore(insert, current.Value);
            else
                orderList.AddLast(current.Value);

            current = current.Next;
        }
        return orderList;
    }
}
