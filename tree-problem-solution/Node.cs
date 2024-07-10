namespace tree_problem_solution;
public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }
    public bool Contains(int value) {
        // value equals the root, so return true
        if (value == Data) {
            return true;
            // if value is less than data(the root), then left is not null, and check if left contains value
        } else if (value < Data) {
            return Left != null && Left.Contains(value);
            //Otherwise check the right side of the tree
        } else {
            return Right != null && Right.Contains(value);
        }
        // if value isn't in data, left, or right, then return false
        return false;
    }

    public int GetHeight()
    {
        // set up counters for each side of the tree
        int leftHeight = 0;
        int rightHeight = 0;
        // if left isn't null, set counter equal to recursive call for left
        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }
        // same for the right side
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }
        
        // return whichever height is greater + 1 to account for the root
        return Math.Max(leftHeight, rightHeight) + 1;
        
    }
}