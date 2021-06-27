using System;
using System.Collections.Generic;
using Tree;

namespace Tree {
    public static class TraversalTree {
        public static IList<int> InorderTraversal(TreeNode root){
            List<int> result = new List<int>();
            Stack<Object> st = new Stack<Object>();

            st.Push(root);
            while(st.Count > 0){
                Object obj = st.Pop();
                if(obj == null) {
                    continue;
                }

                if(obj is TreeNode){
                    TreeNode node = (TreeNode)obj;
                    st.Push(node.right);
                    st.Push(node.val);
                    st.Push(node.left);
                } else if(obj is int){
                    result.Add((int)obj);
                }
            }

            return result;
        }
    }
}