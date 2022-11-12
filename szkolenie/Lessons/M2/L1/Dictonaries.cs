using course_alx.Lessons.M2.L1.ClassesAndEnums;

namespace course_alx.Lessons.M2.L1
{
    public class Dictonaries
    {
        public static void Run()
        {
            var fruitDictonary = new Dictionary<int, string>()
            {
                { 1, "Banana" },
                { 2, "Apple" },
                { 3, "Guanabana" },
                { 4, "Strawberry" },
                { 5, "Melon" },
                { 6, "Tomato" },
                { 7, "Kiwi" },
                { 8, "Peach" },
                { 9, "Blueberry" },
                { 10, "Pineapple" },
                { 11, "Watermelon" },
            };
            Console.WriteLine(fruitDictonary[1]);
            fruitDictonary.Add(1, "Raspberry");
        }
        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name = "abc@gmail.com",
                Role = "Data contractor"
            };

            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\tname: {user.Name}\n\trole: {user.Role}");
         }

        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictonary = new Dictionary<string, UserRoles>()
            {
                {"administrator", UserRoles.ADMINISTRATOR },
                {"user", UserRoles.USER },
                {"supervisor", UserRoles.SUPERVISOR },
                {"datacontractor", UserRoles.DATA_CONTRACTOR },
            };

            var roleFromDTO = userDTO.Role
                .ToLower()
                .Replace(" ", "");

            user.Role = mapDictonary[roleFromDTO];

            return user;
        }
    }
}
