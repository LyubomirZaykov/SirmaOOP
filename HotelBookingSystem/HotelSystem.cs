using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    class HotelSystem
    {
        Dictionary<string, RoomType> roomTypes = new Dictionary<string, RoomType>();
        List<Room> rooms = new List<Room>();
        List<User> users = new List<User>();
        User currentUser = null;

        const string roomTypesFile = "room_types.csv";
        const string roomsFile = "rooms.txt";
        const string usersFile = "users.txt";

        public void Run()
        {
            LoadRoomTypes();
            LoadRooms();
            LoadUsers();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Register\n2. Login\n3. Exit");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    Register();
                }

                else if (choice == "2")
                {
                    Login();
                }
                else
                {
                    break;
                }
            }
        }

        void LoadRoomTypes()
        {
            if (!File.Exists(roomTypesFile)) return;
            foreach (var line in File.ReadAllLines(roomTypesFile).Skip(1))
            {
                var parts = line.Split(',');
                roomTypes[parts[0]] = new RoomType
                {
                    Type = parts[0],
                    PricePerNight = double.Parse(parts[1]),
                    CancellationFee = double.Parse(parts[2]),
                    Amenities = parts[3],
                    MaxOccupancy = int.Parse(parts[4])
                };
            }
        }

        void LoadRooms()
        {
            if (!File.Exists(roomsFile)) return;
            foreach (var line in File.ReadAllLines(roomsFile))
            {
                var parts = line.Split(',');
                rooms.Add(new Room
                {
                    Number = int.Parse(parts[0]),
                    Type = parts[1],
                    IsBooked = bool.Parse(parts[2])
                });
            }
        }

        void LoadUsers()
        {
            if (!File.Exists(usersFile)) return;
            foreach (var line in File.ReadAllLines(usersFile))
            {
                var parts = line.Split(',');
                users.Add(new User { Username = parts[0], Password = parts[1] });
            }
        }

        void SaveRooms() => File.WriteAllLines(roomsFile, rooms.Select(r => $"{r.Number},{r.Type},{r.IsBooked}"));
        void SaveUsers() => File.WriteAllLines(usersFile, users.Select(u => $"{u.Username},{u.Password}"));

        void Register()
        {
            Console.Write("Username: "); var username = Console.ReadLine();
            Console.Write("Password: "); var password = Console.ReadLine();
            users.Add(new User { Username = username, Password = password });
            SaveUsers();
        }

        void Login()
        {
            Console.Write("Username: "); var username = Console.ReadLine();
            Console.Write("Password: "); var password = Console.ReadLine();

            currentUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (currentUser != null)
            {
                UserMenu();
            }
            else
            {
                Console.WriteLine("Login failed. Press any key.");
                Console.ReadKey();
            }
        }

        void UserMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Welcome, {currentUser.Username}");
                Console.WriteLine("1. View Rooms\n2. Book Room\n3. Logout");
                var choice = Console.ReadLine();

                if (choice == "1") ViewRooms();
                else if (choice == "2") BookRoom();
                else break;
            }
        }

        void ViewRooms()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        void BookRoom()
        {
            Console.WriteLine("Enter Room Type (Deluxe, Suite, Single, Double): ");
            var type = Console.ReadLine();

            if (!roomTypes.ContainsKey(type))
            {
                Console.WriteLine("Invalid room type.");
                Console.ReadKey();
                return;
            }

            Console.Write("Start Date (yyyy-MM-dd): ");
            var start = DateTime.Parse(Console.ReadLine());
            Console.Write("End Date (yyyy-MM-dd): ");
            var end = DateTime.Parse(Console.ReadLine());

            var availableRoom = rooms.FirstOrDefault(r => r.Type == type && !r.IsBooked);
            if (availableRoom == null)
            {
                Console.WriteLine("No available rooms of this type.");
                Console.ReadKey();
                return;
            }

            var days = (end - start).Days;
            var price = days * roomTypes[type].PricePerNight;

            Console.WriteLine($"Book Room {availableRoom.Number} for ${price}? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                availableRoom.IsBooked = true;
                SaveRooms();
                currentUser.Bookings.Add(new Booking { Username = currentUser.Username, RoomNumber = availableRoom.Number, StartDate = start, EndDate = end, TotalPrice = price });
                Console.WriteLine("Booking successful.");
            }
            Console.ReadKey();
        }
    }
}
