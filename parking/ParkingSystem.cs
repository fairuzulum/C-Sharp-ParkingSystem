namespace parking;

public class ParkingSystem
{
    private List<Vehicle> _parkingSlot;
    private int _capacity;
    private bool _created = false;

    public ParkingSystem()
    {
        
    }

    public void CreateParkingPlace(int count)
    {
        _capacity = count;
        _parkingSlot = new List<Vehicle>(_capacity);
        for (int i = 0; i < count; i++)
        {
            _parkingSlot.Add(null);
        }

        _created = true;
        Console.WriteLine($"Created a parking lot with {count} slots");
    }

    public void VehicleParking(string policeNumber, string color, string vehicleType)
    {
        if (!_created)
        {
            Console.WriteLine("Parking area not been created!!!");
            return;
        }
        
        for (int i = 0; i < _capacity; i++)
        {
            if (_parkingSlot[i] == null)
            {
                _parkingSlot[i] = new Vehicle
                {
                    SlotNumber = i + 1,
                    PoliceNumber = policeNumber,
                    Color = color,
                    VehicleType = vehicleType
                };
                Console.WriteLine($"Allocated slot number: {i + 1}");
                return;
            }
        }
        Console.WriteLine("Sorry, parking lot is full");
    }

    public void ParkingQuit(int slotNumber)
    {
        if (slotNumber > _capacity || _parkingSlot[slotNumber - 1] == null)
        {
            Console.WriteLine($"Slot number {slotNumber} is free");
        }
        else
        {
            _parkingSlot[slotNumber - 1] = null;
            Console.WriteLine($"Slot number {slotNumber} free now");
        }
    }

    public void StatusReport()
    {
        Console.WriteLine("Slot\tNo.\t\tType\tRegistration No Color");
        for (int i = 0; i < _capacity; i++)
        {
            if (_parkingSlot[i] != null)
            {
                Console.WriteLine($"{i + 1}\t{_parkingSlot[i].PoliceNumber}\t{_parkingSlot[i].VehicleType}\t{_parkingSlot[i].Color}");
            }
        }
    }

    public void VehicleType(string vehicleType)
    {
        int count = _parkingSlot.Count(x => x != null && x.VehicleType == vehicleType);
        Console.WriteLine(count);
    }

    public void EvenAndOdd(bool check)
    {
        var vehicle = _parkingSlot.Where(x => x != null && ((check && int.Parse(x.PoliceNumber.Split('-')[1]) % 2 != 0) || (!check && int.Parse(x.PoliceNumber.Split('-')[1]) % 2 == 0))).Select(x => x.PoliceNumber);
        Console.WriteLine(string.Join(" ", vehicle));
    }

    public void VehicleColor(string color)
    {
        var vehicle = _parkingSlot.Where(x => x != null && x.Color == color).Select(x => x.PoliceNumber);
        Console.WriteLine(string.Join(" ", vehicle));
    }

    public void SlotVehicleColor(string color)
    {
        var slot = _parkingSlot.Where(x => x != null && x.Color == color).Select(x => x.SlotNumber);
        Console.WriteLine(string.Join(", ", slot));
    }

    public void SlotForPoliceNumber(string policeNumber)
    {
        var slot = _parkingSlot.FirstOrDefault(x => x != null && x.PoliceNumber == policeNumber)?.SlotNumber;
        if (slot != null)
        {
            Console.WriteLine(slot);
        }
        else
        {
            Console.WriteLine("Not Found");
        }
    }
    
    
}