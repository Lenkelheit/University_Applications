#include <iostream>
using namespace std;

void main()
{
	//��� ������
	//21. ������ ������� ������ ������� k ��� ����� �������� �� ���� n
	//��� ? ������ ������ ���������� ?
	int amount_of_money, price_one_good, amount_of_goods, amount_remain_money;
	cout << "Input amount of money: ";
	cin >> amount_of_money;
	cout << "Input price of one good: ";
	cin >> price_one_good;
	__asm
	{
		mov ecx, price_one_good
		mov eax, amount_of_money
		cdq//�������� �������� �������, ��� ���� ��������� ���������� ������ �� ������

		div ecx//��� eax �� ecx, ����� amount_of_money/price_one_good

		mov amount_of_goods, eax
		mov amount_remain_money, edx
	}
	cout << "Amount of goods: " << amount_of_goods << endl;
	cout << "Amount of remain money: " << amount_remain_money << endl;


	// *************
	// OTHER PROGRAM
	// *************

	int year, leap;
	cout << endl << "Input year: ";
	cin >> year;
	__asm
	{
		mov ebx, 0
		mov ecx, 400
		mov eax, year
		cdq//�������� �������� �������, ��� ���� ��������� ���������� ������ �� ������

		div ecx//��� eax �� ecx, ����� year/400
		test edx, edx//���� ������ �� ������ = 0, ����� ��������� �������� �������� = 0, �� ZF = 1

		jz is_leap//����������, ���� ZF = 1
		mov eax, year
		cdq//�������� �������� �������, ��� ���� ��������� ���������� ������ �� ������
		mov ecx, 4
		div ecx//��� eax �� ecx, ����� year/4
		test edx, edx//���� ������ �� ������ = 0, ����� ��������� �������� �������� = 0, �� ZF = 1
		jz maybe_leap//����������, ���� ZF = 1
		jmp result
		is_leap :
		mov ebx, 1
			jmp result
			maybe_leap :
		mov eax, year
			cdq//�������� �������� �������, ��� ���� ��������� ���������� ������ �� ������
			mov ecx, 100
			div ecx
			test edx, edx//���� ������ �� ������ = 0, �� ZF = 1
			jz result//����������, ���� ZF = 1
			jmp is_leap//���� �������, ���� ZF = 0
			result :
		mov leap, ebx
	}
	if (leap > 0)
	{
		cout << "Yes" << endl;
	}
	else
	{
		cout << "No" << endl;
	}
	system("pause");
}