using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tree
{
	class Program
	{
		/*
		 * 트리 - 자료 간의 관계가 계층 구조일 때 사용하는 비선형 자료구조
		 *      - 그래프의 한 종류로 최소 연결 트리라고도 불린다.
		 *      - 트리는 계층 모델이다.
		 *      - 트리는 DAG(Directed Acycle Graphs, 방향성이 있는 비순환 그래프)의 한 종류이다.
		 *      - 노드가 N개인 트리는 항상 N-1개의 간선(edge)을 가진다.
		 *      - 순회는 Pre-order, In-order 또는 Post-order로 이루어진다.
		 *      - 트리는 이진 트리, 이진 탐색 트리, 균형 트리, 이진 힙 등이 있다.
		 *      - 루트에서 어떤 노드로 가는 경로는 유일하다.
		 *      
		 * 이진 트리(Binary Tree) - 컴퓨터에서 사용되는 데이터 구조의 하나로, 루트가 있는 트리 구조에서 어떤 노드의 자식 수가
		 *                          최대 2개를 넘지 않는 트리를 말한다. 
		 *                          
		 * 깊이 우선 탐색 / 너비 우선 탐색 
		 * 
		 * 전위 순회(Pre-order) 예제
		 */

		static void Main(string[] args)
		{
			BinaryTree<int> binaryTree = new BinaryTree<int>();

			binaryTree.Inser(4);
			binaryTree.Inser(2);
			binaryTree.Inser(3);
			binaryTree.Inser(6);
			binaryTree.Inser(1);
			binaryTree.Inser(7);
			binaryTree.Inser(5);

			binaryTree.PreOrderTraversal();
		}
	}
}
