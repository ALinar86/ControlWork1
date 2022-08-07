string[] ShortWords(string[] text)
{
string[] textNew = new string[text.Length];
int index = 0;
for (int i = 0; i < text.Length; i++)
{
    if(text[i].Length <= 3)
    {
        textNew[index] = text[i];
        index++;
    }
}
return textNew;
}

void ShowArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write(a[i] + " ");
}

string[] text = {"a", "ab", "abc", "abcd", "abcde"};
ShowArray(ShortWords(text));