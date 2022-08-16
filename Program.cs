Console.Write("Введите число: ");
int number = Console.ReadLine();
int len = number.length();
//где-то тут я накосячила, но мне по хорошему надо вместе все прорешать, я эти палиндромы и синтаксис для его решения незнаю
for(int i = 0; i < len/2; ++i);
		if(number[i] != number[len-i-1])
		Console.WriteLine($"Ваше число:  - не палиндром.");
	Console.WriteLine($"Ваше число: - палиндром.");
breack;
