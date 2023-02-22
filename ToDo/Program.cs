namespace Learning
{
    internal class ToDo
    {
        private static List<string> ListOfToDos { get; set; } = new List<string>();

        public static void Main(string[] args)
        {
            MenuOptions menuSelected;

            do
            {
                menuSelected = ShowInitialMenu();

                if (menuSelected == MenuOptions.Add) ShowMenuAddToDo();
                if (menuSelected == MenuOptions.View) ShowMenuViewToDos();
                if (menuSelected == MenuOptions.Remove) ShowMenuRemoveToDo();
            } while (menuSelected != MenuOptions.Exit);
        } 

        private static MenuOptions ShowInitialMenu()
        {
            Console.WriteLine("Escoge una opción para poder continuar:");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            string? optionSelected = Console.ReadLine();

            if (optionSelected == null) return MenuOptions.Exit;
            return (MenuOptions) Enum.Parse(typeof(MenuOptions), optionSelected);
        }

        public static void ShowMenuAddToDo()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea:");
                string? task = Console.ReadLine();

                if (task == null) throw new Exception("La tarea no puede ser un campo NULL.");

                ListOfToDos.Add(task);
                Console.WriteLine("¡Tarea registrada!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("¡Error con el registro de la tarea!");
                Console.WriteLine(exception.Message);
            }
        }

        public static void ShowMenuRemoveToDo()
        {
            try
            {
                if (CheckIfListOfTodosIsEmpty()) return;

                Console.WriteLine("Ingrese el número de la tarea a remover:");

                ShowListToDos();

                int optionToDoSelected = Convert.ToInt32(Console.ReadLine()) - 1;

                if (optionToDoSelected < -1 || optionToDoSelected >= ListOfToDos.Count || ListOfToDos.Count < 0) return;

                string toDo = ListOfToDos[optionToDoSelected];
                ListOfToDos.RemoveAt(optionToDoSelected);

                Console.WriteLine("¡Tarea \"" + toDo + "\" eliminada!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("¡Error con la eliminación de la tarea!");
                Console.WriteLine(exception.Message);
            }
        }

        public static void ShowMenuViewToDos()
        {
            try
            {
                if (!CheckIfListOfTodosIsEmpty()) ShowListToDos();
            }
            catch (Exception exception)
            {
                Console.WriteLine("¡Se generó una excepción al momento de visualizar el listado de tareas!");
                Console.WriteLine(exception.Message);
            }
        }

        private static bool CheckIfListOfTodosIsEmpty()
        {
            bool isEmpty;

            if (ListOfToDos?.Count > 0)
            {
                isEmpty = false;
            }
            else
            {
                isEmpty = true;
                Console.WriteLine("No hay tareas disponibles para visualizar.");
            }

            return isEmpty;
        }

        private static void ShowListToDos()
        {
            int positionToDo = 1;

            Console.WriteLine("----------------------------------------");

            ListOfToDos.ForEach((toDo) =>
            {
                Console.WriteLine($"{positionToDo}. {toDo}");
                positionToDo++;
            });

            Console.WriteLine("----------------------------------------");
        }

        public enum MenuOptions
        {
            Add = 1,
            Remove = 2,
            View = 3,
            Exit = 4,
        }
    }
}