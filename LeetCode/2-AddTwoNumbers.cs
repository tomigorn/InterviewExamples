namespace LeetCode;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode createNodeFromInt(int i)
    {
        if (i == 0)
            return new ListNode(0);

        ListNode result = null;
        ListNode current = null;

        while (i > 0)
        {
            int digit = i % 10;
            i /= 10;

            ListNode newNode = new(digit);
            if (result == null)
            {
                result = newNode;
                current = newNode;
            }
            else
            {
                current.next = newNode;
                current = newNode;
            }
        }
        return result;
    }

    public static int[] ToArray(ListNode node)
    {
        var list = new List<int>();
        while (node != null)
        {
            list.Add(node.val);
            node = node.next;
        }
        return list.ToArray();
    }
}

public class LeetCode_AddTwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode currentL1Position = l1;
        ListNode currentL2Position = l2;
        ListNode solution = new ListNode();
        ListNode solutionPosition = solution;
        int carryover = 0;


        while (true)
        {
            int currentSum = currentL1Position.val + currentL2Position.val + carryover;
            carryover = 0;
            if (currentSum >= 10)
            {
                carryover = 1;
                currentSum -= 10;
            }
            solutionPosition.val = currentSum;

            
            if (currentL1Position.next == null && currentL2Position.next == null)
            {
                break;
            } else {
                currentL1Position = currentL1Position.next ?? new ListNode();
                currentL2Position = currentL2Position.next ?? new ListNode();

                ListNode newNode = new();
                solutionPosition.next = newNode;
                solutionPosition = newNode;
            }
        }

        if (carryover != 0)
        {
            solutionPosition.next = new ListNode(carryover);
        }

        return solution;
    }
}