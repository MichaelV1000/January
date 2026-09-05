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

int[] digits = [0, 0, 0];
int sum;
int length = digits.Length;

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
    
    for (int i = 1; i <= length; i++)
    {
        int index = length - i;
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
} while (sum < length);
