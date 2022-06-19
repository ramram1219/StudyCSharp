using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LinkedList
{
	public class SinglyLinkedList<T>
	{
		private Node<T> m_head;

		// 마지막 노드에 데이터 추가
		public void AddLast(T data)
		{
			Node<T> node = new Node<T>(data);

			if(m_head == null)
			{
				m_head = node;
			}
			else
			{
				Node<T> last = m_head;

				while(last.Next != null)
				{
					last = last.Next;
				}

				last.Next = node; 
			}
		}

		// 첫 번째 노드에 데이터 추가
		public void AddFirst(T data)
		{
			Node<T> node = new Node<T>(data);

			node.Next = m_head;

			m_head = node;
		}
		
		// 특정 노드 뒤에 데이터 추가
		public void AddAfter(Node<T> find_node, T value)
		{
			Node<T> node = new Node<T>(value);

			node.Next = find_node.Next; 

			find_node.Next = node;
		}

		// 노드 조회
		public Node<T> Find(T value)
		{
			if(m_head != null)
			{
				Node<T> value_node = new Node<T>(value);
				Node<T> node = m_head;

				while(node != null)
				{
					if(node.Data.Equals(value_node.Data))
					{
						break;
					}

					node = node.Next;
				}

				return node;
			}
			else
			{
				return null;
			}
		}

		// 노드 삭제 
		public void Remove(Node<T> removeNode)
		{
			Node<T> node = m_head;
			Node<T> node_before = null;

			while(node != removeNode)
			{
				node_before = node;
				node = node.Next;
			}

			// 제일 처음의 노드를 삭제하는 경우 
			if(node_before == null)
			{
				m_head = removeNode.Next;
			}
			else
			{
				node_before.Next = removeNode.Next;
				node = null;
			}
		}

		public override string ToString()
		{
			var temp = m_head;
			string data = "";

			while(temp != null)
			{
				if(!string.IsNullOrEmpty(data))
				{
					data += ", ";
				}

				data += temp.Data.ToString();

				temp = temp.Next;
			}

			return data;
		}
	}
}
