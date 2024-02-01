using System;
// ReSharper disable InvalidXmlDocComment

namespace Sample
{
    public static class LessonConstructions
    {
        // Максимальное количество баллов = 10

        ///Пример: Найти число корней квадратного уравнения ax^2 + bx + c = 0
        public static int QuadraticRootNumber(double a, double b, double c)
        {
            double discriminant = Discriminant(a, b, c);

            if (discriminant > 0)
            {
                return 2;
            }

            if (discriminant == 0)
            {
                return 1;
            }

            return 0;
        }

        public static double Discriminant(double a, double b, double c) => Sqr(b) - 4 * a * c;
        public static double Sqr(double x) => x * x;

        ///Пример: Получить строковую нотацию для оценки по пятибалльной системе
        public static string GradeNotation(int grade)
        {
            return grade switch
            {
                5 => "отлично",
                4 => "хорошо",
                3 => "удовлетворительно",
                2 => "неудовлетворительно",
                _ => "несуществующая оценка $grade",
            };
        }

        ///Пример: Вычисление факториала 
        public static double Factorial(int n)
        {
            double result = 1.0;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        /**
         * Тривиальная (1 балл)
         *
         * Мой возраст. Для заданного 0 < n < 200, рассматриваемого как возраст человека,
         * вернуть строку вида: «21 год», «32 года», «12 лет».
         */
        public static string AgeDescription(int age)
        {
            int n = age % 10;
            int m = age % 100;

            if (m >= 11 && m <= 20)
            {
                return age + " лет";
            }
            else if (n == 1)
            {
                return  age + " год";
            }
            else if (n >= 2 && n <= 4)
            {
                return age + " года";
            }
            else
            {
                return age + " лет";
            }
        }

        /**
         * Простая (2 балла)
         *
         * Нa шахматной доске стоят черный король и две белые ладьи (ладья бьет по горизонтали и вертикали).
         * Определить, не находится ли король под боем, а если есть угроза, то от кого именно.
         * Вернуть 0, если угрозы нет, 1, если угроза только от первой ладьи, 2, если только от второй ладьи,
         * и 3, если угроза от обеих ладей.
         * Считать, что ладьи не могут загораживать друг друга
         */
        public static int WhichRookThreatens(
            int kingX, int kingY,
            int rookX1, int rookY1,
            int rookX2, int rookY2
        )
        {
            if (kingX != rookX1 & kingX != rookX2 & kingY != rookY1 & kingY != rookY2)
            {
                return 0;
            }
            else if ((kingX == rookX1 & kingX != rookX2 & kingY != rookY1 & kingY != rookY2) || (kingX != rookX1 & kingX != rookX2 & kingY == rookY1 & kingY != rookY2))
            {
                return 1;
            }
            else if ((kingX != rookX1 & kingX == rookX2 & kingY != rookY1 & kingY != rookY2) || (kingX != rookX1 & kingX != rookX2 & kingY != rookY1 & kingY == rookY2))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        /**
         * Средняя (2 балла)
         *
         * Треугольник задан длинами своих сторон a, b, c.
         * Проверить, является ли данный треугольник остроугольным (вернуть 0),
         * прямоугольным (вернуть 1) или тупоугольным (вернуть 2).
         * Если такой треугольник не существует, вернуть -1.
         */
        public static int TriangleKind(double a, double b, double c)
        {

            if(a + b <= c || a + c <= b || b + c <= a)
            {
                return -1;
            }
          else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                return 1;
            }
            else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Тривиальная (1 балла)
         *
         * Найти число Фибоначчи из ряда 1, 1, 2, 3, 5, 8, 13, 21, ... с номером n.
         * Ряд Фибоначчи определён следующим образом: fib(1) = 1, fib(2) = 1, fib(n+2) = fib(n) + fib(n+1)
         */
        public static int Fibonacci(int n)
        {
            int fib = 0;
            int fib2 = 1;
            int Tot = 0;

            for (int i = 0; i < n; i++)
            {
                Tot = fib + fib2;
                fib = fib2;
                fib2 = Tot;
            }

            return fib;
           
        }

        /**
         * Простая (2 балла)
         *
         * Для заданного числа n > 1 найти минимальный делитель, превышающий 1
         */
        public static int MinDivisor(int n)
        {
            int tot = 0;
            for (int i = 2; i <= n; i++)
            {
                int k;
                k = n % i;


                if (k == 0)
                {
                    tot = i;
                    break;
                }
            }
            return tot;

        }
            /**
             * Средняя (2 балла)
             *
             * Поменять порядок цифр заданного числа n на обратный: 13478 -> 87431.
             *
             * Использовать операции со строками в этой задаче запрещается!
             */
        public static int Revert(int n)
            {
            int r = 0;
            for (;n > 0 ;)
            {
                r = r * 10 + n % 10;
                n /= 10;
            }
            return r;
           }
        }
    }
