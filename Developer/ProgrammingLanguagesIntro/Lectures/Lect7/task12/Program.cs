// Ошибочки
int[,] pic = new int[1000, 1000];
for (int i = 0; i < 1000; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 999] = 1;
    pic[999, i] = 1;
}