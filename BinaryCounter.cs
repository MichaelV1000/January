int sum; // sum of items in digits array

/// <summary>
/// changes 0 to 1 or 1 t
/// </summary>
/// <param name="num"> int to be changed </param>
/// <returns> changed int </returns>
int change(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

void print(object str) {
    Console.Write(str);
}

void println(object str)
{
    Console.WriteLine(str);
}

object translate(int num, object result1, object result2)
{
    if (num == 1)
    {
        return result1;
    }
    else
    {
        return result2;
    }
}

bool isTrue(bool p, bool q, bool r)
{
    if (p && (q || r))
    {
        return true;
    }
    else return false;
}

int iterations = 0;

/// <summary>
/// iterates through binary array, counting 
/// </summary>
/// <param name="len"> length of binary array to be created </param>
void iterate(int len)
{
    int[] digits = new int[len]; // binary array 
    List<int[]> arrs = new List<int[]>();

    // iterates through array and sets all items to 0
    for (int i = 0; i < len; i++)
    {
        digits[i] = 0;
    }

    do
    {
        sum = 0;
        foreach (int num in digits)
        {
            Console.Write(translate(num, 'T', 'F') + " ");
            sum += num;
        }

        Console.Write("# ");
        Console.Write(isTrue((bool)translate(digits[0], true, false), (bool)translate(digits[1], true, false), (bool)translate(digits[2], true, false)));

        Console.WriteLine();

        bool flip = true;

        for (int i = 1; i <= len; i++)
        {
            int index = len - i;
            int digit = digits[index];

            if (flip)
            {
                digits[index] = change(digit);

                if (digits[index] == 0)
                {
                    flip = true;
                }
                else
                {
                    flip = false;
                }
            }
        }
        iterations++;

        arrs.Add(digits);
    } while (sum < len);

    Console.WriteLine();
    Console.WriteLine();
}

iterate(3);