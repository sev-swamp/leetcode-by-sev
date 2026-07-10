namespace LeetCode;

public class GraphNode
{
    public int val;
    public IList<GraphNode> neighbors;

    public GraphNode(int val = 0, IList<GraphNode>? neighbors = null)
    {
        this.val = val;
        this.neighbors = neighbors ?? new List<GraphNode>();
    }
}
