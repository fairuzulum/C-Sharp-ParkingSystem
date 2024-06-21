namespace parking;

public class Program
    {
        public static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem();

            while (true)
            {
                string input = Console.ReadLine();
                string[] intruction = input.Split(' ');

                switch (intruction[0])
                {
                    case "create_parking_lot":
                        int slotCount = int.Parse(intruction[1]);
                        parkingSystem.CreateParkingPlace(slotCount);
                        break;

                    case "park":
                        string policeNumber = intruction[1];
                        string color = intruction[2];
                        string vehicleType = intruction[3];
                        parkingSystem.VehicleParking(policeNumber, color, vehicleType);
                        break;

                    case "leave":
                        int slotNumber = int.Parse(intruction[1]);
                        parkingSystem.ParkingQuit(slotNumber);
                        break;

                    case "status":
                        parkingSystem.StatusReport();
                        break;

                    case "type_of_vehicles":
                        string type = intruction[1];
                        parkingSystem.VehicleType(type);
                        break;

                    case "registration_numbers_for_vehicles_with_ood_plate":
                        parkingSystem.EvenAndOdd(true);
                        break;

                    case "registration_numbers_for_vehicles_with_event_plate":
                        parkingSystem.EvenAndOdd(false);
                        break;

                    case "registration_numbers_for_vehicles_with_colour":
                        string vehicleColor = intruction[1];
                        parkingSystem.VehicleColor(vehicleColor);
                        break;

                    case "slot_numbers_for_vehicles_with_colour":
                        string slotColor = intruction[1];
                        parkingSystem.SlotVehicleColor(slotColor);
                        break;

                    case "slot_number_for_registration_number":
                        string number = intruction[1];
                        parkingSystem.SlotForPoliceNumber(number);
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("Intruction Not Found");
                        break;
                }
            }
        }
    }