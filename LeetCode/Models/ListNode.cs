namespace LeetCode;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null!)
    {
        this.val = val;
        this.next = next;
    }

    // Overridden for deep equality checks in tests (recursive chain comparison).
    public override bool Equals(object? obj)
    {
        var item = obj as ListNode;
        if (item == null) return false;
        if (item.next != null && this.next != null)
            return this.val.Equals(item.val) && this.next.Equals(item.next);
        return this.val.Equals(item.val);
    }

    public override int GetHashCode() => this.val.GetHashCode();
}
