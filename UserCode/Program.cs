using UserCode.TransportService.Contract;

namespace UserCode;

public class Program{


    public void Book(TransportType transporterType, string parcel)
    {
        var transport = CargoTransportFactory.CreateTransport(transporterType);
        transport.Book(parcel);
    }
}