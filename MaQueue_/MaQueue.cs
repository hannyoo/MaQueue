using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MaQueue_
{
	public class MaQueue<T>						// 제네릭 클래스
	{
		private T[] array;
		private int front;						// front : 먼저 들어온 data의 인덱스 
		private int rear;						// rear : 늦; 들어온 data의 인덱스 

        private const int fixedSize = 5;		// (문법)const를 사용하여 상수로 고정

		public MaQueue()						// 오버로드 - 같은 이름의 함수에 인자값에 따라 실행을 다르게함
        {
            array = new T[fixedSize];
			front = -1;							// 배열에 처음 들어온 data의 인덱스가 -1 (존재X) = 초기화
			rear = -1;
		}

        public MaQueue(int size)				// 오버로드 - 같은 이름의 함수에 인자값에 따라 실행을 다르게함
        {
            array = new T[size];
            front = -1;
            rear = -1;
        }

        public void MaEnqueue(T item)			// 삽입, 제네릭 클래스 T를 item이라는 인자값으로 받음
		{
			if(rear == array.Length-1)			// 마지막에 삽입된 data의 인덱스 값이 배열의 크기 -1 일때 = 배열이 다 찼을때
			{
				Console.WriteLine("FULL!");
				return;							// 그대로 return
			}
			if(front == -1)						// 배열에 처음 삽입된 데이터의 인덱스 값이 -1 일때 = 삽입된 적이 없음 = 배열에 data가 없음
			{
				front = 0;						// 배열의 0번째로 할당
			}

			array[++rear] = item;				// 배열에 마지막으로 들어온 data의 인덱스 0으로 할당, 인덱스 0번에 item 삽입
		}

		public T MaDequeue()					// 제거
		{
			if(front == -1 || front > rear)		// 배열에 아무것도 없을 때 or 배열에 처음들어온 인덱스가 마지막으로 들어온 인덱스 보다 클때 = 배열에 data가 없을 때
			{
				Console.WriteLine("Empty!");
				return default(T);				// null return
			}
			T item = array[front];				// item을 배열에 처음 인덱스에 할당

			for(int i = 0; i < rear; i++)		// 반복문으로 배열 인덱스 data를 옮김
			{
				array[i] = array[i + 1];
			}
			rear--;								// 제거된 배열의 data 인덱스를 채우기 위해 감소  

			return item;
		}

		public void MaPrint()					// 출력 - 반복문으로 순서대로 data출력
		{
			if(front == -1 || front > rear)
			{
				Console.WriteLine("Empty!!");
				return;
			}
			for(int i = 0; i <= rear; i++)
			{
				Console.Write($"{array[i]}  ");
			}
			Console.WriteLine();
		}

	}
}

