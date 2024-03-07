using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========== Mid Monthly Exam 4 =============");
                Console.WriteLine();
                Console.WriteLine("=========== 1280860 Mohiuddin =============");

                Console.WriteLine();

                DoTask();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("Seven ways to start Task in C#");
            Console.WriteLine("Factory Method");
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("This task is created using factory method");
            });

            Console.WriteLine("-------Action-----------");
            Task actionTask = new Task(new Action(CreateTaskUsingAction));
            actionTask.Wait(1000);
            actionTask.Start();
            Console.WriteLine();


            Console.WriteLine("-------Delegate-----------");
            Task delegateTask = new Task(delegate { CreateTaskUsingDelegate(); });
            delegateTask.Wait(1000);
            delegateTask.Start();

            Console.WriteLine();
            Console.WriteLine("-------Lambda-----------");
            Task lambdaTask = new Task(() => CreateTaskUsinglambda());
            lambdaTask.Wait(1000);
            lambdaTask.Start();

            Console.WriteLine();
            Console.WriteLine("-------Lambda Annonymous-----------");
            Task lambdaAnnonymous = new Task(() =>
            {
                CreateMethodWithLambdaAndAnnonymous();
            });
            lambdaAnnonymous.Wait(1000);
            lambdaAnnonymous.Start();


            Console.WriteLine();
            Console.WriteLine("-------Async and await---------");
            CreateAsyncTask();

            Console.WriteLine();
            Console.WriteLine("--------From Another Result---------");
            Console.WriteLine("\nEnter first Number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Second Number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            SolveProblem(firstNum, secondNum);
        }

        private static async void SolveProblem(int firstNum, int secondNum)
        {
            int result = await Task.FromResult(Add(firstNum, secondNum));
            Console.WriteLine($"Result is {result}");
        }

        private static int Add(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        private static async void CreateAsyncTask()
        {
            await Task.Run(() =>
            {
                CreateTaskUsingAsync();
            });

        }

        private static void CreateTaskUsingAsync()
        {
            Console.WriteLine("This task is using Async ");
        }

        private static void CreateMethodWithLambdaAndAnnonymous()
        {
            Console.WriteLine("This task is using Lambda And Annonymous ");
        }

        private static void CreateTaskUsinglambda()
        {
            Console.WriteLine("This task is using lambda ");
        }

        private static void CreateTaskUsingDelegate()
        {
            Console.WriteLine("This task is using Delegate");
        }

        private static void CreateTaskUsingAction()
        {
            Console.WriteLine("This task is using Action method");
        }
    }
}
