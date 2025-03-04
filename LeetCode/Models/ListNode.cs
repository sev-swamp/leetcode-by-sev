
// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null!)
    {
        this.val = val;
        this.next = next;
    }
    //Пришлось переопределить метод сравнения для тестирования.
    public override bool Equals(object obj)
    {
        var item = obj as ListNode;

        if (item == null)
        {
            return false;
        }
        if (item.next != null && this.next != null)
        {
            return this.val.Equals(item.val) && this.next.Equals(item.next);
        }
        else
            return this.val.Equals(item.val);
    }

    public override int GetHashCode()
    {
        return this.val.GetHashCode();
    }
}
