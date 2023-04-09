using System;
namespace MaQueue_
{
	public class CircularQueue<Tpye>
	{
		private Type[] ary;
		int front;
		int rear;

		private CircularQueue( int size )           // int size를 매개변수로 받는 
		{
			ary = new Type[size];               // 
			int elements = size;
			int front = 0;
			int rear = 0;

		}

		private bool isFull()
		{
			return (rear + 1) % ary.Length == front;
		}

		private bool isEmpty()
		{
			return front == rear;
		}

		private void EnQueue( Type data )
		{
			if(isFull( ))                           // 배열이 FULL 일때
			{
				Console.WriteLine($" FULL ");
			}
			else                                    // 
			{
				rear = (rear + 1) % ary.Length;     // * 원형 큐로 만들어주는 rear의 변화 *
				ary[rear] = data;                   // 
			}
		}

		private Type DeQueue()
		{
			if(isEmpty( ))
			{
				throw new Exception(" EMPTY ");		// 에외처리 Excepeion
			}
			else
			{
				front = (front + 1) % ary.Length;
				Type data = ary[front];
				ary[front] = default(Type);
				return data;
			}
		}




	}

}

