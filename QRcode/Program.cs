namespace QRcode;
using System;
using IronBarCode;

class Program
{
    static void Main(string[] args)
    {
        GeneratedBarcode barcode = IronBarCode.BarcodeWriter.CreateBarcode("Salom23", BarcodeEncoding.QRCode);
        barcode.AddAnnotationTextAboveBarcode("My QR code:");
        barcode.AddBarcodeValueTextBelowBarcode();
        barcode.SaveAsPng("barcode.png");

    }
}

