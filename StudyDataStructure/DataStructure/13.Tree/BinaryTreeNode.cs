using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tree
{
	public class BinaryTree<T>
	{
		private BinaryTreeNode<T> root = null;
		private Comparer<T> comparer = Comparer<T>.Default;

		public void Inser(T val)
		{
			BinaryTreeNode<T> node = root;
			if(node == null)
			{
				root = new BinaryTreeNode<T>(val);
				return;
			}

			while(node != null)
			{
				int result = comparer.Compare(node.tData, val);
				if(result == 0)
				{
					return;
				}
				else if(result > 0)
				{
					if(node.btnLeft == null)
					{
						node.btnLeft = new BinaryTreeNode<T>(val);
						return;
					}
					node = node.btnLeft;
				}
				else
				{
					if(node.btnRight == null)
					{
						node.btnRight = new BinaryTreeNode<T>(val);
						return;
					}
					node = node.btnRight;
				}
			}
		}

		public void PreOrderTraversal()
		{
			PreOrderRecursive(root);
		}

		private void PreOrderRecursive(BinaryTreeNode<T> node)
		{
			if (node == null) return;

			Console.Write(node.tData + "->");
			// 왼쪽 순회
			PreOrderRecursive(node.btnLeft);
			// 오른쪽 순회
			PreOrderRecursive(node.btnRight);
		}
	}
	
	public class BinaryTreeNode<Tdata>
	{
		public Tdata tData { get; set; }
		public BinaryTreeNode<Tdata> btnLeft { get; set; }
		public BinaryTreeNode<Tdata> btnRight { get; set; }

		public BinaryTreeNode(Tdata tdata)
		{
			this.tData = tdata;
		}
	}
}
