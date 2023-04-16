//Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
//•	A união de X com Y
//•	A diferença entre X e Y
//•	A interseção entre X e Y
//Escreva o vetor resultado de cada uma das operações.


int[] vectX = new int[10]; 
int[] vectY = new int[10];
int[] vectUni = new int[10];
int[] vectDif = new int[10];
int[] vectInter = new int[10];


Random valuVect = new Random();

for(int i =0; i < 10; i++)
{
    vectX[i] = valuVect.Next(0,30);
    vectY[i] = valuVect.Next(0,30);
}

for (int i = 0; i < 10; i++)
{
    if(vectX[i] > vectY[i])
    {
        vectDif[i] = vectX[i] - vectY[i];
    }
    else
    {
        vectDif[i] = vectY[i] - vectX[i];
    }
}

for (int i = 0; i < 10; i++)
{
    vectUni[i] = vectX[i] + vectY[i];
}

for (int i = 0; i < 10; i++)
{
    vectUni[i] = vectX[i] + vectY[i];
}

int contadorIntersecao = 0;
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if (vectX[i] == vectY[j])
        {
            vectInter[contadorIntersecao++] = vectX[i];
            break;
        }
    }
}

Console.Write("\nValor do Vetor X: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{vectX[i]} ");
}

Console.Write("\n\nValor do Vetor Y: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{vectY[i]} ");
}

Console.Write("\n\nValor da união dos vetores X e Y: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{vectUni[i]} ");
}

Console.Write("\n\nValor da diferença dos vetores X e Y: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{vectDif[i]} ");
}

Console.Write("\n\nValor da interseção dos vetores X e Y: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"{vectInter[i]} ");
}
Console.WriteLine();