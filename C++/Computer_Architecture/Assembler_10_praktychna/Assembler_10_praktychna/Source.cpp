#include <iostream>
using namespace std;

void arr_int_to_binary(__int32* arr, int size)
{
	for (int i = 0;i < size;++i)
	{
		for (int j = 0; j <24; ++j)
		{
			if (!(j % 8))
			{
				cout << " ";
			}
			cout << ((arr[i] >> (23 - j)) & 1);
		}
		cout << endl;
	}
}

void main()
{
	//������ ����� � 6 ����.���������� ������� ����, ����� ������� � ���� �� �������� 3.
	static __int32 arr[2] =
	{
		7'162'641,//01101101 01001011 00010001
		8'210'754//01111101 01001001 01000010
	};
	static __int32 res = 0;
	static __int32 i = 1;
	__asm {
		mov eax, offset arr//arr[]
		push eax
		mov cx, 6 // ������� ������� �����
		start_outer: // ������� ���������� ����� (�� ������)
		mov bx, 8 // ������� ������� ����������� �����
			xor di, di // ��������� ��������� �������
			start_inner : // ������� ���������� ����� (�� ����)
		pop edx//� ����� ������ ������ arr[]
			mov eax, edx//�������� ������ arr[]
			mov edx, [edx]//�������� �������� arr[]
			push eax//�������� ����� � ����
			and edx, i // ���������� �����
			jz go_next // ���� ��������� �������� �������� � 0
			inc di // ���� ��������� �������� �������� � 1, �������� ��������
			go_next :
		shl i, 1 // �������� ���� ���� �� 1 ��
			dec bx // �������� �������� ������� �� 1
			test bx, bx // ���������� ����� ���������� �����
			jnz start_inner// ���������� ����, ���� ��������� �� 0
			cmp cx, 4
			jne skip_equals//���� �� �������
			pop eax
			add eax, 4
			push eax//�������� ����� � ����
			mov i, 1
			skip_equals :
		cmp di, 3//��������� �� �� �������� 3
			jg end_ // ���� �������� 3
			inc res // ���� �� �������� 3, �������� ��������
			end_ :
		loop start_outer // ��������� ���������� �����
			pop eax
	}

	cout << "Array with 6 bytes:" << endl;
	arr_int_to_binary(arr, 2);
	cout << "Number bytes, in which amount of 1 doesn't exceed 3: " << res << endl;
	system("pause");
}