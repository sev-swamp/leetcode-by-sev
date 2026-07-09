namespace LeetCode;

/// <summary>
/// LeetCode #2 — Add Two Numbers
/// https://leetcode.com/problems/add-two-numbers/
/// Difficulty: Medium | Topic: Linked Lists, Math
///
/// Problem:
///   Two non-empty linked lists represent non-negative integers stored in reverse order.
///   Each node contains a single digit. Add the two numbers and return the sum
///   as a linked list in the same reverse format.
///
/// AddTwoNumbers1 — O(max(n,m)) iterative:
///   Walk both lists simultaneously, accumulate carry into next node.
///
/// AddTwoNumbers2 — O(max(n,m)) recursive:
///   Sum current digits, recurse on next nodes, handle carry with extra recursive call.
/// </summary>
public static class AddTwoNumbers
{
    public static ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
    {
        ListNode newNode = new ListNode();
        var current = newNode;
        var carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return newNode.next;
    }

    public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null) return null!;
        else if (l1 == null) return l2;
        else if (l2 == null) return l1;

        int a = l1.val + l2.val;
        ListNode p = new ListNode(a % 10);
        p.next = AddTwoNumbers2(l1.next, l2.next);
        if (a >= 10) p.next = AddTwoNumbers2(p.next, new ListNode(1));
        return p;
    }
}
