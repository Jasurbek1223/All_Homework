﻿using N42___T1.Models;

var fillerService = new FuelFillerService();
var fuelStationService = new FuelStationService(fillerService);

var random = new Random();
var cars = new List<Car>();
for(var index = 0; index < 100; index++)
    cars.Add(new Car
    {
        FuelLiters = random.Next(30,60)
    });

var balance = await fuelStationService.Start(cars);
Console.WriteLine(balance);
Console.ReadLine();

// SemaphoreExample.Execute();