namespace LeetCode;

public class MultilevelNode
{
    public int val;
    public MultilevelNode? prev;
    public MultilevelNode? next;
    public MultilevelNode? child;

    public MultilevelNode(int val = 0)
    {
        this.val = val;
    }
}
