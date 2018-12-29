#include <iostream>
using namespace std;

void main()
{
	//ìîÿ çàäà÷à
	//21. Ñê³ëüêè îäèíèöü òîâàðó âàðò³ñòþ k ãðí ìîæíà ïðèäáàòè íà ñóìó n
	//ãðí ? Ñê³ëüêè ãðîøåé çàëèøèòüñÿ ?
	int amount_of_money, price_one_good, amount_of_goods, amount_remain_money;
	cout << "Input amount of money: ";
	cin >> amount_of_money;
	cout << "Input price of one good: ";
	cin >> price_one_good;
	__asm
	{
		mov ecx, price_one_good
		mov eax, amount_of_money
		cdq//ðîçøèðþþ çíà÷åííÿ ðåã³ñòðà, àáè ìàòè ìîæëèâ³ñòü çáåðåãàííÿ îñòà÷³ â³ä ä³ëåííÿ

		div ecx//ä³ëþ eax íà ecx, òîáòî amount_of_money/price_one_good

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
		cdq//ðîçøèðþþ çíà÷åííÿ ðåã³ñòðà, àáè ìàòè ìîæëèâ³ñòü çáåðåãàííÿ îñòà÷³ â³ä ä³ëåííÿ

		div ecx//ä³ëþ eax íà ecx, òîáòî year/400
		test edx, edx//ÿêùî îñòà÷à â³ä ä³ëåííÿ = 0, òîáòî ðåçóëüòàò ëîã³÷íîãî ìíîæåííÿ = 0, òî ZF = 1

		jz is_leap//âèêîíàºòüñÿ, ÿêùî ZF = 1
		mov eax, year
		cdq//ðîçøèðþþ çíà÷åííÿ ðåã³ñòðà, àáè ìàòè ìîæëèâ³ñòü çáåðåãàííÿ îñòà÷³ â³ä ä³ëåííÿ
		mov ecx, 4
		div ecx//ä³ëþ eax íà ecx, òîáòî year/4
		test edx, edx//ÿêùî îñòà÷à â³ä ä³ëåííÿ = 0, òîáòî ðåçóëüòàò ëîã³÷íîãî ìíîæåííÿ = 0, òî ZF = 1
		jz maybe_leap//âèêîíàºòüñÿ, ÿêùî ZF = 1
		jmp result
		is_leap :
		mov ebx, 1
			jmp result
			maybe_leap :
		mov eax, year
			cdq//ðîçøèðþþ çíà÷åííÿ ðåã³ñòðà, àáè ìàòè ìîæëèâ³ñòü çáåðåãàííÿ îñòà÷³ â³ä ä³ëåííÿ
			mov ecx, 100
			div ecx
			test edx, edx//ÿêùî îñòà÷à â³ä ä³ëåííÿ = 0, òî ZF = 1
			jz result//âèêîíàºòüñÿ, ÿêùî ZF = 1
			jmp is_leap//ñþäè ïåðåéäó, ÿêùî ZF = 0
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
