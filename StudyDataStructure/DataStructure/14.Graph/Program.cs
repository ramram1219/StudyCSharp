using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Graph
{
	class Program
	{
		/*
		 * 인접 리스트 예제
		 */

		static void Main(string[] args)
		{
			Graph<string> gr = new Graph<string>();
			var v1 = gr.AddVertex("서울");
			var v2 = gr.AddVertex("프랑스");
			var v3 = gr.AddVertex("미국");
			var v4 = gr.AddVertex("방콕");

			gr.AddFdge(v1, v2, 6);
			gr.AddFdge(v1, v3, 1);
			gr.AddFdge(v1, v4, 2);
			gr.AddFdge(v2, v3, 4);
			gr.AddFdge(v3, v4, 9);

			gr.ToString();
		}

		public class Graph<T>
		{
			private List<Node<T>> nodes;	// 노드 
			private bool directedGraph;		// 방향성 

			public Graph(bool directedGraph = false)
			{
				this.nodes = new List<Node<T>>();
				this.directedGraph = directedGraph;
			}

			// 정점 추가
			public Node<T> AddVertex(T data)
			{
				return AddVertex(new Node<T>(data));
			}

			public Node<T> AddVertex(Node<T> node)
			{
				nodes.Add(node);
				return node;
			}

			// 간선 -> 어디에서 어디로 이동 
			public void AddFdge(Node<T> from, Node<T> to, int weight = 1)
			{
				from.AdjcencyNode.Add(to);	// 인접한 곳에 추가 
				from.Weight.Add(weight);	// 가중치 

				if(!directedGraph)
				{
					to.AdjcencyNode.Add(from);
					to.Weight.Add(weight);
				}
			}

			public override string ToString()
			{
				foreach (var item in nodes)
				{
					for(int i = 0; i < item.AdjcencyNode.Count; i++)
					{
						Console.WriteLine(item.Data + "--" + item.Weight[i] + "--" + item.AdjcencyNode[i].Data);
					}
				}

				return "";
			}
		}

		public class Node<T>
		{
			public T Data { get; set; }
			public List<Node<T>> AdjcencyNode { get; private set; }
			public List<int> Weight { get; private set; }

			public Node()
			{
				AdjcencyNode = new List<Node<T>>();
				Weight = new List<int>();
			}

			public Node(T data) : this()
			{
				Data = data;
			}
		}
	}
}
