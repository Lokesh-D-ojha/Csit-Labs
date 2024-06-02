
#include <stdio.h>

int main()
{
    char com[30];
    int i = 2, a = 0;

    printf("\tEnter comment : ");
    scanf("%s", com);

    if (com[0] == '/')
    {
        if (com[1] == '/')
            printf("\tIt is a vlaid comment");
        else if (com[1] == '*')
        {
            for (i = 2; i <= 30; i++)
            {
                if (com[i] == '*' && com[i + 1] == '/')
                {
                    printf("\tIt is a vlaid comment");
                    a = 1;
                    break;
                }
            }
            if (a == 0)
                printf("\tIt is not a valid comment");
        }
        else
            printf("\tIt is not a valid comment");
    }
    else
        printf("\tIt is not a valid comment");

    return 0;
}

