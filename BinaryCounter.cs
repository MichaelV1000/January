// p ∧ (q ∨ r)
/*
-------------------
p q r # p | (q | r)
-------------------
T T T #   T    T  
T T F #   T    T 
T F T #   T    T 
F T T #   T    T 
T F F #   T    F 
F T F #   T    T 
F F T #   T    T 
F F F #   F    F
-------------------

Contingent
T: [T T T] [T T F] [T F T] [F T T] [T F F] [F T F] [F F T]
F: [F F F]
*/
using System;
using System.Collections;

int sum;

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

int[] iterate(int len)
{
    int[] digits = new int[len];

    for (int i = 0; i < len; i++)
    {
        digits[i] = 0;
    }

    do
    {
        sum = 0;
        foreach (int num in digits)
        {
            Console.Write(num);
            sum += num;
        }

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
    } while (sum < len);
    return digits;
}

iterate(5);