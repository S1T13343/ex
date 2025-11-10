using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        // Зменшуємо ключ до діапазону 0–25
        shiftKey = shiftKey % 26;

        char RotateChar(char c)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                return (char)(((c - offset + shiftKey) % 26) + offset);
            }
            return c; // залишаємо пробіли та пунктуацію
        }

        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            result[i] = RotateChar(text[i]);
        }

        return new string(result);
    }
}
