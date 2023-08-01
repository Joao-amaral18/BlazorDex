namespace BlazorDex.Utils
{
    public static class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            string color = type switch
            {
                "normal" => "bg-gray-100 dark:bg-gray-900",
                "fire" => "bg-red-100 dark:bg-red-900",
                "water" => "bg-blue-100 dark:bg-blue-900",
                "electric" => "bg-yellow-100 dark:bg-yellow-900",
                "grass" => "bg-green-100 dark:bg-green-900",
                "ice" => "bg-teal-100 dark:bg-teal-900",
                "fighting" => "bg-red-600 dark:bg-red-800",
                "poison" => "bg-purple-100 dark:bg-purple-900",
                "ground" => "bg-yellow-600 dark:bg-yellow-800",
                "flying" => "bg-indigo-100 dark:bg-indigo-900",
                "psychic" => "bg-pink-100 dark:bg-pink-900",
                "bug" => "bg-blue-200 dark:bg-blue-800",
                "rock" => "bg-gray-700 dark:bg-gray-800",
                "ghost" => "bg-indigo-800 dark:bg-indigo-700",
                "dragon" => "bg-blue-800 dark:bg-blue-700",
                "dark" => "bg-gray-800 dark:bg-gray-700",
                "steel" => "bg-gray-600 dark:bg-gray-700",
                "fairy" => "bg-pink-300 800 dark:bg-pink-700",
                _ => "bg-gray-200 dark:bg-gray-200"
            };
            return color;
        }
    }
}