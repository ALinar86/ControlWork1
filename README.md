# Контрольная работа по итогам 1 четверти
## Описание программы, которая из имеющегося массива строк создает новый массив строк с длинной элементов не более 3 символов. 
Имеется массив строк "text". 
Объявляем второй массив, который будет принимать значения элементов 1 массива с длиной не более 3.
Создаем метод ShortWords, который проверяет размер элементов 1 массива. В случае размера 3 и менее символов - данный элемент перезаписывается во второй массив с индексом index. Далее index увеличивается на единицу.
Проход элементов 1 массива осуществлен с помощью цикла for.
Метод ShowArray предназначен для вывода нового массива в терменале.

P.S.
Блок-схему сделал только для метода ShortWords (основоной метод).
Применил голубую заливку для того, чтобы лучше было видно связи.
В блок-схеме в цикле for указал по ГОСТ, как учили на семинарах (i=0, text.Lenght, 1 означает int i = 0; i < text.Lenght; i++).
