using System;
using CartridgeWriter;

namespace CartridgeWriterForms
{
    public interface ICartridge
    {
        byte[] Encrypted { get; }
        byte[] EEPROMUID { get; }
        double SerialNumber { get; set; }
        Material Material { get; set; }
        string ManufacturingLot { get; set; }
        DateTime ManfuacturingDate { get; set; }
        DateTime UseDate { get; set; }
        double InitialMaterialQuantity { get; set; }
        double CurrentMaterialQuantity { get; set; }
        string KeyFragment { get; }
        ushort Version { get; set; }
        string Signature { get; set; }
    }
}
