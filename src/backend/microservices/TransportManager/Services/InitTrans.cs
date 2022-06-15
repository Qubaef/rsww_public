using MongoDB.Driver;
using Shared.DataModels.Transport;

namespace TransportManager.Services
{
    public static class InitTrans
    {
        public static void CreateSampleData(TransportContext context)
        {
            if (context.TransportCollection.Find(x => true).ToList().Count != 0)
            {
                return;
            }

            var transports = new TransportDataModel[]
 {
new()
{
Id = 1, AllSeats = 27, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Albania", Price = 140, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 2, AllSeats = 27, DateTime = DateTime.Parse("2022-06-12"), From = "Albania", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 3, AllSeats = 65, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Albania", Price = 114, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 4, AllSeats = 65, DateTime = DateTime.Parse("2022-06-12"), From = "Albania", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 5, AllSeats = 65, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Albania", Price = 70, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 6, AllSeats = 65, DateTime = DateTime.Parse("2022-06-12"), From = "Albania", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 7, AllSeats = 96, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Bulgaria", Price = 105, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 8, AllSeats = 96, DateTime = DateTime.Parse("2022-06-12"), From = "Bulgaria", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 9, AllSeats = 37, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Bulgaria", Price = 143, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 10, AllSeats = 37, DateTime = DateTime.Parse("2022-06-12"), From = "Bulgaria", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 11, AllSeats = 38, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Bulgaria", Price = 76, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 12, AllSeats = 38, DateTime = DateTime.Parse("2022-06-12"), From = "Bulgaria", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 13, AllSeats = 92, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Czarnogora", Price = 53, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 14, AllSeats = 92, DateTime = DateTime.Parse("2022-06-12"), From = "Czarnogora", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 15, AllSeats = 39, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Czarnogora", Price = 146, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 16, AllSeats = 39, DateTime = DateTime.Parse("2022-06-12"), From = "Czarnogora", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 17, AllSeats = 85, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Czarnogora", Price = 60, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 18, AllSeats = 85, DateTime = DateTime.Parse("2022-06-12"), From = "Czarnogora", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 19, AllSeats = 41, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Egipt", Price = 110, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 20, AllSeats = 41, DateTime = DateTime.Parse("2022-06-12"), From = "Egipt", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 21, AllSeats = 37, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Egipt", Price = 83, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 22, AllSeats = 37, DateTime = DateTime.Parse("2022-06-12"), From = "Egipt", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 23, AllSeats = 75, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Egipt", Price = 129, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 24, AllSeats = 75, DateTime = DateTime.Parse("2022-06-12"), From = "Egipt", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 25, AllSeats = 96, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Grecja", Price = 70, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 26, AllSeats = 96, DateTime = DateTime.Parse("2022-06-12"), From = "Grecja", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 27, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Grecja", Price = 66, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 28, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Grecja", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 29, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Grecja", Price = 99, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 30, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Grecja", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 31, AllSeats = 60, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Gruzja", Price = 59, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 32, AllSeats = 60, DateTime = DateTime.Parse("2022-06-12"), From = "Gruzja", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 33, AllSeats = 64, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Gruzja", Price = 84, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 34, AllSeats = 64, DateTime = DateTime.Parse("2022-06-12"), From = "Gruzja", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 35, AllSeats = 61, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Gruzja", Price = 131, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 36, AllSeats = 61, DateTime = DateTime.Parse("2022-06-12"), From = "Gruzja", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 37, AllSeats = 62, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Madera", Price = 51, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 38, AllSeats = 62, DateTime = DateTime.Parse("2022-06-12"), From = "Madera", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 39, AllSeats = 28, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Madera", Price = 107, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 40, AllSeats = 28, DateTime = DateTime.Parse("2022-06-12"), From = "Madera", To = "Gdansk", Price = 99, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 41, AllSeats = 61, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Madera", Price = 113, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 42, AllSeats = 61, DateTime = DateTime.Parse("2022-06-12"), From = "Madera", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 43, AllSeats = 25, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malediwy", Price = 54, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 44, AllSeats = 25, DateTime = DateTime.Parse("2022-06-12"), From = "Malediwy", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 45, AllSeats = 58, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malediwy", Price = 112, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 46, AllSeats = 58, DateTime = DateTime.Parse("2022-06-12"), From = "Malediwy", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 47, AllSeats = 75, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malediwy", Price = 108, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 48, AllSeats = 75, DateTime = DateTime.Parse("2022-06-12"), From = "Malediwy", To = "Gdansk", Price = 98, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 49, AllSeats = 69, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malta", Price = 115, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 50, AllSeats = 69, DateTime = DateTime.Parse("2022-06-12"), From = "Malta", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 51, AllSeats = 72, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malta", Price = 84, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 52, AllSeats = 72, DateTime = DateTime.Parse("2022-06-12"), From = "Malta", To = "Gdansk", Price = 89, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 53, AllSeats = 98, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Malta", Price = 88, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 54, AllSeats = 98, DateTime = DateTime.Parse("2022-06-12"), From = "Malta", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 55, AllSeats = 34, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Mauritius", Price = 99, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 56, AllSeats = 34, DateTime = DateTime.Parse("2022-06-12"), From = "Mauritius", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 57, AllSeats = 100, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Mauritius", Price = 138, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 58, AllSeats = 100, DateTime = DateTime.Parse("2022-06-12"), From = "Mauritius", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 59, AllSeats = 81, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Mauritius", Price = 66, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 60, AllSeats = 81, DateTime = DateTime.Parse("2022-06-12"), From = "Mauritius", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 61, AllSeats = 86, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Meksyk", Price = 81, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 62, AllSeats = 86, DateTime = DateTime.Parse("2022-06-12"), From = "Meksyk", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 63, AllSeats = 76, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Meksyk", Price = 100, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 64, AllSeats = 76, DateTime = DateTime.Parse("2022-06-12"), From = "Meksyk", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 65, AllSeats = 50, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Meksyk", Price = 93, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 66, AllSeats = 50, DateTime = DateTime.Parse("2022-06-12"), From = "Meksyk", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 67, AllSeats = 83, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Seszele", Price = 129, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 68, AllSeats = 83, DateTime = DateTime.Parse("2022-06-12"), From = "Seszele", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 69, AllSeats = 85, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Seszele", Price = 115, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 70, AllSeats = 85, DateTime = DateTime.Parse("2022-06-12"), From = "Seszele", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 71, AllSeats = 50, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Seszele", Price = 121, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 72, AllSeats = 50, DateTime = DateTime.Parse("2022-06-12"), From = "Seszele", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 73, AllSeats = 49, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Slowenia", Price = 106, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 74, AllSeats = 49, DateTime = DateTime.Parse("2022-06-12"), From = "Slowenia", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 75, AllSeats = 52, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Slowenia", Price = 125, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 76, AllSeats = 52, DateTime = DateTime.Parse("2022-06-12"), From = "Slowenia", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 77, AllSeats = 46, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Slowenia", Price = 125, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 78, AllSeats = 46, DateTime = DateTime.Parse("2022-06-12"), From = "Slowenia", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 79, AllSeats = 40, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Turcja", Price = 65, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 80, AllSeats = 40, DateTime = DateTime.Parse("2022-06-12"), From = "Turcja", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 81, AllSeats = 38, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Turcja", Price = 91, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 82, AllSeats = 38, DateTime = DateTime.Parse("2022-06-12"), From = "Turcja", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 83, AllSeats = 62, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Turcja", Price = 107, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 84, AllSeats = 62, DateTime = DateTime.Parse("2022-06-12"), From = "Turcja", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 85, AllSeats = 68, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 145, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 86, AllSeats = 68, DateTime = DateTime.Parse("2022-06-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 87, AllSeats = 42, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 72, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 88, AllSeats = 42, DateTime = DateTime.Parse("2022-06-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 89, AllSeats = 55, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 117, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 90, AllSeats = 55, DateTime = DateTime.Parse("2022-06-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 91, AllSeats = 88, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Zanzibar", Price = 138, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 92, AllSeats = 88, DateTime = DateTime.Parse("2022-06-12"), From = "Zanzibar", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 93, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Zanzibar", Price = 70, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 94, AllSeats = 90, DateTime = DateTime.Parse("2022-06-12"), From = "Zanzibar", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 95, AllSeats = 30, DateTime = DateTime.Parse("2022-06-12"), From = "Gdansk", To = "Zanzibar", Price = 114, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 96, AllSeats = 30, DateTime = DateTime.Parse("2022-06-12"), From = "Zanzibar", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 97, AllSeats = 28, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Albania", Price = 106, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 98, AllSeats = 28, DateTime = DateTime.Parse("2022-06-13"), From = "Albania", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 99, AllSeats = 81, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Albania", Price = 53, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 100, AllSeats = 81, DateTime = DateTime.Parse("2022-06-13"), From = "Albania", To = "Gdansk", Price = 92, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 101, AllSeats = 47, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Albania", Price = 126, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 102, AllSeats = 47, DateTime = DateTime.Parse("2022-06-13"), From = "Albania", To = "Gdansk", Price = 112, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 103, AllSeats = 27, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Bulgaria", Price = 149, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 104, AllSeats = 27, DateTime = DateTime.Parse("2022-06-13"), From = "Bulgaria", To = "Gdansk", Price = 149, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 105, AllSeats = 43, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Bulgaria", Price = 100, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 106, AllSeats = 43, DateTime = DateTime.Parse("2022-06-13"), From = "Bulgaria", To = "Gdansk", Price = 71, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 107, AllSeats = 60, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Bulgaria", Price = 99, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 108, AllSeats = 60, DateTime = DateTime.Parse("2022-06-13"), From = "Bulgaria", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 109, AllSeats = 95, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Czarnogora", Price = 137, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 110, AllSeats = 95, DateTime = DateTime.Parse("2022-06-13"), From = "Czarnogora", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 111, AllSeats = 68, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Czarnogora", Price = 103, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 112, AllSeats = 68, DateTime = DateTime.Parse("2022-06-13"), From = "Czarnogora", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 113, AllSeats = 30, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Czarnogora", Price = 92, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 114, AllSeats = 30, DateTime = DateTime.Parse("2022-06-13"), From = "Czarnogora", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 115, AllSeats = 56, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Egipt", Price = 134, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 116, AllSeats = 56, DateTime = DateTime.Parse("2022-06-13"), From = "Egipt", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 117, AllSeats = 33, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Egipt", Price = 109, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 118, AllSeats = 33, DateTime = DateTime.Parse("2022-06-13"), From = "Egipt", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 119, AllSeats = 74, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Egipt", Price = 78, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 120, AllSeats = 74, DateTime = DateTime.Parse("2022-06-13"), From = "Egipt", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 121, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Grecja", Price = 139, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 122, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Grecja", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 123, AllSeats = 35, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Grecja", Price = 107, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 124, AllSeats = 35, DateTime = DateTime.Parse("2022-06-13"), From = "Grecja", To = "Gdansk", Price = 89, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 125, AllSeats = 62, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Grecja", Price = 58, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 126, AllSeats = 62, DateTime = DateTime.Parse("2022-06-13"), From = "Grecja", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 127, AllSeats = 96, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Gruzja", Price = 83, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 128, AllSeats = 96, DateTime = DateTime.Parse("2022-06-13"), From = "Gruzja", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 129, AllSeats = 34, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Gruzja", Price = 93, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 130, AllSeats = 34, DateTime = DateTime.Parse("2022-06-13"), From = "Gruzja", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 131, AllSeats = 47, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Gruzja", Price = 57, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 132, AllSeats = 47, DateTime = DateTime.Parse("2022-06-13"), From = "Gruzja", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 133, AllSeats = 52, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Madera", Price = 146, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 134, AllSeats = 52, DateTime = DateTime.Parse("2022-06-13"), From = "Madera", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 135, AllSeats = 25, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Madera", Price = 51, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 136, AllSeats = 25, DateTime = DateTime.Parse("2022-06-13"), From = "Madera", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 137, AllSeats = 67, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Madera", Price = 131, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 138, AllSeats = 67, DateTime = DateTime.Parse("2022-06-13"), From = "Madera", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 139, AllSeats = 37, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malediwy", Price = 77, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 140, AllSeats = 37, DateTime = DateTime.Parse("2022-06-13"), From = "Malediwy", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 141, AllSeats = 55, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malediwy", Price = 70, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 142, AllSeats = 55, DateTime = DateTime.Parse("2022-06-13"), From = "Malediwy", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 143, AllSeats = 68, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malediwy", Price = 134, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 144, AllSeats = 68, DateTime = DateTime.Parse("2022-06-13"), From = "Malediwy", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 145, AllSeats = 48, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malta", Price = 87, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 146, AllSeats = 48, DateTime = DateTime.Parse("2022-06-13"), From = "Malta", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 147, AllSeats = 87, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malta", Price = 135, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 148, AllSeats = 87, DateTime = DateTime.Parse("2022-06-13"), From = "Malta", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 149, AllSeats = 93, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Malta", Price = 74, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 150, AllSeats = 93, DateTime = DateTime.Parse("2022-06-13"), From = "Malta", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 151, AllSeats = 77, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Mauritius", Price = 122, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 152, AllSeats = 77, DateTime = DateTime.Parse("2022-06-13"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 153, AllSeats = 50, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Mauritius", Price = 96, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 154, AllSeats = 50, DateTime = DateTime.Parse("2022-06-13"), From = "Mauritius", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 155, AllSeats = 73, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Mauritius", Price = 51, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 156, AllSeats = 73, DateTime = DateTime.Parse("2022-06-13"), From = "Mauritius", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 157, AllSeats = 43, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Meksyk", Price = 82, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 158, AllSeats = 43, DateTime = DateTime.Parse("2022-06-13"), From = "Meksyk", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 159, AllSeats = 62, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Meksyk", Price = 85, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 160, AllSeats = 62, DateTime = DateTime.Parse("2022-06-13"), From = "Meksyk", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 161, AllSeats = 75, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Meksyk", Price = 117, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 162, AllSeats = 75, DateTime = DateTime.Parse("2022-06-13"), From = "Meksyk", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 163, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Seszele", Price = 78, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 164, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Seszele", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 165, AllSeats = 71, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Seszele", Price = 67, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 166, AllSeats = 71, DateTime = DateTime.Parse("2022-06-13"), From = "Seszele", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 167, AllSeats = 32, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Seszele", Price = 124, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 168, AllSeats = 32, DateTime = DateTime.Parse("2022-06-13"), From = "Seszele", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 169, AllSeats = 32, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Slowenia", Price = 82, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 170, AllSeats = 32, DateTime = DateTime.Parse("2022-06-13"), From = "Slowenia", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 171, AllSeats = 29, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Slowenia", Price = 96, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 172, AllSeats = 29, DateTime = DateTime.Parse("2022-06-13"), From = "Slowenia", To = "Gdansk", Price = 92, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 173, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Slowenia", Price = 105, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 174, AllSeats = 41, DateTime = DateTime.Parse("2022-06-13"), From = "Slowenia", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 175, AllSeats = 54, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Turcja", Price = 111, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 176, AllSeats = 54, DateTime = DateTime.Parse("2022-06-13"), From = "Turcja", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 177, AllSeats = 45, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Turcja", Price = 117, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 178, AllSeats = 45, DateTime = DateTime.Parse("2022-06-13"), From = "Turcja", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 179, AllSeats = 89, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Turcja", Price = 130, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 180, AllSeats = 89, DateTime = DateTime.Parse("2022-06-13"), From = "Turcja", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 181, AllSeats = 84, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 68, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 182, AllSeats = 84, DateTime = DateTime.Parse("2022-06-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 183, AllSeats = 61, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 110, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 184, AllSeats = 61, DateTime = DateTime.Parse("2022-06-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 185, AllSeats = 77, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 102, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 186, AllSeats = 77, DateTime = DateTime.Parse("2022-06-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 187, AllSeats = 84, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Zanzibar", Price = 150, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 188, AllSeats = 84, DateTime = DateTime.Parse("2022-06-13"), From = "Zanzibar", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 189, AllSeats = 54, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Zanzibar", Price = 135, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 190, AllSeats = 54, DateTime = DateTime.Parse("2022-06-13"), From = "Zanzibar", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 191, AllSeats = 73, DateTime = DateTime.Parse("2022-06-13"), From = "Gdansk", To = "Zanzibar", Price = 94, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 192, AllSeats = 73, DateTime = DateTime.Parse("2022-06-13"), From = "Zanzibar", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 193, AllSeats = 80, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Albania", Price = 88, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 194, AllSeats = 80, DateTime = DateTime.Parse("2022-06-14"), From = "Albania", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 195, AllSeats = 80, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Albania", Price = 50, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 196, AllSeats = 80, DateTime = DateTime.Parse("2022-06-14"), From = "Albania", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 197, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Albania", Price = 81, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 198, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Albania", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 199, AllSeats = 51, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Bulgaria", Price = 80, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 200, AllSeats = 51, DateTime = DateTime.Parse("2022-06-14"), From = "Bulgaria", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 201, AllSeats = 28, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Bulgaria", Price = 78, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 202, AllSeats = 28, DateTime = DateTime.Parse("2022-06-14"), From = "Bulgaria", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 203, AllSeats = 50, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Bulgaria", Price = 98, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 204, AllSeats = 50, DateTime = DateTime.Parse("2022-06-14"), From = "Bulgaria", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 205, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Czarnogora", Price = 101, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 206, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Czarnogora", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 207, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Czarnogora", Price = 133, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 208, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Czarnogora", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 209, AllSeats = 49, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Czarnogora", Price = 140, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 210, AllSeats = 49, DateTime = DateTime.Parse("2022-06-14"), From = "Czarnogora", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 211, AllSeats = 78, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Egipt", Price = 56, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 212, AllSeats = 78, DateTime = DateTime.Parse("2022-06-14"), From = "Egipt", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 213, AllSeats = 73, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Egipt", Price = 127, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 214, AllSeats = 73, DateTime = DateTime.Parse("2022-06-14"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 215, AllSeats = 82, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Egipt", Price = 107, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 216, AllSeats = 82, DateTime = DateTime.Parse("2022-06-14"), From = "Egipt", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 217, AllSeats = 47, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Grecja", Price = 145, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 218, AllSeats = 47, DateTime = DateTime.Parse("2022-06-14"), From = "Grecja", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 219, AllSeats = 87, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Grecja", Price = 120, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 220, AllSeats = 87, DateTime = DateTime.Parse("2022-06-14"), From = "Grecja", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 221, AllSeats = 34, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Grecja", Price = 141, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 222, AllSeats = 34, DateTime = DateTime.Parse("2022-06-14"), From = "Grecja", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 223, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Gruzja", Price = 70, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 224, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gruzja", To = "Gdansk", Price = 107, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 225, AllSeats = 92, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Gruzja", Price = 121, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 226, AllSeats = 92, DateTime = DateTime.Parse("2022-06-14"), From = "Gruzja", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 227, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Gruzja", Price = 65, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 228, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gruzja", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 229, AllSeats = 77, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Madera", Price = 86, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 230, AllSeats = 77, DateTime = DateTime.Parse("2022-06-14"), From = "Madera", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 231, AllSeats = 39, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Madera", Price = 125, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 232, AllSeats = 39, DateTime = DateTime.Parse("2022-06-14"), From = "Madera", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 233, AllSeats = 41, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Madera", Price = 82, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 234, AllSeats = 41, DateTime = DateTime.Parse("2022-06-14"), From = "Madera", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 235, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malediwy", Price = 106, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 236, AllSeats = 84, DateTime = DateTime.Parse("2022-06-14"), From = "Malediwy", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 237, AllSeats = 70, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malediwy", Price = 126, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 238, AllSeats = 70, DateTime = DateTime.Parse("2022-06-14"), From = "Malediwy", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 239, AllSeats = 93, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malediwy", Price = 95, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 240, AllSeats = 93, DateTime = DateTime.Parse("2022-06-14"), From = "Malediwy", To = "Gdansk", Price = 94, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 241, AllSeats = 91, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malta", Price = 106, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 242, AllSeats = 91, DateTime = DateTime.Parse("2022-06-14"), From = "Malta", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 243, AllSeats = 71, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malta", Price = 125, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 244, AllSeats = 71, DateTime = DateTime.Parse("2022-06-14"), From = "Malta", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 245, AllSeats = 77, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Malta", Price = 144, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 246, AllSeats = 77, DateTime = DateTime.Parse("2022-06-14"), From = "Malta", To = "Gdansk", Price = 100, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 247, AllSeats = 37, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Mauritius", Price = 142, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 248, AllSeats = 37, DateTime = DateTime.Parse("2022-06-14"), From = "Mauritius", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 249, AllSeats = 69, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Mauritius", Price = 88, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 250, AllSeats = 69, DateTime = DateTime.Parse("2022-06-14"), From = "Mauritius", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 251, AllSeats = 62, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Mauritius", Price = 126, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 252, AllSeats = 62, DateTime = DateTime.Parse("2022-06-14"), From = "Mauritius", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 253, AllSeats = 60, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Meksyk", Price = 89, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 254, AllSeats = 60, DateTime = DateTime.Parse("2022-06-14"), From = "Meksyk", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 255, AllSeats = 48, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Meksyk", Price = 145, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 256, AllSeats = 48, DateTime = DateTime.Parse("2022-06-14"), From = "Meksyk", To = "Gdansk", Price = 121, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 257, AllSeats = 54, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Meksyk", Price = 130, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 258, AllSeats = 54, DateTime = DateTime.Parse("2022-06-14"), From = "Meksyk", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 259, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Seszele", Price = 109, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 260, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Seszele", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 261, AllSeats = 63, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Seszele", Price = 149, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 262, AllSeats = 63, DateTime = DateTime.Parse("2022-06-14"), From = "Seszele", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 263, AllSeats = 93, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Seszele", Price = 82, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 264, AllSeats = 93, DateTime = DateTime.Parse("2022-06-14"), From = "Seszele", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 265, AllSeats = 33, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Slowenia", Price = 131, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 266, AllSeats = 33, DateTime = DateTime.Parse("2022-06-14"), From = "Slowenia", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 267, AllSeats = 83, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Slowenia", Price = 127, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 268, AllSeats = 83, DateTime = DateTime.Parse("2022-06-14"), From = "Slowenia", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 269, AllSeats = 79, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 270, AllSeats = 79, DateTime = DateTime.Parse("2022-06-14"), From = "Slowenia", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 271, AllSeats = 57, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Turcja", Price = 131, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 272, AllSeats = 57, DateTime = DateTime.Parse("2022-06-14"), From = "Turcja", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 273, AllSeats = 82, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 274, AllSeats = 82, DateTime = DateTime.Parse("2022-06-14"), From = "Turcja", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 275, AllSeats = 70, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Turcja", Price = 134, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 276, AllSeats = 70, DateTime = DateTime.Parse("2022-06-14"), From = "Turcja", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 277, AllSeats = 26, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 112, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 278, AllSeats = 26, DateTime = DateTime.Parse("2022-06-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 279, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 66, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 280, AllSeats = 25, DateTime = DateTime.Parse("2022-06-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 281, AllSeats = 45, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 74, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 282, AllSeats = 45, DateTime = DateTime.Parse("2022-06-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 283, AllSeats = 59, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Zanzibar", Price = 140, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 284, AllSeats = 59, DateTime = DateTime.Parse("2022-06-14"), From = "Zanzibar", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 285, AllSeats = 96, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Zanzibar", Price = 96, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 286, AllSeats = 96, DateTime = DateTime.Parse("2022-06-14"), From = "Zanzibar", To = "Gdansk", Price = 116, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 287, AllSeats = 97, DateTime = DateTime.Parse("2022-06-14"), From = "Gdansk", To = "Zanzibar", Price = 122, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 288, AllSeats = 97, DateTime = DateTime.Parse("2022-06-14"), From = "Zanzibar", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 289, AllSeats = 67, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Albania", Price = 136, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 290, AllSeats = 67, DateTime = DateTime.Parse("2022-06-15"), From = "Albania", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 291, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Albania", Price = 124, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 292, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Albania", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 293, AllSeats = 59, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Albania", Price = 106, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 294, AllSeats = 59, DateTime = DateTime.Parse("2022-06-15"), From = "Albania", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 295, AllSeats = 72, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Bulgaria", Price = 104, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 296, AllSeats = 72, DateTime = DateTime.Parse("2022-06-15"), From = "Bulgaria", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 297, AllSeats = 59, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Bulgaria", Price = 61, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 298, AllSeats = 59, DateTime = DateTime.Parse("2022-06-15"), From = "Bulgaria", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 299, AllSeats = 35, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Bulgaria", Price = 150, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 300, AllSeats = 35, DateTime = DateTime.Parse("2022-06-15"), From = "Bulgaria", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 301, AllSeats = 56, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Czarnogora", Price = 95, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 302, AllSeats = 56, DateTime = DateTime.Parse("2022-06-15"), From = "Czarnogora", To = "Gdansk", Price = 73, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 303, AllSeats = 87, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Czarnogora", Price = 55, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 304, AllSeats = 87, DateTime = DateTime.Parse("2022-06-15"), From = "Czarnogora", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 305, AllSeats = 88, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Czarnogora", Price = 72, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 306, AllSeats = 88, DateTime = DateTime.Parse("2022-06-15"), From = "Czarnogora", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 307, AllSeats = 36, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Egipt", Price = 143, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 308, AllSeats = 36, DateTime = DateTime.Parse("2022-06-15"), From = "Egipt", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 309, AllSeats = 34, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Egipt", Price = 78, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 310, AllSeats = 34, DateTime = DateTime.Parse("2022-06-15"), From = "Egipt", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 311, AllSeats = 35, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Egipt", Price = 111, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 312, AllSeats = 35, DateTime = DateTime.Parse("2022-06-15"), From = "Egipt", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 313, AllSeats = 96, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Grecja", Price = 137, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 314, AllSeats = 96, DateTime = DateTime.Parse("2022-06-15"), From = "Grecja", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 315, AllSeats = 54, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Grecja", Price = 107, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 316, AllSeats = 54, DateTime = DateTime.Parse("2022-06-15"), From = "Grecja", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 317, AllSeats = 60, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Grecja", Price = 149, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 318, AllSeats = 60, DateTime = DateTime.Parse("2022-06-15"), From = "Grecja", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 319, AllSeats = 46, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Gruzja", Price = 64, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 320, AllSeats = 46, DateTime = DateTime.Parse("2022-06-15"), From = "Gruzja", To = "Gdansk", Price = 144, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 321, AllSeats = 83, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Gruzja", Price = 109, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 322, AllSeats = 83, DateTime = DateTime.Parse("2022-06-15"), From = "Gruzja", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 323, AllSeats = 69, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Gruzja", Price = 54, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 324, AllSeats = 69, DateTime = DateTime.Parse("2022-06-15"), From = "Gruzja", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 325, AllSeats = 77, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Madera", Price = 99, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 326, AllSeats = 77, DateTime = DateTime.Parse("2022-06-15"), From = "Madera", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 327, AllSeats = 40, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Madera", Price = 58, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 328, AllSeats = 40, DateTime = DateTime.Parse("2022-06-15"), From = "Madera", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 329, AllSeats = 37, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Madera", Price = 104, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 330, AllSeats = 37, DateTime = DateTime.Parse("2022-06-15"), From = "Madera", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 331, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malediwy", Price = 86, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 332, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Malediwy", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 333, AllSeats = 53, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malediwy", Price = 118, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 334, AllSeats = 53, DateTime = DateTime.Parse("2022-06-15"), From = "Malediwy", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 335, AllSeats = 53, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malediwy", Price = 111, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 336, AllSeats = 53, DateTime = DateTime.Parse("2022-06-15"), From = "Malediwy", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 337, AllSeats = 96, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malta", Price = 101, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 338, AllSeats = 96, DateTime = DateTime.Parse("2022-06-15"), From = "Malta", To = "Gdansk", Price = 137, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 339, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malta", Price = 93, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 340, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Malta", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 341, AllSeats = 86, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Malta", Price = 67, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 342, AllSeats = 86, DateTime = DateTime.Parse("2022-06-15"), From = "Malta", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 343, AllSeats = 45, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Mauritius", Price = 120, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 344, AllSeats = 45, DateTime = DateTime.Parse("2022-06-15"), From = "Mauritius", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 345, AllSeats = 47, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Mauritius", Price = 112, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 346, AllSeats = 47, DateTime = DateTime.Parse("2022-06-15"), From = "Mauritius", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 347, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Mauritius", Price = 90, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 348, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Mauritius", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 349, AllSeats = 68, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Meksyk", Price = 100, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 350, AllSeats = 68, DateTime = DateTime.Parse("2022-06-15"), From = "Meksyk", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 351, AllSeats = 48, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Meksyk", Price = 120, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 352, AllSeats = 48, DateTime = DateTime.Parse("2022-06-15"), From = "Meksyk", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 353, AllSeats = 79, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Meksyk", Price = 99, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 354, AllSeats = 79, DateTime = DateTime.Parse("2022-06-15"), From = "Meksyk", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 355, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Seszele", Price = 120, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 356, AllSeats = 97, DateTime = DateTime.Parse("2022-06-15"), From = "Seszele", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 357, AllSeats = 85, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Seszele", Price = 56, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 358, AllSeats = 85, DateTime = DateTime.Parse("2022-06-15"), From = "Seszele", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 359, AllSeats = 91, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Seszele", Price = 138, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 360, AllSeats = 91, DateTime = DateTime.Parse("2022-06-15"), From = "Seszele", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 361, AllSeats = 25, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Slowenia", Price = 117, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 362, AllSeats = 25, DateTime = DateTime.Parse("2022-06-15"), From = "Slowenia", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 363, AllSeats = 64, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Slowenia", Price = 147, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 364, AllSeats = 64, DateTime = DateTime.Parse("2022-06-15"), From = "Slowenia", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 365, AllSeats = 91, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Slowenia", Price = 79, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 366, AllSeats = 91, DateTime = DateTime.Parse("2022-06-15"), From = "Slowenia", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 367, AllSeats = 99, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Turcja", Price = 117, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 368, AllSeats = 99, DateTime = DateTime.Parse("2022-06-15"), From = "Turcja", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 369, AllSeats = 71, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Turcja", Price = 140, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 370, AllSeats = 71, DateTime = DateTime.Parse("2022-06-15"), From = "Turcja", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 371, AllSeats = 81, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Turcja", Price = 80, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 372, AllSeats = 81, DateTime = DateTime.Parse("2022-06-15"), From = "Turcja", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 373, AllSeats = 57, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 77, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 374, AllSeats = 57, DateTime = DateTime.Parse("2022-06-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 375, AllSeats = 68, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 101, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 376, AllSeats = 68, DateTime = DateTime.Parse("2022-06-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 377, AllSeats = 42, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 59, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 378, AllSeats = 42, DateTime = DateTime.Parse("2022-06-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 379, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Zanzibar", Price = 104, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 380, AllSeats = 84, DateTime = DateTime.Parse("2022-06-15"), From = "Zanzibar", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 381, AllSeats = 55, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Zanzibar", Price = 103, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 382, AllSeats = 55, DateTime = DateTime.Parse("2022-06-15"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 383, AllSeats = 99, DateTime = DateTime.Parse("2022-06-15"), From = "Gdansk", To = "Zanzibar", Price = 76, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 384, AllSeats = 99, DateTime = DateTime.Parse("2022-06-15"), From = "Zanzibar", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 385, AllSeats = 62, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Albania", Price = 81, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 386, AllSeats = 62, DateTime = DateTime.Parse("2022-06-16"), From = "Albania", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 387, AllSeats = 95, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Albania", Price = 115, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 388, AllSeats = 95, DateTime = DateTime.Parse("2022-06-16"), From = "Albania", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 389, AllSeats = 52, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Albania", Price = 59, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 390, AllSeats = 52, DateTime = DateTime.Parse("2022-06-16"), From = "Albania", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 391, AllSeats = 39, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Bulgaria", Price = 97, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 392, AllSeats = 39, DateTime = DateTime.Parse("2022-06-16"), From = "Bulgaria", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 393, AllSeats = 98, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Bulgaria", Price = 123, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 394, AllSeats = 98, DateTime = DateTime.Parse("2022-06-16"), From = "Bulgaria", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 395, AllSeats = 65, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Bulgaria", Price = 81, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 396, AllSeats = 65, DateTime = DateTime.Parse("2022-06-16"), From = "Bulgaria", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 397, AllSeats = 51, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Czarnogora", Price = 54, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 398, AllSeats = 51, DateTime = DateTime.Parse("2022-06-16"), From = "Czarnogora", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 399, AllSeats = 26, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Czarnogora", Price = 53, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 400, AllSeats = 26, DateTime = DateTime.Parse("2022-06-16"), From = "Czarnogora", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 401, AllSeats = 62, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Czarnogora", Price = 128, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 402, AllSeats = 62, DateTime = DateTime.Parse("2022-06-16"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 403, AllSeats = 35, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Egipt", Price = 95, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 404, AllSeats = 35, DateTime = DateTime.Parse("2022-06-16"), From = "Egipt", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 405, AllSeats = 43, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Egipt", Price = 93, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 406, AllSeats = 43, DateTime = DateTime.Parse("2022-06-16"), From = "Egipt", To = "Gdansk", Price = 114, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 407, AllSeats = 58, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Egipt", Price = 146, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 408, AllSeats = 58, DateTime = DateTime.Parse("2022-06-16"), From = "Egipt", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 409, AllSeats = 69, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Grecja", Price = 128, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 410, AllSeats = 69, DateTime = DateTime.Parse("2022-06-16"), From = "Grecja", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 411, AllSeats = 27, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Grecja", Price = 54, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 412, AllSeats = 27, DateTime = DateTime.Parse("2022-06-16"), From = "Grecja", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 413, AllSeats = 93, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Grecja", Price = 107, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 414, AllSeats = 93, DateTime = DateTime.Parse("2022-06-16"), From = "Grecja", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 415, AllSeats = 60, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Gruzja", Price = 138, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 416, AllSeats = 60, DateTime = DateTime.Parse("2022-06-16"), From = "Gruzja", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 417, AllSeats = 32, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Gruzja", Price = 75, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 418, AllSeats = 32, DateTime = DateTime.Parse("2022-06-16"), From = "Gruzja", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 419, AllSeats = 52, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Gruzja", Price = 61, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 420, AllSeats = 52, DateTime = DateTime.Parse("2022-06-16"), From = "Gruzja", To = "Gdansk", Price = 61, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 421, AllSeats = 25, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Madera", Price = 112, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 422, AllSeats = 25, DateTime = DateTime.Parse("2022-06-16"), From = "Madera", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 423, AllSeats = 58, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Madera", Price = 130, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 424, AllSeats = 58, DateTime = DateTime.Parse("2022-06-16"), From = "Madera", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 425, AllSeats = 29, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Madera", Price = 69, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 426, AllSeats = 29, DateTime = DateTime.Parse("2022-06-16"), From = "Madera", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 427, AllSeats = 89, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malediwy", Price = 99, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 428, AllSeats = 89, DateTime = DateTime.Parse("2022-06-16"), From = "Malediwy", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 429, AllSeats = 31, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malediwy", Price = 122, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 430, AllSeats = 31, DateTime = DateTime.Parse("2022-06-16"), From = "Malediwy", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 431, AllSeats = 81, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malediwy", Price = 63, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 432, AllSeats = 81, DateTime = DateTime.Parse("2022-06-16"), From = "Malediwy", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 433, AllSeats = 48, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malta", Price = 99, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 434, AllSeats = 48, DateTime = DateTime.Parse("2022-06-16"), From = "Malta", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 435, AllSeats = 98, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malta", Price = 123, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 436, AllSeats = 98, DateTime = DateTime.Parse("2022-06-16"), From = "Malta", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 437, AllSeats = 40, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Malta", Price = 64, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 438, AllSeats = 40, DateTime = DateTime.Parse("2022-06-16"), From = "Malta", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 439, AllSeats = 28, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Mauritius", Price = 116, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 440, AllSeats = 28, DateTime = DateTime.Parse("2022-06-16"), From = "Mauritius", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 441, AllSeats = 73, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Mauritius", Price = 108, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 442, AllSeats = 73, DateTime = DateTime.Parse("2022-06-16"), From = "Mauritius", To = "Gdansk", Price = 80, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 443, AllSeats = 91, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Mauritius", Price = 92, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 444, AllSeats = 91, DateTime = DateTime.Parse("2022-06-16"), From = "Mauritius", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 445, AllSeats = 38, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Meksyk", Price = 114, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 446, AllSeats = 38, DateTime = DateTime.Parse("2022-06-16"), From = "Meksyk", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 447, AllSeats = 36, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Meksyk", Price = 87, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 448, AllSeats = 36, DateTime = DateTime.Parse("2022-06-16"), From = "Meksyk", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 449, AllSeats = 33, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Meksyk", Price = 72, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 450, AllSeats = 33, DateTime = DateTime.Parse("2022-06-16"), From = "Meksyk", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 451, AllSeats = 38, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Seszele", Price = 66, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 452, AllSeats = 38, DateTime = DateTime.Parse("2022-06-16"), From = "Seszele", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 453, AllSeats = 43, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Seszele", Price = 96, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 454, AllSeats = 43, DateTime = DateTime.Parse("2022-06-16"), From = "Seszele", To = "Gdansk", Price = 131, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 455, AllSeats = 97, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Seszele", Price = 79, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 456, AllSeats = 97, DateTime = DateTime.Parse("2022-06-16"), From = "Seszele", To = "Gdansk", Price = 96, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 457, AllSeats = 37, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Slowenia", Price = 86, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 458, AllSeats = 37, DateTime = DateTime.Parse("2022-06-16"), From = "Slowenia", To = "Gdansk", Price = 143, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 459, AllSeats = 64, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Slowenia", Price = 60, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 460, AllSeats = 64, DateTime = DateTime.Parse("2022-06-16"), From = "Slowenia", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 461, AllSeats = 69, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Slowenia", Price = 52, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 462, AllSeats = 69, DateTime = DateTime.Parse("2022-06-16"), From = "Slowenia", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 463, AllSeats = 48, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Turcja", Price = 108, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 464, AllSeats = 48, DateTime = DateTime.Parse("2022-06-16"), From = "Turcja", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 465, AllSeats = 93, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Turcja", Price = 122, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 466, AllSeats = 93, DateTime = DateTime.Parse("2022-06-16"), From = "Turcja", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 467, AllSeats = 90, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Turcja", Price = 140, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 468, AllSeats = 90, DateTime = DateTime.Parse("2022-06-16"), From = "Turcja", To = "Gdansk", Price = 122, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 469, AllSeats = 95, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 93, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 470, AllSeats = 95, DateTime = DateTime.Parse("2022-06-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 471, AllSeats = 94, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 112, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 472, AllSeats = 94, DateTime = DateTime.Parse("2022-06-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 473, AllSeats = 65, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 149, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 474, AllSeats = 65, DateTime = DateTime.Parse("2022-06-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 475, AllSeats = 26, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Zanzibar", Price = 63, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 476, AllSeats = 26, DateTime = DateTime.Parse("2022-06-16"), From = "Zanzibar", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 477, AllSeats = 27, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Zanzibar", Price = 114, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 478, AllSeats = 27, DateTime = DateTime.Parse("2022-06-16"), From = "Zanzibar", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 479, AllSeats = 77, DateTime = DateTime.Parse("2022-06-16"), From = "Gdansk", To = "Zanzibar", Price = 52, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 480, AllSeats = 77, DateTime = DateTime.Parse("2022-06-16"), From = "Zanzibar", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 481, AllSeats = 26, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Albania", Price = 107, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 482, AllSeats = 26, DateTime = DateTime.Parse("2022-06-17"), From = "Albania", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 483, AllSeats = 70, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Albania", Price = 130, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 484, AllSeats = 70, DateTime = DateTime.Parse("2022-06-17"), From = "Albania", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 485, AllSeats = 96, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Albania", Price = 81, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 486, AllSeats = 96, DateTime = DateTime.Parse("2022-06-17"), From = "Albania", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 487, AllSeats = 48, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 488, AllSeats = 48, DateTime = DateTime.Parse("2022-06-17"), From = "Bulgaria", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 489, AllSeats = 81, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Bulgaria", Price = 114, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 490, AllSeats = 81, DateTime = DateTime.Parse("2022-06-17"), From = "Bulgaria", To = "Gdansk", Price = 58, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 491, AllSeats = 86, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Bulgaria", Price = 123, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 492, AllSeats = 86, DateTime = DateTime.Parse("2022-06-17"), From = "Bulgaria", To = "Gdansk", Price = 143, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 493, AllSeats = 41, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Czarnogora", Price = 70, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 494, AllSeats = 41, DateTime = DateTime.Parse("2022-06-17"), From = "Czarnogora", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 495, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Czarnogora", Price = 87, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 496, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Czarnogora", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 497, AllSeats = 74, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Czarnogora", Price = 101, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 498, AllSeats = 74, DateTime = DateTime.Parse("2022-06-17"), From = "Czarnogora", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 499, AllSeats = 62, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Egipt", Price = 143, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 500, AllSeats = 62, DateTime = DateTime.Parse("2022-06-17"), From = "Egipt", To = "Gdansk", Price = 104, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 501, AllSeats = 42, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Egipt", Price = 140, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 502, AllSeats = 42, DateTime = DateTime.Parse("2022-06-17"), From = "Egipt", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 503, AllSeats = 81, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Egipt", Price = 67, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 504, AllSeats = 81, DateTime = DateTime.Parse("2022-06-17"), From = "Egipt", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 505, AllSeats = 64, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Grecja", Price = 140, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 506, AllSeats = 64, DateTime = DateTime.Parse("2022-06-17"), From = "Grecja", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 507, AllSeats = 49, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Grecja", Price = 134, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 508, AllSeats = 49, DateTime = DateTime.Parse("2022-06-17"), From = "Grecja", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 509, AllSeats = 57, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Grecja", Price = 66, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 510, AllSeats = 57, DateTime = DateTime.Parse("2022-06-17"), From = "Grecja", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 511, AllSeats = 26, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Gruzja", Price = 85, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 512, AllSeats = 26, DateTime = DateTime.Parse("2022-06-17"), From = "Gruzja", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 513, AllSeats = 31, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Gruzja", Price = 139, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 514, AllSeats = 31, DateTime = DateTime.Parse("2022-06-17"), From = "Gruzja", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 515, AllSeats = 55, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Gruzja", Price = 88, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 516, AllSeats = 55, DateTime = DateTime.Parse("2022-06-17"), From = "Gruzja", To = "Gdansk", Price = 61, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 517, AllSeats = 56, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Madera", Price = 53, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 518, AllSeats = 56, DateTime = DateTime.Parse("2022-06-17"), From = "Madera", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 519, AllSeats = 59, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Madera", Price = 98, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 520, AllSeats = 59, DateTime = DateTime.Parse("2022-06-17"), From = "Madera", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 521, AllSeats = 82, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Madera", Price = 134, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 522, AllSeats = 82, DateTime = DateTime.Parse("2022-06-17"), From = "Madera", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 523, AllSeats = 76, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malediwy", Price = 50, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 524, AllSeats = 76, DateTime = DateTime.Parse("2022-06-17"), From = "Malediwy", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 525, AllSeats = 34, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malediwy", Price = 93, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 526, AllSeats = 34, DateTime = DateTime.Parse("2022-06-17"), From = "Malediwy", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 527, AllSeats = 74, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malediwy", Price = 53, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 528, AllSeats = 74, DateTime = DateTime.Parse("2022-06-17"), From = "Malediwy", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 529, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malta", Price = 81, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 530, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Malta", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 531, AllSeats = 48, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malta", Price = 64, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 532, AllSeats = 48, DateTime = DateTime.Parse("2022-06-17"), From = "Malta", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 533, AllSeats = 53, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Malta", Price = 121, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 534, AllSeats = 53, DateTime = DateTime.Parse("2022-06-17"), From = "Malta", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 535, AllSeats = 61, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Mauritius", Price = 138, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 536, AllSeats = 61, DateTime = DateTime.Parse("2022-06-17"), From = "Mauritius", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 537, AllSeats = 77, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Mauritius", Price = 57, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 538, AllSeats = 77, DateTime = DateTime.Parse("2022-06-17"), From = "Mauritius", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 539, AllSeats = 72, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Mauritius", Price = 122, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 540, AllSeats = 72, DateTime = DateTime.Parse("2022-06-17"), From = "Mauritius", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 541, AllSeats = 84, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Meksyk", Price = 145, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 542, AllSeats = 84, DateTime = DateTime.Parse("2022-06-17"), From = "Meksyk", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 543, AllSeats = 54, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Meksyk", Price = 119, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 544, AllSeats = 54, DateTime = DateTime.Parse("2022-06-17"), From = "Meksyk", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 545, AllSeats = 89, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Meksyk", Price = 125, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 546, AllSeats = 89, DateTime = DateTime.Parse("2022-06-17"), From = "Meksyk", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 547, AllSeats = 61, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Seszele", Price = 137, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 548, AllSeats = 61, DateTime = DateTime.Parse("2022-06-17"), From = "Seszele", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 549, AllSeats = 87, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Seszele", Price = 64, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 550, AllSeats = 87, DateTime = DateTime.Parse("2022-06-17"), From = "Seszele", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 551, AllSeats = 72, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Seszele", Price = 121, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 552, AllSeats = 72, DateTime = DateTime.Parse("2022-06-17"), From = "Seszele", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 553, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Slowenia", Price = 59, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 554, AllSeats = 94, DateTime = DateTime.Parse("2022-06-17"), From = "Slowenia", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 555, AllSeats = 84, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Slowenia", Price = 132, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 556, AllSeats = 84, DateTime = DateTime.Parse("2022-06-17"), From = "Slowenia", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 557, AllSeats = 65, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Slowenia", Price = 96, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 558, AllSeats = 65, DateTime = DateTime.Parse("2022-06-17"), From = "Slowenia", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 559, AllSeats = 38, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Turcja", Price = 99, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 560, AllSeats = 38, DateTime = DateTime.Parse("2022-06-17"), From = "Turcja", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 561, AllSeats = 29, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Turcja", Price = 87, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 562, AllSeats = 29, DateTime = DateTime.Parse("2022-06-17"), From = "Turcja", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 563, AllSeats = 64, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 564, AllSeats = 64, DateTime = DateTime.Parse("2022-06-17"), From = "Turcja", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 565, AllSeats = 34, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 104, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 566, AllSeats = 34, DateTime = DateTime.Parse("2022-06-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 73, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 567, AllSeats = 28, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 119, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 568, AllSeats = 28, DateTime = DateTime.Parse("2022-06-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 569, AllSeats = 67, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 106, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 570, AllSeats = 67, DateTime = DateTime.Parse("2022-06-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 571, AllSeats = 85, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Zanzibar", Price = 111, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 572, AllSeats = 85, DateTime = DateTime.Parse("2022-06-17"), From = "Zanzibar", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 573, AllSeats = 49, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Zanzibar", Price = 140, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 574, AllSeats = 49, DateTime = DateTime.Parse("2022-06-17"), From = "Zanzibar", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 575, AllSeats = 36, DateTime = DateTime.Parse("2022-06-17"), From = "Gdansk", To = "Zanzibar", Price = 58, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 576, AllSeats = 36, DateTime = DateTime.Parse("2022-06-17"), From = "Zanzibar", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 577, AllSeats = 27, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Albania", Price = 122, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 578, AllSeats = 27, DateTime = DateTime.Parse("2022-06-18"), From = "Albania", To = "Gdansk", Price = 149, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 579, AllSeats = 38, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Albania", Price = 55, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 580, AllSeats = 38, DateTime = DateTime.Parse("2022-06-18"), From = "Albania", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 581, AllSeats = 63, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Albania", Price = 140, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 582, AllSeats = 63, DateTime = DateTime.Parse("2022-06-18"), From = "Albania", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 583, AllSeats = 82, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Bulgaria", Price = 86, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 584, AllSeats = 82, DateTime = DateTime.Parse("2022-06-18"), From = "Bulgaria", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 585, AllSeats = 76, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Bulgaria", Price = 149, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 586, AllSeats = 76, DateTime = DateTime.Parse("2022-06-18"), From = "Bulgaria", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 587, AllSeats = 31, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Bulgaria", Price = 90, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 588, AllSeats = 31, DateTime = DateTime.Parse("2022-06-18"), From = "Bulgaria", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 589, AllSeats = 68, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Czarnogora", Price = 61, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 590, AllSeats = 68, DateTime = DateTime.Parse("2022-06-18"), From = "Czarnogora", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 591, AllSeats = 95, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Czarnogora", Price = 69, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 592, AllSeats = 95, DateTime = DateTime.Parse("2022-06-18"), From = "Czarnogora", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 593, AllSeats = 78, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Czarnogora", Price = 50, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 594, AllSeats = 78, DateTime = DateTime.Parse("2022-06-18"), From = "Czarnogora", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 595, AllSeats = 85, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Egipt", Price = 76, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 596, AllSeats = 85, DateTime = DateTime.Parse("2022-06-18"), From = "Egipt", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 597, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Egipt", Price = 81, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 598, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Egipt", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 599, AllSeats = 55, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Egipt", Price = 142, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 600, AllSeats = 55, DateTime = DateTime.Parse("2022-06-18"), From = "Egipt", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 601, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Grecja", Price = 131, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 602, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Grecja", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 603, AllSeats = 50, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Grecja", Price = 114, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 604, AllSeats = 50, DateTime = DateTime.Parse("2022-06-18"), From = "Grecja", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 605, AllSeats = 54, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Grecja", Price = 65, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 606, AllSeats = 54, DateTime = DateTime.Parse("2022-06-18"), From = "Grecja", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 607, AllSeats = 47, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Gruzja", Price = 133, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 608, AllSeats = 47, DateTime = DateTime.Parse("2022-06-18"), From = "Gruzja", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 609, AllSeats = 87, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Gruzja", Price = 66, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 610, AllSeats = 87, DateTime = DateTime.Parse("2022-06-18"), From = "Gruzja", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 611, AllSeats = 62, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Gruzja", Price = 103, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 612, AllSeats = 62, DateTime = DateTime.Parse("2022-06-18"), From = "Gruzja", To = "Gdansk", Price = 89, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 613, AllSeats = 68, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Madera", Price = 122, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 614, AllSeats = 68, DateTime = DateTime.Parse("2022-06-18"), From = "Madera", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 615, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Madera", Price = 123, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 616, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Madera", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 617, AllSeats = 87, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Madera", Price = 103, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 618, AllSeats = 87, DateTime = DateTime.Parse("2022-06-18"), From = "Madera", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 619, AllSeats = 61, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malediwy", Price = 61, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 620, AllSeats = 61, DateTime = DateTime.Parse("2022-06-18"), From = "Malediwy", To = "Gdansk", Price = 104, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 621, AllSeats = 83, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malediwy", Price = 130, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 622, AllSeats = 83, DateTime = DateTime.Parse("2022-06-18"), From = "Malediwy", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 623, AllSeats = 72, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malediwy", Price = 131, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 624, AllSeats = 72, DateTime = DateTime.Parse("2022-06-18"), From = "Malediwy", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 625, AllSeats = 83, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malta", Price = 97, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 626, AllSeats = 83, DateTime = DateTime.Parse("2022-06-18"), From = "Malta", To = "Gdansk", Price = 87, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 627, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malta", Price = 75, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 628, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Malta", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 629, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Malta", Price = 97, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 630, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Malta", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 631, AllSeats = 32, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Mauritius", Price = 145, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 632, AllSeats = 32, DateTime = DateTime.Parse("2022-06-18"), From = "Mauritius", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 633, AllSeats = 64, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Mauritius", Price = 121, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 634, AllSeats = 64, DateTime = DateTime.Parse("2022-06-18"), From = "Mauritius", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 635, AllSeats = 99, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Mauritius", Price = 94, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 636, AllSeats = 99, DateTime = DateTime.Parse("2022-06-18"), From = "Mauritius", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 637, AllSeats = 27, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Meksyk", Price = 81, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 638, AllSeats = 27, DateTime = DateTime.Parse("2022-06-18"), From = "Meksyk", To = "Gdansk", Price = 89, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 639, AllSeats = 56, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Meksyk", Price = 144, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 640, AllSeats = 56, DateTime = DateTime.Parse("2022-06-18"), From = "Meksyk", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 641, AllSeats = 82, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Meksyk", Price = 61, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 642, AllSeats = 82, DateTime = DateTime.Parse("2022-06-18"), From = "Meksyk", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 643, AllSeats = 51, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Seszele", Price = 65, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 644, AllSeats = 51, DateTime = DateTime.Parse("2022-06-18"), From = "Seszele", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 645, AllSeats = 37, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Seszele", Price = 53, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 646, AllSeats = 37, DateTime = DateTime.Parse("2022-06-18"), From = "Seszele", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 647, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Seszele", Price = 69, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 648, AllSeats = 75, DateTime = DateTime.Parse("2022-06-18"), From = "Seszele", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 649, AllSeats = 32, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Slowenia", Price = 89, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 650, AllSeats = 32, DateTime = DateTime.Parse("2022-06-18"), From = "Slowenia", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 651, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Slowenia", Price = 82, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 652, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Slowenia", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 653, AllSeats = 38, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Slowenia", Price = 140, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 654, AllSeats = 38, DateTime = DateTime.Parse("2022-06-18"), From = "Slowenia", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 655, AllSeats = 65, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Turcja", Price = 128, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 656, AllSeats = 65, DateTime = DateTime.Parse("2022-06-18"), From = "Turcja", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 657, AllSeats = 93, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Turcja", Price = 105, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 658, AllSeats = 93, DateTime = DateTime.Parse("2022-06-18"), From = "Turcja", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 659, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Turcja", Price = 92, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 660, AllSeats = 94, DateTime = DateTime.Parse("2022-06-18"), From = "Turcja", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 661, AllSeats = 47, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 53, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 662, AllSeats = 47, DateTime = DateTime.Parse("2022-06-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 663, AllSeats = 34, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 149, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 664, AllSeats = 34, DateTime = DateTime.Parse("2022-06-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 665, AllSeats = 31, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 124, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 666, AllSeats = 31, DateTime = DateTime.Parse("2022-06-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 667, AllSeats = 43, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Zanzibar", Price = 132, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 668, AllSeats = 43, DateTime = DateTime.Parse("2022-06-18"), From = "Zanzibar", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 669, AllSeats = 99, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Zanzibar", Price = 121, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 670, AllSeats = 99, DateTime = DateTime.Parse("2022-06-18"), From = "Zanzibar", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 671, AllSeats = 96, DateTime = DateTime.Parse("2022-06-18"), From = "Gdansk", To = "Zanzibar", Price = 118, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 672, AllSeats = 96, DateTime = DateTime.Parse("2022-06-18"), From = "Zanzibar", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 673, AllSeats = 81, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Albania", Price = 53, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 674, AllSeats = 81, DateTime = DateTime.Parse("2022-06-19"), From = "Albania", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 675, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Albania", Price = 77, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 676, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Albania", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 677, AllSeats = 30, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Albania", Price = 57, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 678, AllSeats = 30, DateTime = DateTime.Parse("2022-06-19"), From = "Albania", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 679, AllSeats = 64, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Bulgaria", Price = 64, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 680, AllSeats = 64, DateTime = DateTime.Parse("2022-06-19"), From = "Bulgaria", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 681, AllSeats = 38, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 682, AllSeats = 38, DateTime = DateTime.Parse("2022-06-19"), From = "Bulgaria", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 683, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Bulgaria", Price = 121, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 684, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Bulgaria", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 685, AllSeats = 82, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Czarnogora", Price = 56, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 686, AllSeats = 82, DateTime = DateTime.Parse("2022-06-19"), From = "Czarnogora", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 687, AllSeats = 68, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Czarnogora", Price = 118, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 688, AllSeats = 68, DateTime = DateTime.Parse("2022-06-19"), From = "Czarnogora", To = "Gdansk", Price = 112, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 689, AllSeats = 72, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Czarnogora", Price = 87, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 690, AllSeats = 72, DateTime = DateTime.Parse("2022-06-19"), From = "Czarnogora", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 691, AllSeats = 95, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Egipt", Price = 58, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 692, AllSeats = 95, DateTime = DateTime.Parse("2022-06-19"), From = "Egipt", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 693, AllSeats = 54, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Egipt", Price = 59, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 694, AllSeats = 54, DateTime = DateTime.Parse("2022-06-19"), From = "Egipt", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 695, AllSeats = 76, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Egipt", Price = 51, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 696, AllSeats = 76, DateTime = DateTime.Parse("2022-06-19"), From = "Egipt", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 697, AllSeats = 88, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Grecja", Price = 109, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 698, AllSeats = 88, DateTime = DateTime.Parse("2022-06-19"), From = "Grecja", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 699, AllSeats = 25, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Grecja", Price = 124, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 700, AllSeats = 25, DateTime = DateTime.Parse("2022-06-19"), From = "Grecja", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 701, AllSeats = 34, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Grecja", Price = 100, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 702, AllSeats = 34, DateTime = DateTime.Parse("2022-06-19"), From = "Grecja", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 703, AllSeats = 58, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Gruzja", Price = 82, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 704, AllSeats = 58, DateTime = DateTime.Parse("2022-06-19"), From = "Gruzja", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 705, AllSeats = 77, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Gruzja", Price = 73, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 706, AllSeats = 77, DateTime = DateTime.Parse("2022-06-19"), From = "Gruzja", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 707, AllSeats = 56, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Gruzja", Price = 126, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 708, AllSeats = 56, DateTime = DateTime.Parse("2022-06-19"), From = "Gruzja", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 709, AllSeats = 31, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Madera", Price = 129, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 710, AllSeats = 31, DateTime = DateTime.Parse("2022-06-19"), From = "Madera", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 711, AllSeats = 72, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Madera", Price = 83, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 712, AllSeats = 72, DateTime = DateTime.Parse("2022-06-19"), From = "Madera", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 713, AllSeats = 64, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Madera", Price = 80, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 714, AllSeats = 64, DateTime = DateTime.Parse("2022-06-19"), From = "Madera", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 715, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malediwy", Price = 134, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 716, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Malediwy", To = "Gdansk", Price = 95, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 717, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malediwy", Price = 114, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 718, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Malediwy", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 719, AllSeats = 91, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malediwy", Price = 129, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 720, AllSeats = 91, DateTime = DateTime.Parse("2022-06-19"), From = "Malediwy", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 721, AllSeats = 89, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malta", Price = 53, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 722, AllSeats = 89, DateTime = DateTime.Parse("2022-06-19"), From = "Malta", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 723, AllSeats = 74, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malta", Price = 99, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 724, AllSeats = 74, DateTime = DateTime.Parse("2022-06-19"), From = "Malta", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 725, AllSeats = 38, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Malta", Price = 118, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 726, AllSeats = 38, DateTime = DateTime.Parse("2022-06-19"), From = "Malta", To = "Gdansk", Price = 89, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 727, AllSeats = 68, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Mauritius", Price = 114, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 728, AllSeats = 68, DateTime = DateTime.Parse("2022-06-19"), From = "Mauritius", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 729, AllSeats = 81, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Mauritius", Price = 72, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 730, AllSeats = 81, DateTime = DateTime.Parse("2022-06-19"), From = "Mauritius", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 731, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Mauritius", Price = 98, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 732, AllSeats = 66, DateTime = DateTime.Parse("2022-06-19"), From = "Mauritius", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 733, AllSeats = 77, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Meksyk", Price = 80, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 734, AllSeats = 77, DateTime = DateTime.Parse("2022-06-19"), From = "Meksyk", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 735, AllSeats = 70, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Meksyk", Price = 94, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 736, AllSeats = 70, DateTime = DateTime.Parse("2022-06-19"), From = "Meksyk", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 737, AllSeats = 76, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Meksyk", Price = 89, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 738, AllSeats = 76, DateTime = DateTime.Parse("2022-06-19"), From = "Meksyk", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 739, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Seszele", Price = 150, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 740, AllSeats = 69, DateTime = DateTime.Parse("2022-06-19"), From = "Seszele", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 741, AllSeats = 71, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Seszele", Price = 120, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 742, AllSeats = 71, DateTime = DateTime.Parse("2022-06-19"), From = "Seszele", To = "Gdansk", Price = 86, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 743, AllSeats = 41, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Seszele", Price = 138, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 744, AllSeats = 41, DateTime = DateTime.Parse("2022-06-19"), From = "Seszele", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 745, AllSeats = 53, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Slowenia", Price = 133, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 746, AllSeats = 53, DateTime = DateTime.Parse("2022-06-19"), From = "Slowenia", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 747, AllSeats = 50, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Slowenia", Price = 57, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 748, AllSeats = 50, DateTime = DateTime.Parse("2022-06-19"), From = "Slowenia", To = "Gdansk", Price = 121, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 749, AllSeats = 44, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Slowenia", Price = 107, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 750, AllSeats = 44, DateTime = DateTime.Parse("2022-06-19"), From = "Slowenia", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 751, AllSeats = 100, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Turcja", Price = 78, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 752, AllSeats = 100, DateTime = DateTime.Parse("2022-06-19"), From = "Turcja", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 753, AllSeats = 34, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Turcja", Price = 110, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 754, AllSeats = 34, DateTime = DateTime.Parse("2022-06-19"), From = "Turcja", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 755, AllSeats = 52, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Turcja", Price = 140, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 756, AllSeats = 52, DateTime = DateTime.Parse("2022-06-19"), From = "Turcja", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 757, AllSeats = 63, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 98, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 758, AllSeats = 63, DateTime = DateTime.Parse("2022-06-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 759, AllSeats = 30, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 128, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 760, AllSeats = 30, DateTime = DateTime.Parse("2022-06-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 106, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 761, AllSeats = 54, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 97, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 762, AllSeats = 54, DateTime = DateTime.Parse("2022-06-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 763, AllSeats = 50, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Zanzibar", Price = 144, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 764, AllSeats = 50, DateTime = DateTime.Parse("2022-06-19"), From = "Zanzibar", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 765, AllSeats = 59, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Zanzibar", Price = 99, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 766, AllSeats = 59, DateTime = DateTime.Parse("2022-06-19"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 767, AllSeats = 99, DateTime = DateTime.Parse("2022-06-19"), From = "Gdansk", To = "Zanzibar", Price = 71, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 768, AllSeats = 99, DateTime = DateTime.Parse("2022-06-19"), From = "Zanzibar", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 769, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Albania", Price = 62, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 770, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Albania", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 771, AllSeats = 91, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Albania", Price = 95, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 772, AllSeats = 91, DateTime = DateTime.Parse("2022-06-20"), From = "Albania", To = "Gdansk", Price = 86, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 773, AllSeats = 87, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Albania", Price = 143, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 774, AllSeats = 87, DateTime = DateTime.Parse("2022-06-20"), From = "Albania", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 775, AllSeats = 40, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Bulgaria", Price = 90, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 776, AllSeats = 40, DateTime = DateTime.Parse("2022-06-20"), From = "Bulgaria", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 777, AllSeats = 61, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Bulgaria", Price = 128, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 778, AllSeats = 61, DateTime = DateTime.Parse("2022-06-20"), From = "Bulgaria", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 779, AllSeats = 88, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Bulgaria", Price = 140, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 780, AllSeats = 88, DateTime = DateTime.Parse("2022-06-20"), From = "Bulgaria", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 781, AllSeats = 92, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Czarnogora", Price = 57, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 782, AllSeats = 92, DateTime = DateTime.Parse("2022-06-20"), From = "Czarnogora", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 783, AllSeats = 72, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Czarnogora", Price = 63, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 784, AllSeats = 72, DateTime = DateTime.Parse("2022-06-20"), From = "Czarnogora", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 785, AllSeats = 37, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Czarnogora", Price = 127, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 786, AllSeats = 37, DateTime = DateTime.Parse("2022-06-20"), From = "Czarnogora", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 787, AllSeats = 49, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Egipt", Price = 100, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 788, AllSeats = 49, DateTime = DateTime.Parse("2022-06-20"), From = "Egipt", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 789, AllSeats = 56, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Egipt", Price = 117, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 790, AllSeats = 56, DateTime = DateTime.Parse("2022-06-20"), From = "Egipt", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 791, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Egipt", Price = 105, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 792, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Egipt", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 793, AllSeats = 36, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Grecja", Price = 106, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 794, AllSeats = 36, DateTime = DateTime.Parse("2022-06-20"), From = "Grecja", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 795, AllSeats = 92, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Grecja", Price = 102, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 796, AllSeats = 92, DateTime = DateTime.Parse("2022-06-20"), From = "Grecja", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 797, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Grecja", Price = 106, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 798, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Grecja", To = "Gdansk", Price = 140, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 799, AllSeats = 32, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Gruzja", Price = 91, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 800, AllSeats = 32, DateTime = DateTime.Parse("2022-06-20"), From = "Gruzja", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 801, AllSeats = 55, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Gruzja", Price = 108, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 802, AllSeats = 55, DateTime = DateTime.Parse("2022-06-20"), From = "Gruzja", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 803, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Gruzja", Price = 54, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 804, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Gruzja", To = "Gdansk", Price = 122, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 805, AllSeats = 28, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Madera", Price = 97, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 806, AllSeats = 28, DateTime = DateTime.Parse("2022-06-20"), From = "Madera", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 807, AllSeats = 71, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Madera", Price = 72, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 808, AllSeats = 71, DateTime = DateTime.Parse("2022-06-20"), From = "Madera", To = "Gdansk", Price = 112, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 809, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Madera", Price = 51, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 810, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Madera", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 811, AllSeats = 33, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malediwy", Price = 134, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 812, AllSeats = 33, DateTime = DateTime.Parse("2022-06-20"), From = "Malediwy", To = "Gdansk", Price = 121, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 813, AllSeats = 84, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malediwy", Price = 97, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 814, AllSeats = 84, DateTime = DateTime.Parse("2022-06-20"), From = "Malediwy", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 815, AllSeats = 50, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malediwy", Price = 138, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 816, AllSeats = 50, DateTime = DateTime.Parse("2022-06-20"), From = "Malediwy", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 817, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malta", Price = 108, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 818, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Malta", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 819, AllSeats = 100, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malta", Price = 79, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 820, AllSeats = 100, DateTime = DateTime.Parse("2022-06-20"), From = "Malta", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 821, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Malta", Price = 109, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 822, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Malta", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 823, AllSeats = 35, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Mauritius", Price = 50, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 824, AllSeats = 35, DateTime = DateTime.Parse("2022-06-20"), From = "Mauritius", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 825, AllSeats = 75, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Mauritius", Price = 96, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 826, AllSeats = 75, DateTime = DateTime.Parse("2022-06-20"), From = "Mauritius", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 827, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Mauritius", Price = 99, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 828, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Mauritius", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 829, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Meksyk", Price = 132, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 830, AllSeats = 64, DateTime = DateTime.Parse("2022-06-20"), From = "Meksyk", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 831, AllSeats = 67, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Meksyk", Price = 121, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 832, AllSeats = 67, DateTime = DateTime.Parse("2022-06-20"), From = "Meksyk", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 833, AllSeats = 62, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Meksyk", Price = 107, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 834, AllSeats = 62, DateTime = DateTime.Parse("2022-06-20"), From = "Meksyk", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 835, AllSeats = 35, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Seszele", Price = 94, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 836, AllSeats = 35, DateTime = DateTime.Parse("2022-06-20"), From = "Seszele", To = "Gdansk", Price = 149, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 837, AllSeats = 97, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Seszele", Price = 143, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 838, AllSeats = 97, DateTime = DateTime.Parse("2022-06-20"), From = "Seszele", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 839, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Seszele", Price = 147, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 840, AllSeats = 79, DateTime = DateTime.Parse("2022-06-20"), From = "Seszele", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 841, AllSeats = 88, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Slowenia", Price = 63, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 842, AllSeats = 88, DateTime = DateTime.Parse("2022-06-20"), From = "Slowenia", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 843, AllSeats = 56, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Slowenia", Price = 72, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 844, AllSeats = 56, DateTime = DateTime.Parse("2022-06-20"), From = "Slowenia", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 845, AllSeats = 29, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Slowenia", Price = 58, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 846, AllSeats = 29, DateTime = DateTime.Parse("2022-06-20"), From = "Slowenia", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 847, AllSeats = 43, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Turcja", Price = 60, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 848, AllSeats = 43, DateTime = DateTime.Parse("2022-06-20"), From = "Turcja", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 849, AllSeats = 97, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Turcja", Price = 58, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 850, AllSeats = 97, DateTime = DateTime.Parse("2022-06-20"), From = "Turcja", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 851, AllSeats = 29, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Turcja", Price = 139, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 852, AllSeats = 29, DateTime = DateTime.Parse("2022-06-20"), From = "Turcja", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 853, AllSeats = 47, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 75, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 854, AllSeats = 47, DateTime = DateTime.Parse("2022-06-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 855, AllSeats = 28, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 56, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 856, AllSeats = 28, DateTime = DateTime.Parse("2022-06-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 857, AllSeats = 80, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 141, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 858, AllSeats = 80, DateTime = DateTime.Parse("2022-06-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 859, AllSeats = 51, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Zanzibar", Price = 125, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 860, AllSeats = 51, DateTime = DateTime.Parse("2022-06-20"), From = "Zanzibar", To = "Gdansk", Price = 144, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 861, AllSeats = 54, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Zanzibar", Price = 149, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 862, AllSeats = 54, DateTime = DateTime.Parse("2022-06-20"), From = "Zanzibar", To = "Gdansk", Price = 71, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 863, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Gdansk", To = "Zanzibar", Price = 120, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 864, AllSeats = 69, DateTime = DateTime.Parse("2022-06-20"), From = "Zanzibar", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 865, AllSeats = 42, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Albania", Price = 146, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 866, AllSeats = 42, DateTime = DateTime.Parse("2022-06-21"), From = "Albania", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 867, AllSeats = 38, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Albania", Price = 71, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 868, AllSeats = 38, DateTime = DateTime.Parse("2022-06-21"), From = "Albania", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 869, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Albania", Price = 95, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 870, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Albania", To = "Gdansk", Price = 62, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 871, AllSeats = 70, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Bulgaria", Price = 102, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 872, AllSeats = 70, DateTime = DateTime.Parse("2022-06-21"), From = "Bulgaria", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 873, AllSeats = 56, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Bulgaria", Price = 122, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 874, AllSeats = 56, DateTime = DateTime.Parse("2022-06-21"), From = "Bulgaria", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 875, AllSeats = 100, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Bulgaria", Price = 65, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 876, AllSeats = 100, DateTime = DateTime.Parse("2022-06-21"), From = "Bulgaria", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 877, AllSeats = 55, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Czarnogora", Price = 94, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 878, AllSeats = 55, DateTime = DateTime.Parse("2022-06-21"), From = "Czarnogora", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 879, AllSeats = 84, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Czarnogora", Price = 132, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 880, AllSeats = 84, DateTime = DateTime.Parse("2022-06-21"), From = "Czarnogora", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 881, AllSeats = 28, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Czarnogora", Price = 80, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 882, AllSeats = 28, DateTime = DateTime.Parse("2022-06-21"), From = "Czarnogora", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 883, AllSeats = 83, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Egipt", Price = 73, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 884, AllSeats = 83, DateTime = DateTime.Parse("2022-06-21"), From = "Egipt", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 885, AllSeats = 48, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Egipt", Price = 106, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 886, AllSeats = 48, DateTime = DateTime.Parse("2022-06-21"), From = "Egipt", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 887, AllSeats = 67, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Egipt", Price = 92, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 888, AllSeats = 67, DateTime = DateTime.Parse("2022-06-21"), From = "Egipt", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 889, AllSeats = 67, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Grecja", Price = 115, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 890, AllSeats = 67, DateTime = DateTime.Parse("2022-06-21"), From = "Grecja", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 891, AllSeats = 28, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Grecja", Price = 113, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 892, AllSeats = 28, DateTime = DateTime.Parse("2022-06-21"), From = "Grecja", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 893, AllSeats = 68, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Grecja", Price = 85, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 894, AllSeats = 68, DateTime = DateTime.Parse("2022-06-21"), From = "Grecja", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 895, AllSeats = 35, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Gruzja", Price = 101, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 896, AllSeats = 35, DateTime = DateTime.Parse("2022-06-21"), From = "Gruzja", To = "Gdansk", Price = 118, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 897, AllSeats = 56, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Gruzja", Price = 114, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 898, AllSeats = 56, DateTime = DateTime.Parse("2022-06-21"), From = "Gruzja", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 899, AllSeats = 98, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Gruzja", Price = 95, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 900, AllSeats = 98, DateTime = DateTime.Parse("2022-06-21"), From = "Gruzja", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 901, AllSeats = 50, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Madera", Price = 92, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 902, AllSeats = 50, DateTime = DateTime.Parse("2022-06-21"), From = "Madera", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 903, AllSeats = 52, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Madera", Price = 92, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 904, AllSeats = 52, DateTime = DateTime.Parse("2022-06-21"), From = "Madera", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 905, AllSeats = 32, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Madera", Price = 104, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 906, AllSeats = 32, DateTime = DateTime.Parse("2022-06-21"), From = "Madera", To = "Gdansk", Price = 147, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 907, AllSeats = 90, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malediwy", Price = 123, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 908, AllSeats = 90, DateTime = DateTime.Parse("2022-06-21"), From = "Malediwy", To = "Gdansk", Price = 89, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 909, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malediwy", Price = 133, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 910, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Malediwy", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 911, AllSeats = 45, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malediwy", Price = 67, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 912, AllSeats = 45, DateTime = DateTime.Parse("2022-06-21"), From = "Malediwy", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 913, AllSeats = 87, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malta", Price = 51, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 914, AllSeats = 87, DateTime = DateTime.Parse("2022-06-21"), From = "Malta", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 915, AllSeats = 44, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malta", Price = 91, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 916, AllSeats = 44, DateTime = DateTime.Parse("2022-06-21"), From = "Malta", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 917, AllSeats = 43, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Malta", Price = 61, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 918, AllSeats = 43, DateTime = DateTime.Parse("2022-06-21"), From = "Malta", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 919, AllSeats = 58, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Mauritius", Price = 87, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 920, AllSeats = 58, DateTime = DateTime.Parse("2022-06-21"), From = "Mauritius", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 921, AllSeats = 25, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Mauritius", Price = 90, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 922, AllSeats = 25, DateTime = DateTime.Parse("2022-06-21"), From = "Mauritius", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 923, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Mauritius", Price = 76, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 924, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Mauritius", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 925, AllSeats = 57, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Meksyk", Price = 72, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 926, AllSeats = 57, DateTime = DateTime.Parse("2022-06-21"), From = "Meksyk", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 927, AllSeats = 88, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Meksyk", Price = 129, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 928, AllSeats = 88, DateTime = DateTime.Parse("2022-06-21"), From = "Meksyk", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 929, AllSeats = 29, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Meksyk", Price = 125, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 930, AllSeats = 29, DateTime = DateTime.Parse("2022-06-21"), From = "Meksyk", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 931, AllSeats = 27, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Seszele", Price = 82, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 932, AllSeats = 27, DateTime = DateTime.Parse("2022-06-21"), From = "Seszele", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 933, AllSeats = 72, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Seszele", Price = 102, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 934, AllSeats = 72, DateTime = DateTime.Parse("2022-06-21"), From = "Seszele", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 935, AllSeats = 41, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Seszele", Price = 81, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 936, AllSeats = 41, DateTime = DateTime.Parse("2022-06-21"), From = "Seszele", To = "Gdansk", Price = 84, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 937, AllSeats = 29, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 938, AllSeats = 29, DateTime = DateTime.Parse("2022-06-21"), From = "Slowenia", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 939, AllSeats = 89, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Slowenia", Price = 71, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 940, AllSeats = 89, DateTime = DateTime.Parse("2022-06-21"), From = "Slowenia", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 941, AllSeats = 66, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Slowenia", Price = 150, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 942, AllSeats = 66, DateTime = DateTime.Parse("2022-06-21"), From = "Slowenia", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 943, AllSeats = 42, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Turcja", Price = 146, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 944, AllSeats = 42, DateTime = DateTime.Parse("2022-06-21"), From = "Turcja", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 945, AllSeats = 80, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Turcja", Price = 121, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 946, AllSeats = 80, DateTime = DateTime.Parse("2022-06-21"), From = "Turcja", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 947, AllSeats = 50, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 948, AllSeats = 50, DateTime = DateTime.Parse("2022-06-21"), From = "Turcja", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 949, AllSeats = 94, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 94, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 950, AllSeats = 94, DateTime = DateTime.Parse("2022-06-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 951, AllSeats = 95, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 123, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 952, AllSeats = 95, DateTime = DateTime.Parse("2022-06-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 953, AllSeats = 58, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 148, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 954, AllSeats = 58, DateTime = DateTime.Parse("2022-06-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 955, AllSeats = 71, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Zanzibar", Price = 57, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 956, AllSeats = 71, DateTime = DateTime.Parse("2022-06-21"), From = "Zanzibar", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 957, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Zanzibar", Price = 111, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 958, AllSeats = 47, DateTime = DateTime.Parse("2022-06-21"), From = "Zanzibar", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 959, AllSeats = 91, DateTime = DateTime.Parse("2022-06-21"), From = "Gdansk", To = "Zanzibar", Price = 78, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 960, AllSeats = 91, DateTime = DateTime.Parse("2022-06-21"), From = "Zanzibar", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 961, AllSeats = 50, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Albania", Price = 81, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 962, AllSeats = 50, DateTime = DateTime.Parse("2022-06-22"), From = "Albania", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 963, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Albania", Price = 124, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 964, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Albania", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 965, AllSeats = 76, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Albania", Price = 88, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 966, AllSeats = 76, DateTime = DateTime.Parse("2022-06-22"), From = "Albania", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 967, AllSeats = 36, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 968, AllSeats = 36, DateTime = DateTime.Parse("2022-06-22"), From = "Bulgaria", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 969, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Bulgaria", Price = 75, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 970, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Bulgaria", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 971, AllSeats = 82, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Bulgaria", Price = 108, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 972, AllSeats = 82, DateTime = DateTime.Parse("2022-06-22"), From = "Bulgaria", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 973, AllSeats = 53, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Czarnogora", Price = 81, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 974, AllSeats = 53, DateTime = DateTime.Parse("2022-06-22"), From = "Czarnogora", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 975, AllSeats = 63, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Czarnogora", Price = 65, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 976, AllSeats = 63, DateTime = DateTime.Parse("2022-06-22"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 977, AllSeats = 72, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Czarnogora", Price = 96, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 978, AllSeats = 72, DateTime = DateTime.Parse("2022-06-22"), From = "Czarnogora", To = "Gdansk", Price = 140, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 979, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Egipt", Price = 85, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 980, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Egipt", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 981, AllSeats = 99, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Egipt", Price = 130, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 982, AllSeats = 99, DateTime = DateTime.Parse("2022-06-22"), From = "Egipt", To = "Gdansk", Price = 76, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 983, AllSeats = 96, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Egipt", Price = 123, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 984, AllSeats = 96, DateTime = DateTime.Parse("2022-06-22"), From = "Egipt", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 985, AllSeats = 69, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Grecja", Price = 90, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 986, AllSeats = 69, DateTime = DateTime.Parse("2022-06-22"), From = "Grecja", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 987, AllSeats = 60, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Grecja", Price = 62, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 988, AllSeats = 60, DateTime = DateTime.Parse("2022-06-22"), From = "Grecja", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 989, AllSeats = 42, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Grecja", Price = 70, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 990, AllSeats = 42, DateTime = DateTime.Parse("2022-06-22"), From = "Grecja", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 991, AllSeats = 52, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Gruzja", Price = 128, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 992, AllSeats = 52, DateTime = DateTime.Parse("2022-06-22"), From = "Gruzja", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 993, AllSeats = 78, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Gruzja", Price = 100, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 994, AllSeats = 78, DateTime = DateTime.Parse("2022-06-22"), From = "Gruzja", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 995, AllSeats = 90, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Gruzja", Price = 100, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 996, AllSeats = 90, DateTime = DateTime.Parse("2022-06-22"), From = "Gruzja", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 997, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Madera", Price = 128, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 998, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Madera", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 999, AllSeats = 39, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Madera", Price = 127, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 1000, AllSeats = 39, DateTime = DateTime.Parse("2022-06-22"), From = "Madera", To = "Gdansk", Price = 86, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 1001, AllSeats = 67, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Madera", Price = 103, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 1002, AllSeats = 67, DateTime = DateTime.Parse("2022-06-22"), From = "Madera", To = "Gdansk", Price = 61, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 1003, AllSeats = 34, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malediwy", Price = 130, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1004, AllSeats = 34, DateTime = DateTime.Parse("2022-06-22"), From = "Malediwy", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1005, AllSeats = 88, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malediwy", Price = 149, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1006, AllSeats = 88, DateTime = DateTime.Parse("2022-06-22"), From = "Malediwy", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1007, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malediwy", Price = 58, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1008, AllSeats = 55, DateTime = DateTime.Parse("2022-06-22"), From = "Malediwy", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1009, AllSeats = 34, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malta", Price = 132, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1010, AllSeats = 34, DateTime = DateTime.Parse("2022-06-22"), From = "Malta", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1011, AllSeats = 31, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malta", Price = 112, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1012, AllSeats = 31, DateTime = DateTime.Parse("2022-06-22"), From = "Malta", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1013, AllSeats = 31, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Malta", Price = 143, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1014, AllSeats = 31, DateTime = DateTime.Parse("2022-06-22"), From = "Malta", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1015, AllSeats = 51, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Mauritius", Price = 78, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 1016, AllSeats = 51, DateTime = DateTime.Parse("2022-06-22"), From = "Mauritius", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 1017, AllSeats = 77, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Mauritius", Price = 148, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 1018, AllSeats = 77, DateTime = DateTime.Parse("2022-06-22"), From = "Mauritius", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 1019, AllSeats = 66, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Mauritius", Price = 104, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1020, AllSeats = 66, DateTime = DateTime.Parse("2022-06-22"), From = "Mauritius", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1021, AllSeats = 83, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Meksyk", Price = 105, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 1022, AllSeats = 83, DateTime = DateTime.Parse("2022-06-22"), From = "Meksyk", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 1023, AllSeats = 30, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Meksyk", Price = 81, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1024, AllSeats = 30, DateTime = DateTime.Parse("2022-06-22"), From = "Meksyk", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1025, AllSeats = 97, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Meksyk", Price = 137, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1026, AllSeats = 97, DateTime = DateTime.Parse("2022-06-22"), From = "Meksyk", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1027, AllSeats = 82, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Seszele", Price = 74, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 1028, AllSeats = 82, DateTime = DateTime.Parse("2022-06-22"), From = "Seszele", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 1029, AllSeats = 98, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Seszele", Price = 106, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1030, AllSeats = 98, DateTime = DateTime.Parse("2022-06-22"), From = "Seszele", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1031, AllSeats = 88, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Seszele", Price = 101, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1032, AllSeats = 88, DateTime = DateTime.Parse("2022-06-22"), From = "Seszele", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1033, AllSeats = 72, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Slowenia", Price = 104, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1034, AllSeats = 72, DateTime = DateTime.Parse("2022-06-22"), From = "Slowenia", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1035, AllSeats = 74, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Slowenia", Price = 68, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1036, AllSeats = 74, DateTime = DateTime.Parse("2022-06-22"), From = "Slowenia", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1037, AllSeats = 69, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Slowenia", Price = 51, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 1038, AllSeats = 69, DateTime = DateTime.Parse("2022-06-22"), From = "Slowenia", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 1039, AllSeats = 26, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1040, AllSeats = 26, DateTime = DateTime.Parse("2022-06-22"), From = "Turcja", To = "Gdansk", Price = 73, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1041, AllSeats = 57, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1042, AllSeats = 57, DateTime = DateTime.Parse("2022-06-22"), From = "Turcja", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1043, AllSeats = 96, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Turcja", Price = 76, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 1044, AllSeats = 96, DateTime = DateTime.Parse("2022-06-22"), From = "Turcja", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 1045, AllSeats = 58, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 85, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1046, AllSeats = 58, DateTime = DateTime.Parse("2022-06-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 148, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1047, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 76, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1048, AllSeats = 61, DateTime = DateTime.Parse("2022-06-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1049, AllSeats = 32, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 67, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1050, AllSeats = 32, DateTime = DateTime.Parse("2022-06-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1051, AllSeats = 41, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Zanzibar", Price = 69, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 1052, AllSeats = 41, DateTime = DateTime.Parse("2022-06-22"), From = "Zanzibar", To = "Gdansk", Price = 95, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 1053, AllSeats = 77, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Zanzibar", Price = 75, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 1054, AllSeats = 77, DateTime = DateTime.Parse("2022-06-22"), From = "Zanzibar", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 1055, AllSeats = 54, DateTime = DateTime.Parse("2022-06-22"), From = "Gdansk", To = "Zanzibar", Price = 75, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1056, AllSeats = 54, DateTime = DateTime.Parse("2022-06-22"), From = "Zanzibar", To = "Gdansk", Price = 112, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1057, AllSeats = 34, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Albania", Price = 63, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1058, AllSeats = 34, DateTime = DateTime.Parse("2022-06-23"), From = "Albania", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1059, AllSeats = 48, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Albania", Price = 117, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 1060, AllSeats = 48, DateTime = DateTime.Parse("2022-06-23"), From = "Albania", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 1061, AllSeats = 60, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Albania", Price = 83, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 1062, AllSeats = 60, DateTime = DateTime.Parse("2022-06-23"), From = "Albania", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 1063, AllSeats = 93, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Bulgaria", Price = 52, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 1064, AllSeats = 93, DateTime = DateTime.Parse("2022-06-23"), From = "Bulgaria", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 1065, AllSeats = 49, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Bulgaria", Price = 79, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 1066, AllSeats = 49, DateTime = DateTime.Parse("2022-06-23"), From = "Bulgaria", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 1067, AllSeats = 72, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Bulgaria", Price = 110, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1068, AllSeats = 72, DateTime = DateTime.Parse("2022-06-23"), From = "Bulgaria", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1069, AllSeats = 75, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Czarnogora", Price = 84, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1070, AllSeats = 75, DateTime = DateTime.Parse("2022-06-23"), From = "Czarnogora", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1071, AllSeats = 56, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Czarnogora", Price = 63, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1072, AllSeats = 56, DateTime = DateTime.Parse("2022-06-23"), From = "Czarnogora", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1073, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Czarnogora", Price = 56, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1074, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Czarnogora", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1075, AllSeats = 95, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Egipt", Price = 99, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 1076, AllSeats = 95, DateTime = DateTime.Parse("2022-06-23"), From = "Egipt", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 1077, AllSeats = 61, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Egipt", Price = 101, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1078, AllSeats = 61, DateTime = DateTime.Parse("2022-06-23"), From = "Egipt", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1079, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Egipt", Price = 115, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1080, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Egipt", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1081, AllSeats = 58, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Grecja", Price = 149, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1082, AllSeats = 58, DateTime = DateTime.Parse("2022-06-23"), From = "Grecja", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1083, AllSeats = 75, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Grecja", Price = 148, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1084, AllSeats = 75, DateTime = DateTime.Parse("2022-06-23"), From = "Grecja", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1085, AllSeats = 42, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Grecja", Price = 92, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1086, AllSeats = 42, DateTime = DateTime.Parse("2022-06-23"), From = "Grecja", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1087, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Gruzja", Price = 82, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1088, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gruzja", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1089, AllSeats = 25, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Gruzja", Price = 97, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 1090, AllSeats = 25, DateTime = DateTime.Parse("2022-06-23"), From = "Gruzja", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 1091, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Gruzja", Price = 54, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1092, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gruzja", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1093, AllSeats = 69, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Madera", Price = 77, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1094, AllSeats = 69, DateTime = DateTime.Parse("2022-06-23"), From = "Madera", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1095, AllSeats = 41, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Madera", Price = 135, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 1096, AllSeats = 41, DateTime = DateTime.Parse("2022-06-23"), From = "Madera", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 1097, AllSeats = 69, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Madera", Price = 57, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 1098, AllSeats = 69, DateTime = DateTime.Parse("2022-06-23"), From = "Madera", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 1099, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malediwy", Price = 108, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1100, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Malediwy", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1101, AllSeats = 61, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1102, AllSeats = 61, DateTime = DateTime.Parse("2022-06-23"), From = "Malediwy", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1103, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malediwy", Price = 65, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1104, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Malediwy", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1105, AllSeats = 39, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malta", Price = 135, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1106, AllSeats = 39, DateTime = DateTime.Parse("2022-06-23"), From = "Malta", To = "Gdansk", Price = 70, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1107, AllSeats = 42, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malta", Price = 77, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 1108, AllSeats = 42, DateTime = DateTime.Parse("2022-06-23"), From = "Malta", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 1109, AllSeats = 87, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Malta", Price = 91, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1110, AllSeats = 87, DateTime = DateTime.Parse("2022-06-23"), From = "Malta", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1111, AllSeats = 66, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Mauritius", Price = 90, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1112, AllSeats = 66, DateTime = DateTime.Parse("2022-06-23"), From = "Mauritius", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1113, AllSeats = 33, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Mauritius", Price = 109, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 1114, AllSeats = 33, DateTime = DateTime.Parse("2022-06-23"), From = "Mauritius", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 1115, AllSeats = 66, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Mauritius", Price = 126, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1116, AllSeats = 66, DateTime = DateTime.Parse("2022-06-23"), From = "Mauritius", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1117, AllSeats = 84, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Meksyk", Price = 65, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 1118, AllSeats = 84, DateTime = DateTime.Parse("2022-06-23"), From = "Meksyk", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 1119, AllSeats = 88, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Meksyk", Price = 74, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1120, AllSeats = 88, DateTime = DateTime.Parse("2022-06-23"), From = "Meksyk", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1121, AllSeats = 28, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Meksyk", Price = 126, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 1122, AllSeats = 28, DateTime = DateTime.Parse("2022-06-23"), From = "Meksyk", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 1123, AllSeats = 33, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Seszele", Price = 114, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1124, AllSeats = 33, DateTime = DateTime.Parse("2022-06-23"), From = "Seszele", To = "Gdansk", Price = 121, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1125, AllSeats = 78, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Seszele", Price = 82, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1126, AllSeats = 78, DateTime = DateTime.Parse("2022-06-23"), From = "Seszele", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1127, AllSeats = 36, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Seszele", Price = 133, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 1128, AllSeats = 36, DateTime = DateTime.Parse("2022-06-23"), From = "Seszele", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 1129, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Slowenia", Price = 145, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1130, AllSeats = 86, DateTime = DateTime.Parse("2022-06-23"), From = "Slowenia", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1131, AllSeats = 73, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Slowenia", Price = 136, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 1132, AllSeats = 73, DateTime = DateTime.Parse("2022-06-23"), From = "Slowenia", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 1133, AllSeats = 35, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Slowenia", Price = 73, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1134, AllSeats = 35, DateTime = DateTime.Parse("2022-06-23"), From = "Slowenia", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1135, AllSeats = 56, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Turcja", Price = 105, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 1136, AllSeats = 56, DateTime = DateTime.Parse("2022-06-23"), From = "Turcja", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 1137, AllSeats = 68, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Turcja", Price = 129, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1138, AllSeats = 68, DateTime = DateTime.Parse("2022-06-23"), From = "Turcja", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1139, AllSeats = 30, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Turcja", Price = 105, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1140, AllSeats = 30, DateTime = DateTime.Parse("2022-06-23"), From = "Turcja", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1141, AllSeats = 43, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 148, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1142, AllSeats = 43, DateTime = DateTime.Parse("2022-06-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1143, AllSeats = 25, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 92, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 1144, AllSeats = 25, DateTime = DateTime.Parse("2022-06-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 1145, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 66, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1146, AllSeats = 62, DateTime = DateTime.Parse("2022-06-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1147, AllSeats = 52, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Zanzibar", Price = 149, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1148, AllSeats = 52, DateTime = DateTime.Parse("2022-06-23"), From = "Zanzibar", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1149, AllSeats = 40, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Zanzibar", Price = 79, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 1150, AllSeats = 40, DateTime = DateTime.Parse("2022-06-23"), From = "Zanzibar", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 1151, AllSeats = 28, DateTime = DateTime.Parse("2022-06-23"), From = "Gdansk", To = "Zanzibar", Price = 149, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 1152, AllSeats = 28, DateTime = DateTime.Parse("2022-06-23"), From = "Zanzibar", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 1153, AllSeats = 80, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Albania", Price = 72, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1154, AllSeats = 80, DateTime = DateTime.Parse("2022-06-24"), From = "Albania", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1155, AllSeats = 95, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Albania", Price = 149, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1156, AllSeats = 95, DateTime = DateTime.Parse("2022-06-24"), From = "Albania", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1157, AllSeats = 98, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Albania", Price = 57, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 1158, AllSeats = 98, DateTime = DateTime.Parse("2022-06-24"), From = "Albania", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 1159, AllSeats = 69, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Bulgaria", Price = 72, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1160, AllSeats = 69, DateTime = DateTime.Parse("2022-06-24"), From = "Bulgaria", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1161, AllSeats = 33, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Bulgaria", Price = 147, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 1162, AllSeats = 33, DateTime = DateTime.Parse("2022-06-24"), From = "Bulgaria", To = "Gdansk", Price = 95, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 1163, AllSeats = 80, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Bulgaria", Price = 132, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 1164, AllSeats = 80, DateTime = DateTime.Parse("2022-06-24"), From = "Bulgaria", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 1165, AllSeats = 44, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Czarnogora", Price = 72, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 1166, AllSeats = 44, DateTime = DateTime.Parse("2022-06-24"), From = "Czarnogora", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 1167, AllSeats = 54, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Czarnogora", Price = 112, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 1168, AllSeats = 54, DateTime = DateTime.Parse("2022-06-24"), From = "Czarnogora", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 1169, AllSeats = 73, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Czarnogora", Price = 75, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1170, AllSeats = 73, DateTime = DateTime.Parse("2022-06-24"), From = "Czarnogora", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1171, AllSeats = 61, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Egipt", Price = 73, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 1172, AllSeats = 61, DateTime = DateTime.Parse("2022-06-24"), From = "Egipt", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 1173, AllSeats = 98, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Egipt", Price = 67, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1174, AllSeats = 98, DateTime = DateTime.Parse("2022-06-24"), From = "Egipt", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1175, AllSeats = 97, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Egipt", Price = 88, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1176, AllSeats = 97, DateTime = DateTime.Parse("2022-06-24"), From = "Egipt", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1177, AllSeats = 75, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Grecja", Price = 125, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1178, AllSeats = 75, DateTime = DateTime.Parse("2022-06-24"), From = "Grecja", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1179, AllSeats = 27, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Grecja", Price = 60, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1180, AllSeats = 27, DateTime = DateTime.Parse("2022-06-24"), From = "Grecja", To = "Gdansk", Price = 80, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1181, AllSeats = 57, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Grecja", Price = 132, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 1182, AllSeats = 57, DateTime = DateTime.Parse("2022-06-24"), From = "Grecja", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 1183, AllSeats = 86, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Gruzja", Price = 73, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1184, AllSeats = 86, DateTime = DateTime.Parse("2022-06-24"), From = "Gruzja", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1185, AllSeats = 90, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Gruzja", Price = 141, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 1186, AllSeats = 90, DateTime = DateTime.Parse("2022-06-24"), From = "Gruzja", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 1187, AllSeats = 82, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Gruzja", Price = 126, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1188, AllSeats = 82, DateTime = DateTime.Parse("2022-06-24"), From = "Gruzja", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1189, AllSeats = 85, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Madera", Price = 80, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1190, AllSeats = 85, DateTime = DateTime.Parse("2022-06-24"), From = "Madera", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1191, AllSeats = 69, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Madera", Price = 87, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 1192, AllSeats = 69, DateTime = DateTime.Parse("2022-06-24"), From = "Madera", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 1193, AllSeats = 29, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Madera", Price = 94, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1194, AllSeats = 29, DateTime = DateTime.Parse("2022-06-24"), From = "Madera", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1195, AllSeats = 43, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malediwy", Price = 58, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1196, AllSeats = 43, DateTime = DateTime.Parse("2022-06-24"), From = "Malediwy", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1197, AllSeats = 96, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malediwy", Price = 57, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1198, AllSeats = 96, DateTime = DateTime.Parse("2022-06-24"), From = "Malediwy", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1199, AllSeats = 55, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malediwy", Price = 107, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1200, AllSeats = 55, DateTime = DateTime.Parse("2022-06-24"), From = "Malediwy", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1201, AllSeats = 52, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malta", Price = 134, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1202, AllSeats = 52, DateTime = DateTime.Parse("2022-06-24"), From = "Malta", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1203, AllSeats = 87, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malta", Price = 141, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1204, AllSeats = 87, DateTime = DateTime.Parse("2022-06-24"), From = "Malta", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1205, AllSeats = 65, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Malta", Price = 74, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1206, AllSeats = 65, DateTime = DateTime.Parse("2022-06-24"), From = "Malta", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1207, AllSeats = 87, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Mauritius", Price = 85, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1208, AllSeats = 87, DateTime = DateTime.Parse("2022-06-24"), From = "Mauritius", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1209, AllSeats = 82, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Mauritius", Price = 134, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 1210, AllSeats = 82, DateTime = DateTime.Parse("2022-06-24"), From = "Mauritius", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 1211, AllSeats = 74, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Mauritius", Price = 55, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1212, AllSeats = 74, DateTime = DateTime.Parse("2022-06-24"), From = "Mauritius", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1213, AllSeats = 83, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Meksyk", Price = 105, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 1214, AllSeats = 83, DateTime = DateTime.Parse("2022-06-24"), From = "Meksyk", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 1215, AllSeats = 60, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Meksyk", Price = 148, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 1216, AllSeats = 60, DateTime = DateTime.Parse("2022-06-24"), From = "Meksyk", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 1217, AllSeats = 86, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Meksyk", Price = 123, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1218, AllSeats = 86, DateTime = DateTime.Parse("2022-06-24"), From = "Meksyk", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1219, AllSeats = 38, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Seszele", Price = 107, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 1220, AllSeats = 38, DateTime = DateTime.Parse("2022-06-24"), From = "Seszele", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 1221, AllSeats = 57, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Seszele", Price = 124, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1222, AllSeats = 57, DateTime = DateTime.Parse("2022-06-24"), From = "Seszele", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1223, AllSeats = 47, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Seszele", Price = 130, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 1224, AllSeats = 47, DateTime = DateTime.Parse("2022-06-24"), From = "Seszele", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 1225, AllSeats = 60, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Slowenia", Price = 57, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 1226, AllSeats = 60, DateTime = DateTime.Parse("2022-06-24"), From = "Slowenia", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 1227, AllSeats = 83, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Slowenia", Price = 106, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 1228, AllSeats = 83, DateTime = DateTime.Parse("2022-06-24"), From = "Slowenia", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 1229, AllSeats = 35, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1230, AllSeats = 35, DateTime = DateTime.Parse("2022-06-24"), From = "Slowenia", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1231, AllSeats = 88, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Turcja", Price = 139, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1232, AllSeats = 88, DateTime = DateTime.Parse("2022-06-24"), From = "Turcja", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1233, AllSeats = 99, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Turcja", Price = 101, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1234, AllSeats = 99, DateTime = DateTime.Parse("2022-06-24"), From = "Turcja", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1235, AllSeats = 46, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Turcja", Price = 120, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1236, AllSeats = 46, DateTime = DateTime.Parse("2022-06-24"), From = "Turcja", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1237, AllSeats = 34, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 137, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1238, AllSeats = 34, DateTime = DateTime.Parse("2022-06-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1239, AllSeats = 53, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 144, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 1240, AllSeats = 53, DateTime = DateTime.Parse("2022-06-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 1241, AllSeats = 26, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 144, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1242, AllSeats = 26, DateTime = DateTime.Parse("2022-06-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 61, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1243, AllSeats = 25, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Zanzibar", Price = 113, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1244, AllSeats = 25, DateTime = DateTime.Parse("2022-06-24"), From = "Zanzibar", To = "Gdansk", Price = 70, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1245, AllSeats = 92, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Zanzibar", Price = 71, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1246, AllSeats = 92, DateTime = DateTime.Parse("2022-06-24"), From = "Zanzibar", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1247, AllSeats = 30, DateTime = DateTime.Parse("2022-06-24"), From = "Gdansk", To = "Zanzibar", Price = 115, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1248, AllSeats = 30, DateTime = DateTime.Parse("2022-06-24"), From = "Zanzibar", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1249, AllSeats = 59, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Albania", Price = 108, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1250, AllSeats = 59, DateTime = DateTime.Parse("2022-06-25"), From = "Albania", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1251, AllSeats = 63, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Albania", Price = 69, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1252, AllSeats = 63, DateTime = DateTime.Parse("2022-06-25"), From = "Albania", To = "Gdansk", Price = 71, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1253, AllSeats = 75, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Albania", Price = 83, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 1254, AllSeats = 75, DateTime = DateTime.Parse("2022-06-25"), From = "Albania", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 1255, AllSeats = 66, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Bulgaria", Price = 137, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1256, AllSeats = 66, DateTime = DateTime.Parse("2022-06-25"), From = "Bulgaria", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1257, AllSeats = 78, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1258, AllSeats = 78, DateTime = DateTime.Parse("2022-06-25"), From = "Bulgaria", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1259, AllSeats = 40, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Bulgaria", Price = 52, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 1260, AllSeats = 40, DateTime = DateTime.Parse("2022-06-25"), From = "Bulgaria", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 1261, AllSeats = 65, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Czarnogora", Price = 110, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1262, AllSeats = 65, DateTime = DateTime.Parse("2022-06-25"), From = "Czarnogora", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1263, AllSeats = 75, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Czarnogora", Price = 96, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1264, AllSeats = 75, DateTime = DateTime.Parse("2022-06-25"), From = "Czarnogora", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1265, AllSeats = 89, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Czarnogora", Price = 66, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 1266, AllSeats = 89, DateTime = DateTime.Parse("2022-06-25"), From = "Czarnogora", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 1267, AllSeats = 68, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Egipt", Price = 56, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 1268, AllSeats = 68, DateTime = DateTime.Parse("2022-06-25"), From = "Egipt", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 1269, AllSeats = 88, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Egipt", Price = 83, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1270, AllSeats = 88, DateTime = DateTime.Parse("2022-06-25"), From = "Egipt", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1271, AllSeats = 63, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Egipt", Price = 101, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 1272, AllSeats = 63, DateTime = DateTime.Parse("2022-06-25"), From = "Egipt", To = "Gdansk", Price = 94, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 1273, AllSeats = 93, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Grecja", Price = 105, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 1274, AllSeats = 93, DateTime = DateTime.Parse("2022-06-25"), From = "Grecja", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 1275, AllSeats = 26, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Grecja", Price = 105, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1276, AllSeats = 26, DateTime = DateTime.Parse("2022-06-25"), From = "Grecja", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1277, AllSeats = 73, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Grecja", Price = 90, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1278, AllSeats = 73, DateTime = DateTime.Parse("2022-06-25"), From = "Grecja", To = "Gdansk", Price = 59, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1279, AllSeats = 33, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Gruzja", Price = 116, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1280, AllSeats = 33, DateTime = DateTime.Parse("2022-06-25"), From = "Gruzja", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1281, AllSeats = 99, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Gruzja", Price = 83, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1282, AllSeats = 99, DateTime = DateTime.Parse("2022-06-25"), From = "Gruzja", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1283, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Gruzja", Price = 128, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1284, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Gruzja", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1285, AllSeats = 40, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Madera", Price = 143, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 1286, AllSeats = 40, DateTime = DateTime.Parse("2022-06-25"), From = "Madera", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 1287, AllSeats = 96, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Madera", Price = 66, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1288, AllSeats = 96, DateTime = DateTime.Parse("2022-06-25"), From = "Madera", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1289, AllSeats = 86, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Madera", Price = 112, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1290, AllSeats = 86, DateTime = DateTime.Parse("2022-06-25"), From = "Madera", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1291, AllSeats = 74, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malediwy", Price = 65, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1292, AllSeats = 74, DateTime = DateTime.Parse("2022-06-25"), From = "Malediwy", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1293, AllSeats = 91, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malediwy", Price = 117, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1294, AllSeats = 91, DateTime = DateTime.Parse("2022-06-25"), From = "Malediwy", To = "Gdansk", Price = 101, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1295, AllSeats = 31, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malediwy", Price = 125, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1296, AllSeats = 31, DateTime = DateTime.Parse("2022-06-25"), From = "Malediwy", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1297, AllSeats = 90, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malta", Price = 69, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 1298, AllSeats = 90, DateTime = DateTime.Parse("2022-06-25"), From = "Malta", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 1299, AllSeats = 64, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malta", Price = 102, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 1300, AllSeats = 64, DateTime = DateTime.Parse("2022-06-25"), From = "Malta", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 1301, AllSeats = 93, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Malta", Price = 139, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 1302, AllSeats = 93, DateTime = DateTime.Parse("2022-06-25"), From = "Malta", To = "Gdansk", Price = 81, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 1303, AllSeats = 53, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Mauritius", Price = 65, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 1304, AllSeats = 53, DateTime = DateTime.Parse("2022-06-25"), From = "Mauritius", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 1305, AllSeats = 90, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Mauritius", Price = 58, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 1306, AllSeats = 90, DateTime = DateTime.Parse("2022-06-25"), From = "Mauritius", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 1307, AllSeats = 73, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Mauritius", Price = 79, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1308, AllSeats = 73, DateTime = DateTime.Parse("2022-06-25"), From = "Mauritius", To = "Gdansk", Price = 57, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1309, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Meksyk", Price = 70, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1310, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Meksyk", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1311, AllSeats = 84, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Meksyk", Price = 70, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 1312, AllSeats = 84, DateTime = DateTime.Parse("2022-06-25"), From = "Meksyk", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 1313, AllSeats = 91, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Meksyk", Price = 107, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1314, AllSeats = 91, DateTime = DateTime.Parse("2022-06-25"), From = "Meksyk", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1315, AllSeats = 60, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Seszele", Price = 90, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 1316, AllSeats = 60, DateTime = DateTime.Parse("2022-06-25"), From = "Seszele", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 1317, AllSeats = 72, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Seszele", Price = 61, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 1318, AllSeats = 72, DateTime = DateTime.Parse("2022-06-25"), From = "Seszele", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 1319, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Seszele", Price = 75, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1320, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Seszele", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 1321, AllSeats = 42, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Slowenia", Price = 103, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 1322, AllSeats = 42, DateTime = DateTime.Parse("2022-06-25"), From = "Slowenia", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 1323, AllSeats = 45, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Slowenia", Price = 139, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1324, AllSeats = 45, DateTime = DateTime.Parse("2022-06-25"), From = "Slowenia", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1325, AllSeats = 71, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Slowenia", Price = 98, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 1326, AllSeats = 71, DateTime = DateTime.Parse("2022-06-25"), From = "Slowenia", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 1327, AllSeats = 45, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Turcja", Price = 135, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 1328, AllSeats = 45, DateTime = DateTime.Parse("2022-06-25"), From = "Turcja", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 1329, AllSeats = 69, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Turcja", Price = 127, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 1330, AllSeats = 69, DateTime = DateTime.Parse("2022-06-25"), From = "Turcja", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 1331, AllSeats = 44, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Turcja", Price = 95, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 1332, AllSeats = 44, DateTime = DateTime.Parse("2022-06-25"), From = "Turcja", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 1333, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 80, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1334, AllSeats = 54, DateTime = DateTime.Parse("2022-06-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 108, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1335, AllSeats = 62, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 146, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1336, AllSeats = 62, DateTime = DateTime.Parse("2022-06-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1337, AllSeats = 37, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 94, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 1338, AllSeats = 37, DateTime = DateTime.Parse("2022-06-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 1339, AllSeats = 79, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Zanzibar", Price = 71, Type = TransportType.Bus, AvailableSeats = 79
},
new()
{
Id = 1340, AllSeats = 79, DateTime = DateTime.Parse("2022-06-25"), From = "Zanzibar", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 79
},
new()
{
Id = 1341, AllSeats = 81, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Zanzibar", Price = 137, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1342, AllSeats = 81, DateTime = DateTime.Parse("2022-06-25"), From = "Zanzibar", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1343, AllSeats = 26, DateTime = DateTime.Parse("2022-06-25"), From = "Gdansk", To = "Zanzibar", Price = 121, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1344, AllSeats = 26, DateTime = DateTime.Parse("2022-06-25"), From = "Zanzibar", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1345, AllSeats = 34, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Albania", Price = 61, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1346, AllSeats = 34, DateTime = DateTime.Parse("2022-06-26"), From = "Albania", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1347, AllSeats = 86, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Albania", Price = 149, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1348, AllSeats = 86, DateTime = DateTime.Parse("2022-06-26"), From = "Albania", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1349, AllSeats = 87, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Albania", Price = 62, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1350, AllSeats = 87, DateTime = DateTime.Parse("2022-06-26"), From = "Albania", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1351, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Bulgaria", Price = 89, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1352, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Bulgaria", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1353, AllSeats = 45, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Bulgaria", Price = 111, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1354, AllSeats = 45, DateTime = DateTime.Parse("2022-06-26"), From = "Bulgaria", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1355, AllSeats = 82, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Bulgaria", Price = 144, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1356, AllSeats = 82, DateTime = DateTime.Parse("2022-06-26"), From = "Bulgaria", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1357, AllSeats = 95, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Czarnogora", Price = 89, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 1358, AllSeats = 95, DateTime = DateTime.Parse("2022-06-26"), From = "Czarnogora", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 1359, AllSeats = 71, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Czarnogora", Price = 116, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 1360, AllSeats = 71, DateTime = DateTime.Parse("2022-06-26"), From = "Czarnogora", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 1361, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Czarnogora", Price = 81, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1362, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Czarnogora", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1363, AllSeats = 77, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Egipt", Price = 123, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1364, AllSeats = 77, DateTime = DateTime.Parse("2022-06-26"), From = "Egipt", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1365, AllSeats = 57, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Egipt", Price = 102, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1366, AllSeats = 57, DateTime = DateTime.Parse("2022-06-26"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1367, AllSeats = 68, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Egipt", Price = 79, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 1368, AllSeats = 68, DateTime = DateTime.Parse("2022-06-26"), From = "Egipt", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 1369, AllSeats = 59, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Grecja", Price = 103, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1370, AllSeats = 59, DateTime = DateTime.Parse("2022-06-26"), From = "Grecja", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1371, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Grecja", Price = 126, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1372, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Grecja", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1373, AllSeats = 35, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Grecja", Price = 115, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1374, AllSeats = 35, DateTime = DateTime.Parse("2022-06-26"), From = "Grecja", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1375, AllSeats = 75, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Gruzja", Price = 139, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1376, AllSeats = 75, DateTime = DateTime.Parse("2022-06-26"), From = "Gruzja", To = "Gdansk", Price = 74, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 1377, AllSeats = 61, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Gruzja", Price = 95, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1378, AllSeats = 61, DateTime = DateTime.Parse("2022-06-26"), From = "Gruzja", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1379, AllSeats = 53, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Gruzja", Price = 69, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 1380, AllSeats = 53, DateTime = DateTime.Parse("2022-06-26"), From = "Gruzja", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 1381, AllSeats = 41, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Madera", Price = 62, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 1382, AllSeats = 41, DateTime = DateTime.Parse("2022-06-26"), From = "Madera", To = "Gdansk", Price = 89, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 1383, AllSeats = 97, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Madera", Price = 140, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 1384, AllSeats = 97, DateTime = DateTime.Parse("2022-06-26"), From = "Madera", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 1385, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Madera", Price = 149, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1386, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Madera", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 1387, AllSeats = 32, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malediwy", Price = 84, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 1388, AllSeats = 32, DateTime = DateTime.Parse("2022-06-26"), From = "Malediwy", To = "Gdansk", Price = 58, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 1389, AllSeats = 65, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malediwy", Price = 122, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 1390, AllSeats = 65, DateTime = DateTime.Parse("2022-06-26"), From = "Malediwy", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 1391, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malediwy", Price = 104, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 1392, AllSeats = 63, DateTime = DateTime.Parse("2022-06-26"), From = "Malediwy", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 1393, AllSeats = 48, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malta", Price = 95, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 1394, AllSeats = 48, DateTime = DateTime.Parse("2022-06-26"), From = "Malta", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 1395, AllSeats = 32, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malta", Price = 52, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1396, AllSeats = 32, DateTime = DateTime.Parse("2022-06-26"), From = "Malta", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1397, AllSeats = 53, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Malta", Price = 99, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 1398, AllSeats = 53, DateTime = DateTime.Parse("2022-06-26"), From = "Malta", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 1399, AllSeats = 69, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Mauritius", Price = 119, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1400, AllSeats = 69, DateTime = DateTime.Parse("2022-06-26"), From = "Mauritius", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 1401, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Mauritius", Price = 106, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1402, AllSeats = 31, DateTime = DateTime.Parse("2022-06-26"), From = "Mauritius", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1403, AllSeats = 91, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Mauritius", Price = 146, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1404, AllSeats = 91, DateTime = DateTime.Parse("2022-06-26"), From = "Mauritius", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1405, AllSeats = 92, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Meksyk", Price = 64, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1406, AllSeats = 92, DateTime = DateTime.Parse("2022-06-26"), From = "Meksyk", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1407, AllSeats = 43, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Meksyk", Price = 139, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 1408, AllSeats = 43, DateTime = DateTime.Parse("2022-06-26"), From = "Meksyk", To = "Gdansk", Price = 89, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 1409, AllSeats = 52, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Meksyk", Price = 120, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 1410, AllSeats = 52, DateTime = DateTime.Parse("2022-06-26"), From = "Meksyk", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 1411, AllSeats = 92, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Seszele", Price = 139, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1412, AllSeats = 92, DateTime = DateTime.Parse("2022-06-26"), From = "Seszele", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1413, AllSeats = 95, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Seszele", Price = 72, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1414, AllSeats = 95, DateTime = DateTime.Parse("2022-06-26"), From = "Seszele", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1415, AllSeats = 64, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Seszele", Price = 70, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 1416, AllSeats = 64, DateTime = DateTime.Parse("2022-06-26"), From = "Seszele", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 1417, AllSeats = 87, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Slowenia", Price = 101, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1418, AllSeats = 87, DateTime = DateTime.Parse("2022-06-26"), From = "Slowenia", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1419, AllSeats = 86, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Slowenia", Price = 67, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1420, AllSeats = 86, DateTime = DateTime.Parse("2022-06-26"), From = "Slowenia", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1421, AllSeats = 74, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Slowenia", Price = 91, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1422, AllSeats = 74, DateTime = DateTime.Parse("2022-06-26"), From = "Slowenia", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1423, AllSeats = 74, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Turcja", Price = 142, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1424, AllSeats = 74, DateTime = DateTime.Parse("2022-06-26"), From = "Turcja", To = "Gdansk", Price = 87, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1425, AllSeats = 100, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Turcja", Price = 150, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1426, AllSeats = 100, DateTime = DateTime.Parse("2022-06-26"), From = "Turcja", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1427, AllSeats = 34, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Turcja", Price = 64, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 1428, AllSeats = 34, DateTime = DateTime.Parse("2022-06-26"), From = "Turcja", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 1429, AllSeats = 96, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 112, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 1430, AllSeats = 96, DateTime = DateTime.Parse("2022-06-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 1431, AllSeats = 71, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 83, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 1432, AllSeats = 71, DateTime = DateTime.Parse("2022-06-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 1433, AllSeats = 33, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 150, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 1434, AllSeats = 33, DateTime = DateTime.Parse("2022-06-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 1435, AllSeats = 72, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Zanzibar", Price = 99, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1436, AllSeats = 72, DateTime = DateTime.Parse("2022-06-26"), From = "Zanzibar", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1437, AllSeats = 99, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Zanzibar", Price = 84, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1438, AllSeats = 99, DateTime = DateTime.Parse("2022-06-26"), From = "Zanzibar", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1439, AllSeats = 70, DateTime = DateTime.Parse("2022-06-26"), From = "Gdansk", To = "Zanzibar", Price = 54, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1440, AllSeats = 70, DateTime = DateTime.Parse("2022-06-26"), From = "Zanzibar", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1441, AllSeats = 78, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Albania", Price = 53, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1442, AllSeats = 78, DateTime = DateTime.Parse("2022-06-27"), From = "Albania", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1443, AllSeats = 58, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Albania", Price = 101, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 1444, AllSeats = 58, DateTime = DateTime.Parse("2022-06-27"), From = "Albania", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 1445, AllSeats = 46, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Albania", Price = 64, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1446, AllSeats = 46, DateTime = DateTime.Parse("2022-06-27"), From = "Albania", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1447, AllSeats = 74, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Bulgaria", Price = 58, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1448, AllSeats = 74, DateTime = DateTime.Parse("2022-06-27"), From = "Bulgaria", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 1449, AllSeats = 89, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Bulgaria", Price = 51, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 1450, AllSeats = 89, DateTime = DateTime.Parse("2022-06-27"), From = "Bulgaria", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 1451, AllSeats = 60, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Bulgaria", Price = 101, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 1452, AllSeats = 60, DateTime = DateTime.Parse("2022-06-27"), From = "Bulgaria", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 1453, AllSeats = 34, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Czarnogora", Price = 75, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1454, AllSeats = 34, DateTime = DateTime.Parse("2022-06-27"), From = "Czarnogora", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1455, AllSeats = 56, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Czarnogora", Price = 62, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1456, AllSeats = 56, DateTime = DateTime.Parse("2022-06-27"), From = "Czarnogora", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1457, AllSeats = 96, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Czarnogora", Price = 102, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 1458, AllSeats = 96, DateTime = DateTime.Parse("2022-06-27"), From = "Czarnogora", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 1459, AllSeats = 78, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Egipt", Price = 66, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1460, AllSeats = 78, DateTime = DateTime.Parse("2022-06-27"), From = "Egipt", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1461, AllSeats = 52, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Egipt", Price = 78, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 1462, AllSeats = 52, DateTime = DateTime.Parse("2022-06-27"), From = "Egipt", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 1463, AllSeats = 36, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Egipt", Price = 145, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 1464, AllSeats = 36, DateTime = DateTime.Parse("2022-06-27"), From = "Egipt", To = "Gdansk", Price = 59, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 1465, AllSeats = 51, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Grecja", Price = 88, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 1466, AllSeats = 51, DateTime = DateTime.Parse("2022-06-27"), From = "Grecja", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 1467, AllSeats = 26, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Grecja", Price = 106, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1468, AllSeats = 26, DateTime = DateTime.Parse("2022-06-27"), From = "Grecja", To = "Gdansk", Price = 149, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1469, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Grecja", Price = 125, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 1470, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Grecja", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 1471, AllSeats = 63, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Gruzja", Price = 98, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1472, AllSeats = 63, DateTime = DateTime.Parse("2022-06-27"), From = "Gruzja", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1473, AllSeats = 86, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Gruzja", Price = 64, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1474, AllSeats = 86, DateTime = DateTime.Parse("2022-06-27"), From = "Gruzja", To = "Gdansk", Price = 123, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1475, AllSeats = 37, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Gruzja", Price = 86, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 1476, AllSeats = 37, DateTime = DateTime.Parse("2022-06-27"), From = "Gruzja", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 1477, AllSeats = 76, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Madera", Price = 124, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1478, AllSeats = 76, DateTime = DateTime.Parse("2022-06-27"), From = "Madera", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1479, AllSeats = 67, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Madera", Price = 92, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1480, AllSeats = 67, DateTime = DateTime.Parse("2022-06-27"), From = "Madera", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1481, AllSeats = 45, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Madera", Price = 70, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1482, AllSeats = 45, DateTime = DateTime.Parse("2022-06-27"), From = "Madera", To = "Gdansk", Price = 89, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1483, AllSeats = 25, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malediwy", Price = 66, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1484, AllSeats = 25, DateTime = DateTime.Parse("2022-06-27"), From = "Malediwy", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1485, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malediwy", Price = 73, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1486, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Malediwy", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1487, AllSeats = 81, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malediwy", Price = 52, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1488, AllSeats = 81, DateTime = DateTime.Parse("2022-06-27"), From = "Malediwy", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1489, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malta", Price = 140, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 1490, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Malta", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 1491, AllSeats = 88, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malta", Price = 91, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1492, AllSeats = 88, DateTime = DateTime.Parse("2022-06-27"), From = "Malta", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1493, AllSeats = 70, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Malta", Price = 132, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1494, AllSeats = 70, DateTime = DateTime.Parse("2022-06-27"), From = "Malta", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1495, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Mauritius", Price = 95, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1496, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Mauritius", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1497, AllSeats = 57, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Mauritius", Price = 104, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1498, AllSeats = 57, DateTime = DateTime.Parse("2022-06-27"), From = "Mauritius", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1499, AllSeats = 82, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Mauritius", Price = 105, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1500, AllSeats = 82, DateTime = DateTime.Parse("2022-06-27"), From = "Mauritius", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1501, AllSeats = 30, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Meksyk", Price = 124, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 1502, AllSeats = 30, DateTime = DateTime.Parse("2022-06-27"), From = "Meksyk", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 1503, AllSeats = 27, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Meksyk", Price = 75, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1504, AllSeats = 27, DateTime = DateTime.Parse("2022-06-27"), From = "Meksyk", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1505, AllSeats = 65, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Meksyk", Price = 84, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1506, AllSeats = 65, DateTime = DateTime.Parse("2022-06-27"), From = "Meksyk", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1507, AllSeats = 50, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Seszele", Price = 129, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 1508, AllSeats = 50, DateTime = DateTime.Parse("2022-06-27"), From = "Seszele", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 1509, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Seszele", Price = 102, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1510, AllSeats = 91, DateTime = DateTime.Parse("2022-06-27"), From = "Seszele", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 1511, AllSeats = 46, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Seszele", Price = 92, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1512, AllSeats = 46, DateTime = DateTime.Parse("2022-06-27"), From = "Seszele", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1513, AllSeats = 49, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Slowenia", Price = 129, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 1514, AllSeats = 49, DateTime = DateTime.Parse("2022-06-27"), From = "Slowenia", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 1515, AllSeats = 100, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Slowenia", Price = 113, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1516, AllSeats = 100, DateTime = DateTime.Parse("2022-06-27"), From = "Slowenia", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1517, AllSeats = 45, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Slowenia", Price = 102, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1518, AllSeats = 45, DateTime = DateTime.Parse("2022-06-27"), From = "Slowenia", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1519, AllSeats = 33, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1520, AllSeats = 33, DateTime = DateTime.Parse("2022-06-27"), From = "Turcja", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1521, AllSeats = 26, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Turcja", Price = 65, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1522, AllSeats = 26, DateTime = DateTime.Parse("2022-06-27"), From = "Turcja", To = "Gdansk", Price = 121, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1523, AllSeats = 35, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Turcja", Price = 102, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1524, AllSeats = 35, DateTime = DateTime.Parse("2022-06-27"), From = "Turcja", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1525, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 66, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1526, AllSeats = 80, DateTime = DateTime.Parse("2022-06-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1527, AllSeats = 96, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 117, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1528, AllSeats = 96, DateTime = DateTime.Parse("2022-06-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 1529, AllSeats = 55, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 124, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1530, AllSeats = 55, DateTime = DateTime.Parse("2022-06-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1531, AllSeats = 86, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Zanzibar", Price = 109, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1532, AllSeats = 86, DateTime = DateTime.Parse("2022-06-27"), From = "Zanzibar", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1533, AllSeats = 67, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Zanzibar", Price = 125, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1534, AllSeats = 67, DateTime = DateTime.Parse("2022-06-27"), From = "Zanzibar", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1535, AllSeats = 97, DateTime = DateTime.Parse("2022-06-27"), From = "Gdansk", To = "Zanzibar", Price = 53, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1536, AllSeats = 97, DateTime = DateTime.Parse("2022-06-27"), From = "Zanzibar", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1537, AllSeats = 52, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Albania", Price = 70, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1538, AllSeats = 52, DateTime = DateTime.Parse("2022-06-28"), From = "Albania", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1539, AllSeats = 81, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Albania", Price = 70, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1540, AllSeats = 81, DateTime = DateTime.Parse("2022-06-28"), From = "Albania", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1541, AllSeats = 78, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Albania", Price = 121, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1542, AllSeats = 78, DateTime = DateTime.Parse("2022-06-28"), From = "Albania", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1543, AllSeats = 30, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Bulgaria", Price = 142, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 1544, AllSeats = 30, DateTime = DateTime.Parse("2022-06-28"), From = "Bulgaria", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 1545, AllSeats = 79, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Bulgaria", Price = 50, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 1546, AllSeats = 79, DateTime = DateTime.Parse("2022-06-28"), From = "Bulgaria", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 1547, AllSeats = 48, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Bulgaria", Price = 82, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 1548, AllSeats = 48, DateTime = DateTime.Parse("2022-06-28"), From = "Bulgaria", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 1549, AllSeats = 46, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Czarnogora", Price = 82, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 1550, AllSeats = 46, DateTime = DateTime.Parse("2022-06-28"), From = "Czarnogora", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 1551, AllSeats = 95, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Czarnogora", Price = 93, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1552, AllSeats = 95, DateTime = DateTime.Parse("2022-06-28"), From = "Czarnogora", To = "Gdansk", Price = 106, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 1553, AllSeats = 72, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Czarnogora", Price = 137, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1554, AllSeats = 72, DateTime = DateTime.Parse("2022-06-28"), From = "Czarnogora", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1555, AllSeats = 76, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Egipt", Price = 86, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1556, AllSeats = 76, DateTime = DateTime.Parse("2022-06-28"), From = "Egipt", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1557, AllSeats = 68, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Egipt", Price = 128, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1558, AllSeats = 68, DateTime = DateTime.Parse("2022-06-28"), From = "Egipt", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1559, AllSeats = 83, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Egipt", Price = 65, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1560, AllSeats = 83, DateTime = DateTime.Parse("2022-06-28"), From = "Egipt", To = "Gdansk", Price = 96, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1561, AllSeats = 85, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Grecja", Price = 67, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1562, AllSeats = 85, DateTime = DateTime.Parse("2022-06-28"), From = "Grecja", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1563, AllSeats = 45, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Grecja", Price = 114, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1564, AllSeats = 45, DateTime = DateTime.Parse("2022-06-28"), From = "Grecja", To = "Gdansk", Price = 149, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1565, AllSeats = 48, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Grecja", Price = 99, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 1566, AllSeats = 48, DateTime = DateTime.Parse("2022-06-28"), From = "Grecja", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 1567, AllSeats = 39, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Gruzja", Price = 119, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1568, AllSeats = 39, DateTime = DateTime.Parse("2022-06-28"), From = "Gruzja", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1569, AllSeats = 62, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Gruzja", Price = 119, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1570, AllSeats = 62, DateTime = DateTime.Parse("2022-06-28"), From = "Gruzja", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1571, AllSeats = 56, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Gruzja", Price = 70, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 1572, AllSeats = 56, DateTime = DateTime.Parse("2022-06-28"), From = "Gruzja", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 1573, AllSeats = 97, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Madera", Price = 125, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 1574, AllSeats = 97, DateTime = DateTime.Parse("2022-06-28"), From = "Madera", To = "Gdansk", Price = 118, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 1575, AllSeats = 53, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Madera", Price = 77, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 1576, AllSeats = 53, DateTime = DateTime.Parse("2022-06-28"), From = "Madera", To = "Gdansk", Price = 112, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 1577, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Madera", Price = 114, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1578, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Madera", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 1579, AllSeats = 44, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malediwy", Price = 54, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 1580, AllSeats = 44, DateTime = DateTime.Parse("2022-06-28"), From = "Malediwy", To = "Gdansk", Price = 74, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 1581, AllSeats = 37, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malediwy", Price = 55, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 1582, AllSeats = 37, DateTime = DateTime.Parse("2022-06-28"), From = "Malediwy", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 1583, AllSeats = 73, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malediwy", Price = 128, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1584, AllSeats = 73, DateTime = DateTime.Parse("2022-06-28"), From = "Malediwy", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1585, AllSeats = 33, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malta", Price = 118, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1586, AllSeats = 33, DateTime = DateTime.Parse("2022-06-28"), From = "Malta", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1587, AllSeats = 55, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malta", Price = 106, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 1588, AllSeats = 55, DateTime = DateTime.Parse("2022-06-28"), From = "Malta", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 1589, AllSeats = 97, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Malta", Price = 82, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1590, AllSeats = 97, DateTime = DateTime.Parse("2022-06-28"), From = "Malta", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1591, AllSeats = 87, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Mauritius", Price = 91, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1592, AllSeats = 87, DateTime = DateTime.Parse("2022-06-28"), From = "Mauritius", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 1593, AllSeats = 27, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Mauritius", Price = 63, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1594, AllSeats = 27, DateTime = DateTime.Parse("2022-06-28"), From = "Mauritius", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 1595, AllSeats = 83, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Mauritius", Price = 83, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1596, AllSeats = 83, DateTime = DateTime.Parse("2022-06-28"), From = "Mauritius", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1597, AllSeats = 39, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Meksyk", Price = 137, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1598, AllSeats = 39, DateTime = DateTime.Parse("2022-06-28"), From = "Meksyk", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1599, AllSeats = 86, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Meksyk", Price = 103, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1600, AllSeats = 86, DateTime = DateTime.Parse("2022-06-28"), From = "Meksyk", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1601, AllSeats = 62, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Meksyk", Price = 104, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1602, AllSeats = 62, DateTime = DateTime.Parse("2022-06-28"), From = "Meksyk", To = "Gdansk", Price = 141, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1603, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Seszele", Price = 66, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1604, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Seszele", To = "Gdansk", Price = 137, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1605, AllSeats = 61, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Seszele", Price = 104, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1606, AllSeats = 61, DateTime = DateTime.Parse("2022-06-28"), From = "Seszele", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1607, AllSeats = 33, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Seszele", Price = 60, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 1608, AllSeats = 33, DateTime = DateTime.Parse("2022-06-28"), From = "Seszele", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 1609, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Slowenia", Price = 110, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1610, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Slowenia", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1611, AllSeats = 84, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Slowenia", Price = 91, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 1612, AllSeats = 84, DateTime = DateTime.Parse("2022-06-28"), From = "Slowenia", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 1613, AllSeats = 29, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Slowenia", Price = 110, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1614, AllSeats = 29, DateTime = DateTime.Parse("2022-06-28"), From = "Slowenia", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1615, AllSeats = 73, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Turcja", Price = 58, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1616, AllSeats = 73, DateTime = DateTime.Parse("2022-06-28"), From = "Turcja", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1617, AllSeats = 45, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Turcja", Price = 119, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1618, AllSeats = 45, DateTime = DateTime.Parse("2022-06-28"), From = "Turcja", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1619, AllSeats = 82, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Turcja", Price = 133, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1620, AllSeats = 82, DateTime = DateTime.Parse("2022-06-28"), From = "Turcja", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1621, AllSeats = 43, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 97, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1622, AllSeats = 43, DateTime = DateTime.Parse("2022-06-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1623, AllSeats = 61, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 64, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1624, AllSeats = 61, DateTime = DateTime.Parse("2022-06-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 1625, AllSeats = 74, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 144, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1626, AllSeats = 74, DateTime = DateTime.Parse("2022-06-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1627, AllSeats = 82, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Zanzibar", Price = 101, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 1628, AllSeats = 82, DateTime = DateTime.Parse("2022-06-28"), From = "Zanzibar", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 1629, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Zanzibar", Price = 135, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1630, AllSeats = 26, DateTime = DateTime.Parse("2022-06-28"), From = "Zanzibar", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1631, AllSeats = 65, DateTime = DateTime.Parse("2022-06-28"), From = "Gdansk", To = "Zanzibar", Price = 146, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1632, AllSeats = 65, DateTime = DateTime.Parse("2022-06-28"), From = "Zanzibar", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1633, AllSeats = 27, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Albania", Price = 120, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 1634, AllSeats = 27, DateTime = DateTime.Parse("2022-06-29"), From = "Albania", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 1635, AllSeats = 75, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Albania", Price = 59, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1636, AllSeats = 75, DateTime = DateTime.Parse("2022-06-29"), From = "Albania", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1637, AllSeats = 72, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Albania", Price = 96, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1638, AllSeats = 72, DateTime = DateTime.Parse("2022-06-29"), From = "Albania", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1639, AllSeats = 85, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Bulgaria", Price = 117, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1640, AllSeats = 85, DateTime = DateTime.Parse("2022-06-29"), From = "Bulgaria", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 1641, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Bulgaria", Price = 74, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1642, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Bulgaria", To = "Gdansk", Price = 89, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1643, AllSeats = 72, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Bulgaria", Price = 98, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1644, AllSeats = 72, DateTime = DateTime.Parse("2022-06-29"), From = "Bulgaria", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1645, AllSeats = 58, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Czarnogora", Price = 51, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1646, AllSeats = 58, DateTime = DateTime.Parse("2022-06-29"), From = "Czarnogora", To = "Gdansk", Price = 99, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1647, AllSeats = 47, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Czarnogora", Price = 108, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 1648, AllSeats = 47, DateTime = DateTime.Parse("2022-06-29"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 1649, AllSeats = 71, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Czarnogora", Price = 77, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 1650, AllSeats = 71, DateTime = DateTime.Parse("2022-06-29"), From = "Czarnogora", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 1651, AllSeats = 47, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Egipt", Price = 88, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 1652, AllSeats = 47, DateTime = DateTime.Parse("2022-06-29"), From = "Egipt", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 1653, AllSeats = 99, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Egipt", Price = 141, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1654, AllSeats = 99, DateTime = DateTime.Parse("2022-06-29"), From = "Egipt", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1655, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Egipt", Price = 58, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1656, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Egipt", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1657, AllSeats = 76, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Grecja", Price = 150, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1658, AllSeats = 76, DateTime = DateTime.Parse("2022-06-29"), From = "Grecja", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1659, AllSeats = 50, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Grecja", Price = 126, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 1660, AllSeats = 50, DateTime = DateTime.Parse("2022-06-29"), From = "Grecja", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 1661, AllSeats = 84, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Grecja", Price = 75, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 1662, AllSeats = 84, DateTime = DateTime.Parse("2022-06-29"), From = "Grecja", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 1663, AllSeats = 29, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Gruzja", Price = 104, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 1664, AllSeats = 29, DateTime = DateTime.Parse("2022-06-29"), From = "Gruzja", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 1665, AllSeats = 31, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Gruzja", Price = 111, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1666, AllSeats = 31, DateTime = DateTime.Parse("2022-06-29"), From = "Gruzja", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1667, AllSeats = 83, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Gruzja", Price = 127, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1668, AllSeats = 83, DateTime = DateTime.Parse("2022-06-29"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1669, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Madera", Price = 148, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1670, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Madera", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1671, AllSeats = 32, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Madera", Price = 86, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1672, AllSeats = 32, DateTime = DateTime.Parse("2022-06-29"), From = "Madera", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1673, AllSeats = 45, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Madera", Price = 109, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1674, AllSeats = 45, DateTime = DateTime.Parse("2022-06-29"), From = "Madera", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 1675, AllSeats = 89, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malediwy", Price = 62, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 1676, AllSeats = 89, DateTime = DateTime.Parse("2022-06-29"), From = "Malediwy", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 1677, AllSeats = 62, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malediwy", Price = 78, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1678, AllSeats = 62, DateTime = DateTime.Parse("2022-06-29"), From = "Malediwy", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1679, AllSeats = 81, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malediwy", Price = 62, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1680, AllSeats = 81, DateTime = DateTime.Parse("2022-06-29"), From = "Malediwy", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1681, AllSeats = 37, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malta", Price = 60, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 1682, AllSeats = 37, DateTime = DateTime.Parse("2022-06-29"), From = "Malta", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 1683, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malta", Price = 113, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1684, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Malta", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1685, AllSeats = 32, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Malta", Price = 124, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1686, AllSeats = 32, DateTime = DateTime.Parse("2022-06-29"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1687, AllSeats = 90, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Mauritius", Price = 143, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 1688, AllSeats = 90, DateTime = DateTime.Parse("2022-06-29"), From = "Mauritius", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 1689, AllSeats = 87, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Mauritius", Price = 55, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1690, AllSeats = 87, DateTime = DateTime.Parse("2022-06-29"), From = "Mauritius", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1691, AllSeats = 95, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Mauritius", Price = 150, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 1692, AllSeats = 95, DateTime = DateTime.Parse("2022-06-29"), From = "Mauritius", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 1693, AllSeats = 42, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Meksyk", Price = 61, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 1694, AllSeats = 42, DateTime = DateTime.Parse("2022-06-29"), From = "Meksyk", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 1695, AllSeats = 100, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Meksyk", Price = 62, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1696, AllSeats = 100, DateTime = DateTime.Parse("2022-06-29"), From = "Meksyk", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 1697, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Meksyk", Price = 147, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1698, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Meksyk", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 1699, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Seszele", Price = 149, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1700, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Seszele", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1701, AllSeats = 88, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Seszele", Price = 141, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1702, AllSeats = 88, DateTime = DateTime.Parse("2022-06-29"), From = "Seszele", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1703, AllSeats = 85, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Seszele", Price = 56, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 1704, AllSeats = 85, DateTime = DateTime.Parse("2022-06-29"), From = "Seszele", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 1705, AllSeats = 96, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Slowenia", Price = 108, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 1706, AllSeats = 96, DateTime = DateTime.Parse("2022-06-29"), From = "Slowenia", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 1707, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Slowenia", Price = 54, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1708, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Slowenia", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1709, AllSeats = 86, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Slowenia", Price = 115, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1710, AllSeats = 86, DateTime = DateTime.Parse("2022-06-29"), From = "Slowenia", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 1711, AllSeats = 49, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Turcja", Price = 94, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 1712, AllSeats = 49, DateTime = DateTime.Parse("2022-06-29"), From = "Turcja", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 1713, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Turcja", Price = 74, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1714, AllSeats = 74, DateTime = DateTime.Parse("2022-06-29"), From = "Turcja", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1715, AllSeats = 83, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Turcja", Price = 112, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1716, AllSeats = 83, DateTime = DateTime.Parse("2022-06-29"), From = "Turcja", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 1717, AllSeats = 77, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 83, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1718, AllSeats = 77, DateTime = DateTime.Parse("2022-06-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1719, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 86, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1720, AllSeats = 92, DateTime = DateTime.Parse("2022-06-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 1721, AllSeats = 73, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 107, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1722, AllSeats = 73, DateTime = DateTime.Parse("2022-06-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1723, AllSeats = 35, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Zanzibar", Price = 106, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 1724, AllSeats = 35, DateTime = DateTime.Parse("2022-06-29"), From = "Zanzibar", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 1725, AllSeats = 45, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Zanzibar", Price = 133, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1726, AllSeats = 45, DateTime = DateTime.Parse("2022-06-29"), From = "Zanzibar", To = "Gdansk", Price = 140, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 1727, AllSeats = 88, DateTime = DateTime.Parse("2022-06-29"), From = "Gdansk", To = "Zanzibar", Price = 72, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1728, AllSeats = 88, DateTime = DateTime.Parse("2022-06-29"), From = "Zanzibar", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1729, AllSeats = 80, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Albania", Price = 66, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1730, AllSeats = 80, DateTime = DateTime.Parse("2022-06-30"), From = "Albania", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1731, AllSeats = 39, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Albania", Price = 97, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 1732, AllSeats = 39, DateTime = DateTime.Parse("2022-06-30"), From = "Albania", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 1733, AllSeats = 56, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Albania", Price = 130, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 1734, AllSeats = 56, DateTime = DateTime.Parse("2022-06-30"), From = "Albania", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 1735, AllSeats = 25, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Bulgaria", Price = 77, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1736, AllSeats = 25, DateTime = DateTime.Parse("2022-06-30"), From = "Bulgaria", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1737, AllSeats = 31, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Bulgaria", Price = 148, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1738, AllSeats = 31, DateTime = DateTime.Parse("2022-06-30"), From = "Bulgaria", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1739, AllSeats = 95, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Bulgaria", Price = 65, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 1740, AllSeats = 95, DateTime = DateTime.Parse("2022-06-30"), From = "Bulgaria", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 1741, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Czarnogora", Price = 135, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1742, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Czarnogora", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1743, AllSeats = 28, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Czarnogora", Price = 71, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1744, AllSeats = 28, DateTime = DateTime.Parse("2022-06-30"), From = "Czarnogora", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1745, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Czarnogora", Price = 99, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1746, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Czarnogora", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 1747, AllSeats = 72, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Egipt", Price = 107, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1748, AllSeats = 72, DateTime = DateTime.Parse("2022-06-30"), From = "Egipt", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 1749, AllSeats = 93, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Egipt", Price = 56, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 1750, AllSeats = 93, DateTime = DateTime.Parse("2022-06-30"), From = "Egipt", To = "Gdansk", Price = 115, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 1751, AllSeats = 29, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Egipt", Price = 61, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1752, AllSeats = 29, DateTime = DateTime.Parse("2022-06-30"), From = "Egipt", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 1753, AllSeats = 36, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Grecja", Price = 111, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1754, AllSeats = 36, DateTime = DateTime.Parse("2022-06-30"), From = "Grecja", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1755, AllSeats = 41, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Grecja", Price = 63, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 1756, AllSeats = 41, DateTime = DateTime.Parse("2022-06-30"), From = "Grecja", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 1757, AllSeats = 72, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Grecja", Price = 110, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1758, AllSeats = 72, DateTime = DateTime.Parse("2022-06-30"), From = "Grecja", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 1759, AllSeats = 54, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Gruzja", Price = 80, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1760, AllSeats = 54, DateTime = DateTime.Parse("2022-06-30"), From = "Gruzja", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 1761, AllSeats = 56, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Gruzja", Price = 150, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1762, AllSeats = 56, DateTime = DateTime.Parse("2022-06-30"), From = "Gruzja", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 1763, AllSeats = 35, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Gruzja", Price = 59, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1764, AllSeats = 35, DateTime = DateTime.Parse("2022-06-30"), From = "Gruzja", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 1765, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Madera", Price = 135, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1766, AllSeats = 73, DateTime = DateTime.Parse("2022-06-30"), From = "Madera", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1767, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Madera", Price = 144, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1768, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Madera", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 1769, AllSeats = 62, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Madera", Price = 63, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1770, AllSeats = 62, DateTime = DateTime.Parse("2022-06-30"), From = "Madera", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 1771, AllSeats = 62, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malediwy", Price = 108, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1772, AllSeats = 62, DateTime = DateTime.Parse("2022-06-30"), From = "Malediwy", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 1773, AllSeats = 49, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malediwy", Price = 139, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 1774, AllSeats = 49, DateTime = DateTime.Parse("2022-06-30"), From = "Malediwy", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 1775, AllSeats = 46, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malediwy", Price = 51, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1776, AllSeats = 46, DateTime = DateTime.Parse("2022-06-30"), From = "Malediwy", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1777, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malta", Price = 100, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1778, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Malta", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 1779, AllSeats = 76, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malta", Price = 73, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1780, AllSeats = 76, DateTime = DateTime.Parse("2022-06-30"), From = "Malta", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1781, AllSeats = 42, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Malta", Price = 107, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1782, AllSeats = 42, DateTime = DateTime.Parse("2022-06-30"), From = "Malta", To = "Gdansk", Price = 84, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1783, AllSeats = 88, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Mauritius", Price = 95, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1784, AllSeats = 88, DateTime = DateTime.Parse("2022-06-30"), From = "Mauritius", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1785, AllSeats = 30, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Mauritius", Price = 80, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1786, AllSeats = 30, DateTime = DateTime.Parse("2022-06-30"), From = "Mauritius", To = "Gdansk", Price = 121, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1787, AllSeats = 52, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Mauritius", Price = 113, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 1788, AllSeats = 52, DateTime = DateTime.Parse("2022-06-30"), From = "Mauritius", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 1789, AllSeats = 86, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Meksyk", Price = 146, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1790, AllSeats = 86, DateTime = DateTime.Parse("2022-06-30"), From = "Meksyk", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1791, AllSeats = 80, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Meksyk", Price = 79, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 1792, AllSeats = 80, DateTime = DateTime.Parse("2022-06-30"), From = "Meksyk", To = "Gdansk", Price = 76, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 1793, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Meksyk", Price = 142, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1794, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Meksyk", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1795, AllSeats = 63, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Seszele", Price = 68, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1796, AllSeats = 63, DateTime = DateTime.Parse("2022-06-30"), From = "Seszele", To = "Gdansk", Price = 137, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 1797, AllSeats = 63, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Seszele", Price = 50, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1798, AllSeats = 63, DateTime = DateTime.Parse("2022-06-30"), From = "Seszele", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 1799, AllSeats = 100, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Seszele", Price = 64, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 1800, AllSeats = 100, DateTime = DateTime.Parse("2022-06-30"), From = "Seszele", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 1801, AllSeats = 34, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Slowenia", Price = 61, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1802, AllSeats = 34, DateTime = DateTime.Parse("2022-06-30"), From = "Slowenia", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1803, AllSeats = 81, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Slowenia", Price = 141, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1804, AllSeats = 81, DateTime = DateTime.Parse("2022-06-30"), From = "Slowenia", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 1805, AllSeats = 70, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Slowenia", Price = 112, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1806, AllSeats = 70, DateTime = DateTime.Parse("2022-06-30"), From = "Slowenia", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 1807, AllSeats = 59, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Turcja", Price = 104, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1808, AllSeats = 59, DateTime = DateTime.Parse("2022-06-30"), From = "Turcja", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 1809, AllSeats = 98, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Turcja", Price = 76, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1810, AllSeats = 98, DateTime = DateTime.Parse("2022-06-30"), From = "Turcja", To = "Gdansk", Price = 139, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 1811, AllSeats = 92, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Turcja", Price = 121, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 1812, AllSeats = 92, DateTime = DateTime.Parse("2022-06-30"), From = "Turcja", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 1813, AllSeats = 65, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 84, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1814, AllSeats = 65, DateTime = DateTime.Parse("2022-06-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1815, AllSeats = 32, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 81, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1816, AllSeats = 32, DateTime = DateTime.Parse("2022-06-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 1817, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 119, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1818, AllSeats = 78, DateTime = DateTime.Parse("2022-06-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 1819, AllSeats = 76, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Zanzibar", Price = 150, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1820, AllSeats = 76, DateTime = DateTime.Parse("2022-06-30"), From = "Zanzibar", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 1821, AllSeats = 51, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Zanzibar", Price = 109, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 1822, AllSeats = 51, DateTime = DateTime.Parse("2022-06-30"), From = "Zanzibar", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 1823, AllSeats = 43, DateTime = DateTime.Parse("2022-06-30"), From = "Gdansk", To = "Zanzibar", Price = 110, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 1824, AllSeats = 43, DateTime = DateTime.Parse("2022-06-30"), From = "Zanzibar", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 1825, AllSeats = 26, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Albania", Price = 103, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1826, AllSeats = 26, DateTime = DateTime.Parse("2022-07-01"), From = "Albania", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 1827, AllSeats = 31, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Albania", Price = 121, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1828, AllSeats = 31, DateTime = DateTime.Parse("2022-07-01"), From = "Albania", To = "Gdansk", Price = 131, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1829, AllSeats = 30, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Albania", Price = 50, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1830, AllSeats = 30, DateTime = DateTime.Parse("2022-07-01"), From = "Albania", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1831, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Bulgaria", Price = 112, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 1832, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Bulgaria", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 1833, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Bulgaria", Price = 105, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 1834, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Bulgaria", To = "Gdansk", Price = 131, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 1835, AllSeats = 99, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Bulgaria", Price = 117, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 1836, AllSeats = 99, DateTime = DateTime.Parse("2022-07-01"), From = "Bulgaria", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 1837, AllSeats = 80, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Czarnogora", Price = 123, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1838, AllSeats = 80, DateTime = DateTime.Parse("2022-07-01"), From = "Czarnogora", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 1839, AllSeats = 83, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Czarnogora", Price = 129, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 1840, AllSeats = 83, DateTime = DateTime.Parse("2022-07-01"), From = "Czarnogora", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 1841, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Czarnogora", Price = 137, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1842, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Czarnogora", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 1843, AllSeats = 39, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Egipt", Price = 111, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1844, AllSeats = 39, DateTime = DateTime.Parse("2022-07-01"), From = "Egipt", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1845, AllSeats = 76, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Egipt", Price = 84, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1846, AllSeats = 76, DateTime = DateTime.Parse("2022-07-01"), From = "Egipt", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1847, AllSeats = 65, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Egipt", Price = 71, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1848, AllSeats = 65, DateTime = DateTime.Parse("2022-07-01"), From = "Egipt", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 1849, AllSeats = 92, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Grecja", Price = 141, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1850, AllSeats = 92, DateTime = DateTime.Parse("2022-07-01"), From = "Grecja", To = "Gdansk", Price = 137, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 1851, AllSeats = 99, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Grecja", Price = 145, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1852, AllSeats = 99, DateTime = DateTime.Parse("2022-07-01"), From = "Grecja", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 1853, AllSeats = 66, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Grecja", Price = 51, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1854, AllSeats = 66, DateTime = DateTime.Parse("2022-07-01"), From = "Grecja", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 1855, AllSeats = 66, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Gruzja", Price = 81, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1856, AllSeats = 66, DateTime = DateTime.Parse("2022-07-01"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 1857, AllSeats = 87, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Gruzja", Price = 113, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1858, AllSeats = 87, DateTime = DateTime.Parse("2022-07-01"), From = "Gruzja", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 1859, AllSeats = 25, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Gruzja", Price = 76, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 1860, AllSeats = 25, DateTime = DateTime.Parse("2022-07-01"), From = "Gruzja", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 1861, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Madera", Price = 74, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1862, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Madera", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 1863, AllSeats = 76, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Madera", Price = 121, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1864, AllSeats = 76, DateTime = DateTime.Parse("2022-07-01"), From = "Madera", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 1865, AllSeats = 91, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Madera", Price = 85, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1866, AllSeats = 91, DateTime = DateTime.Parse("2022-07-01"), From = "Madera", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 1867, AllSeats = 39, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malediwy", Price = 149, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1868, AllSeats = 39, DateTime = DateTime.Parse("2022-07-01"), From = "Malediwy", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 1869, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malediwy", Price = 136, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1870, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Malediwy", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 1871, AllSeats = 87, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malediwy", Price = 132, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1872, AllSeats = 87, DateTime = DateTime.Parse("2022-07-01"), From = "Malediwy", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 1873, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malta", Price = 70, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1874, AllSeats = 88, DateTime = DateTime.Parse("2022-07-01"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 1875, AllSeats = 52, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malta", Price = 88, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 1876, AllSeats = 52, DateTime = DateTime.Parse("2022-07-01"), From = "Malta", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 1877, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Malta", Price = 57, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 1878, AllSeats = 34, DateTime = DateTime.Parse("2022-07-01"), From = "Malta", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 1879, AllSeats = 25, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Mauritius", Price = 75, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1880, AllSeats = 25, DateTime = DateTime.Parse("2022-07-01"), From = "Mauritius", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 1881, AllSeats = 57, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Mauritius", Price = 84, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1882, AllSeats = 57, DateTime = DateTime.Parse("2022-07-01"), From = "Mauritius", To = "Gdansk", Price = 131, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 1883, AllSeats = 38, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Mauritius", Price = 89, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 1884, AllSeats = 38, DateTime = DateTime.Parse("2022-07-01"), From = "Mauritius", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 1885, AllSeats = 81, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Meksyk", Price = 114, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 1886, AllSeats = 81, DateTime = DateTime.Parse("2022-07-01"), From = "Meksyk", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 1887, AllSeats = 68, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Meksyk", Price = 51, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1888, AllSeats = 68, DateTime = DateTime.Parse("2022-07-01"), From = "Meksyk", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 1889, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Meksyk", Price = 145, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 1890, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Meksyk", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 1891, AllSeats = 89, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Seszele", Price = 128, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 1892, AllSeats = 89, DateTime = DateTime.Parse("2022-07-01"), From = "Seszele", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 1893, AllSeats = 67, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Seszele", Price = 63, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1894, AllSeats = 67, DateTime = DateTime.Parse("2022-07-01"), From = "Seszele", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1895, AllSeats = 82, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Seszele", Price = 109, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1896, AllSeats = 82, DateTime = DateTime.Parse("2022-07-01"), From = "Seszele", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 1897, AllSeats = 71, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Slowenia", Price = 50, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 1898, AllSeats = 71, DateTime = DateTime.Parse("2022-07-01"), From = "Slowenia", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 1899, AllSeats = 94, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Slowenia", Price = 122, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 1900, AllSeats = 94, DateTime = DateTime.Parse("2022-07-01"), From = "Slowenia", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 1901, AllSeats = 27, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Slowenia", Price = 146, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 1902, AllSeats = 27, DateTime = DateTime.Parse("2022-07-01"), From = "Slowenia", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 1903, AllSeats = 33, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Turcja", Price = 99, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1904, AllSeats = 33, DateTime = DateTime.Parse("2022-07-01"), From = "Turcja", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 1905, AllSeats = 85, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Turcja", Price = 60, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 1906, AllSeats = 85, DateTime = DateTime.Parse("2022-07-01"), From = "Turcja", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 1907, AllSeats = 32, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Turcja", Price = 64, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1908, AllSeats = 32, DateTime = DateTime.Parse("2022-07-01"), From = "Turcja", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 1909, AllSeats = 91, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 91, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 1910, AllSeats = 91, DateTime = DateTime.Parse("2022-07-01"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 1911, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 135, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 1912, AllSeats = 50, DateTime = DateTime.Parse("2022-07-01"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 1913, AllSeats = 46, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 120, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1914, AllSeats = 46, DateTime = DateTime.Parse("2022-07-01"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 66, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1915, AllSeats = 57, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Zanzibar", Price = 96, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 1916, AllSeats = 57, DateTime = DateTime.Parse("2022-07-01"), From = "Zanzibar", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 1917, AllSeats = 74, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Zanzibar", Price = 133, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1918, AllSeats = 74, DateTime = DateTime.Parse("2022-07-01"), From = "Zanzibar", To = "Gdansk", Price = 101, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 1919, AllSeats = 97, DateTime = DateTime.Parse("2022-07-01"), From = "Gdansk", To = "Zanzibar", Price = 132, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1920, AllSeats = 97, DateTime = DateTime.Parse("2022-07-01"), From = "Zanzibar", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1921, AllSeats = 53, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Albania", Price = 140, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 1922, AllSeats = 53, DateTime = DateTime.Parse("2022-07-02"), From = "Albania", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 1923, AllSeats = 26, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Albania", Price = 145, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1924, AllSeats = 26, DateTime = DateTime.Parse("2022-07-02"), From = "Albania", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 1925, AllSeats = 51, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Albania", Price = 91, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 1926, AllSeats = 51, DateTime = DateTime.Parse("2022-07-02"), From = "Albania", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 1927, AllSeats = 43, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1928, AllSeats = 43, DateTime = DateTime.Parse("2022-07-02"), From = "Bulgaria", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 1929, AllSeats = 31, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Bulgaria", Price = 80, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1930, AllSeats = 31, DateTime = DateTime.Parse("2022-07-02"), From = "Bulgaria", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 1931, AllSeats = 59, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Bulgaria", Price = 89, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 1932, AllSeats = 59, DateTime = DateTime.Parse("2022-07-02"), From = "Bulgaria", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 1933, AllSeats = 77, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Czarnogora", Price = 106, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1934, AllSeats = 77, DateTime = DateTime.Parse("2022-07-02"), From = "Czarnogora", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1935, AllSeats = 43, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Czarnogora", Price = 150, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 1936, AllSeats = 43, DateTime = DateTime.Parse("2022-07-02"), From = "Czarnogora", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 1937, AllSeats = 30, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Czarnogora", Price = 94, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1938, AllSeats = 30, DateTime = DateTime.Parse("2022-07-02"), From = "Czarnogora", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 1939, AllSeats = 36, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Egipt", Price = 130, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1940, AllSeats = 36, DateTime = DateTime.Parse("2022-07-02"), From = "Egipt", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1941, AllSeats = 65, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Egipt", Price = 105, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 1942, AllSeats = 65, DateTime = DateTime.Parse("2022-07-02"), From = "Egipt", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 1943, AllSeats = 39, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Egipt", Price = 62, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 1944, AllSeats = 39, DateTime = DateTime.Parse("2022-07-02"), From = "Egipt", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 1945, AllSeats = 52, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Grecja", Price = 55, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1946, AllSeats = 52, DateTime = DateTime.Parse("2022-07-02"), From = "Grecja", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1947, AllSeats = 86, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Grecja", Price = 107, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1948, AllSeats = 86, DateTime = DateTime.Parse("2022-07-02"), From = "Grecja", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 1949, AllSeats = 55, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Grecja", Price = 58, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1950, AllSeats = 55, DateTime = DateTime.Parse("2022-07-02"), From = "Grecja", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 1951, AllSeats = 58, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Gruzja", Price = 135, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1952, AllSeats = 58, DateTime = DateTime.Parse("2022-07-02"), From = "Gruzja", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 1953, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Gruzja", Price = 124, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1954, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1955, AllSeats = 42, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Gruzja", Price = 105, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1956, AllSeats = 42, DateTime = DateTime.Parse("2022-07-02"), From = "Gruzja", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 1957, AllSeats = 36, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Madera", Price = 78, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1958, AllSeats = 36, DateTime = DateTime.Parse("2022-07-02"), From = "Madera", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 1959, AllSeats = 89, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Madera", Price = 54, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 1960, AllSeats = 89, DateTime = DateTime.Parse("2022-07-02"), From = "Madera", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 1961, AllSeats = 46, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Madera", Price = 83, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1962, AllSeats = 46, DateTime = DateTime.Parse("2022-07-02"), From = "Madera", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 1963, AllSeats = 86, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malediwy", Price = 127, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1964, AllSeats = 86, DateTime = DateTime.Parse("2022-07-02"), From = "Malediwy", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 1965, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malediwy", Price = 143, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1966, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Malediwy", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 1967, AllSeats = 100, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malediwy", Price = 74, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 1968, AllSeats = 100, DateTime = DateTime.Parse("2022-07-02"), From = "Malediwy", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 1969, AllSeats = 73, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malta", Price = 80, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1970, AllSeats = 73, DateTime = DateTime.Parse("2022-07-02"), From = "Malta", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 1971, AllSeats = 30, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malta", Price = 122, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1972, AllSeats = 30, DateTime = DateTime.Parse("2022-07-02"), From = "Malta", To = "Gdansk", Price = 149, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 1973, AllSeats = 75, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Malta", Price = 110, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 1974, AllSeats = 75, DateTime = DateTime.Parse("2022-07-02"), From = "Malta", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 1975, AllSeats = 52, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Mauritius", Price = 110, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1976, AllSeats = 52, DateTime = DateTime.Parse("2022-07-02"), From = "Mauritius", To = "Gdansk", Price = 60, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 1977, AllSeats = 93, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Mauritius", Price = 115, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 1978, AllSeats = 93, DateTime = DateTime.Parse("2022-07-02"), From = "Mauritius", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 1979, AllSeats = 97, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Mauritius", Price = 128, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1980, AllSeats = 97, DateTime = DateTime.Parse("2022-07-02"), From = "Mauritius", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 1981, AllSeats = 65, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Meksyk", Price = 98, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1982, AllSeats = 65, DateTime = DateTime.Parse("2022-07-02"), From = "Meksyk", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 1983, AllSeats = 62, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Meksyk", Price = 123, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1984, AllSeats = 62, DateTime = DateTime.Parse("2022-07-02"), From = "Meksyk", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 1985, AllSeats = 81, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Meksyk", Price = 118, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1986, AllSeats = 81, DateTime = DateTime.Parse("2022-07-02"), From = "Meksyk", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 1987, AllSeats = 77, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Seszele", Price = 143, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1988, AllSeats = 77, DateTime = DateTime.Parse("2022-07-02"), From = "Seszele", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 1989, AllSeats = 67, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Seszele", Price = 107, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1990, AllSeats = 67, DateTime = DateTime.Parse("2022-07-02"), From = "Seszele", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 1991, AllSeats = 93, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Seszele", Price = 131, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 1992, AllSeats = 93, DateTime = DateTime.Parse("2022-07-02"), From = "Seszele", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 1993, AllSeats = 27, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Slowenia", Price = 93, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 1994, AllSeats = 27, DateTime = DateTime.Parse("2022-07-02"), From = "Slowenia", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 1995, AllSeats = 75, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Slowenia", Price = 118, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1996, AllSeats = 75, DateTime = DateTime.Parse("2022-07-02"), From = "Slowenia", To = "Gdansk", Price = 68, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 1997, AllSeats = 98, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Slowenia", Price = 71, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 1998, AllSeats = 98, DateTime = DateTime.Parse("2022-07-02"), From = "Slowenia", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 1999, AllSeats = 60, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Turcja", Price = 138, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2000, AllSeats = 60, DateTime = DateTime.Parse("2022-07-02"), From = "Turcja", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2001, AllSeats = 100, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Turcja", Price = 84, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2002, AllSeats = 100, DateTime = DateTime.Parse("2022-07-02"), From = "Turcja", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2003, AllSeats = 87, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Turcja", Price = 55, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2004, AllSeats = 87, DateTime = DateTime.Parse("2022-07-02"), From = "Turcja", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2005, AllSeats = 48, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 85, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 2006, AllSeats = 48, DateTime = DateTime.Parse("2022-07-02"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 2007, AllSeats = 27, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 98, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2008, AllSeats = 27, DateTime = DateTime.Parse("2022-07-02"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2009, AllSeats = 44, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 96, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2010, AllSeats = 44, DateTime = DateTime.Parse("2022-07-02"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2011, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Zanzibar", Price = 141, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2012, AllSeats = 28, DateTime = DateTime.Parse("2022-07-02"), From = "Zanzibar", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2013, AllSeats = 57, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Zanzibar", Price = 131, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2014, AllSeats = 57, DateTime = DateTime.Parse("2022-07-02"), From = "Zanzibar", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2015, AllSeats = 55, DateTime = DateTime.Parse("2022-07-02"), From = "Gdansk", To = "Zanzibar", Price = 63, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2016, AllSeats = 55, DateTime = DateTime.Parse("2022-07-02"), From = "Zanzibar", To = "Gdansk", Price = 100, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2017, AllSeats = 41, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Albania", Price = 97, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2018, AllSeats = 41, DateTime = DateTime.Parse("2022-07-03"), From = "Albania", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2019, AllSeats = 30, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Albania", Price = 62, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 2020, AllSeats = 30, DateTime = DateTime.Parse("2022-07-03"), From = "Albania", To = "Gdansk", Price = 86, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 2021, AllSeats = 80, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Albania", Price = 93, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2022, AllSeats = 80, DateTime = DateTime.Parse("2022-07-03"), From = "Albania", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2023, AllSeats = 56, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Bulgaria", Price = 110, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2024, AllSeats = 56, DateTime = DateTime.Parse("2022-07-03"), From = "Bulgaria", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2025, AllSeats = 32, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Bulgaria", Price = 110, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2026, AllSeats = 32, DateTime = DateTime.Parse("2022-07-03"), From = "Bulgaria", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2027, AllSeats = 92, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Bulgaria", Price = 101, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2028, AllSeats = 92, DateTime = DateTime.Parse("2022-07-03"), From = "Bulgaria", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2029, AllSeats = 29, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Czarnogora", Price = 111, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2030, AllSeats = 29, DateTime = DateTime.Parse("2022-07-03"), From = "Czarnogora", To = "Gdansk", Price = 148, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2031, AllSeats = 44, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Czarnogora", Price = 67, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 2032, AllSeats = 44, DateTime = DateTime.Parse("2022-07-03"), From = "Czarnogora", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 2033, AllSeats = 40, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Czarnogora", Price = 117, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2034, AllSeats = 40, DateTime = DateTime.Parse("2022-07-03"), From = "Czarnogora", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2035, AllSeats = 77, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Egipt", Price = 136, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2036, AllSeats = 77, DateTime = DateTime.Parse("2022-07-03"), From = "Egipt", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2037, AllSeats = 89, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Egipt", Price = 124, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 2038, AllSeats = 89, DateTime = DateTime.Parse("2022-07-03"), From = "Egipt", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 2039, AllSeats = 81, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Egipt", Price = 78, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 2040, AllSeats = 81, DateTime = DateTime.Parse("2022-07-03"), From = "Egipt", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 2041, AllSeats = 70, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Grecja", Price = 50, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2042, AllSeats = 70, DateTime = DateTime.Parse("2022-07-03"), From = "Grecja", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2043, AllSeats = 32, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Grecja", Price = 79, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2044, AllSeats = 32, DateTime = DateTime.Parse("2022-07-03"), From = "Grecja", To = "Gdansk", Price = 116, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2045, AllSeats = 65, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Grecja", Price = 99, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 2046, AllSeats = 65, DateTime = DateTime.Parse("2022-07-03"), From = "Grecja", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 2047, AllSeats = 38, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Gruzja", Price = 52, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 2048, AllSeats = 38, DateTime = DateTime.Parse("2022-07-03"), From = "Gruzja", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 2049, AllSeats = 25, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Gruzja", Price = 96, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 2050, AllSeats = 25, DateTime = DateTime.Parse("2022-07-03"), From = "Gruzja", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 2051, AllSeats = 47, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Gruzja", Price = 141, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 2052, AllSeats = 47, DateTime = DateTime.Parse("2022-07-03"), From = "Gruzja", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 2053, AllSeats = 70, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Madera", Price = 127, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2054, AllSeats = 70, DateTime = DateTime.Parse("2022-07-03"), From = "Madera", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2055, AllSeats = 59, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Madera", Price = 76, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 2056, AllSeats = 59, DateTime = DateTime.Parse("2022-07-03"), From = "Madera", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 2057, AllSeats = 53, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Madera", Price = 89, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 2058, AllSeats = 53, DateTime = DateTime.Parse("2022-07-03"), From = "Madera", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 2059, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malediwy", Price = 126, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2060, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Malediwy", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2061, AllSeats = 43, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malediwy", Price = 68, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2062, AllSeats = 43, DateTime = DateTime.Parse("2022-07-03"), From = "Malediwy", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2063, AllSeats = 28, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malediwy", Price = 138, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2064, AllSeats = 28, DateTime = DateTime.Parse("2022-07-03"), From = "Malediwy", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2065, AllSeats = 51, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malta", Price = 135, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2066, AllSeats = 51, DateTime = DateTime.Parse("2022-07-03"), From = "Malta", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2067, AllSeats = 82, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malta", Price = 126, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 2068, AllSeats = 82, DateTime = DateTime.Parse("2022-07-03"), From = "Malta", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 2069, AllSeats = 28, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Malta", Price = 105, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2070, AllSeats = 28, DateTime = DateTime.Parse("2022-07-03"), From = "Malta", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2071, AllSeats = 27, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Mauritius", Price = 60, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 2072, AllSeats = 27, DateTime = DateTime.Parse("2022-07-03"), From = "Mauritius", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 2073, AllSeats = 57, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Mauritius", Price = 66, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2074, AllSeats = 57, DateTime = DateTime.Parse("2022-07-03"), From = "Mauritius", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2075, AllSeats = 46, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Mauritius", Price = 50, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2076, AllSeats = 46, DateTime = DateTime.Parse("2022-07-03"), From = "Mauritius", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2077, AllSeats = 61, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Meksyk", Price = 53, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2078, AllSeats = 61, DateTime = DateTime.Parse("2022-07-03"), From = "Meksyk", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2079, AllSeats = 83, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Meksyk", Price = 68, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 2080, AllSeats = 83, DateTime = DateTime.Parse("2022-07-03"), From = "Meksyk", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 2081, AllSeats = 95, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2082, AllSeats = 95, DateTime = DateTime.Parse("2022-07-03"), From = "Meksyk", To = "Gdansk", Price = 62, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2083, AllSeats = 69, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Seszele", Price = 128, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2084, AllSeats = 69, DateTime = DateTime.Parse("2022-07-03"), From = "Seszele", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2085, AllSeats = 60, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Seszele", Price = 101, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2086, AllSeats = 60, DateTime = DateTime.Parse("2022-07-03"), From = "Seszele", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2087, AllSeats = 63, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Seszele", Price = 103, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 2088, AllSeats = 63, DateTime = DateTime.Parse("2022-07-03"), From = "Seszele", To = "Gdansk", Price = 112, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 2089, AllSeats = 62, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Slowenia", Price = 111, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2090, AllSeats = 62, DateTime = DateTime.Parse("2022-07-03"), From = "Slowenia", To = "Gdansk", Price = 108, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2091, AllSeats = 33, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Slowenia", Price = 62, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2092, AllSeats = 33, DateTime = DateTime.Parse("2022-07-03"), From = "Slowenia", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2093, AllSeats = 67, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Slowenia", Price = 81, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 2094, AllSeats = 67, DateTime = DateTime.Parse("2022-07-03"), From = "Slowenia", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 2095, AllSeats = 92, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Turcja", Price = 96, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2096, AllSeats = 92, DateTime = DateTime.Parse("2022-07-03"), From = "Turcja", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2097, AllSeats = 42, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Turcja", Price = 123, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2098, AllSeats = 42, DateTime = DateTime.Parse("2022-07-03"), From = "Turcja", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2099, AllSeats = 39, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Turcja", Price = 76, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2100, AllSeats = 39, DateTime = DateTime.Parse("2022-07-03"), From = "Turcja", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2101, AllSeats = 67, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 91, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 2102, AllSeats = 67, DateTime = DateTime.Parse("2022-07-03"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 2103, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 71, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 2104, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 2105, AllSeats = 41, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 134, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 2106, AllSeats = 41, DateTime = DateTime.Parse("2022-07-03"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 2107, AllSeats = 44, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Zanzibar", Price = 129, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2108, AllSeats = 44, DateTime = DateTime.Parse("2022-07-03"), From = "Zanzibar", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2109, AllSeats = 48, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Zanzibar", Price = 143, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2110, AllSeats = 48, DateTime = DateTime.Parse("2022-07-03"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2111, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Gdansk", To = "Zanzibar", Price = 74, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2112, AllSeats = 36, DateTime = DateTime.Parse("2022-07-03"), From = "Zanzibar", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2113, AllSeats = 63, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Albania", Price = 64, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 2114, AllSeats = 63, DateTime = DateTime.Parse("2022-07-04"), From = "Albania", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 2115, AllSeats = 80, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Albania", Price = 128, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2116, AllSeats = 80, DateTime = DateTime.Parse("2022-07-04"), From = "Albania", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2117, AllSeats = 57, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Albania", Price = 89, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2118, AllSeats = 57, DateTime = DateTime.Parse("2022-07-04"), From = "Albania", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2119, AllSeats = 77, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Bulgaria", Price = 112, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2120, AllSeats = 77, DateTime = DateTime.Parse("2022-07-04"), From = "Bulgaria", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2121, AllSeats = 64, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Bulgaria", Price = 128, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2122, AllSeats = 64, DateTime = DateTime.Parse("2022-07-04"), From = "Bulgaria", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2123, AllSeats = 52, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Bulgaria", Price = 56, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 2124, AllSeats = 52, DateTime = DateTime.Parse("2022-07-04"), From = "Bulgaria", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 2125, AllSeats = 75, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Czarnogora", Price = 84, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2126, AllSeats = 75, DateTime = DateTime.Parse("2022-07-04"), From = "Czarnogora", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2127, AllSeats = 50, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Czarnogora", Price = 65, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 2128, AllSeats = 50, DateTime = DateTime.Parse("2022-07-04"), From = "Czarnogora", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 2129, AllSeats = 97, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Czarnogora", Price = 78, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2130, AllSeats = 97, DateTime = DateTime.Parse("2022-07-04"), From = "Czarnogora", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2131, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Egipt", Price = 52, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 2132, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Egipt", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 2133, AllSeats = 48, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Egipt", Price = 126, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2134, AllSeats = 48, DateTime = DateTime.Parse("2022-07-04"), From = "Egipt", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2135, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Egipt", Price = 149, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2136, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Egipt", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2137, AllSeats = 61, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Grecja", Price = 86, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2138, AllSeats = 61, DateTime = DateTime.Parse("2022-07-04"), From = "Grecja", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2139, AllSeats = 95, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Grecja", Price = 118, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2140, AllSeats = 95, DateTime = DateTime.Parse("2022-07-04"), From = "Grecja", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2141, AllSeats = 77, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Grecja", Price = 122, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 2142, AllSeats = 77, DateTime = DateTime.Parse("2022-07-04"), From = "Grecja", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 2143, AllSeats = 47, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Gruzja", Price = 79, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2144, AllSeats = 47, DateTime = DateTime.Parse("2022-07-04"), From = "Gruzja", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2145, AllSeats = 69, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Gruzja", Price = 109, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2146, AllSeats = 69, DateTime = DateTime.Parse("2022-07-04"), From = "Gruzja", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2147, AllSeats = 29, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Gruzja", Price = 147, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 2148, AllSeats = 29, DateTime = DateTime.Parse("2022-07-04"), From = "Gruzja", To = "Gdansk", Price = 84, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 2149, AllSeats = 56, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Madera", Price = 142, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2150, AllSeats = 56, DateTime = DateTime.Parse("2022-07-04"), From = "Madera", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2151, AllSeats = 58, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Madera", Price = 61, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 2152, AllSeats = 58, DateTime = DateTime.Parse("2022-07-04"), From = "Madera", To = "Gdansk", Price = 68, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 2153, AllSeats = 39, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Madera", Price = 76, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2154, AllSeats = 39, DateTime = DateTime.Parse("2022-07-04"), From = "Madera", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2155, AllSeats = 28, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malediwy", Price = 64, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2156, AllSeats = 28, DateTime = DateTime.Parse("2022-07-04"), From = "Malediwy", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2157, AllSeats = 61, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malediwy", Price = 78, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2158, AllSeats = 61, DateTime = DateTime.Parse("2022-07-04"), From = "Malediwy", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2159, AllSeats = 58, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malediwy", Price = 124, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2160, AllSeats = 58, DateTime = DateTime.Parse("2022-07-04"), From = "Malediwy", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2161, AllSeats = 37, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malta", Price = 113, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 2162, AllSeats = 37, DateTime = DateTime.Parse("2022-07-04"), From = "Malta", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 2163, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malta", Price = 77, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2164, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Malta", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2165, AllSeats = 83, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Malta", Price = 50, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2166, AllSeats = 83, DateTime = DateTime.Parse("2022-07-04"), From = "Malta", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2167, AllSeats = 60, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Mauritius", Price = 132, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2168, AllSeats = 60, DateTime = DateTime.Parse("2022-07-04"), From = "Mauritius", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2169, AllSeats = 98, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Mauritius", Price = 136, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2170, AllSeats = 98, DateTime = DateTime.Parse("2022-07-04"), From = "Mauritius", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2171, AllSeats = 99, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Mauritius", Price = 109, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 2172, AllSeats = 99, DateTime = DateTime.Parse("2022-07-04"), From = "Mauritius", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 2173, AllSeats = 94, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Meksyk", Price = 87, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2174, AllSeats = 94, DateTime = DateTime.Parse("2022-07-04"), From = "Meksyk", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2175, AllSeats = 48, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Meksyk", Price = 69, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2176, AllSeats = 48, DateTime = DateTime.Parse("2022-07-04"), From = "Meksyk", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2177, AllSeats = 68, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Meksyk", Price = 57, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2178, AllSeats = 68, DateTime = DateTime.Parse("2022-07-04"), From = "Meksyk", To = "Gdansk", Price = 66, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2179, AllSeats = 30, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Seszele", Price = 111, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2180, AllSeats = 30, DateTime = DateTime.Parse("2022-07-04"), From = "Seszele", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2181, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Seszele", Price = 141, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2182, AllSeats = 71, DateTime = DateTime.Parse("2022-07-04"), From = "Seszele", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2183, AllSeats = 80, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Seszele", Price = 72, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2184, AllSeats = 80, DateTime = DateTime.Parse("2022-07-04"), From = "Seszele", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2185, AllSeats = 47, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Slowenia", Price = 60, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2186, AllSeats = 47, DateTime = DateTime.Parse("2022-07-04"), From = "Slowenia", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2187, AllSeats = 74, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Slowenia", Price = 59, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2188, AllSeats = 74, DateTime = DateTime.Parse("2022-07-04"), From = "Slowenia", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2189, AllSeats = 74, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Slowenia", Price = 63, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 2190, AllSeats = 74, DateTime = DateTime.Parse("2022-07-04"), From = "Slowenia", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 2191, AllSeats = 27, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Turcja", Price = 126, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 2192, AllSeats = 27, DateTime = DateTime.Parse("2022-07-04"), From = "Turcja", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 2193, AllSeats = 75, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Turcja", Price = 123, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2194, AllSeats = 75, DateTime = DateTime.Parse("2022-07-04"), From = "Turcja", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2195, AllSeats = 84, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Turcja", Price = 95, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2196, AllSeats = 84, DateTime = DateTime.Parse("2022-07-04"), From = "Turcja", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2197, AllSeats = 43, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 107, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 2198, AllSeats = 43, DateTime = DateTime.Parse("2022-07-04"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 2199, AllSeats = 70, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 142, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 2200, AllSeats = 70, DateTime = DateTime.Parse("2022-07-04"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 2201, AllSeats = 30, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 70, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2202, AllSeats = 30, DateTime = DateTime.Parse("2022-07-04"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2203, AllSeats = 40, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Zanzibar", Price = 148, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2204, AllSeats = 40, DateTime = DateTime.Parse("2022-07-04"), From = "Zanzibar", To = "Gdansk", Price = 118, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2205, AllSeats = 52, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Zanzibar", Price = 105, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2206, AllSeats = 52, DateTime = DateTime.Parse("2022-07-04"), From = "Zanzibar", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2207, AllSeats = 70, DateTime = DateTime.Parse("2022-07-04"), From = "Gdansk", To = "Zanzibar", Price = 106, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 2208, AllSeats = 70, DateTime = DateTime.Parse("2022-07-04"), From = "Zanzibar", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 2209, AllSeats = 75, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Albania", Price = 147, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2210, AllSeats = 75, DateTime = DateTime.Parse("2022-07-05"), From = "Albania", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2211, AllSeats = 93, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Albania", Price = 91, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 2212, AllSeats = 93, DateTime = DateTime.Parse("2022-07-05"), From = "Albania", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 2213, AllSeats = 54, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Albania", Price = 127, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 2214, AllSeats = 54, DateTime = DateTime.Parse("2022-07-05"), From = "Albania", To = "Gdansk", Price = 143, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 2215, AllSeats = 52, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Bulgaria", Price = 87, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 2216, AllSeats = 52, DateTime = DateTime.Parse("2022-07-05"), From = "Bulgaria", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 2217, AllSeats = 84, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Bulgaria", Price = 82, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 2218, AllSeats = 84, DateTime = DateTime.Parse("2022-07-05"), From = "Bulgaria", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 84
},
new()
{
Id = 2219, AllSeats = 83, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Bulgaria", Price = 134, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2220, AllSeats = 83, DateTime = DateTime.Parse("2022-07-05"), From = "Bulgaria", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2221, AllSeats = 49, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Czarnogora", Price = 146, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2222, AllSeats = 49, DateTime = DateTime.Parse("2022-07-05"), From = "Czarnogora", To = "Gdansk", Price = 139, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2223, AllSeats = 98, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Czarnogora", Price = 102, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2224, AllSeats = 98, DateTime = DateTime.Parse("2022-07-05"), From = "Czarnogora", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2225, AllSeats = 83, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Czarnogora", Price = 124, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2226, AllSeats = 83, DateTime = DateTime.Parse("2022-07-05"), From = "Czarnogora", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2227, AllSeats = 62, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Egipt", Price = 125, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2228, AllSeats = 62, DateTime = DateTime.Parse("2022-07-05"), From = "Egipt", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2229, AllSeats = 62, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Egipt", Price = 115, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 2230, AllSeats = 62, DateTime = DateTime.Parse("2022-07-05"), From = "Egipt", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 2231, AllSeats = 42, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Egipt", Price = 120, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2232, AllSeats = 42, DateTime = DateTime.Parse("2022-07-05"), From = "Egipt", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2233, AllSeats = 35, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Grecja", Price = 132, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2234, AllSeats = 35, DateTime = DateTime.Parse("2022-07-05"), From = "Grecja", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2235, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Grecja", Price = 113, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2236, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Grecja", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2237, AllSeats = 48, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Grecja", Price = 138, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 2238, AllSeats = 48, DateTime = DateTime.Parse("2022-07-05"), From = "Grecja", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 2239, AllSeats = 30, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Gruzja", Price = 59, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2240, AllSeats = 30, DateTime = DateTime.Parse("2022-07-05"), From = "Gruzja", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2241, AllSeats = 63, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Gruzja", Price = 81, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2242, AllSeats = 63, DateTime = DateTime.Parse("2022-07-05"), From = "Gruzja", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2243, AllSeats = 60, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Gruzja", Price = 145, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2244, AllSeats = 60, DateTime = DateTime.Parse("2022-07-05"), From = "Gruzja", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2245, AllSeats = 66, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Madera", Price = 127, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 2246, AllSeats = 66, DateTime = DateTime.Parse("2022-07-05"), From = "Madera", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 66
},
new()
{
Id = 2247, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Madera", Price = 95, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2248, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Madera", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2249, AllSeats = 56, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Madera", Price = 63, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2250, AllSeats = 56, DateTime = DateTime.Parse("2022-07-05"), From = "Madera", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2251, AllSeats = 29, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malediwy", Price = 130, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2252, AllSeats = 29, DateTime = DateTime.Parse("2022-07-05"), From = "Malediwy", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2253, AllSeats = 28, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malediwy", Price = 113, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 2254, AllSeats = 28, DateTime = DateTime.Parse("2022-07-05"), From = "Malediwy", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 2255, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malediwy", Price = 125, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2256, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Malediwy", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2257, AllSeats = 80, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malta", Price = 147, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 2258, AllSeats = 80, DateTime = DateTime.Parse("2022-07-05"), From = "Malta", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 2259, AllSeats = 32, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malta", Price = 101, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2260, AllSeats = 32, DateTime = DateTime.Parse("2022-07-05"), From = "Malta", To = "Gdansk", Price = 139, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2261, AllSeats = 60, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Malta", Price = 130, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2262, AllSeats = 60, DateTime = DateTime.Parse("2022-07-05"), From = "Malta", To = "Gdansk", Price = 123, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2263, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Mauritius", Price = 148, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2264, AllSeats = 87, DateTime = DateTime.Parse("2022-07-05"), From = "Mauritius", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2265, AllSeats = 30, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Mauritius", Price = 122, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 2266, AllSeats = 30, DateTime = DateTime.Parse("2022-07-05"), From = "Mauritius", To = "Gdansk", Price = 92, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 2267, AllSeats = 44, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Mauritius", Price = 101, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2268, AllSeats = 44, DateTime = DateTime.Parse("2022-07-05"), From = "Mauritius", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2269, AllSeats = 45, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Meksyk", Price = 121, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2270, AllSeats = 45, DateTime = DateTime.Parse("2022-07-05"), From = "Meksyk", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2271, AllSeats = 81, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Meksyk", Price = 150, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2272, AllSeats = 81, DateTime = DateTime.Parse("2022-07-05"), From = "Meksyk", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2273, AllSeats = 95, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Meksyk", Price = 75, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2274, AllSeats = 95, DateTime = DateTime.Parse("2022-07-05"), From = "Meksyk", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2275, AllSeats = 65, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Seszele", Price = 122, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 2276, AllSeats = 65, DateTime = DateTime.Parse("2022-07-05"), From = "Seszele", To = "Gdansk", Price = 58, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 2277, AllSeats = 79, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Seszele", Price = 62, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 2278, AllSeats = 79, DateTime = DateTime.Parse("2022-07-05"), From = "Seszele", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 2279, AllSeats = 40, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Seszele", Price = 111, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2280, AllSeats = 40, DateTime = DateTime.Parse("2022-07-05"), From = "Seszele", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2281, AllSeats = 91, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Slowenia", Price = 132, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 2282, AllSeats = 91, DateTime = DateTime.Parse("2022-07-05"), From = "Slowenia", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 2283, AllSeats = 69, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Slowenia", Price = 136, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2284, AllSeats = 69, DateTime = DateTime.Parse("2022-07-05"), From = "Slowenia", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2285, AllSeats = 79, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Slowenia", Price = 110, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2286, AllSeats = 79, DateTime = DateTime.Parse("2022-07-05"), From = "Slowenia", To = "Gdansk", Price = 62, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2287, AllSeats = 61, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Turcja", Price = 131, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2288, AllSeats = 61, DateTime = DateTime.Parse("2022-07-05"), From = "Turcja", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2289, AllSeats = 65, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Turcja", Price = 114, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2290, AllSeats = 65, DateTime = DateTime.Parse("2022-07-05"), From = "Turcja", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2291, AllSeats = 46, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Turcja", Price = 93, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2292, AllSeats = 46, DateTime = DateTime.Parse("2022-07-05"), From = "Turcja", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2293, AllSeats = 25, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 73, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 2294, AllSeats = 25, DateTime = DateTime.Parse("2022-07-05"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 2295, AllSeats = 80, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 107, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2296, AllSeats = 80, DateTime = DateTime.Parse("2022-07-05"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2297, AllSeats = 38, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 116, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 2298, AllSeats = 38, DateTime = DateTime.Parse("2022-07-05"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 2299, AllSeats = 100, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Zanzibar", Price = 128, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 2300, AllSeats = 100, DateTime = DateTime.Parse("2022-07-05"), From = "Zanzibar", To = "Gdansk", Price = 73, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 2301, AllSeats = 66, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Zanzibar", Price = 142, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 2302, AllSeats = 66, DateTime = DateTime.Parse("2022-07-05"), From = "Zanzibar", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 2303, AllSeats = 82, DateTime = DateTime.Parse("2022-07-05"), From = "Gdansk", To = "Zanzibar", Price = 95, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2304, AllSeats = 82, DateTime = DateTime.Parse("2022-07-05"), From = "Zanzibar", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2305, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Albania", Price = 78, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 2306, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Albania", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 2307, AllSeats = 34, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Albania", Price = 57, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2308, AllSeats = 34, DateTime = DateTime.Parse("2022-07-06"), From = "Albania", To = "Gdansk", Price = 76, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2309, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Albania", Price = 124, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2310, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Albania", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2311, AllSeats = 99, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Bulgaria", Price = 113, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 2312, AllSeats = 99, DateTime = DateTime.Parse("2022-07-06"), From = "Bulgaria", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 2313, AllSeats = 100, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Bulgaria", Price = 101, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2314, AllSeats = 100, DateTime = DateTime.Parse("2022-07-06"), From = "Bulgaria", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2315, AllSeats = 93, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Bulgaria", Price = 62, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2316, AllSeats = 93, DateTime = DateTime.Parse("2022-07-06"), From = "Bulgaria", To = "Gdansk", Price = 141, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2317, AllSeats = 98, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Czarnogora", Price = 143, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 2318, AllSeats = 98, DateTime = DateTime.Parse("2022-07-06"), From = "Czarnogora", To = "Gdansk", Price = 74, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 2319, AllSeats = 92, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Czarnogora", Price = 137, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2320, AllSeats = 92, DateTime = DateTime.Parse("2022-07-06"), From = "Czarnogora", To = "Gdansk", Price = 95, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2321, AllSeats = 40, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Czarnogora", Price = 60, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2322, AllSeats = 40, DateTime = DateTime.Parse("2022-07-06"), From = "Czarnogora", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2323, AllSeats = 86, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Egipt", Price = 91, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2324, AllSeats = 86, DateTime = DateTime.Parse("2022-07-06"), From = "Egipt", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2325, AllSeats = 61, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Egipt", Price = 141, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2326, AllSeats = 61, DateTime = DateTime.Parse("2022-07-06"), From = "Egipt", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2327, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Egipt", Price = 130, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2328, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Egipt", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2329, AllSeats = 41, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Grecja", Price = 109, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2330, AllSeats = 41, DateTime = DateTime.Parse("2022-07-06"), From = "Grecja", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2331, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Grecja", Price = 86, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2332, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Grecja", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2333, AllSeats = 62, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Grecja", Price = 134, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 2334, AllSeats = 62, DateTime = DateTime.Parse("2022-07-06"), From = "Grecja", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 2335, AllSeats = 53, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Gruzja", Price = 123, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 2336, AllSeats = 53, DateTime = DateTime.Parse("2022-07-06"), From = "Gruzja", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 2337, AllSeats = 42, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Gruzja", Price = 111, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2338, AllSeats = 42, DateTime = DateTime.Parse("2022-07-06"), From = "Gruzja", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2339, AllSeats = 50, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Gruzja", Price = 59, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2340, AllSeats = 50, DateTime = DateTime.Parse("2022-07-06"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2341, AllSeats = 98, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Madera", Price = 77, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 2342, AllSeats = 98, DateTime = DateTime.Parse("2022-07-06"), From = "Madera", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 2343, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Madera", Price = 76, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2344, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Madera", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2345, AllSeats = 59, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Madera", Price = 150, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 2346, AllSeats = 59, DateTime = DateTime.Parse("2022-07-06"), From = "Madera", To = "Gdansk", Price = 150, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 2347, AllSeats = 82, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malediwy", Price = 146, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 2348, AllSeats = 82, DateTime = DateTime.Parse("2022-07-06"), From = "Malediwy", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 2349, AllSeats = 28, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malediwy", Price = 60, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 2350, AllSeats = 28, DateTime = DateTime.Parse("2022-07-06"), From = "Malediwy", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 2351, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malediwy", Price = 111, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2352, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Malediwy", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2353, AllSeats = 54, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malta", Price = 72, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 2354, AllSeats = 54, DateTime = DateTime.Parse("2022-07-06"), From = "Malta", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 2355, AllSeats = 88, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malta", Price = 106, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 2356, AllSeats = 88, DateTime = DateTime.Parse("2022-07-06"), From = "Malta", To = "Gdansk", Price = 82, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 2357, AllSeats = 28, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Malta", Price = 122, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2358, AllSeats = 28, DateTime = DateTime.Parse("2022-07-06"), From = "Malta", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2359, AllSeats = 47, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Mauritius", Price = 137, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2360, AllSeats = 47, DateTime = DateTime.Parse("2022-07-06"), From = "Mauritius", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2361, AllSeats = 87, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Mauritius", Price = 147, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2362, AllSeats = 87, DateTime = DateTime.Parse("2022-07-06"), From = "Mauritius", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2363, AllSeats = 49, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Mauritius", Price = 112, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 2364, AllSeats = 49, DateTime = DateTime.Parse("2022-07-06"), From = "Mauritius", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 2365, AllSeats = 35, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Meksyk", Price = 135, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2366, AllSeats = 35, DateTime = DateTime.Parse("2022-07-06"), From = "Meksyk", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2367, AllSeats = 81, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Meksyk", Price = 146, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2368, AllSeats = 81, DateTime = DateTime.Parse("2022-07-06"), From = "Meksyk", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2369, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Meksyk", Price = 139, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2370, AllSeats = 71, DateTime = DateTime.Parse("2022-07-06"), From = "Meksyk", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2371, AllSeats = 33, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Seszele", Price = 107, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 2372, AllSeats = 33, DateTime = DateTime.Parse("2022-07-06"), From = "Seszele", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 2373, AllSeats = 64, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Seszele", Price = 131, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2374, AllSeats = 64, DateTime = DateTime.Parse("2022-07-06"), From = "Seszele", To = "Gdansk", Price = 58, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2375, AllSeats = 96, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Seszele", Price = 120, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 2376, AllSeats = 96, DateTime = DateTime.Parse("2022-07-06"), From = "Seszele", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 2377, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Slowenia", Price = 84, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 2378, AllSeats = 97, DateTime = DateTime.Parse("2022-07-06"), From = "Slowenia", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 2379, AllSeats = 62, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Slowenia", Price = 64, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 2380, AllSeats = 62, DateTime = DateTime.Parse("2022-07-06"), From = "Slowenia", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 2381, AllSeats = 87, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Slowenia", Price = 94, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2382, AllSeats = 87, DateTime = DateTime.Parse("2022-07-06"), From = "Slowenia", To = "Gdansk", Price = 123, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 2383, AllSeats = 61, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Turcja", Price = 55, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2384, AllSeats = 61, DateTime = DateTime.Parse("2022-07-06"), From = "Turcja", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2385, AllSeats = 88, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Turcja", Price = 73, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 2386, AllSeats = 88, DateTime = DateTime.Parse("2022-07-06"), From = "Turcja", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 2387, AllSeats = 25, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Turcja", Price = 88, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2388, AllSeats = 25, DateTime = DateTime.Parse("2022-07-06"), From = "Turcja", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2389, AllSeats = 47, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 89, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2390, AllSeats = 47, DateTime = DateTime.Parse("2022-07-06"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2391, AllSeats = 37, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 65, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2392, AllSeats = 37, DateTime = DateTime.Parse("2022-07-06"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2393, AllSeats = 40, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 131, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2394, AllSeats = 40, DateTime = DateTime.Parse("2022-07-06"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2395, AllSeats = 93, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Zanzibar", Price = 62, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 2396, AllSeats = 93, DateTime = DateTime.Parse("2022-07-06"), From = "Zanzibar", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 2397, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Zanzibar", Price = 146, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2398, AllSeats = 57, DateTime = DateTime.Parse("2022-07-06"), From = "Zanzibar", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2399, AllSeats = 56, DateTime = DateTime.Parse("2022-07-06"), From = "Gdansk", To = "Zanzibar", Price = 147, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2400, AllSeats = 56, DateTime = DateTime.Parse("2022-07-06"), From = "Zanzibar", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2401, AllSeats = 87, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Albania", Price = 80, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2402, AllSeats = 87, DateTime = DateTime.Parse("2022-07-07"), From = "Albania", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2403, AllSeats = 91, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Albania", Price = 77, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 2404, AllSeats = 91, DateTime = DateTime.Parse("2022-07-07"), From = "Albania", To = "Gdansk", Price = 114, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 2405, AllSeats = 98, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Albania", Price = 87, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2406, AllSeats = 98, DateTime = DateTime.Parse("2022-07-07"), From = "Albania", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2407, AllSeats = 84, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Bulgaria", Price = 95, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2408, AllSeats = 84, DateTime = DateTime.Parse("2022-07-07"), From = "Bulgaria", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2409, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Bulgaria", Price = 75, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2410, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Bulgaria", To = "Gdansk", Price = 121, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2411, AllSeats = 34, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Bulgaria", Price = 119, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 2412, AllSeats = 34, DateTime = DateTime.Parse("2022-07-07"), From = "Bulgaria", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 2413, AllSeats = 44, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Czarnogora", Price = 66, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2414, AllSeats = 44, DateTime = DateTime.Parse("2022-07-07"), From = "Czarnogora", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2415, AllSeats = 35, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Czarnogora", Price = 126, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 2416, AllSeats = 35, DateTime = DateTime.Parse("2022-07-07"), From = "Czarnogora", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 2417, AllSeats = 60, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Czarnogora", Price = 86, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2418, AllSeats = 60, DateTime = DateTime.Parse("2022-07-07"), From = "Czarnogora", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2419, AllSeats = 94, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Egipt", Price = 89, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2420, AllSeats = 94, DateTime = DateTime.Parse("2022-07-07"), From = "Egipt", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2421, AllSeats = 40, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Egipt", Price = 101, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 2422, AllSeats = 40, DateTime = DateTime.Parse("2022-07-07"), From = "Egipt", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 2423, AllSeats = 63, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Egipt", Price = 141, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 2424, AllSeats = 63, DateTime = DateTime.Parse("2022-07-07"), From = "Egipt", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 2425, AllSeats = 49, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Grecja", Price = 63, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2426, AllSeats = 49, DateTime = DateTime.Parse("2022-07-07"), From = "Grecja", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2427, AllSeats = 26, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Grecja", Price = 122, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 2428, AllSeats = 26, DateTime = DateTime.Parse("2022-07-07"), From = "Grecja", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 2429, AllSeats = 92, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Grecja", Price = 112, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2430, AllSeats = 92, DateTime = DateTime.Parse("2022-07-07"), From = "Grecja", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2431, AllSeats = 57, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Gruzja", Price = 91, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 2432, AllSeats = 57, DateTime = DateTime.Parse("2022-07-07"), From = "Gruzja", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 2433, AllSeats = 99, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Gruzja", Price = 70, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 2434, AllSeats = 99, DateTime = DateTime.Parse("2022-07-07"), From = "Gruzja", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 2435, AllSeats = 89, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Gruzja", Price = 74, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 2436, AllSeats = 89, DateTime = DateTime.Parse("2022-07-07"), From = "Gruzja", To = "Gdansk", Price = 100, Type = TransportType.Train, AvailableSeats = 89
},
new()
{
Id = 2437, AllSeats = 45, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Madera", Price = 96, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2438, AllSeats = 45, DateTime = DateTime.Parse("2022-07-07"), From = "Madera", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2439, AllSeats = 76, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Madera", Price = 57, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 2440, AllSeats = 76, DateTime = DateTime.Parse("2022-07-07"), From = "Madera", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 2441, AllSeats = 91, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Madera", Price = 96, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 2442, AllSeats = 91, DateTime = DateTime.Parse("2022-07-07"), From = "Madera", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 2443, AllSeats = 29, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malediwy", Price = 76, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2444, AllSeats = 29, DateTime = DateTime.Parse("2022-07-07"), From = "Malediwy", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2445, AllSeats = 46, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malediwy", Price = 109, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2446, AllSeats = 46, DateTime = DateTime.Parse("2022-07-07"), From = "Malediwy", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2447, AllSeats = 37, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malediwy", Price = 101, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 2448, AllSeats = 37, DateTime = DateTime.Parse("2022-07-07"), From = "Malediwy", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 2449, AllSeats = 90, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malta", Price = 70, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2450, AllSeats = 90, DateTime = DateTime.Parse("2022-07-07"), From = "Malta", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2451, AllSeats = 33, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malta", Price = 106, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2452, AllSeats = 33, DateTime = DateTime.Parse("2022-07-07"), From = "Malta", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2453, AllSeats = 52, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Malta", Price = 92, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 2454, AllSeats = 52, DateTime = DateTime.Parse("2022-07-07"), From = "Malta", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 2455, AllSeats = 93, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Mauritius", Price = 94, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 2456, AllSeats = 93, DateTime = DateTime.Parse("2022-07-07"), From = "Mauritius", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 2457, AllSeats = 64, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Mauritius", Price = 140, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2458, AllSeats = 64, DateTime = DateTime.Parse("2022-07-07"), From = "Mauritius", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2459, AllSeats = 93, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Mauritius", Price = 89, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2460, AllSeats = 93, DateTime = DateTime.Parse("2022-07-07"), From = "Mauritius", To = "Gdansk", Price = 140, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2461, AllSeats = 32, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Meksyk", Price = 98, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 2462, AllSeats = 32, DateTime = DateTime.Parse("2022-07-07"), From = "Meksyk", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 2463, AllSeats = 61, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Meksyk", Price = 134, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2464, AllSeats = 61, DateTime = DateTime.Parse("2022-07-07"), From = "Meksyk", To = "Gdansk", Price = 68, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2465, AllSeats = 55, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Meksyk", Price = 57, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2466, AllSeats = 55, DateTime = DateTime.Parse("2022-07-07"), From = "Meksyk", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2467, AllSeats = 34, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Seszele", Price = 51, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2468, AllSeats = 34, DateTime = DateTime.Parse("2022-07-07"), From = "Seszele", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2469, AllSeats = 27, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Seszele", Price = 139, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2470, AllSeats = 27, DateTime = DateTime.Parse("2022-07-07"), From = "Seszele", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2471, AllSeats = 76, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Seszele", Price = 108, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 2472, AllSeats = 76, DateTime = DateTime.Parse("2022-07-07"), From = "Seszele", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 2473, AllSeats = 36, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Slowenia", Price = 71, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2474, AllSeats = 36, DateTime = DateTime.Parse("2022-07-07"), From = "Slowenia", To = "Gdansk", Price = 73, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2475, AllSeats = 60, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Slowenia", Price = 70, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2476, AllSeats = 60, DateTime = DateTime.Parse("2022-07-07"), From = "Slowenia", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2477, AllSeats = 68, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Slowenia", Price = 131, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2478, AllSeats = 68, DateTime = DateTime.Parse("2022-07-07"), From = "Slowenia", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2479, AllSeats = 25, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Turcja", Price = 144, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 2480, AllSeats = 25, DateTime = DateTime.Parse("2022-07-07"), From = "Turcja", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 2481, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Turcja", Price = 73, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2482, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Turcja", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 2483, AllSeats = 57, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Turcja", Price = 123, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2484, AllSeats = 57, DateTime = DateTime.Parse("2022-07-07"), From = "Turcja", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2485, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 118, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 2486, AllSeats = 95, DateTime = DateTime.Parse("2022-07-07"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 2487, AllSeats = 92, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 105, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2488, AllSeats = 92, DateTime = DateTime.Parse("2022-07-07"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2489, AllSeats = 73, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 106, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 2490, AllSeats = 73, DateTime = DateTime.Parse("2022-07-07"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 2491, AllSeats = 48, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Zanzibar", Price = 98, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 2492, AllSeats = 48, DateTime = DateTime.Parse("2022-07-07"), From = "Zanzibar", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 2493, AllSeats = 33, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Zanzibar", Price = 139, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2494, AllSeats = 33, DateTime = DateTime.Parse("2022-07-07"), From = "Zanzibar", To = "Gdansk", Price = 116, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 2495, AllSeats = 90, DateTime = DateTime.Parse("2022-07-07"), From = "Gdansk", To = "Zanzibar", Price = 63, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 2496, AllSeats = 90, DateTime = DateTime.Parse("2022-07-07"), From = "Zanzibar", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 2497, AllSeats = 62, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Albania", Price = 141, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2498, AllSeats = 62, DateTime = DateTime.Parse("2022-07-08"), From = "Albania", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 2499, AllSeats = 55, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Albania", Price = 121, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 2500, AllSeats = 55, DateTime = DateTime.Parse("2022-07-08"), From = "Albania", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 2501, AllSeats = 96, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Albania", Price = 96, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 2502, AllSeats = 96, DateTime = DateTime.Parse("2022-07-08"), From = "Albania", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 2503, AllSeats = 33, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Bulgaria", Price = 68, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 2504, AllSeats = 33, DateTime = DateTime.Parse("2022-07-08"), From = "Bulgaria", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 2505, AllSeats = 68, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Bulgaria", Price = 114, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 2506, AllSeats = 68, DateTime = DateTime.Parse("2022-07-08"), From = "Bulgaria", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 2507, AllSeats = 28, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Bulgaria", Price = 76, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2508, AllSeats = 28, DateTime = DateTime.Parse("2022-07-08"), From = "Bulgaria", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2509, AllSeats = 43, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Czarnogora", Price = 92, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 2510, AllSeats = 43, DateTime = DateTime.Parse("2022-07-08"), From = "Czarnogora", To = "Gdansk", Price = 87, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 2511, AllSeats = 71, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Czarnogora", Price = 121, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2512, AllSeats = 71, DateTime = DateTime.Parse("2022-07-08"), From = "Czarnogora", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2513, AllSeats = 73, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Czarnogora", Price = 96, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 2514, AllSeats = 73, DateTime = DateTime.Parse("2022-07-08"), From = "Czarnogora", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 2515, AllSeats = 99, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Egipt", Price = 57, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 2516, AllSeats = 99, DateTime = DateTime.Parse("2022-07-08"), From = "Egipt", To = "Gdansk", Price = 107, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 2517, AllSeats = 65, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Egipt", Price = 65, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2518, AllSeats = 65, DateTime = DateTime.Parse("2022-07-08"), From = "Egipt", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2519, AllSeats = 55, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Egipt", Price = 57, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2520, AllSeats = 55, DateTime = DateTime.Parse("2022-07-08"), From = "Egipt", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 2521, AllSeats = 49, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Grecja", Price = 106, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2522, AllSeats = 49, DateTime = DateTime.Parse("2022-07-08"), From = "Grecja", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 2523, AllSeats = 27, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Grecja", Price = 53, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2524, AllSeats = 27, DateTime = DateTime.Parse("2022-07-08"), From = "Grecja", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2525, AllSeats = 68, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Grecja", Price = 135, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2526, AllSeats = 68, DateTime = DateTime.Parse("2022-07-08"), From = "Grecja", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2527, AllSeats = 77, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Gruzja", Price = 86, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2528, AllSeats = 77, DateTime = DateTime.Parse("2022-07-08"), From = "Gruzja", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2529, AllSeats = 44, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Gruzja", Price = 143, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 2530, AllSeats = 44, DateTime = DateTime.Parse("2022-07-08"), From = "Gruzja", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 2531, AllSeats = 32, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Gruzja", Price = 137, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 2532, AllSeats = 32, DateTime = DateTime.Parse("2022-07-08"), From = "Gruzja", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 2533, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Madera", Price = 128, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2534, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Madera", To = "Gdansk", Price = 70, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2535, AllSeats = 63, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Madera", Price = 138, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2536, AllSeats = 63, DateTime = DateTime.Parse("2022-07-08"), From = "Madera", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2537, AllSeats = 71, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Madera", Price = 88, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2538, AllSeats = 71, DateTime = DateTime.Parse("2022-07-08"), From = "Madera", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 2539, AllSeats = 84, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malediwy", Price = 125, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2540, AllSeats = 84, DateTime = DateTime.Parse("2022-07-08"), From = "Malediwy", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2541, AllSeats = 29, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malediwy", Price = 52, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 2542, AllSeats = 29, DateTime = DateTime.Parse("2022-07-08"), From = "Malediwy", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 2543, AllSeats = 31, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malediwy", Price = 72, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2544, AllSeats = 31, DateTime = DateTime.Parse("2022-07-08"), From = "Malediwy", To = "Gdansk", Price = 89, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2545, AllSeats = 51, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malta", Price = 74, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2546, AllSeats = 51, DateTime = DateTime.Parse("2022-07-08"), From = "Malta", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2547, AllSeats = 61, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malta", Price = 88, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2548, AllSeats = 61, DateTime = DateTime.Parse("2022-07-08"), From = "Malta", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 2549, AllSeats = 43, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Malta", Price = 75, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 2550, AllSeats = 43, DateTime = DateTime.Parse("2022-07-08"), From = "Malta", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 2551, AllSeats = 92, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Mauritius", Price = 87, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2552, AllSeats = 92, DateTime = DateTime.Parse("2022-07-08"), From = "Mauritius", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2553, AllSeats = 52, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Mauritius", Price = 62, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2554, AllSeats = 52, DateTime = DateTime.Parse("2022-07-08"), From = "Mauritius", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2555, AllSeats = 44, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Mauritius", Price = 56, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2556, AllSeats = 44, DateTime = DateTime.Parse("2022-07-08"), From = "Mauritius", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2557, AllSeats = 36, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Meksyk", Price = 137, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2558, AllSeats = 36, DateTime = DateTime.Parse("2022-07-08"), From = "Meksyk", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2559, AllSeats = 38, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Meksyk", Price = 137, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 2560, AllSeats = 38, DateTime = DateTime.Parse("2022-07-08"), From = "Meksyk", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 2561, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Meksyk", Price = 111, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2562, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Meksyk", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2563, AllSeats = 28, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Seszele", Price = 114, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2564, AllSeats = 28, DateTime = DateTime.Parse("2022-07-08"), From = "Seszele", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2565, AllSeats = 27, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Seszele", Price = 142, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2566, AllSeats = 27, DateTime = DateTime.Parse("2022-07-08"), From = "Seszele", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2567, AllSeats = 31, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Seszele", Price = 102, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2568, AllSeats = 31, DateTime = DateTime.Parse("2022-07-08"), From = "Seszele", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2569, AllSeats = 92, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Slowenia", Price = 93, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2570, AllSeats = 92, DateTime = DateTime.Parse("2022-07-08"), From = "Slowenia", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2571, AllSeats = 46, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Slowenia", Price = 138, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2572, AllSeats = 46, DateTime = DateTime.Parse("2022-07-08"), From = "Slowenia", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2573, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Slowenia", Price = 66, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2574, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Slowenia", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2575, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Turcja", Price = 82, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2576, AllSeats = 40, DateTime = DateTime.Parse("2022-07-08"), From = "Turcja", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 2577, AllSeats = 32, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Turcja", Price = 144, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2578, AllSeats = 32, DateTime = DateTime.Parse("2022-07-08"), From = "Turcja", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2579, AllSeats = 30, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Turcja", Price = 147, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2580, AllSeats = 30, DateTime = DateTime.Parse("2022-07-08"), From = "Turcja", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2581, AllSeats = 60, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 117, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2582, AllSeats = 60, DateTime = DateTime.Parse("2022-07-08"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 147, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 2583, AllSeats = 57, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 91, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2584, AllSeats = 57, DateTime = DateTime.Parse("2022-07-08"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2585, AllSeats = 97, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 122, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2586, AllSeats = 97, DateTime = DateTime.Parse("2022-07-08"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2587, AllSeats = 86, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Zanzibar", Price = 67, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2588, AllSeats = 86, DateTime = DateTime.Parse("2022-07-08"), From = "Zanzibar", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2589, AllSeats = 87, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Zanzibar", Price = 137, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2590, AllSeats = 87, DateTime = DateTime.Parse("2022-07-08"), From = "Zanzibar", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 2591, AllSeats = 38, DateTime = DateTime.Parse("2022-07-08"), From = "Gdansk", To = "Zanzibar", Price = 87, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 2592, AllSeats = 38, DateTime = DateTime.Parse("2022-07-08"), From = "Zanzibar", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 2593, AllSeats = 85, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Albania", Price = 73, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 2594, AllSeats = 85, DateTime = DateTime.Parse("2022-07-09"), From = "Albania", To = "Gdansk", Price = 143, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 2595, AllSeats = 75, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Albania", Price = 91, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2596, AllSeats = 75, DateTime = DateTime.Parse("2022-07-09"), From = "Albania", To = "Gdansk", Price = 115, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2597, AllSeats = 62, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Albania", Price = 105, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 2598, AllSeats = 62, DateTime = DateTime.Parse("2022-07-09"), From = "Albania", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 2599, AllSeats = 76, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Bulgaria", Price = 94, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 2600, AllSeats = 76, DateTime = DateTime.Parse("2022-07-09"), From = "Bulgaria", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 2601, AllSeats = 75, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Bulgaria", Price = 107, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2602, AllSeats = 75, DateTime = DateTime.Parse("2022-07-09"), From = "Bulgaria", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 2603, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Bulgaria", Price = 139, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2604, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Bulgaria", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2605, AllSeats = 81, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Czarnogora", Price = 50, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 2606, AllSeats = 81, DateTime = DateTime.Parse("2022-07-09"), From = "Czarnogora", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 2607, AllSeats = 82, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Czarnogora", Price = 51, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 2608, AllSeats = 82, DateTime = DateTime.Parse("2022-07-09"), From = "Czarnogora", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 82
},
new()
{
Id = 2609, AllSeats = 58, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Czarnogora", Price = 72, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2610, AllSeats = 58, DateTime = DateTime.Parse("2022-07-09"), From = "Czarnogora", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2611, AllSeats = 47, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Egipt", Price = 79, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2612, AllSeats = 47, DateTime = DateTime.Parse("2022-07-09"), From = "Egipt", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 2613, AllSeats = 85, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Egipt", Price = 75, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 2614, AllSeats = 85, DateTime = DateTime.Parse("2022-07-09"), From = "Egipt", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 2615, AllSeats = 54, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Egipt", Price = 132, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 2616, AllSeats = 54, DateTime = DateTime.Parse("2022-07-09"), From = "Egipt", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 2617, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Grecja", Price = 111, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2618, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Grecja", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2619, AllSeats = 59, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Grecja", Price = 132, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 2620, AllSeats = 59, DateTime = DateTime.Parse("2022-07-09"), From = "Grecja", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 2621, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Grecja", Price = 92, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2622, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Grecja", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2623, AllSeats = 96, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Gruzja", Price = 111, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 2624, AllSeats = 96, DateTime = DateTime.Parse("2022-07-09"), From = "Gruzja", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 2625, AllSeats = 31, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Gruzja", Price = 65, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 2626, AllSeats = 31, DateTime = DateTime.Parse("2022-07-09"), From = "Gruzja", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 2627, AllSeats = 60, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Gruzja", Price = 128, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2628, AllSeats = 60, DateTime = DateTime.Parse("2022-07-09"), From = "Gruzja", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 2629, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Madera", Price = 139, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2630, AllSeats = 84, DateTime = DateTime.Parse("2022-07-09"), From = "Madera", To = "Gdansk", Price = 95, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2631, AllSeats = 71, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Madera", Price = 80, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2632, AllSeats = 71, DateTime = DateTime.Parse("2022-07-09"), From = "Madera", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2633, AllSeats = 86, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Madera", Price = 142, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 2634, AllSeats = 86, DateTime = DateTime.Parse("2022-07-09"), From = "Madera", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 2635, AllSeats = 42, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 2636, AllSeats = 42, DateTime = DateTime.Parse("2022-07-09"), From = "Malediwy", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 2637, AllSeats = 46, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malediwy", Price = 73, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2638, AllSeats = 46, DateTime = DateTime.Parse("2022-07-09"), From = "Malediwy", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2639, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malediwy", Price = 114, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2640, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Malediwy", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2641, AllSeats = 73, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malta", Price = 69, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 2642, AllSeats = 73, DateTime = DateTime.Parse("2022-07-09"), From = "Malta", To = "Gdansk", Price = 58, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 2643, AllSeats = 72, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malta", Price = 67, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 2644, AllSeats = 72, DateTime = DateTime.Parse("2022-07-09"), From = "Malta", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 2645, AllSeats = 30, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Malta", Price = 128, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2646, AllSeats = 30, DateTime = DateTime.Parse("2022-07-09"), From = "Malta", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 2647, AllSeats = 69, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Mauritius", Price = 91, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2648, AllSeats = 69, DateTime = DateTime.Parse("2022-07-09"), From = "Mauritius", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2649, AllSeats = 73, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Mauritius", Price = 127, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 2650, AllSeats = 73, DateTime = DateTime.Parse("2022-07-09"), From = "Mauritius", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 2651, AllSeats = 92, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Mauritius", Price = 88, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2652, AllSeats = 92, DateTime = DateTime.Parse("2022-07-09"), From = "Mauritius", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2653, AllSeats = 90, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Meksyk", Price = 126, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2654, AllSeats = 90, DateTime = DateTime.Parse("2022-07-09"), From = "Meksyk", To = "Gdansk", Price = 121, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2655, AllSeats = 66, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Meksyk", Price = 96, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 2656, AllSeats = 66, DateTime = DateTime.Parse("2022-07-09"), From = "Meksyk", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 2657, AllSeats = 92, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Meksyk", Price = 68, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2658, AllSeats = 92, DateTime = DateTime.Parse("2022-07-09"), From = "Meksyk", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 2659, AllSeats = 30, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Seszele", Price = 120, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2660, AllSeats = 30, DateTime = DateTime.Parse("2022-07-09"), From = "Seszele", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2661, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Seszele", Price = 78, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 2662, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Seszele", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 2663, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Seszele", Price = 136, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2664, AllSeats = 57, DateTime = DateTime.Parse("2022-07-09"), From = "Seszele", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 2665, AllSeats = 31, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Slowenia", Price = 90, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 2666, AllSeats = 31, DateTime = DateTime.Parse("2022-07-09"), From = "Slowenia", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 2667, AllSeats = 96, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Slowenia", Price = 53, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 2668, AllSeats = 96, DateTime = DateTime.Parse("2022-07-09"), From = "Slowenia", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 2669, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Slowenia", Price = 50, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 2670, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Slowenia", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 2671, AllSeats = 34, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Turcja", Price = 142, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2672, AllSeats = 34, DateTime = DateTime.Parse("2022-07-09"), From = "Turcja", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2673, AllSeats = 99, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Turcja", Price = 58, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 2674, AllSeats = 99, DateTime = DateTime.Parse("2022-07-09"), From = "Turcja", To = "Gdansk", Price = 115, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 2675, AllSeats = 39, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2676, AllSeats = 39, DateTime = DateTime.Parse("2022-07-09"), From = "Turcja", To = "Gdansk", Price = 143, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2677, AllSeats = 61, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 131, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2678, AllSeats = 61, DateTime = DateTime.Parse("2022-07-09"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2679, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 118, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 2680, AllSeats = 51, DateTime = DateTime.Parse("2022-07-09"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 117, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 2681, AllSeats = 78, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 144, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 2682, AllSeats = 78, DateTime = DateTime.Parse("2022-07-09"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 2683, AllSeats = 72, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Zanzibar", Price = 86, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 2684, AllSeats = 72, DateTime = DateTime.Parse("2022-07-09"), From = "Zanzibar", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 2685, AllSeats = 56, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Zanzibar", Price = 126, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 2686, AllSeats = 56, DateTime = DateTime.Parse("2022-07-09"), From = "Zanzibar", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 2687, AllSeats = 39, DateTime = DateTime.Parse("2022-07-09"), From = "Gdansk", To = "Zanzibar", Price = 107, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2688, AllSeats = 39, DateTime = DateTime.Parse("2022-07-09"), From = "Zanzibar", To = "Gdansk", Price = 123, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 2689, AllSeats = 51, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Albania", Price = 148, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2690, AllSeats = 51, DateTime = DateTime.Parse("2022-07-10"), From = "Albania", To = "Gdansk", Price = 144, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 2691, AllSeats = 67, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Albania", Price = 114, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 2692, AllSeats = 67, DateTime = DateTime.Parse("2022-07-10"), From = "Albania", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 2693, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Albania", Price = 147, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2694, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Albania", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2695, AllSeats = 100, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Bulgaria", Price = 101, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 2696, AllSeats = 100, DateTime = DateTime.Parse("2022-07-10"), From = "Bulgaria", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 2697, AllSeats = 37, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Bulgaria", Price = 108, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2698, AllSeats = 37, DateTime = DateTime.Parse("2022-07-10"), From = "Bulgaria", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2699, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Bulgaria", Price = 75, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2700, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Bulgaria", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2701, AllSeats = 68, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Czarnogora", Price = 63, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 2702, AllSeats = 68, DateTime = DateTime.Parse("2022-07-10"), From = "Czarnogora", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 2703, AllSeats = 27, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Czarnogora", Price = 85, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2704, AllSeats = 27, DateTime = DateTime.Parse("2022-07-10"), From = "Czarnogora", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2705, AllSeats = 46, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Czarnogora", Price = 140, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2706, AllSeats = 46, DateTime = DateTime.Parse("2022-07-10"), From = "Czarnogora", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 2707, AllSeats = 35, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Egipt", Price = 91, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2708, AllSeats = 35, DateTime = DateTime.Parse("2022-07-10"), From = "Egipt", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2709, AllSeats = 86, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Egipt", Price = 102, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 2710, AllSeats = 86, DateTime = DateTime.Parse("2022-07-10"), From = "Egipt", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 2711, AllSeats = 74, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Egipt", Price = 74, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 2712, AllSeats = 74, DateTime = DateTime.Parse("2022-07-10"), From = "Egipt", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 2713, AllSeats = 45, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Grecja", Price = 54, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2714, AllSeats = 45, DateTime = DateTime.Parse("2022-07-10"), From = "Grecja", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2715, AllSeats = 60, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Grecja", Price = 100, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2716, AllSeats = 60, DateTime = DateTime.Parse("2022-07-10"), From = "Grecja", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 2717, AllSeats = 100, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Grecja", Price = 100, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 2718, AllSeats = 100, DateTime = DateTime.Parse("2022-07-10"), From = "Grecja", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 2719, AllSeats = 86, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Gruzja", Price = 84, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2720, AllSeats = 86, DateTime = DateTime.Parse("2022-07-10"), From = "Gruzja", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2721, AllSeats = 80, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Gruzja", Price = 95, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2722, AllSeats = 80, DateTime = DateTime.Parse("2022-07-10"), From = "Gruzja", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 2723, AllSeats = 59, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Gruzja", Price = 111, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 2724, AllSeats = 59, DateTime = DateTime.Parse("2022-07-10"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 2725, AllSeats = 97, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Madera", Price = 105, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 2726, AllSeats = 97, DateTime = DateTime.Parse("2022-07-10"), From = "Madera", To = "Gdansk", Price = 121, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 2727, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Madera", Price = 77, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2728, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Madera", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 2729, AllSeats = 78, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Madera", Price = 106, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 2730, AllSeats = 78, DateTime = DateTime.Parse("2022-07-10"), From = "Madera", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 2731, AllSeats = 94, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malediwy", Price = 66, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2732, AllSeats = 94, DateTime = DateTime.Parse("2022-07-10"), From = "Malediwy", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 2733, AllSeats = 46, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malediwy", Price = 51, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2734, AllSeats = 46, DateTime = DateTime.Parse("2022-07-10"), From = "Malediwy", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 2735, AllSeats = 83, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malediwy", Price = 105, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2736, AllSeats = 83, DateTime = DateTime.Parse("2022-07-10"), From = "Malediwy", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 2737, AllSeats = 90, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malta", Price = 63, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2738, AllSeats = 90, DateTime = DateTime.Parse("2022-07-10"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 2739, AllSeats = 90, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malta", Price = 63, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 2740, AllSeats = 90, DateTime = DateTime.Parse("2022-07-10"), From = "Malta", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 2741, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Malta", Price = 110, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2742, AllSeats = 42, DateTime = DateTime.Parse("2022-07-10"), From = "Malta", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 2743, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Mauritius", Price = 118, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2744, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Mauritius", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 2745, AllSeats = 35, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Mauritius", Price = 150, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 2746, AllSeats = 35, DateTime = DateTime.Parse("2022-07-10"), From = "Mauritius", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 2747, AllSeats = 64, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Mauritius", Price = 62, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 2748, AllSeats = 64, DateTime = DateTime.Parse("2022-07-10"), From = "Mauritius", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 2749, AllSeats = 32, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Meksyk", Price = 116, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 2750, AllSeats = 32, DateTime = DateTime.Parse("2022-07-10"), From = "Meksyk", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 2751, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Meksyk", Price = 145, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 2752, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Meksyk", To = "Gdansk", Price = 139, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 2753, AllSeats = 97, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2754, AllSeats = 97, DateTime = DateTime.Parse("2022-07-10"), From = "Meksyk", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2755, AllSeats = 41, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Seszele", Price = 119, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2756, AllSeats = 41, DateTime = DateTime.Parse("2022-07-10"), From = "Seszele", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2757, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Seszele", Price = 60, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2758, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Seszele", To = "Gdansk", Price = 117, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2759, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Seszele", Price = 134, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2760, AllSeats = 36, DateTime = DateTime.Parse("2022-07-10"), From = "Seszele", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2761, AllSeats = 29, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Slowenia", Price = 90, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2762, AllSeats = 29, DateTime = DateTime.Parse("2022-07-10"), From = "Slowenia", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 2763, AllSeats = 81, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Slowenia", Price = 143, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2764, AllSeats = 81, DateTime = DateTime.Parse("2022-07-10"), From = "Slowenia", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 2765, AllSeats = 56, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Slowenia", Price = 117, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2766, AllSeats = 56, DateTime = DateTime.Parse("2022-07-10"), From = "Slowenia", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 2767, AllSeats = 58, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Turcja", Price = 130, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2768, AllSeats = 58, DateTime = DateTime.Parse("2022-07-10"), From = "Turcja", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2769, AllSeats = 93, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Turcja", Price = 106, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 2770, AllSeats = 93, DateTime = DateTime.Parse("2022-07-10"), From = "Turcja", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 2771, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Turcja", Price = 75, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2772, AllSeats = 98, DateTime = DateTime.Parse("2022-07-10"), From = "Turcja", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 2773, AllSeats = 64, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 94, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 2774, AllSeats = 64, DateTime = DateTime.Parse("2022-07-10"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 2775, AllSeats = 56, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 137, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 2776, AllSeats = 56, DateTime = DateTime.Parse("2022-07-10"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 2777, AllSeats = 50, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 106, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2778, AllSeats = 50, DateTime = DateTime.Parse("2022-07-10"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2779, AllSeats = 67, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Zanzibar", Price = 85, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 2780, AllSeats = 67, DateTime = DateTime.Parse("2022-07-10"), From = "Zanzibar", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 2781, AllSeats = 63, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Zanzibar", Price = 138, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2782, AllSeats = 63, DateTime = DateTime.Parse("2022-07-10"), From = "Zanzibar", To = "Gdansk", Price = 116, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 2783, AllSeats = 84, DateTime = DateTime.Parse("2022-07-10"), From = "Gdansk", To = "Zanzibar", Price = 67, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2784, AllSeats = 84, DateTime = DateTime.Parse("2022-07-10"), From = "Zanzibar", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2785, AllSeats = 78, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Albania", Price = 84, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 2786, AllSeats = 78, DateTime = DateTime.Parse("2022-07-11"), From = "Albania", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 2787, AllSeats = 43, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Albania", Price = 54, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2788, AllSeats = 43, DateTime = DateTime.Parse("2022-07-11"), From = "Albania", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2789, AllSeats = 43, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Albania", Price = 106, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 2790, AllSeats = 43, DateTime = DateTime.Parse("2022-07-11"), From = "Albania", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 2791, AllSeats = 37, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Bulgaria", Price = 101, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 2792, AllSeats = 37, DateTime = DateTime.Parse("2022-07-11"), From = "Bulgaria", To = "Gdansk", Price = 82, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 2793, AllSeats = 90, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Bulgaria", Price = 117, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 2794, AllSeats = 90, DateTime = DateTime.Parse("2022-07-11"), From = "Bulgaria", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 2795, AllSeats = 25, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Bulgaria", Price = 97, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2796, AllSeats = 25, DateTime = DateTime.Parse("2022-07-11"), From = "Bulgaria", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2797, AllSeats = 50, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Czarnogora", Price = 91, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 2798, AllSeats = 50, DateTime = DateTime.Parse("2022-07-11"), From = "Czarnogora", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 2799, AllSeats = 94, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Czarnogora", Price = 140, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 2800, AllSeats = 94, DateTime = DateTime.Parse("2022-07-11"), From = "Czarnogora", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 2801, AllSeats = 25, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Czarnogora", Price = 107, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2802, AllSeats = 25, DateTime = DateTime.Parse("2022-07-11"), From = "Czarnogora", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 2803, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Egipt", Price = 145, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2804, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Egipt", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2805, AllSeats = 50, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Egipt", Price = 103, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 2806, AllSeats = 50, DateTime = DateTime.Parse("2022-07-11"), From = "Egipt", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 2807, AllSeats = 80, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Egipt", Price = 106, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2808, AllSeats = 80, DateTime = DateTime.Parse("2022-07-11"), From = "Egipt", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 2809, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Grecja", Price = 58, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2810, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Grecja", To = "Gdansk", Price = 89, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 2811, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Grecja", Price = 94, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2812, AllSeats = 34, DateTime = DateTime.Parse("2022-07-11"), From = "Grecja", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2813, AllSeats = 72, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Grecja", Price = 135, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 2814, AllSeats = 72, DateTime = DateTime.Parse("2022-07-11"), From = "Grecja", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 2815, AllSeats = 35, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Gruzja", Price = 103, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2816, AllSeats = 35, DateTime = DateTime.Parse("2022-07-11"), From = "Gruzja", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 2817, AllSeats = 100, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Gruzja", Price = 95, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2818, AllSeats = 100, DateTime = DateTime.Parse("2022-07-11"), From = "Gruzja", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2819, AllSeats = 49, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Gruzja", Price = 89, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 2820, AllSeats = 49, DateTime = DateTime.Parse("2022-07-11"), From = "Gruzja", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 2821, AllSeats = 82, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Madera", Price = 111, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 2822, AllSeats = 82, DateTime = DateTime.Parse("2022-07-11"), From = "Madera", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 2823, AllSeats = 32, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Madera", Price = 60, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2824, AllSeats = 32, DateTime = DateTime.Parse("2022-07-11"), From = "Madera", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 2825, AllSeats = 31, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Madera", Price = 96, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2826, AllSeats = 31, DateTime = DateTime.Parse("2022-07-11"), From = "Madera", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2827, AllSeats = 54, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malediwy", Price = 60, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 2828, AllSeats = 54, DateTime = DateTime.Parse("2022-07-11"), From = "Malediwy", To = "Gdansk", Price = 144, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 2829, AllSeats = 71, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malediwy", Price = 106, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2830, AllSeats = 71, DateTime = DateTime.Parse("2022-07-11"), From = "Malediwy", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 2831, AllSeats = 27, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malediwy", Price = 131, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 2832, AllSeats = 27, DateTime = DateTime.Parse("2022-07-11"), From = "Malediwy", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 2833, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malta", Price = 67, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2834, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Malta", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 2835, AllSeats = 86, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malta", Price = 85, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 2836, AllSeats = 86, DateTime = DateTime.Parse("2022-07-11"), From = "Malta", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 2837, AllSeats = 97, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Malta", Price = 91, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2838, AllSeats = 97, DateTime = DateTime.Parse("2022-07-11"), From = "Malta", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2839, AllSeats = 28, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Mauritius", Price = 70, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2840, AllSeats = 28, DateTime = DateTime.Parse("2022-07-11"), From = "Mauritius", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 2841, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Mauritius", Price = 126, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2842, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Mauritius", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2843, AllSeats = 93, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Mauritius", Price = 75, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2844, AllSeats = 93, DateTime = DateTime.Parse("2022-07-11"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 93
},
new()
{
Id = 2845, AllSeats = 53, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Meksyk", Price = 94, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 2846, AllSeats = 53, DateTime = DateTime.Parse("2022-07-11"), From = "Meksyk", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 2847, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Meksyk", Price = 133, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2848, AllSeats = 92, DateTime = DateTime.Parse("2022-07-11"), From = "Meksyk", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 2849, AllSeats = 53, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Meksyk", Price = 109, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 2850, AllSeats = 53, DateTime = DateTime.Parse("2022-07-11"), From = "Meksyk", To = "Gdansk", Price = 98, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 2851, AllSeats = 77, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Seszele", Price = 121, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2852, AllSeats = 77, DateTime = DateTime.Parse("2022-07-11"), From = "Seszele", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2853, AllSeats = 52, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Seszele", Price = 144, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2854, AllSeats = 52, DateTime = DateTime.Parse("2022-07-11"), From = "Seszele", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 2855, AllSeats = 31, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Seszele", Price = 97, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2856, AllSeats = 31, DateTime = DateTime.Parse("2022-07-11"), From = "Seszele", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2857, AllSeats = 61, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Slowenia", Price = 133, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2858, AllSeats = 61, DateTime = DateTime.Parse("2022-07-11"), From = "Slowenia", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 2859, AllSeats = 45, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Slowenia", Price = 85, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 2860, AllSeats = 45, DateTime = DateTime.Parse("2022-07-11"), From = "Slowenia", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 2861, AllSeats = 44, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Slowenia", Price = 92, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2862, AllSeats = 44, DateTime = DateTime.Parse("2022-07-11"), From = "Slowenia", To = "Gdansk", Price = 133, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 2863, AllSeats = 58, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Turcja", Price = 135, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2864, AllSeats = 58, DateTime = DateTime.Parse("2022-07-11"), From = "Turcja", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2865, AllSeats = 57, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Turcja", Price = 103, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2866, AllSeats = 57, DateTime = DateTime.Parse("2022-07-11"), From = "Turcja", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 2867, AllSeats = 82, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Turcja", Price = 60, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2868, AllSeats = 82, DateTime = DateTime.Parse("2022-07-11"), From = "Turcja", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2869, AllSeats = 70, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 103, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2870, AllSeats = 70, DateTime = DateTime.Parse("2022-07-11"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2871, AllSeats = 48, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 136, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2872, AllSeats = 48, DateTime = DateTime.Parse("2022-07-11"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 2873, AllSeats = 58, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 105, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2874, AllSeats = 58, DateTime = DateTime.Parse("2022-07-11"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 2875, AllSeats = 30, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Zanzibar", Price = 120, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2876, AllSeats = 30, DateTime = DateTime.Parse("2022-07-11"), From = "Zanzibar", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 2877, AllSeats = 94, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Zanzibar", Price = 150, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 2878, AllSeats = 94, DateTime = DateTime.Parse("2022-07-11"), From = "Zanzibar", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 2879, AllSeats = 69, DateTime = DateTime.Parse("2022-07-11"), From = "Gdansk", To = "Zanzibar", Price = 51, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 2880, AllSeats = 69, DateTime = DateTime.Parse("2022-07-11"), From = "Zanzibar", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 2881, AllSeats = 77, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Albania", Price = 125, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2882, AllSeats = 77, DateTime = DateTime.Parse("2022-07-12"), From = "Albania", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2883, AllSeats = 37, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Albania", Price = 133, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2884, AllSeats = 37, DateTime = DateTime.Parse("2022-07-12"), From = "Albania", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2885, AllSeats = 67, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Albania", Price = 70, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 2886, AllSeats = 67, DateTime = DateTime.Parse("2022-07-12"), From = "Albania", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 2887, AllSeats = 63, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Bulgaria", Price = 121, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 2888, AllSeats = 63, DateTime = DateTime.Parse("2022-07-12"), From = "Bulgaria", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 2889, AllSeats = 69, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Bulgaria", Price = 113, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2890, AllSeats = 69, DateTime = DateTime.Parse("2022-07-12"), From = "Bulgaria", To = "Gdansk", Price = 112, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 2891, AllSeats = 28, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Bulgaria", Price = 113, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2892, AllSeats = 28, DateTime = DateTime.Parse("2022-07-12"), From = "Bulgaria", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 2893, AllSeats = 44, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Czarnogora", Price = 113, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2894, AllSeats = 44, DateTime = DateTime.Parse("2022-07-12"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 2895, AllSeats = 76, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Czarnogora", Price = 92, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 2896, AllSeats = 76, DateTime = DateTime.Parse("2022-07-12"), From = "Czarnogora", To = "Gdansk", Price = 131, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 2897, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Czarnogora", Price = 123, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 2898, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Czarnogora", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 2899, AllSeats = 42, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Egipt", Price = 90, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 2900, AllSeats = 42, DateTime = DateTime.Parse("2022-07-12"), From = "Egipt", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 2901, AllSeats = 29, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Egipt", Price = 72, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 2902, AllSeats = 29, DateTime = DateTime.Parse("2022-07-12"), From = "Egipt", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 2903, AllSeats = 97, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Egipt", Price = 50, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2904, AllSeats = 97, DateTime = DateTime.Parse("2022-07-12"), From = "Egipt", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 2905, AllSeats = 55, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Grecja", Price = 92, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 2906, AllSeats = 55, DateTime = DateTime.Parse("2022-07-12"), From = "Grecja", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 2907, AllSeats = 74, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Grecja", Price = 67, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2908, AllSeats = 74, DateTime = DateTime.Parse("2022-07-12"), From = "Grecja", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2909, AllSeats = 40, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Grecja", Price = 135, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2910, AllSeats = 40, DateTime = DateTime.Parse("2022-07-12"), From = "Grecja", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 2911, AllSeats = 69, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Gruzja", Price = 104, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2912, AllSeats = 69, DateTime = DateTime.Parse("2022-07-12"), From = "Gruzja", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 2913, AllSeats = 34, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Gruzja", Price = 80, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2914, AllSeats = 34, DateTime = DateTime.Parse("2022-07-12"), From = "Gruzja", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 2915, AllSeats = 50, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Gruzja", Price = 96, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2916, AllSeats = 50, DateTime = DateTime.Parse("2022-07-12"), From = "Gruzja", To = "Gdansk", Price = 98, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 2917, AllSeats = 56, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Madera", Price = 59, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2918, AllSeats = 56, DateTime = DateTime.Parse("2022-07-12"), From = "Madera", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 56
},
new()
{
Id = 2919, AllSeats = 27, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Madera", Price = 99, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2920, AllSeats = 27, DateTime = DateTime.Parse("2022-07-12"), From = "Madera", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 2921, AllSeats = 82, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Madera", Price = 111, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2922, AllSeats = 82, DateTime = DateTime.Parse("2022-07-12"), From = "Madera", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 2923, AllSeats = 87, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malediwy", Price = 97, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2924, AllSeats = 87, DateTime = DateTime.Parse("2022-07-12"), From = "Malediwy", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 2925, AllSeats = 64, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malediwy", Price = 133, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2926, AllSeats = 64, DateTime = DateTime.Parse("2022-07-12"), From = "Malediwy", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 2927, AllSeats = 95, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malediwy", Price = 146, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2928, AllSeats = 95, DateTime = DateTime.Parse("2022-07-12"), From = "Malediwy", To = "Gdansk", Price = 98, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 2929, AllSeats = 77, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malta", Price = 74, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2930, AllSeats = 77, DateTime = DateTime.Parse("2022-07-12"), From = "Malta", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 2931, AllSeats = 65, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malta", Price = 146, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2932, AllSeats = 65, DateTime = DateTime.Parse("2022-07-12"), From = "Malta", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 2933, AllSeats = 79, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Malta", Price = 84, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2934, AllSeats = 79, DateTime = DateTime.Parse("2022-07-12"), From = "Malta", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2935, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Mauritius", Price = 147, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2936, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Mauritius", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 2937, AllSeats = 98, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Mauritius", Price = 84, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2938, AllSeats = 98, DateTime = DateTime.Parse("2022-07-12"), From = "Mauritius", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 2939, AllSeats = 35, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Mauritius", Price = 92, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 2940, AllSeats = 35, DateTime = DateTime.Parse("2022-07-12"), From = "Mauritius", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 2941, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Meksyk", Price = 67, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2942, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Meksyk", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 2943, AllSeats = 100, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Meksyk", Price = 119, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2944, AllSeats = 100, DateTime = DateTime.Parse("2022-07-12"), From = "Meksyk", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2945, AllSeats = 34, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Meksyk", Price = 93, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 2946, AllSeats = 34, DateTime = DateTime.Parse("2022-07-12"), From = "Meksyk", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 2947, AllSeats = 31, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Seszele", Price = 134, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 2948, AllSeats = 31, DateTime = DateTime.Parse("2022-07-12"), From = "Seszele", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 2949, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Seszele", Price = 63, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 2950, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Seszele", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 2951, AllSeats = 48, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Seszele", Price = 86, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 2952, AllSeats = 48, DateTime = DateTime.Parse("2022-07-12"), From = "Seszele", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 2953, AllSeats = 73, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Slowenia", Price = 136, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 2954, AllSeats = 73, DateTime = DateTime.Parse("2022-07-12"), From = "Slowenia", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 2955, AllSeats = 43, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Slowenia", Price = 76, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2956, AllSeats = 43, DateTime = DateTime.Parse("2022-07-12"), From = "Slowenia", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 2957, AllSeats = 68, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Slowenia", Price = 55, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2958, AllSeats = 68, DateTime = DateTime.Parse("2022-07-12"), From = "Slowenia", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 2959, AllSeats = 75, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Turcja", Price = 64, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2960, AllSeats = 75, DateTime = DateTime.Parse("2022-07-12"), From = "Turcja", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 2961, AllSeats = 74, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Turcja", Price = 82, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2962, AllSeats = 74, DateTime = DateTime.Parse("2022-07-12"), From = "Turcja", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 2963, AllSeats = 84, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Turcja", Price = 114, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2964, AllSeats = 84, DateTime = DateTime.Parse("2022-07-12"), From = "Turcja", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 2965, AllSeats = 84, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 121, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2966, AllSeats = 84, DateTime = DateTime.Parse("2022-07-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 2967, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 115, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 2968, AllSeats = 45, DateTime = DateTime.Parse("2022-07-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 2969, AllSeats = 36, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 101, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2970, AllSeats = 36, DateTime = DateTime.Parse("2022-07-12"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 2971, AllSeats = 52, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Zanzibar", Price = 55, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 2972, AllSeats = 52, DateTime = DateTime.Parse("2022-07-12"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 2973, AllSeats = 100, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Zanzibar", Price = 69, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2974, AllSeats = 100, DateTime = DateTime.Parse("2022-07-12"), From = "Zanzibar", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 2975, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Gdansk", To = "Zanzibar", Price = 53, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 2976, AllSeats = 41, DateTime = DateTime.Parse("2022-07-12"), From = "Zanzibar", To = "Gdansk", Price = 70, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 2977, AllSeats = 86, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Albania", Price = 56, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2978, AllSeats = 86, DateTime = DateTime.Parse("2022-07-13"), From = "Albania", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 2979, AllSeats = 97, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Albania", Price = 123, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2980, AllSeats = 97, DateTime = DateTime.Parse("2022-07-13"), From = "Albania", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 2981, AllSeats = 79, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Albania", Price = 117, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2982, AllSeats = 79, DateTime = DateTime.Parse("2022-07-13"), From = "Albania", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 2983, AllSeats = 65, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Bulgaria", Price = 70, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 2984, AllSeats = 65, DateTime = DateTime.Parse("2022-07-13"), From = "Bulgaria", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 2985, AllSeats = 78, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Bulgaria", Price = 132, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 2986, AllSeats = 78, DateTime = DateTime.Parse("2022-07-13"), From = "Bulgaria", To = "Gdansk", Price = 68, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 2987, AllSeats = 31, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Bulgaria", Price = 68, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2988, AllSeats = 31, DateTime = DateTime.Parse("2022-07-13"), From = "Bulgaria", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 2989, AllSeats = 70, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Czarnogora", Price = 102, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2990, AllSeats = 70, DateTime = DateTime.Parse("2022-07-13"), From = "Czarnogora", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 2991, AllSeats = 37, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Czarnogora", Price = 116, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2992, AllSeats = 37, DateTime = DateTime.Parse("2022-07-13"), From = "Czarnogora", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 2993, AllSeats = 61, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Czarnogora", Price = 94, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 2994, AllSeats = 61, DateTime = DateTime.Parse("2022-07-13"), From = "Czarnogora", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 2995, AllSeats = 58, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Egipt", Price = 81, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2996, AllSeats = 58, DateTime = DateTime.Parse("2022-07-13"), From = "Egipt", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 2997, AllSeats = 54, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Egipt", Price = 112, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 2998, AllSeats = 54, DateTime = DateTime.Parse("2022-07-13"), From = "Egipt", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 2999, AllSeats = 94, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Egipt", Price = 110, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 3000, AllSeats = 94, DateTime = DateTime.Parse("2022-07-13"), From = "Egipt", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 3001, AllSeats = 87, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Grecja", Price = 73, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3002, AllSeats = 87, DateTime = DateTime.Parse("2022-07-13"), From = "Grecja", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3003, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Grecja", Price = 136, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3004, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Grecja", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3005, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Grecja", Price = 68, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3006, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Grecja", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3007, AllSeats = 61, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Gruzja", Price = 90, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3008, AllSeats = 61, DateTime = DateTime.Parse("2022-07-13"), From = "Gruzja", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3009, AllSeats = 70, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Gruzja", Price = 88, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3010, AllSeats = 70, DateTime = DateTime.Parse("2022-07-13"), From = "Gruzja", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3011, AllSeats = 62, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Gruzja", Price = 76, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3012, AllSeats = 62, DateTime = DateTime.Parse("2022-07-13"), From = "Gruzja", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3013, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Madera", Price = 104, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3014, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Madera", To = "Gdansk", Price = 108, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3015, AllSeats = 62, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Madera", Price = 150, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 3016, AllSeats = 62, DateTime = DateTime.Parse("2022-07-13"), From = "Madera", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 3017, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Madera", Price = 149, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3018, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Madera", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3019, AllSeats = 83, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malediwy", Price = 77, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3020, AllSeats = 83, DateTime = DateTime.Parse("2022-07-13"), From = "Malediwy", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3021, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malediwy", Price = 82, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3022, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Malediwy", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3023, AllSeats = 60, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malediwy", Price = 137, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3024, AllSeats = 60, DateTime = DateTime.Parse("2022-07-13"), From = "Malediwy", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3025, AllSeats = 29, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malta", Price = 98, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3026, AllSeats = 29, DateTime = DateTime.Parse("2022-07-13"), From = "Malta", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3027, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malta", Price = 53, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 3028, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Malta", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 3029, AllSeats = 100, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Malta", Price = 130, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3030, AllSeats = 100, DateTime = DateTime.Parse("2022-07-13"), From = "Malta", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3031, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Mauritius", Price = 125, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3032, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Mauritius", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3033, AllSeats = 45, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Mauritius", Price = 150, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3034, AllSeats = 45, DateTime = DateTime.Parse("2022-07-13"), From = "Mauritius", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3035, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Mauritius", Price = 116, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 3036, AllSeats = 42, DateTime = DateTime.Parse("2022-07-13"), From = "Mauritius", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 3037, AllSeats = 89, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 3038, AllSeats = 89, DateTime = DateTime.Parse("2022-07-13"), From = "Meksyk", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 3039, AllSeats = 45, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Meksyk", Price = 69, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3040, AllSeats = 45, DateTime = DateTime.Parse("2022-07-13"), From = "Meksyk", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3041, AllSeats = 59, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Meksyk", Price = 64, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3042, AllSeats = 59, DateTime = DateTime.Parse("2022-07-13"), From = "Meksyk", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3043, AllSeats = 84, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Seszele", Price = 52, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3044, AllSeats = 84, DateTime = DateTime.Parse("2022-07-13"), From = "Seszele", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3045, AllSeats = 63, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Seszele", Price = 99, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 3046, AllSeats = 63, DateTime = DateTime.Parse("2022-07-13"), From = "Seszele", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 3047, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Seszele", Price = 82, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3048, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Seszele", To = "Gdansk", Price = 66, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3049, AllSeats = 76, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Slowenia", Price = 78, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 3050, AllSeats = 76, DateTime = DateTime.Parse("2022-07-13"), From = "Slowenia", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 3051, AllSeats = 72, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Slowenia", Price = 78, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3052, AllSeats = 72, DateTime = DateTime.Parse("2022-07-13"), From = "Slowenia", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3053, AllSeats = 81, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Slowenia", Price = 137, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3054, AllSeats = 81, DateTime = DateTime.Parse("2022-07-13"), From = "Slowenia", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3055, AllSeats = 96, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 3056, AllSeats = 96, DateTime = DateTime.Parse("2022-07-13"), From = "Turcja", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 3057, AllSeats = 78, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Turcja", Price = 68, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3058, AllSeats = 78, DateTime = DateTime.Parse("2022-07-13"), From = "Turcja", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3059, AllSeats = 67, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Turcja", Price = 120, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3060, AllSeats = 67, DateTime = DateTime.Parse("2022-07-13"), From = "Turcja", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3061, AllSeats = 99, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 100, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3062, AllSeats = 99, DateTime = DateTime.Parse("2022-07-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 121, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3063, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 124, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 3064, AllSeats = 98, DateTime = DateTime.Parse("2022-07-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 117, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 3065, AllSeats = 65, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 150, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 3066, AllSeats = 65, DateTime = DateTime.Parse("2022-07-13"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 3067, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Zanzibar", Price = 135, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 3068, AllSeats = 51, DateTime = DateTime.Parse("2022-07-13"), From = "Zanzibar", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 3069, AllSeats = 68, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Zanzibar", Price = 93, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3070, AllSeats = 68, DateTime = DateTime.Parse("2022-07-13"), From = "Zanzibar", To = "Gdansk", Price = 58, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3071, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Gdansk", To = "Zanzibar", Price = 97, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3072, AllSeats = 39, DateTime = DateTime.Parse("2022-07-13"), From = "Zanzibar", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3073, AllSeats = 42, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Albania", Price = 79, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3074, AllSeats = 42, DateTime = DateTime.Parse("2022-07-14"), From = "Albania", To = "Gdansk", Price = 107, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3075, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Albania", Price = 119, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3076, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Albania", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3077, AllSeats = 28, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Albania", Price = 57, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3078, AllSeats = 28, DateTime = DateTime.Parse("2022-07-14"), From = "Albania", To = "Gdansk", Price = 92, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3079, AllSeats = 46, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3080, AllSeats = 46, DateTime = DateTime.Parse("2022-07-14"), From = "Bulgaria", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3081, AllSeats = 29, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Bulgaria", Price = 148, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3082, AllSeats = 29, DateTime = DateTime.Parse("2022-07-14"), From = "Bulgaria", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3083, AllSeats = 50, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Bulgaria", Price = 116, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3084, AllSeats = 50, DateTime = DateTime.Parse("2022-07-14"), From = "Bulgaria", To = "Gdansk", Price = 100, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3085, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Czarnogora", Price = 149, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3086, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Czarnogora", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3087, AllSeats = 73, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Czarnogora", Price = 76, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3088, AllSeats = 73, DateTime = DateTime.Parse("2022-07-14"), From = "Czarnogora", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3089, AllSeats = 65, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Czarnogora", Price = 143, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 3090, AllSeats = 65, DateTime = DateTime.Parse("2022-07-14"), From = "Czarnogora", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 3091, AllSeats = 95, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Egipt", Price = 122, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 3092, AllSeats = 95, DateTime = DateTime.Parse("2022-07-14"), From = "Egipt", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 3093, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Egipt", Price = 56, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 3094, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Egipt", To = "Gdansk", Price = 80, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 3095, AllSeats = 87, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Egipt", Price = 125, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3096, AllSeats = 87, DateTime = DateTime.Parse("2022-07-14"), From = "Egipt", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3097, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Grecja", Price = 131, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3098, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Grecja", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3099, AllSeats = 52, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Grecja", Price = 72, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 3100, AllSeats = 52, DateTime = DateTime.Parse("2022-07-14"), From = "Grecja", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 3101, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Grecja", Price = 87, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3102, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Grecja", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3103, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Gruzja", Price = 60, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3104, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Gruzja", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3105, AllSeats = 80, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Gruzja", Price = 103, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3106, AllSeats = 80, DateTime = DateTime.Parse("2022-07-14"), From = "Gruzja", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3107, AllSeats = 50, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Gruzja", Price = 129, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3108, AllSeats = 50, DateTime = DateTime.Parse("2022-07-14"), From = "Gruzja", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3109, AllSeats = 97, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Madera", Price = 101, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3110, AllSeats = 97, DateTime = DateTime.Parse("2022-07-14"), From = "Madera", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3111, AllSeats = 78, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Madera", Price = 120, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3112, AllSeats = 78, DateTime = DateTime.Parse("2022-07-14"), From = "Madera", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3113, AllSeats = 58, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Madera", Price = 145, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 3114, AllSeats = 58, DateTime = DateTime.Parse("2022-07-14"), From = "Madera", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 3115, AllSeats = 93, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malediwy", Price = 54, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3116, AllSeats = 93, DateTime = DateTime.Parse("2022-07-14"), From = "Malediwy", To = "Gdansk", Price = 149, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3117, AllSeats = 28, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malediwy", Price = 127, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 3118, AllSeats = 28, DateTime = DateTime.Parse("2022-07-14"), From = "Malediwy", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 3119, AllSeats = 82, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malediwy", Price = 145, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3120, AllSeats = 82, DateTime = DateTime.Parse("2022-07-14"), From = "Malediwy", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3121, AllSeats = 98, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malta", Price = 113, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3122, AllSeats = 98, DateTime = DateTime.Parse("2022-07-14"), From = "Malta", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3123, AllSeats = 66, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malta", Price = 141, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 3124, AllSeats = 66, DateTime = DateTime.Parse("2022-07-14"), From = "Malta", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 3125, AllSeats = 81, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Malta", Price = 71, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3126, AllSeats = 81, DateTime = DateTime.Parse("2022-07-14"), From = "Malta", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3127, AllSeats = 46, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Mauritius", Price = 76, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3128, AllSeats = 46, DateTime = DateTime.Parse("2022-07-14"), From = "Mauritius", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3129, AllSeats = 72, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Mauritius", Price = 75, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3130, AllSeats = 72, DateTime = DateTime.Parse("2022-07-14"), From = "Mauritius", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3131, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Mauritius", Price = 94, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3132, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Mauritius", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3133, AllSeats = 97, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Meksyk", Price = 139, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3134, AllSeats = 97, DateTime = DateTime.Parse("2022-07-14"), From = "Meksyk", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3135, AllSeats = 72, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3136, AllSeats = 72, DateTime = DateTime.Parse("2022-07-14"), From = "Meksyk", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3137, AllSeats = 39, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Meksyk", Price = 107, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3138, AllSeats = 39, DateTime = DateTime.Parse("2022-07-14"), From = "Meksyk", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3139, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Seszele", Price = 64, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3140, AllSeats = 40, DateTime = DateTime.Parse("2022-07-14"), From = "Seszele", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3141, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Seszele", Price = 124, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 3142, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Seszele", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 3143, AllSeats = 44, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Seszele", Price = 123, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3144, AllSeats = 44, DateTime = DateTime.Parse("2022-07-14"), From = "Seszele", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3145, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Slowenia", Price = 147, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 3146, AllSeats = 100, DateTime = DateTime.Parse("2022-07-14"), From = "Slowenia", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 3147, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Slowenia", Price = 93, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3148, AllSeats = 32, DateTime = DateTime.Parse("2022-07-14"), From = "Slowenia", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3149, AllSeats = 63, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Slowenia", Price = 99, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 3150, AllSeats = 63, DateTime = DateTime.Parse("2022-07-14"), From = "Slowenia", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 63
},
new()
{
Id = 3151, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Turcja", Price = 102, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3152, AllSeats = 35, DateTime = DateTime.Parse("2022-07-14"), From = "Turcja", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3153, AllSeats = 25, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Turcja", Price = 136, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 3154, AllSeats = 25, DateTime = DateTime.Parse("2022-07-14"), From = "Turcja", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 3155, AllSeats = 60, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Turcja", Price = 113, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3156, AllSeats = 60, DateTime = DateTime.Parse("2022-07-14"), From = "Turcja", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3157, AllSeats = 95, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 103, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 3158, AllSeats = 95, DateTime = DateTime.Parse("2022-07-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 3159, AllSeats = 88, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 112, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 3160, AllSeats = 88, DateTime = DateTime.Parse("2022-07-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 3161, AllSeats = 98, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 104, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3162, AllSeats = 98, DateTime = DateTime.Parse("2022-07-14"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3163, AllSeats = 74, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Zanzibar", Price = 67, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3164, AllSeats = 74, DateTime = DateTime.Parse("2022-07-14"), From = "Zanzibar", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3165, AllSeats = 45, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Zanzibar", Price = 52, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3166, AllSeats = 45, DateTime = DateTime.Parse("2022-07-14"), From = "Zanzibar", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3167, AllSeats = 29, DateTime = DateTime.Parse("2022-07-14"), From = "Gdansk", To = "Zanzibar", Price = 55, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3168, AllSeats = 29, DateTime = DateTime.Parse("2022-07-14"), From = "Zanzibar", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3169, AllSeats = 39, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Albania", Price = 148, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3170, AllSeats = 39, DateTime = DateTime.Parse("2022-07-15"), From = "Albania", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3171, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Albania", Price = 122, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3172, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Albania", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3173, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Albania", Price = 135, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3174, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Albania", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3175, AllSeats = 84, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Bulgaria", Price = 67, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3176, AllSeats = 84, DateTime = DateTime.Parse("2022-07-15"), From = "Bulgaria", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3177, AllSeats = 33, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 3178, AllSeats = 33, DateTime = DateTime.Parse("2022-07-15"), From = "Bulgaria", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 3179, AllSeats = 91, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Bulgaria", Price = 54, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 3180, AllSeats = 91, DateTime = DateTime.Parse("2022-07-15"), From = "Bulgaria", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 3181, AllSeats = 64, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Czarnogora", Price = 126, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3182, AllSeats = 64, DateTime = DateTime.Parse("2022-07-15"), From = "Czarnogora", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3183, AllSeats = 51, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Czarnogora", Price = 54, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3184, AllSeats = 51, DateTime = DateTime.Parse("2022-07-15"), From = "Czarnogora", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3185, AllSeats = 38, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Czarnogora", Price = 94, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 3186, AllSeats = 38, DateTime = DateTime.Parse("2022-07-15"), From = "Czarnogora", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 3187, AllSeats = 74, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Egipt", Price = 85, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3188, AllSeats = 74, DateTime = DateTime.Parse("2022-07-15"), From = "Egipt", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3189, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Egipt", Price = 106, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3190, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Egipt", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3191, AllSeats = 28, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Egipt", Price = 105, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3192, AllSeats = 28, DateTime = DateTime.Parse("2022-07-15"), From = "Egipt", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3193, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Grecja", Price = 114, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3194, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Grecja", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3195, AllSeats = 92, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Grecja", Price = 100, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 3196, AllSeats = 92, DateTime = DateTime.Parse("2022-07-15"), From = "Grecja", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 3197, AllSeats = 77, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Grecja", Price = 66, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 3198, AllSeats = 77, DateTime = DateTime.Parse("2022-07-15"), From = "Grecja", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 3199, AllSeats = 58, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Gruzja", Price = 63, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3200, AllSeats = 58, DateTime = DateTime.Parse("2022-07-15"), From = "Gruzja", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3201, AllSeats = 38, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Gruzja", Price = 90, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 3202, AllSeats = 38, DateTime = DateTime.Parse("2022-07-15"), From = "Gruzja", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 38
},
new()
{
Id = 3203, AllSeats = 92, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Gruzja", Price = 115, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3204, AllSeats = 92, DateTime = DateTime.Parse("2022-07-15"), From = "Gruzja", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3205, AllSeats = 53, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Madera", Price = 141, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 3206, AllSeats = 53, DateTime = DateTime.Parse("2022-07-15"), From = "Madera", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 3207, AllSeats = 58, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Madera", Price = 73, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3208, AllSeats = 58, DateTime = DateTime.Parse("2022-07-15"), From = "Madera", To = "Gdansk", Price = 94, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3209, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Madera", Price = 92, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3210, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Madera", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3211, AllSeats = 83, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malediwy", Price = 127, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3212, AllSeats = 83, DateTime = DateTime.Parse("2022-07-15"), From = "Malediwy", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3213, AllSeats = 97, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malediwy", Price = 71, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 3214, AllSeats = 97, DateTime = DateTime.Parse("2022-07-15"), From = "Malediwy", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 3215, AllSeats = 95, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malediwy", Price = 74, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3216, AllSeats = 95, DateTime = DateTime.Parse("2022-07-15"), From = "Malediwy", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3217, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malta", Price = 138, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 3218, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Malta", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 3219, AllSeats = 31, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malta", Price = 86, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 3220, AllSeats = 31, DateTime = DateTime.Parse("2022-07-15"), From = "Malta", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 3221, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Malta", Price = 55, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3222, AllSeats = 98, DateTime = DateTime.Parse("2022-07-15"), From = "Malta", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3223, AllSeats = 70, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Mauritius", Price = 85, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 3224, AllSeats = 70, DateTime = DateTime.Parse("2022-07-15"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 3225, AllSeats = 70, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Mauritius", Price = 91, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3226, AllSeats = 70, DateTime = DateTime.Parse("2022-07-15"), From = "Mauritius", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3227, AllSeats = 59, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Mauritius", Price = 145, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3228, AllSeats = 59, DateTime = DateTime.Parse("2022-07-15"), From = "Mauritius", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3229, AllSeats = 32, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Meksyk", Price = 121, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3230, AllSeats = 32, DateTime = DateTime.Parse("2022-07-15"), From = "Meksyk", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3231, AllSeats = 67, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Meksyk", Price = 129, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3232, AllSeats = 67, DateTime = DateTime.Parse("2022-07-15"), From = "Meksyk", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3233, AllSeats = 37, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Meksyk", Price = 137, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 3234, AllSeats = 37, DateTime = DateTime.Parse("2022-07-15"), From = "Meksyk", To = "Gdansk", Price = 148, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 3235, AllSeats = 46, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Seszele", Price = 102, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3236, AllSeats = 46, DateTime = DateTime.Parse("2022-07-15"), From = "Seszele", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 3237, AllSeats = 83, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Seszele", Price = 149, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3238, AllSeats = 83, DateTime = DateTime.Parse("2022-07-15"), From = "Seszele", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3239, AllSeats = 52, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Seszele", Price = 60, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 3240, AllSeats = 52, DateTime = DateTime.Parse("2022-07-15"), From = "Seszele", To = "Gdansk", Price = 81, Type = TransportType.Train, AvailableSeats = 52
},
new()
{
Id = 3241, AllSeats = 42, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Slowenia", Price = 145, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3242, AllSeats = 42, DateTime = DateTime.Parse("2022-07-15"), From = "Slowenia", To = "Gdansk", Price = 58, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3243, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Slowenia", Price = 70, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3244, AllSeats = 69, DateTime = DateTime.Parse("2022-07-15"), From = "Slowenia", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3245, AllSeats = 40, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Slowenia", Price = 122, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3246, AllSeats = 40, DateTime = DateTime.Parse("2022-07-15"), From = "Slowenia", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3247, AllSeats = 87, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Turcja", Price = 149, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3248, AllSeats = 87, DateTime = DateTime.Parse("2022-07-15"), From = "Turcja", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3249, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3250, AllSeats = 50, DateTime = DateTime.Parse("2022-07-15"), From = "Turcja", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3251, AllSeats = 28, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Turcja", Price = 77, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3252, AllSeats = 28, DateTime = DateTime.Parse("2022-07-15"), From = "Turcja", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3253, AllSeats = 29, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 75, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3254, AllSeats = 29, DateTime = DateTime.Parse("2022-07-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3255, AllSeats = 53, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 69, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3256, AllSeats = 53, DateTime = DateTime.Parse("2022-07-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3257, AllSeats = 45, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 103, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 3258, AllSeats = 45, DateTime = DateTime.Parse("2022-07-15"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 3259, AllSeats = 82, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Zanzibar", Price = 77, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 3260, AllSeats = 82, DateTime = DateTime.Parse("2022-07-15"), From = "Zanzibar", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 3261, AllSeats = 29, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Zanzibar", Price = 53, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3262, AllSeats = 29, DateTime = DateTime.Parse("2022-07-15"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3263, AllSeats = 72, DateTime = DateTime.Parse("2022-07-15"), From = "Gdansk", To = "Zanzibar", Price = 131, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 3264, AllSeats = 72, DateTime = DateTime.Parse("2022-07-15"), From = "Zanzibar", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 3265, AllSeats = 72, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Albania", Price = 101, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3266, AllSeats = 72, DateTime = DateTime.Parse("2022-07-16"), From = "Albania", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3267, AllSeats = 39, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Albania", Price = 60, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 3268, AllSeats = 39, DateTime = DateTime.Parse("2022-07-16"), From = "Albania", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 3269, AllSeats = 86, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Albania", Price = 112, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 3270, AllSeats = 86, DateTime = DateTime.Parse("2022-07-16"), From = "Albania", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 3271, AllSeats = 48, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 3272, AllSeats = 48, DateTime = DateTime.Parse("2022-07-16"), From = "Bulgaria", To = "Gdansk", Price = 148, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 3273, AllSeats = 63, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Bulgaria", Price = 70, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 3274, AllSeats = 63, DateTime = DateTime.Parse("2022-07-16"), From = "Bulgaria", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 63
},
new()
{
Id = 3275, AllSeats = 61, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Bulgaria", Price = 102, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 3276, AllSeats = 61, DateTime = DateTime.Parse("2022-07-16"), From = "Bulgaria", To = "Gdansk", Price = 81, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 3277, AllSeats = 40, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Czarnogora", Price = 55, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3278, AllSeats = 40, DateTime = DateTime.Parse("2022-07-16"), From = "Czarnogora", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 3279, AllSeats = 57, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Czarnogora", Price = 91, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 3280, AllSeats = 57, DateTime = DateTime.Parse("2022-07-16"), From = "Czarnogora", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 3281, AllSeats = 81, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Czarnogora", Price = 122, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3282, AllSeats = 81, DateTime = DateTime.Parse("2022-07-16"), From = "Czarnogora", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3283, AllSeats = 57, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Egipt", Price = 110, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3284, AllSeats = 57, DateTime = DateTime.Parse("2022-07-16"), From = "Egipt", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3285, AllSeats = 46, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Egipt", Price = 117, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3286, AllSeats = 46, DateTime = DateTime.Parse("2022-07-16"), From = "Egipt", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3287, AllSeats = 48, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Egipt", Price = 88, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 3288, AllSeats = 48, DateTime = DateTime.Parse("2022-07-16"), From = "Egipt", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 3289, AllSeats = 59, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Grecja", Price = 126, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3290, AllSeats = 59, DateTime = DateTime.Parse("2022-07-16"), From = "Grecja", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3291, AllSeats = 55, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Grecja", Price = 61, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3292, AllSeats = 55, DateTime = DateTime.Parse("2022-07-16"), From = "Grecja", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3293, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Grecja", Price = 75, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3294, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Grecja", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3295, AllSeats = 65, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Gruzja", Price = 142, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 3296, AllSeats = 65, DateTime = DateTime.Parse("2022-07-16"), From = "Gruzja", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 3297, AllSeats = 64, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Gruzja", Price = 51, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 3298, AllSeats = 64, DateTime = DateTime.Parse("2022-07-16"), From = "Gruzja", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 3299, AllSeats = 56, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Gruzja", Price = 135, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 3300, AllSeats = 56, DateTime = DateTime.Parse("2022-07-16"), From = "Gruzja", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 3301, AllSeats = 87, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Madera", Price = 145, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3302, AllSeats = 87, DateTime = DateTime.Parse("2022-07-16"), From = "Madera", To = "Gdansk", Price = 89, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3303, AllSeats = 91, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Madera", Price = 138, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 3304, AllSeats = 91, DateTime = DateTime.Parse("2022-07-16"), From = "Madera", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 3305, AllSeats = 92, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Madera", Price = 101, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3306, AllSeats = 92, DateTime = DateTime.Parse("2022-07-16"), From = "Madera", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3307, AllSeats = 99, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malediwy", Price = 145, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3308, AllSeats = 99, DateTime = DateTime.Parse("2022-07-16"), From = "Malediwy", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3309, AllSeats = 76, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malediwy", Price = 69, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 3310, AllSeats = 76, DateTime = DateTime.Parse("2022-07-16"), From = "Malediwy", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 3311, AllSeats = 31, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malediwy", Price = 138, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 3312, AllSeats = 31, DateTime = DateTime.Parse("2022-07-16"), From = "Malediwy", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 3313, AllSeats = 31, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malta", Price = 66, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 3314, AllSeats = 31, DateTime = DateTime.Parse("2022-07-16"), From = "Malta", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 3315, AllSeats = 73, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malta", Price = 134, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3316, AllSeats = 73, DateTime = DateTime.Parse("2022-07-16"), From = "Malta", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3317, AllSeats = 84, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Malta", Price = 149, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 3318, AllSeats = 84, DateTime = DateTime.Parse("2022-07-16"), From = "Malta", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 3319, AllSeats = 42, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Mauritius", Price = 90, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3320, AllSeats = 42, DateTime = DateTime.Parse("2022-07-16"), From = "Mauritius", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3321, AllSeats = 44, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Mauritius", Price = 115, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 3322, AllSeats = 44, DateTime = DateTime.Parse("2022-07-16"), From = "Mauritius", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 3323, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Mauritius", Price = 114, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3324, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Mauritius", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 51
},
new()
{
Id = 3325, AllSeats = 93, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Meksyk", Price = 104, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3326, AllSeats = 93, DateTime = DateTime.Parse("2022-07-16"), From = "Meksyk", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3327, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3328, AllSeats = 51, DateTime = DateTime.Parse("2022-07-16"), From = "Meksyk", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3329, AllSeats = 90, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Meksyk", Price = 144, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3330, AllSeats = 90, DateTime = DateTime.Parse("2022-07-16"), From = "Meksyk", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3331, AllSeats = 99, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Seszele", Price = 136, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3332, AllSeats = 99, DateTime = DateTime.Parse("2022-07-16"), From = "Seszele", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3333, AllSeats = 56, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Seszele", Price = 76, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3334, AllSeats = 56, DateTime = DateTime.Parse("2022-07-16"), From = "Seszele", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3335, AllSeats = 34, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Seszele", Price = 124, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3336, AllSeats = 34, DateTime = DateTime.Parse("2022-07-16"), From = "Seszele", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3337, AllSeats = 37, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Slowenia", Price = 59, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 3338, AllSeats = 37, DateTime = DateTime.Parse("2022-07-16"), From = "Slowenia", To = "Gdansk", Price = 143, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 3339, AllSeats = 81, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Slowenia", Price = 134, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 3340, AllSeats = 81, DateTime = DateTime.Parse("2022-07-16"), From = "Slowenia", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 3341, AllSeats = 70, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Slowenia", Price = 103, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3342, AllSeats = 70, DateTime = DateTime.Parse("2022-07-16"), From = "Slowenia", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3343, AllSeats = 52, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Turcja", Price = 75, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3344, AllSeats = 52, DateTime = DateTime.Parse("2022-07-16"), From = "Turcja", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3345, AllSeats = 55, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Turcja", Price = 72, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3346, AllSeats = 55, DateTime = DateTime.Parse("2022-07-16"), From = "Turcja", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3347, AllSeats = 59, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Turcja", Price = 104, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3348, AllSeats = 59, DateTime = DateTime.Parse("2022-07-16"), From = "Turcja", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3349, AllSeats = 34, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 145, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 3350, AllSeats = 34, DateTime = DateTime.Parse("2022-07-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 3351, AllSeats = 86, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 125, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3352, AllSeats = 86, DateTime = DateTime.Parse("2022-07-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 101, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3353, AllSeats = 87, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 74, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3354, AllSeats = 87, DateTime = DateTime.Parse("2022-07-16"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 59, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3355, AllSeats = 93, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Zanzibar", Price = 122, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3356, AllSeats = 93, DateTime = DateTime.Parse("2022-07-16"), From = "Zanzibar", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3357, AllSeats = 29, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Zanzibar", Price = 68, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3358, AllSeats = 29, DateTime = DateTime.Parse("2022-07-16"), From = "Zanzibar", To = "Gdansk", Price = 89, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 3359, AllSeats = 42, DateTime = DateTime.Parse("2022-07-16"), From = "Gdansk", To = "Zanzibar", Price = 144, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 3360, AllSeats = 42, DateTime = DateTime.Parse("2022-07-16"), From = "Zanzibar", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 3361, AllSeats = 94, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Albania", Price = 150, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3362, AllSeats = 94, DateTime = DateTime.Parse("2022-07-17"), From = "Albania", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3363, AllSeats = 64, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Albania", Price = 112, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 3364, AllSeats = 64, DateTime = DateTime.Parse("2022-07-17"), From = "Albania", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 64
},
new()
{
Id = 3365, AllSeats = 66, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Albania", Price = 105, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 3366, AllSeats = 66, DateTime = DateTime.Parse("2022-07-17"), From = "Albania", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 3367, AllSeats = 45, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Bulgaria", Price = 76, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3368, AllSeats = 45, DateTime = DateTime.Parse("2022-07-17"), From = "Bulgaria", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3369, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Bulgaria", Price = 57, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3370, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Bulgaria", To = "Gdansk", Price = 148, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 3371, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Bulgaria", Price = 87, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3372, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Bulgaria", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3373, AllSeats = 64, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Czarnogora", Price = 105, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3374, AllSeats = 64, DateTime = DateTime.Parse("2022-07-17"), From = "Czarnogora", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3375, AllSeats = 91, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Czarnogora", Price = 121, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 3376, AllSeats = 91, DateTime = DateTime.Parse("2022-07-17"), From = "Czarnogora", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 3377, AllSeats = 34, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Czarnogora", Price = 122, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3378, AllSeats = 34, DateTime = DateTime.Parse("2022-07-17"), From = "Czarnogora", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3379, AllSeats = 44, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Egipt", Price = 105, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3380, AllSeats = 44, DateTime = DateTime.Parse("2022-07-17"), From = "Egipt", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3381, AllSeats = 49, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Egipt", Price = 99, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3382, AllSeats = 49, DateTime = DateTime.Parse("2022-07-17"), From = "Egipt", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3383, AllSeats = 97, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Egipt", Price = 113, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 3384, AllSeats = 97, DateTime = DateTime.Parse("2022-07-17"), From = "Egipt", To = "Gdansk", Price = 127, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 3385, AllSeats = 68, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Grecja", Price = 59, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 3386, AllSeats = 68, DateTime = DateTime.Parse("2022-07-17"), From = "Grecja", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 3387, AllSeats = 73, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Grecja", Price = 60, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3388, AllSeats = 73, DateTime = DateTime.Parse("2022-07-17"), From = "Grecja", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 3389, AllSeats = 29, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Grecja", Price = 132, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3390, AllSeats = 29, DateTime = DateTime.Parse("2022-07-17"), From = "Grecja", To = "Gdansk", Price = 88, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3391, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Gruzja", Price = 133, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 3392, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Gruzja", To = "Gdansk", Price = 139, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 3393, AllSeats = 51, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Gruzja", Price = 75, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3394, AllSeats = 51, DateTime = DateTime.Parse("2022-07-17"), From = "Gruzja", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3395, AllSeats = 25, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Gruzja", Price = 117, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 3396, AllSeats = 25, DateTime = DateTime.Parse("2022-07-17"), From = "Gruzja", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 3397, AllSeats = 62, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Madera", Price = 58, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 3398, AllSeats = 62, DateTime = DateTime.Parse("2022-07-17"), From = "Madera", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 3399, AllSeats = 75, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Madera", Price = 139, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 3400, AllSeats = 75, DateTime = DateTime.Parse("2022-07-17"), From = "Madera", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 3401, AllSeats = 62, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Madera", Price = 56, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3402, AllSeats = 62, DateTime = DateTime.Parse("2022-07-17"), From = "Madera", To = "Gdansk", Price = 144, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3403, AllSeats = 50, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malediwy", Price = 90, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 3404, AllSeats = 50, DateTime = DateTime.Parse("2022-07-17"), From = "Malediwy", To = "Gdansk", Price = 139, Type = TransportType.Bus, AvailableSeats = 50
},
new()
{
Id = 3405, AllSeats = 36, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malediwy", Price = 66, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 3406, AllSeats = 36, DateTime = DateTime.Parse("2022-07-17"), From = "Malediwy", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 3407, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malediwy", Price = 113, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3408, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Malediwy", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3409, AllSeats = 31, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malta", Price = 150, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 3410, AllSeats = 31, DateTime = DateTime.Parse("2022-07-17"), From = "Malta", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 3411, AllSeats = 40, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malta", Price = 130, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3412, AllSeats = 40, DateTime = DateTime.Parse("2022-07-17"), From = "Malta", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3413, AllSeats = 98, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Malta", Price = 65, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3414, AllSeats = 98, DateTime = DateTime.Parse("2022-07-17"), From = "Malta", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3415, AllSeats = 97, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Mauritius", Price = 69, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3416, AllSeats = 97, DateTime = DateTime.Parse("2022-07-17"), From = "Mauritius", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3417, AllSeats = 56, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Mauritius", Price = 118, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3418, AllSeats = 56, DateTime = DateTime.Parse("2022-07-17"), From = "Mauritius", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3419, AllSeats = 25, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Mauritius", Price = 143, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 3420, AllSeats = 25, DateTime = DateTime.Parse("2022-07-17"), From = "Mauritius", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 3421, AllSeats = 58, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Meksyk", Price = 118, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3422, AllSeats = 58, DateTime = DateTime.Parse("2022-07-17"), From = "Meksyk", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3423, AllSeats = 55, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Meksyk", Price = 90, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3424, AllSeats = 55, DateTime = DateTime.Parse("2022-07-17"), From = "Meksyk", To = "Gdansk", Price = 115, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3425, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Meksyk", Price = 70, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3426, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Meksyk", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3427, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Seszele", Price = 105, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 3428, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Seszele", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 3429, AllSeats = 32, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Seszele", Price = 140, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3430, AllSeats = 32, DateTime = DateTime.Parse("2022-07-17"), From = "Seszele", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3431, AllSeats = 82, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Seszele", Price = 89, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3432, AllSeats = 82, DateTime = DateTime.Parse("2022-07-17"), From = "Seszele", To = "Gdansk", Price = 99, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3433, AllSeats = 94, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Slowenia", Price = 62, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3434, AllSeats = 94, DateTime = DateTime.Parse("2022-07-17"), From = "Slowenia", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3435, AllSeats = 100, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Slowenia", Price = 58, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 3436, AllSeats = 100, DateTime = DateTime.Parse("2022-07-17"), From = "Slowenia", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 100
},
new()
{
Id = 3437, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Slowenia", Price = 147, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3438, AllSeats = 78, DateTime = DateTime.Parse("2022-07-17"), From = "Slowenia", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3439, AllSeats = 49, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Turcja", Price = 117, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 3440, AllSeats = 49, DateTime = DateTime.Parse("2022-07-17"), From = "Turcja", To = "Gdansk", Price = 98, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 3441, AllSeats = 46, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Turcja", Price = 91, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3442, AllSeats = 46, DateTime = DateTime.Parse("2022-07-17"), From = "Turcja", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3443, AllSeats = 90, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Turcja", Price = 89, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3444, AllSeats = 90, DateTime = DateTime.Parse("2022-07-17"), From = "Turcja", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3445, AllSeats = 55, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 89, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 3446, AllSeats = 55, DateTime = DateTime.Parse("2022-07-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 3447, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 134, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3448, AllSeats = 67, DateTime = DateTime.Parse("2022-07-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3449, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 146, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3450, AllSeats = 95, DateTime = DateTime.Parse("2022-07-17"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 95
},
new()
{
Id = 3451, AllSeats = 91, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Zanzibar", Price = 80, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3452, AllSeats = 91, DateTime = DateTime.Parse("2022-07-17"), From = "Zanzibar", To = "Gdansk", Price = 95, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3453, AllSeats = 53, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Zanzibar", Price = 69, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3454, AllSeats = 53, DateTime = DateTime.Parse("2022-07-17"), From = "Zanzibar", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3455, AllSeats = 33, DateTime = DateTime.Parse("2022-07-17"), From = "Gdansk", To = "Zanzibar", Price = 76, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3456, AllSeats = 33, DateTime = DateTime.Parse("2022-07-17"), From = "Zanzibar", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3457, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Albania", Price = 138, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3458, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Albania", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3459, AllSeats = 80, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Albania", Price = 65, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3460, AllSeats = 80, DateTime = DateTime.Parse("2022-07-18"), From = "Albania", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3461, AllSeats = 32, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Albania", Price = 61, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 3462, AllSeats = 32, DateTime = DateTime.Parse("2022-07-18"), From = "Albania", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 3463, AllSeats = 44, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Bulgaria", Price = 117, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3464, AllSeats = 44, DateTime = DateTime.Parse("2022-07-18"), From = "Bulgaria", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3465, AllSeats = 96, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Bulgaria", Price = 106, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 3466, AllSeats = 96, DateTime = DateTime.Parse("2022-07-18"), From = "Bulgaria", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 3467, AllSeats = 39, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Bulgaria", Price = 60, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3468, AllSeats = 39, DateTime = DateTime.Parse("2022-07-18"), From = "Bulgaria", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3469, AllSeats = 93, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Czarnogora", Price = 60, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3470, AllSeats = 93, DateTime = DateTime.Parse("2022-07-18"), From = "Czarnogora", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3471, AllSeats = 46, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Czarnogora", Price = 99, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3472, AllSeats = 46, DateTime = DateTime.Parse("2022-07-18"), From = "Czarnogora", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 3473, AllSeats = 81, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Czarnogora", Price = 116, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3474, AllSeats = 81, DateTime = DateTime.Parse("2022-07-18"), From = "Czarnogora", To = "Gdansk", Price = 100, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3475, AllSeats = 64, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Egipt", Price = 51, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3476, AllSeats = 64, DateTime = DateTime.Parse("2022-07-18"), From = "Egipt", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 3477, AllSeats = 40, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Egipt", Price = 116, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3478, AllSeats = 40, DateTime = DateTime.Parse("2022-07-18"), From = "Egipt", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3479, AllSeats = 92, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Egipt", Price = 120, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3480, AllSeats = 92, DateTime = DateTime.Parse("2022-07-18"), From = "Egipt", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3481, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Grecja", Price = 127, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3482, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Grecja", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3483, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Grecja", Price = 95, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3484, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Grecja", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3485, AllSeats = 46, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Grecja", Price = 138, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 3486, AllSeats = 46, DateTime = DateTime.Parse("2022-07-18"), From = "Grecja", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 3487, AllSeats = 58, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Gruzja", Price = 102, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3488, AllSeats = 58, DateTime = DateTime.Parse("2022-07-18"), From = "Gruzja", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 3489, AllSeats = 69, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Gruzja", Price = 107, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3490, AllSeats = 69, DateTime = DateTime.Parse("2022-07-18"), From = "Gruzja", To = "Gdansk", Price = 149, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 3491, AllSeats = 96, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Gruzja", Price = 52, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 3492, AllSeats = 96, DateTime = DateTime.Parse("2022-07-18"), From = "Gruzja", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 3493, AllSeats = 59, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Madera", Price = 63, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3494, AllSeats = 59, DateTime = DateTime.Parse("2022-07-18"), From = "Madera", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3495, AllSeats = 40, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Madera", Price = 60, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3496, AllSeats = 40, DateTime = DateTime.Parse("2022-07-18"), From = "Madera", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3497, AllSeats = 53, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Madera", Price = 63, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3498, AllSeats = 53, DateTime = DateTime.Parse("2022-07-18"), From = "Madera", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3499, AllSeats = 57, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malediwy", Price = 89, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3500, AllSeats = 57, DateTime = DateTime.Parse("2022-07-18"), From = "Malediwy", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3501, AllSeats = 49, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malediwy", Price = 150, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3502, AllSeats = 49, DateTime = DateTime.Parse("2022-07-18"), From = "Malediwy", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3503, AllSeats = 33, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malediwy", Price = 75, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3504, AllSeats = 33, DateTime = DateTime.Parse("2022-07-18"), From = "Malediwy", To = "Gdansk", Price = 59, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3505, AllSeats = 75, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malta", Price = 80, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3506, AllSeats = 75, DateTime = DateTime.Parse("2022-07-18"), From = "Malta", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3507, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malta", Price = 104, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3508, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Malta", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3509, AllSeats = 69, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Malta", Price = 80, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3510, AllSeats = 69, DateTime = DateTime.Parse("2022-07-18"), From = "Malta", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3511, AllSeats = 91, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Mauritius", Price = 72, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3512, AllSeats = 91, DateTime = DateTime.Parse("2022-07-18"), From = "Mauritius", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3513, AllSeats = 86, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Mauritius", Price = 111, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3514, AllSeats = 86, DateTime = DateTime.Parse("2022-07-18"), From = "Mauritius", To = "Gdansk", Price = 117, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3515, AllSeats = 67, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Mauritius", Price = 107, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3516, AllSeats = 67, DateTime = DateTime.Parse("2022-07-18"), From = "Mauritius", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3517, AllSeats = 36, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Meksyk", Price = 144, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 3518, AllSeats = 36, DateTime = DateTime.Parse("2022-07-18"), From = "Meksyk", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 3519, AllSeats = 26, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Meksyk", Price = 105, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 3520, AllSeats = 26, DateTime = DateTime.Parse("2022-07-18"), From = "Meksyk", To = "Gdansk", Price = 139, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 3521, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Meksyk", Price = 135, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 3522, AllSeats = 30, DateTime = DateTime.Parse("2022-07-18"), From = "Meksyk", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 3523, AllSeats = 42, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Seszele", Price = 102, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3524, AllSeats = 42, DateTime = DateTime.Parse("2022-07-18"), From = "Seszele", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 3525, AllSeats = 41, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Seszele", Price = 51, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3526, AllSeats = 41, DateTime = DateTime.Parse("2022-07-18"), From = "Seszele", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3527, AllSeats = 28, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Seszele", Price = 126, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3528, AllSeats = 28, DateTime = DateTime.Parse("2022-07-18"), From = "Seszele", To = "Gdansk", Price = 141, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3529, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Slowenia", Price = 138, Type = TransportType.Bus, AvailableSeats = 79
},
new()
{
Id = 3530, AllSeats = 79, DateTime = DateTime.Parse("2022-07-18"), From = "Slowenia", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 79
},
new()
{
Id = 3531, AllSeats = 85, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Slowenia", Price = 83, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 3532, AllSeats = 85, DateTime = DateTime.Parse("2022-07-18"), From = "Slowenia", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 3533, AllSeats = 53, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Slowenia", Price = 121, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3534, AllSeats = 53, DateTime = DateTime.Parse("2022-07-18"), From = "Slowenia", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3535, AllSeats = 44, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Turcja", Price = 63, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3536, AllSeats = 44, DateTime = DateTime.Parse("2022-07-18"), From = "Turcja", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 44
},
new()
{
Id = 3537, AllSeats = 42, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Turcja", Price = 64, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3538, AllSeats = 42, DateTime = DateTime.Parse("2022-07-18"), From = "Turcja", To = "Gdansk", Price = 83, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3539, AllSeats = 78, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Turcja", Price = 78, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3540, AllSeats = 78, DateTime = DateTime.Parse("2022-07-18"), From = "Turcja", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3541, AllSeats = 91, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 115, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3542, AllSeats = 91, DateTime = DateTime.Parse("2022-07-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 3543, AllSeats = 90, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 50, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 3544, AllSeats = 90, DateTime = DateTime.Parse("2022-07-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 90
},
new()
{
Id = 3545, AllSeats = 100, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 102, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3546, AllSeats = 100, DateTime = DateTime.Parse("2022-07-18"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 57, Type = TransportType.Train, AvailableSeats = 100
},
new()
{
Id = 3547, AllSeats = 81, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Zanzibar", Price = 120, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3548, AllSeats = 81, DateTime = DateTime.Parse("2022-07-18"), From = "Zanzibar", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3549, AllSeats = 60, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Zanzibar", Price = 136, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3550, AllSeats = 60, DateTime = DateTime.Parse("2022-07-18"), From = "Zanzibar", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3551, AllSeats = 64, DateTime = DateTime.Parse("2022-07-18"), From = "Gdansk", To = "Zanzibar", Price = 84, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 3552, AllSeats = 64, DateTime = DateTime.Parse("2022-07-18"), From = "Zanzibar", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 3553, AllSeats = 92, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Albania", Price = 137, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 3554, AllSeats = 92, DateTime = DateTime.Parse("2022-07-19"), From = "Albania", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 3555, AllSeats = 37, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Albania", Price = 144, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 3556, AllSeats = 37, DateTime = DateTime.Parse("2022-07-19"), From = "Albania", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 3557, AllSeats = 75, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Albania", Price = 150, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 3558, AllSeats = 75, DateTime = DateTime.Parse("2022-07-19"), From = "Albania", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 3559, AllSeats = 45, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Bulgaria", Price = 85, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3560, AllSeats = 45, DateTime = DateTime.Parse("2022-07-19"), From = "Bulgaria", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3561, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Bulgaria", Price = 114, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3562, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Bulgaria", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3563, AllSeats = 44, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3564, AllSeats = 44, DateTime = DateTime.Parse("2022-07-19"), From = "Bulgaria", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3565, AllSeats = 81, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Czarnogora", Price = 68, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3566, AllSeats = 81, DateTime = DateTime.Parse("2022-07-19"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3567, AllSeats = 67, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Czarnogora", Price = 130, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3568, AllSeats = 67, DateTime = DateTime.Parse("2022-07-19"), From = "Czarnogora", To = "Gdansk", Price = 79, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3569, AllSeats = 99, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Czarnogora", Price = 98, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 3570, AllSeats = 99, DateTime = DateTime.Parse("2022-07-19"), From = "Czarnogora", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 3571, AllSeats = 72, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Egipt", Price = 119, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3572, AllSeats = 72, DateTime = DateTime.Parse("2022-07-19"), From = "Egipt", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3573, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Egipt", Price = 81, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3574, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Egipt", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3575, AllSeats = 90, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Egipt", Price = 73, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3576, AllSeats = 90, DateTime = DateTime.Parse("2022-07-19"), From = "Egipt", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 3577, AllSeats = 77, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Grecja", Price = 95, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 3578, AllSeats = 77, DateTime = DateTime.Parse("2022-07-19"), From = "Grecja", To = "Gdansk", Price = 82, Type = TransportType.Bus, AvailableSeats = 77
},
new()
{
Id = 3579, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Grecja", Price = 84, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3580, AllSeats = 70, DateTime = DateTime.Parse("2022-07-19"), From = "Grecja", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 3581, AllSeats = 29, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Grecja", Price = 64, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3582, AllSeats = 29, DateTime = DateTime.Parse("2022-07-19"), From = "Grecja", To = "Gdansk", Price = 67, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 3583, AllSeats = 99, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Gruzja", Price = 136, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3584, AllSeats = 99, DateTime = DateTime.Parse("2022-07-19"), From = "Gruzja", To = "Gdansk", Price = 99, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3585, AllSeats = 49, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Gruzja", Price = 59, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3586, AllSeats = 49, DateTime = DateTime.Parse("2022-07-19"), From = "Gruzja", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3587, AllSeats = 92, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Gruzja", Price = 99, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3588, AllSeats = 92, DateTime = DateTime.Parse("2022-07-19"), From = "Gruzja", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3589, AllSeats = 97, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Madera", Price = 72, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3590, AllSeats = 97, DateTime = DateTime.Parse("2022-07-19"), From = "Madera", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3591, AllSeats = 30, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Madera", Price = 91, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 3592, AllSeats = 30, DateTime = DateTime.Parse("2022-07-19"), From = "Madera", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 3593, AllSeats = 55, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Madera", Price = 139, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 3594, AllSeats = 55, DateTime = DateTime.Parse("2022-07-19"), From = "Madera", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 3595, AllSeats = 87, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3596, AllSeats = 87, DateTime = DateTime.Parse("2022-07-19"), From = "Malediwy", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 3597, AllSeats = 75, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malediwy", Price = 57, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 3598, AllSeats = 75, DateTime = DateTime.Parse("2022-07-19"), From = "Malediwy", To = "Gdansk", Price = 76, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 3599, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malediwy", Price = 139, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3600, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Malediwy", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3601, AllSeats = 86, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malta", Price = 149, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 3602, AllSeats = 86, DateTime = DateTime.Parse("2022-07-19"), From = "Malta", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 3603, AllSeats = 44, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malta", Price = 85, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 3604, AllSeats = 44, DateTime = DateTime.Parse("2022-07-19"), From = "Malta", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 3605, AllSeats = 82, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Malta", Price = 77, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3606, AllSeats = 82, DateTime = DateTime.Parse("2022-07-19"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 3607, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Mauritius", Price = 82, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3608, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Mauritius", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3609, AllSeats = 74, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Mauritius", Price = 67, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 3610, AllSeats = 74, DateTime = DateTime.Parse("2022-07-19"), From = "Mauritius", To = "Gdansk", Price = 72, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 3611, AllSeats = 69, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Mauritius", Price = 92, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3612, AllSeats = 69, DateTime = DateTime.Parse("2022-07-19"), From = "Mauritius", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3613, AllSeats = 67, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Meksyk", Price = 131, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 3614, AllSeats = 67, DateTime = DateTime.Parse("2022-07-19"), From = "Meksyk", To = "Gdansk", Price = 95, Type = TransportType.Bus, AvailableSeats = 67
},
new()
{
Id = 3615, AllSeats = 60, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Meksyk", Price = 67, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3616, AllSeats = 60, DateTime = DateTime.Parse("2022-07-19"), From = "Meksyk", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3617, AllSeats = 85, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Meksyk", Price = 94, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 3618, AllSeats = 85, DateTime = DateTime.Parse("2022-07-19"), From = "Meksyk", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 3619, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Seszele", Price = 94, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3620, AllSeats = 98, DateTime = DateTime.Parse("2022-07-19"), From = "Seszele", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3621, AllSeats = 79, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Seszele", Price = 119, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3622, AllSeats = 79, DateTime = DateTime.Parse("2022-07-19"), From = "Seszele", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3623, AllSeats = 76, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Seszele", Price = 139, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3624, AllSeats = 76, DateTime = DateTime.Parse("2022-07-19"), From = "Seszele", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3625, AllSeats = 73, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Slowenia", Price = 61, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3626, AllSeats = 73, DateTime = DateTime.Parse("2022-07-19"), From = "Slowenia", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3627, AllSeats = 66, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Slowenia", Price = 129, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 3628, AllSeats = 66, DateTime = DateTime.Parse("2022-07-19"), From = "Slowenia", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 3629, AllSeats = 33, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Slowenia", Price = 67, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3630, AllSeats = 33, DateTime = DateTime.Parse("2022-07-19"), From = "Slowenia", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3631, AllSeats = 97, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Turcja", Price = 76, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3632, AllSeats = 97, DateTime = DateTime.Parse("2022-07-19"), From = "Turcja", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 3633, AllSeats = 50, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Turcja", Price = 148, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3634, AllSeats = 50, DateTime = DateTime.Parse("2022-07-19"), From = "Turcja", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 3635, AllSeats = 32, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Turcja", Price = 82, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 3636, AllSeats = 32, DateTime = DateTime.Parse("2022-07-19"), From = "Turcja", To = "Gdansk", Price = 78, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 3637, AllSeats = 25, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 150, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 3638, AllSeats = 25, DateTime = DateTime.Parse("2022-07-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 70, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 3639, AllSeats = 48, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 90, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3640, AllSeats = 48, DateTime = DateTime.Parse("2022-07-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 110, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3641, AllSeats = 78, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 54, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3642, AllSeats = 78, DateTime = DateTime.Parse("2022-07-19"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3643, AllSeats = 93, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Zanzibar", Price = 82, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3644, AllSeats = 93, DateTime = DateTime.Parse("2022-07-19"), From = "Zanzibar", To = "Gdansk", Price = 63, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3645, AllSeats = 83, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Zanzibar", Price = 81, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3646, AllSeats = 83, DateTime = DateTime.Parse("2022-07-19"), From = "Zanzibar", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3647, AllSeats = 78, DateTime = DateTime.Parse("2022-07-19"), From = "Gdansk", To = "Zanzibar", Price = 91, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3648, AllSeats = 78, DateTime = DateTime.Parse("2022-07-19"), From = "Zanzibar", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3649, AllSeats = 78, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Albania", Price = 85, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 3650, AllSeats = 78, DateTime = DateTime.Parse("2022-07-20"), From = "Albania", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 3651, AllSeats = 36, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Albania", Price = 56, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 3652, AllSeats = 36, DateTime = DateTime.Parse("2022-07-20"), From = "Albania", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 36
},
new()
{
Id = 3653, AllSeats = 69, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Albania", Price = 119, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3654, AllSeats = 69, DateTime = DateTime.Parse("2022-07-20"), From = "Albania", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3655, AllSeats = 41, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Bulgaria", Price = 61, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3656, AllSeats = 41, DateTime = DateTime.Parse("2022-07-20"), From = "Bulgaria", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3657, AllSeats = 87, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Bulgaria", Price = 138, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 3658, AllSeats = 87, DateTime = DateTime.Parse("2022-07-20"), From = "Bulgaria", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 3659, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3660, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Bulgaria", To = "Gdansk", Price = 137, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 3661, AllSeats = 98, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Czarnogora", Price = 68, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3662, AllSeats = 98, DateTime = DateTime.Parse("2022-07-20"), From = "Czarnogora", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3663, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Czarnogora", Price = 82, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3664, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Czarnogora", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 3665, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Czarnogora", Price = 132, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3666, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Czarnogora", To = "Gdansk", Price = 116, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3667, AllSeats = 33, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Egipt", Price = 99, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3668, AllSeats = 33, DateTime = DateTime.Parse("2022-07-20"), From = "Egipt", To = "Gdansk", Price = 62, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3669, AllSeats = 42, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Egipt", Price = 117, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3670, AllSeats = 42, DateTime = DateTime.Parse("2022-07-20"), From = "Egipt", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3671, AllSeats = 58, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Egipt", Price = 126, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 3672, AllSeats = 58, DateTime = DateTime.Parse("2022-07-20"), From = "Egipt", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 58
},
new()
{
Id = 3673, AllSeats = 74, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Grecja", Price = 140, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3674, AllSeats = 74, DateTime = DateTime.Parse("2022-07-20"), From = "Grecja", To = "Gdansk", Price = 143, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3675, AllSeats = 48, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Grecja", Price = 135, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3676, AllSeats = 48, DateTime = DateTime.Parse("2022-07-20"), From = "Grecja", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3677, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Grecja", Price = 138, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 3678, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Grecja", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 3679, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Gruzja", Price = 75, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3680, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Gruzja", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3681, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Gruzja", Price = 80, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3682, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Gruzja", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 3683, AllSeats = 97, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Gruzja", Price = 121, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 3684, AllSeats = 97, DateTime = DateTime.Parse("2022-07-20"), From = "Gruzja", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 3685, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Madera", Price = 55, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3686, AllSeats = 45, DateTime = DateTime.Parse("2022-07-20"), From = "Madera", To = "Gdansk", Price = 148, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3687, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Madera", Price = 71, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3688, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Madera", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3689, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Madera", Price = 68, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 3690, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Madera", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 3691, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malediwy", Price = 129, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 3692, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Malediwy", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 3693, AllSeats = 77, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malediwy", Price = 93, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 3694, AllSeats = 77, DateTime = DateTime.Parse("2022-07-20"), From = "Malediwy", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 3695, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malediwy", Price = 71, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3696, AllSeats = 40, DateTime = DateTime.Parse("2022-07-20"), From = "Malediwy", To = "Gdansk", Price = 54, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3697, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malta", Price = 102, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3698, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Malta", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 3699, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malta", Price = 64, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3700, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Malta", To = "Gdansk", Price = 144, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3701, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Malta", Price = 58, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 3702, AllSeats = 47, DateTime = DateTime.Parse("2022-07-20"), From = "Malta", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 3703, AllSeats = 84, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Mauritius", Price = 51, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3704, AllSeats = 84, DateTime = DateTime.Parse("2022-07-20"), From = "Mauritius", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 3705, AllSeats = 71, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Mauritius", Price = 111, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 3706, AllSeats = 71, DateTime = DateTime.Parse("2022-07-20"), From = "Mauritius", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 71
},
new()
{
Id = 3707, AllSeats = 81, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Mauritius", Price = 64, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3708, AllSeats = 81, DateTime = DateTime.Parse("2022-07-20"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 3709, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Meksyk", Price = 90, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 3710, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Meksyk", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 3711, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Meksyk", Price = 139, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3712, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Meksyk", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 3713, AllSeats = 79, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Meksyk", Price = 103, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3714, AllSeats = 79, DateTime = DateTime.Parse("2022-07-20"), From = "Meksyk", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3715, AllSeats = 73, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Seszele", Price = 78, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3716, AllSeats = 73, DateTime = DateTime.Parse("2022-07-20"), From = "Seszele", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3717, AllSeats = 35, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Seszele", Price = 97, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 3718, AllSeats = 35, DateTime = DateTime.Parse("2022-07-20"), From = "Seszele", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 3719, AllSeats = 71, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Seszele", Price = 93, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 3720, AllSeats = 71, DateTime = DateTime.Parse("2022-07-20"), From = "Seszele", To = "Gdansk", Price = 106, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 3721, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Slowenia", Price = 50, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 3722, AllSeats = 26, DateTime = DateTime.Parse("2022-07-20"), From = "Slowenia", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 3723, AllSeats = 59, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 3724, AllSeats = 59, DateTime = DateTime.Parse("2022-07-20"), From = "Slowenia", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 3725, AllSeats = 64, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Slowenia", Price = 80, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 3726, AllSeats = 64, DateTime = DateTime.Parse("2022-07-20"), From = "Slowenia", To = "Gdansk", Price = 55, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 3727, AllSeats = 39, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Turcja", Price = 59, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3728, AllSeats = 39, DateTime = DateTime.Parse("2022-07-20"), From = "Turcja", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3729, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Turcja", Price = 137, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3730, AllSeats = 67, DateTime = DateTime.Parse("2022-07-20"), From = "Turcja", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 3731, AllSeats = 73, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Turcja", Price = 101, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 3732, AllSeats = 73, DateTime = DateTime.Parse("2022-07-20"), From = "Turcja", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 3733, AllSeats = 83, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 85, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3734, AllSeats = 83, DateTime = DateTime.Parse("2022-07-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 74, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3735, AllSeats = 83, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 95, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3736, AllSeats = 83, DateTime = DateTime.Parse("2022-07-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 50, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 3737, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 88, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 3738, AllSeats = 72, DateTime = DateTime.Parse("2022-07-20"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 72
},
new()
{
Id = 3739, AllSeats = 51, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Zanzibar", Price = 100, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 3740, AllSeats = 51, DateTime = DateTime.Parse("2022-07-20"), From = "Zanzibar", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 3741, AllSeats = 79, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Zanzibar", Price = 114, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3742, AllSeats = 79, DateTime = DateTime.Parse("2022-07-20"), From = "Zanzibar", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 79
},
new()
{
Id = 3743, AllSeats = 60, DateTime = DateTime.Parse("2022-07-20"), From = "Gdansk", To = "Zanzibar", Price = 63, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3744, AllSeats = 60, DateTime = DateTime.Parse("2022-07-20"), From = "Zanzibar", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3745, AllSeats = 35, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Albania", Price = 89, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3746, AllSeats = 35, DateTime = DateTime.Parse("2022-07-21"), From = "Albania", To = "Gdansk", Price = 61, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 3747, AllSeats = 80, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Albania", Price = 147, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3748, AllSeats = 80, DateTime = DateTime.Parse("2022-07-21"), From = "Albania", To = "Gdansk", Price = 115, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3749, AllSeats = 71, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Albania", Price = 122, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 3750, AllSeats = 71, DateTime = DateTime.Parse("2022-07-21"), From = "Albania", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 3751, AllSeats = 83, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Bulgaria", Price = 128, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3752, AllSeats = 83, DateTime = DateTime.Parse("2022-07-21"), From = "Bulgaria", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3753, AllSeats = 28, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 3754, AllSeats = 28, DateTime = DateTime.Parse("2022-07-21"), From = "Bulgaria", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 3755, AllSeats = 69, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Bulgaria", Price = 67, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3756, AllSeats = 69, DateTime = DateTime.Parse("2022-07-21"), From = "Bulgaria", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 69
},
new()
{
Id = 3757, AllSeats = 57, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Czarnogora", Price = 149, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3758, AllSeats = 57, DateTime = DateTime.Parse("2022-07-21"), From = "Czarnogora", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 3759, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Czarnogora", Price = 130, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3760, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Czarnogora", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3761, AllSeats = 40, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Czarnogora", Price = 67, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3762, AllSeats = 40, DateTime = DateTime.Parse("2022-07-21"), From = "Czarnogora", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 3763, AllSeats = 73, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Egipt", Price = 53, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3764, AllSeats = 73, DateTime = DateTime.Parse("2022-07-21"), From = "Egipt", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 3765, AllSeats = 87, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Egipt", Price = 135, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 3766, AllSeats = 87, DateTime = DateTime.Parse("2022-07-21"), From = "Egipt", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 3767, AllSeats = 55, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Egipt", Price = 55, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 3768, AllSeats = 55, DateTime = DateTime.Parse("2022-07-21"), From = "Egipt", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 3769, AllSeats = 30, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Grecja", Price = 118, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3770, AllSeats = 30, DateTime = DateTime.Parse("2022-07-21"), From = "Grecja", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 3771, AllSeats = 27, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Grecja", Price = 58, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 3772, AllSeats = 27, DateTime = DateTime.Parse("2022-07-21"), From = "Grecja", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 3773, AllSeats = 73, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Grecja", Price = 109, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 3774, AllSeats = 73, DateTime = DateTime.Parse("2022-07-21"), From = "Grecja", To = "Gdansk", Price = 124, Type = TransportType.Train, AvailableSeats = 73
},
new()
{
Id = 3775, AllSeats = 65, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Gruzja", Price = 105, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 3776, AllSeats = 65, DateTime = DateTime.Parse("2022-07-21"), From = "Gruzja", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 3777, AllSeats = 85, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Gruzja", Price = 134, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 3778, AllSeats = 85, DateTime = DateTime.Parse("2022-07-21"), From = "Gruzja", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 85
},
new()
{
Id = 3779, AllSeats = 87, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Gruzja", Price = 96, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3780, AllSeats = 87, DateTime = DateTime.Parse("2022-07-21"), From = "Gruzja", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3781, AllSeats = 61, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Madera", Price = 67, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3782, AllSeats = 61, DateTime = DateTime.Parse("2022-07-21"), From = "Madera", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3783, AllSeats = 89, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Madera", Price = 137, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 3784, AllSeats = 89, DateTime = DateTime.Parse("2022-07-21"), From = "Madera", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 3785, AllSeats = 98, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Madera", Price = 78, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3786, AllSeats = 98, DateTime = DateTime.Parse("2022-07-21"), From = "Madera", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 3787, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malediwy", Price = 125, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3788, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Malediwy", To = "Gdansk", Price = 101, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3789, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malediwy", Price = 132, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 3790, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Malediwy", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 3791, AllSeats = 39, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malediwy", Price = 135, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3792, AllSeats = 39, DateTime = DateTime.Parse("2022-07-21"), From = "Malediwy", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 3793, AllSeats = 54, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malta", Price = 102, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 3794, AllSeats = 54, DateTime = DateTime.Parse("2022-07-21"), From = "Malta", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 3795, AllSeats = 42, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malta", Price = 94, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3796, AllSeats = 42, DateTime = DateTime.Parse("2022-07-21"), From = "Malta", To = "Gdansk", Price = 91, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 3797, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Malta", Price = 126, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3798, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Malta", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 3799, AllSeats = 75, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Mauritius", Price = 126, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3800, AllSeats = 75, DateTime = DateTime.Parse("2022-07-21"), From = "Mauritius", To = "Gdansk", Price = 104, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3801, AllSeats = 68, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Mauritius", Price = 65, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3802, AllSeats = 68, DateTime = DateTime.Parse("2022-07-21"), From = "Mauritius", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3803, AllSeats = 92, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Mauritius", Price = 83, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3804, AllSeats = 92, DateTime = DateTime.Parse("2022-07-21"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3805, AllSeats = 93, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Meksyk", Price = 66, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3806, AllSeats = 93, DateTime = DateTime.Parse("2022-07-21"), From = "Meksyk", To = "Gdansk", Price = 53, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3807, AllSeats = 74, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Meksyk", Price = 96, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 3808, AllSeats = 74, DateTime = DateTime.Parse("2022-07-21"), From = "Meksyk", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 74
},
new()
{
Id = 3809, AllSeats = 60, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Meksyk", Price = 132, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3810, AllSeats = 60, DateTime = DateTime.Parse("2022-07-21"), From = "Meksyk", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3811, AllSeats = 81, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Seszele", Price = 149, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3812, AllSeats = 81, DateTime = DateTime.Parse("2022-07-21"), From = "Seszele", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 3813, AllSeats = 58, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Seszele", Price = 78, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3814, AllSeats = 58, DateTime = DateTime.Parse("2022-07-21"), From = "Seszele", To = "Gdansk", Price = 149, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3815, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Seszele", Price = 85, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 3816, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Seszele", To = "Gdansk", Price = 102, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 3817, AllSeats = 75, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Slowenia", Price = 106, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3818, AllSeats = 75, DateTime = DateTime.Parse("2022-07-21"), From = "Slowenia", To = "Gdansk", Price = 107, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 3819, AllSeats = 53, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Slowenia", Price = 113, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3820, AllSeats = 53, DateTime = DateTime.Parse("2022-07-21"), From = "Slowenia", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 3821, AllSeats = 79, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Slowenia", Price = 106, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3822, AllSeats = 79, DateTime = DateTime.Parse("2022-07-21"), From = "Slowenia", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3823, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Turcja", Price = 74, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3824, AllSeats = 41, DateTime = DateTime.Parse("2022-07-21"), From = "Turcja", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 3825, AllSeats = 32, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Turcja", Price = 144, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3826, AllSeats = 32, DateTime = DateTime.Parse("2022-07-21"), From = "Turcja", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3827, AllSeats = 70, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Turcja", Price = 137, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3828, AllSeats = 70, DateTime = DateTime.Parse("2022-07-21"), From = "Turcja", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3829, AllSeats = 98, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 150, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3830, AllSeats = 98, DateTime = DateTime.Parse("2022-07-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 55, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 3831, AllSeats = 94, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 128, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 3832, AllSeats = 94, DateTime = DateTime.Parse("2022-07-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 3833, AllSeats = 37, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 60, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 3834, AllSeats = 37, DateTime = DateTime.Parse("2022-07-21"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 3835, AllSeats = 49, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Zanzibar", Price = 131, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 3836, AllSeats = 49, DateTime = DateTime.Parse("2022-07-21"), From = "Zanzibar", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 49
},
new()
{
Id = 3837, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Zanzibar", Price = 101, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 3838, AllSeats = 34, DateTime = DateTime.Parse("2022-07-21"), From = "Zanzibar", To = "Gdansk", Price = 82, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 3839, AllSeats = 28, DateTime = DateTime.Parse("2022-07-21"), From = "Gdansk", To = "Zanzibar", Price = 94, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3840, AllSeats = 28, DateTime = DateTime.Parse("2022-07-21"), From = "Zanzibar", To = "Gdansk", Price = 66, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 3841, AllSeats = 88, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Albania", Price = 147, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 3842, AllSeats = 88, DateTime = DateTime.Parse("2022-07-22"), From = "Albania", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 3843, AllSeats = 68, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Albania", Price = 63, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3844, AllSeats = 68, DateTime = DateTime.Parse("2022-07-22"), From = "Albania", To = "Gdansk", Price = 118, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3845, AllSeats = 87, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Albania", Price = 55, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3846, AllSeats = 87, DateTime = DateTime.Parse("2022-07-22"), From = "Albania", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 3847, AllSeats = 61, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Bulgaria", Price = 71, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3848, AllSeats = 61, DateTime = DateTime.Parse("2022-07-22"), From = "Bulgaria", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 3849, AllSeats = 65, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Bulgaria", Price = 78, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 3850, AllSeats = 65, DateTime = DateTime.Parse("2022-07-22"), From = "Bulgaria", To = "Gdansk", Price = 99, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 3851, AllSeats = 70, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Bulgaria", Price = 88, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3852, AllSeats = 70, DateTime = DateTime.Parse("2022-07-22"), From = "Bulgaria", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3853, AllSeats = 74, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Czarnogora", Price = 87, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3854, AllSeats = 74, DateTime = DateTime.Parse("2022-07-22"), From = "Czarnogora", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 3855, AllSeats = 95, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Czarnogora", Price = 113, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 3856, AllSeats = 95, DateTime = DateTime.Parse("2022-07-22"), From = "Czarnogora", To = "Gdansk", Price = 114, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 3857, AllSeats = 83, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Czarnogora", Price = 121, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 3858, AllSeats = 83, DateTime = DateTime.Parse("2022-07-22"), From = "Czarnogora", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 3859, AllSeats = 27, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Egipt", Price = 142, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 3860, AllSeats = 27, DateTime = DateTime.Parse("2022-07-22"), From = "Egipt", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 3861, AllSeats = 89, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Egipt", Price = 141, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 3862, AllSeats = 89, DateTime = DateTime.Parse("2022-07-22"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 3863, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Egipt", Price = 124, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3864, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Egipt", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 3865, AllSeats = 32, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Grecja", Price = 108, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3866, AllSeats = 32, DateTime = DateTime.Parse("2022-07-22"), From = "Grecja", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3867, AllSeats = 32, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Grecja", Price = 77, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3868, AllSeats = 32, DateTime = DateTime.Parse("2022-07-22"), From = "Grecja", To = "Gdansk", Price = 108, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 3869, AllSeats = 74, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Grecja", Price = 90, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 3870, AllSeats = 74, DateTime = DateTime.Parse("2022-07-22"), From = "Grecja", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 3871, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Gruzja", Price = 53, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 3872, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Gruzja", To = "Gdansk", Price = 149, Type = TransportType.Bus, AvailableSeats = 60
},
new()
{
Id = 3873, AllSeats = 49, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Gruzja", Price = 125, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3874, AllSeats = 49, DateTime = DateTime.Parse("2022-07-22"), From = "Gruzja", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 49
},
new()
{
Id = 3875, AllSeats = 53, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Gruzja", Price = 129, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3876, AllSeats = 53, DateTime = DateTime.Parse("2022-07-22"), From = "Gruzja", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 53
},
new()
{
Id = 3877, AllSeats = 39, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Madera", Price = 137, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3878, AllSeats = 39, DateTime = DateTime.Parse("2022-07-22"), From = "Madera", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3879, AllSeats = 41, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Madera", Price = 73, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3880, AllSeats = 41, DateTime = DateTime.Parse("2022-07-22"), From = "Madera", To = "Gdansk", Price = 113, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 3881, AllSeats = 92, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Madera", Price = 128, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3882, AllSeats = 92, DateTime = DateTime.Parse("2022-07-22"), From = "Madera", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 3883, AllSeats = 90, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malediwy", Price = 102, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 3884, AllSeats = 90, DateTime = DateTime.Parse("2022-07-22"), From = "Malediwy", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 3885, AllSeats = 55, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3886, AllSeats = 55, DateTime = DateTime.Parse("2022-07-22"), From = "Malediwy", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3887, AllSeats = 44, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malediwy", Price = 81, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3888, AllSeats = 44, DateTime = DateTime.Parse("2022-07-22"), From = "Malediwy", To = "Gdansk", Price = 122, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3889, AllSeats = 59, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malta", Price = 66, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3890, AllSeats = 59, DateTime = DateTime.Parse("2022-07-22"), From = "Malta", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 3891, AllSeats = 68, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malta", Price = 56, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3892, AllSeats = 68, DateTime = DateTime.Parse("2022-07-22"), From = "Malta", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 3893, AllSeats = 76, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Malta", Price = 111, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3894, AllSeats = 76, DateTime = DateTime.Parse("2022-07-22"), From = "Malta", To = "Gdansk", Price = 107, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3895, AllSeats = 94, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Mauritius", Price = 52, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3896, AllSeats = 94, DateTime = DateTime.Parse("2022-07-22"), From = "Mauritius", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 3897, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Mauritius", Price = 129, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3898, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Mauritius", To = "Gdansk", Price = 64, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3899, AllSeats = 85, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Mauritius", Price = 140, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 3900, AllSeats = 85, DateTime = DateTime.Parse("2022-07-22"), From = "Mauritius", To = "Gdansk", Price = 128, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 3901, AllSeats = 39, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Meksyk", Price = 131, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3902, AllSeats = 39, DateTime = DateTime.Parse("2022-07-22"), From = "Meksyk", To = "Gdansk", Price = 117, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3903, AllSeats = 55, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Meksyk", Price = 68, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3904, AllSeats = 55, DateTime = DateTime.Parse("2022-07-22"), From = "Meksyk", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3905, AllSeats = 79, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Meksyk", Price = 112, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3906, AllSeats = 79, DateTime = DateTime.Parse("2022-07-22"), From = "Meksyk", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 3907, AllSeats = 52, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Seszele", Price = 63, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3908, AllSeats = 52, DateTime = DateTime.Parse("2022-07-22"), From = "Seszele", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3909, AllSeats = 56, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Seszele", Price = 56, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3910, AllSeats = 56, DateTime = DateTime.Parse("2022-07-22"), From = "Seszele", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 3911, AllSeats = 59, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Seszele", Price = 83, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3912, AllSeats = 59, DateTime = DateTime.Parse("2022-07-22"), From = "Seszele", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 3913, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Slowenia", Price = 80, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3914, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Slowenia", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3915, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Slowenia", Price = 118, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3916, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Slowenia", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3917, AllSeats = 76, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Slowenia", Price = 116, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3918, AllSeats = 76, DateTime = DateTime.Parse("2022-07-22"), From = "Slowenia", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 3919, AllSeats = 93, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3920, AllSeats = 93, DateTime = DateTime.Parse("2022-07-22"), From = "Turcja", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 3921, AllSeats = 48, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Turcja", Price = 70, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3922, AllSeats = 48, DateTime = DateTime.Parse("2022-07-22"), From = "Turcja", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 3923, AllSeats = 83, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Turcja", Price = 73, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 3924, AllSeats = 83, DateTime = DateTime.Parse("2022-07-22"), From = "Turcja", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 3925, AllSeats = 45, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 118, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3926, AllSeats = 45, DateTime = DateTime.Parse("2022-07-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 54, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 3927, AllSeats = 27, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 102, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 3928, AllSeats = 27, DateTime = DateTime.Parse("2022-07-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 27
},
new()
{
Id = 3929, AllSeats = 44, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 135, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3930, AllSeats = 44, DateTime = DateTime.Parse("2022-07-22"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 135, Type = TransportType.Train, AvailableSeats = 44
},
new()
{
Id = 3931, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Zanzibar", Price = 129, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3932, AllSeats = 33, DateTime = DateTime.Parse("2022-07-22"), From = "Zanzibar", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 33
},
new()
{
Id = 3933, AllSeats = 86, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Zanzibar", Price = 72, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3934, AllSeats = 86, DateTime = DateTime.Parse("2022-07-22"), From = "Zanzibar", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 3935, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Gdansk", To = "Zanzibar", Price = 114, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3936, AllSeats = 60, DateTime = DateTime.Parse("2022-07-22"), From = "Zanzibar", To = "Gdansk", Price = 65, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3937, AllSeats = 90, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Albania", Price = 146, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 3938, AllSeats = 90, DateTime = DateTime.Parse("2022-07-23"), From = "Albania", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 3939, AllSeats = 31, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Albania", Price = 81, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 3940, AllSeats = 31, DateTime = DateTime.Parse("2022-07-23"), From = "Albania", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 3941, AllSeats = 62, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Albania", Price = 135, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3942, AllSeats = 62, DateTime = DateTime.Parse("2022-07-23"), From = "Albania", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 3943, AllSeats = 83, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Bulgaria", Price = 76, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3944, AllSeats = 83, DateTime = DateTime.Parse("2022-07-23"), From = "Bulgaria", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 3945, AllSeats = 58, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Bulgaria", Price = 147, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3946, AllSeats = 58, DateTime = DateTime.Parse("2022-07-23"), From = "Bulgaria", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 3947, AllSeats = 50, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Bulgaria", Price = 129, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3948, AllSeats = 50, DateTime = DateTime.Parse("2022-07-23"), From = "Bulgaria", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 50
},
new()
{
Id = 3949, AllSeats = 39, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Czarnogora", Price = 83, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3950, AllSeats = 39, DateTime = DateTime.Parse("2022-07-23"), From = "Czarnogora", To = "Gdansk", Price = 92, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 3951, AllSeats = 80, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Czarnogora", Price = 50, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3952, AllSeats = 80, DateTime = DateTime.Parse("2022-07-23"), From = "Czarnogora", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 3953, AllSeats = 84, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Czarnogora", Price = 147, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 3954, AllSeats = 84, DateTime = DateTime.Parse("2022-07-23"), From = "Czarnogora", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 3955, AllSeats = 29, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Egipt", Price = 75, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3956, AllSeats = 29, DateTime = DateTime.Parse("2022-07-23"), From = "Egipt", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3957, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Egipt", Price = 52, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 3958, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Plane, AvailableSeats = 99
},
new()
{
Id = 3959, AllSeats = 54, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Egipt", Price = 94, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 3960, AllSeats = 54, DateTime = DateTime.Parse("2022-07-23"), From = "Egipt", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 3961, AllSeats = 29, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Grecja", Price = 98, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3962, AllSeats = 29, DateTime = DateTime.Parse("2022-07-23"), From = "Grecja", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 3963, AllSeats = 55, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Grecja", Price = 88, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3964, AllSeats = 55, DateTime = DateTime.Parse("2022-07-23"), From = "Grecja", To = "Gdansk", Price = 85, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 3965, AllSeats = 70, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Grecja", Price = 65, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3966, AllSeats = 70, DateTime = DateTime.Parse("2022-07-23"), From = "Grecja", To = "Gdansk", Price = 85, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 3967, AllSeats = 68, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Gruzja", Price = 70, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 3968, AllSeats = 68, DateTime = DateTime.Parse("2022-07-23"), From = "Gruzja", To = "Gdansk", Price = 132, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 3969, AllSeats = 60, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Gruzja", Price = 132, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3970, AllSeats = 60, DateTime = DateTime.Parse("2022-07-23"), From = "Gruzja", To = "Gdansk", Price = 103, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 3971, AllSeats = 60, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Gruzja", Price = 98, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3972, AllSeats = 60, DateTime = DateTime.Parse("2022-07-23"), From = "Gruzja", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 3973, AllSeats = 28, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Madera", Price = 91, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 3974, AllSeats = 28, DateTime = DateTime.Parse("2022-07-23"), From = "Madera", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 3975, AllSeats = 97, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Madera", Price = 119, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 3976, AllSeats = 97, DateTime = DateTime.Parse("2022-07-23"), From = "Madera", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 3977, AllSeats = 74, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Madera", Price = 81, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 3978, AllSeats = 74, DateTime = DateTime.Parse("2022-07-23"), From = "Madera", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 3979, AllSeats = 32, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malediwy", Price = 143, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3980, AllSeats = 32, DateTime = DateTime.Parse("2022-07-23"), From = "Malediwy", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 3981, AllSeats = 92, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malediwy", Price = 145, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 3982, AllSeats = 92, DateTime = DateTime.Parse("2022-07-23"), From = "Malediwy", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 3983, AllSeats = 54, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malediwy", Price = 78, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 3984, AllSeats = 54, DateTime = DateTime.Parse("2022-07-23"), From = "Malediwy", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 3985, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malta", Price = 97, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3986, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Malta", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 3987, AllSeats = 51, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malta", Price = 124, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3988, AllSeats = 51, DateTime = DateTime.Parse("2022-07-23"), From = "Malta", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 3989, AllSeats = 78, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Malta", Price = 105, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3990, AllSeats = 78, DateTime = DateTime.Parse("2022-07-23"), From = "Malta", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 78
},
new()
{
Id = 3991, AllSeats = 36, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Mauritius", Price = 50, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 3992, AllSeats = 36, DateTime = DateTime.Parse("2022-07-23"), From = "Mauritius", To = "Gdansk", Price = 143, Type = TransportType.Bus, AvailableSeats = 36
},
new()
{
Id = 3993, AllSeats = 25, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Mauritius", Price = 54, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 3994, AllSeats = 25, DateTime = DateTime.Parse("2022-07-23"), From = "Mauritius", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 3995, AllSeats = 30, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Mauritius", Price = 98, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 3996, AllSeats = 30, DateTime = DateTime.Parse("2022-07-23"), From = "Mauritius", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 3997, AllSeats = 52, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Meksyk", Price = 114, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3998, AllSeats = 52, DateTime = DateTime.Parse("2022-07-23"), From = "Meksyk", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 3999, AllSeats = 58, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Meksyk", Price = 59, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 4000, AllSeats = 58, DateTime = DateTime.Parse("2022-07-23"), From = "Meksyk", To = "Gdansk", Price = 84, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 4001, AllSeats = 33, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Meksyk", Price = 69, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 4002, AllSeats = 33, DateTime = DateTime.Parse("2022-07-23"), From = "Meksyk", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 33
},
new()
{
Id = 4003, AllSeats = 97, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Seszele", Price = 76, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4004, AllSeats = 97, DateTime = DateTime.Parse("2022-07-23"), From = "Seszele", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4005, AllSeats = 47, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Seszele", Price = 95, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4006, AllSeats = 47, DateTime = DateTime.Parse("2022-07-23"), From = "Seszele", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4007, AllSeats = 85, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Seszele", Price = 129, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 4008, AllSeats = 85, DateTime = DateTime.Parse("2022-07-23"), From = "Seszele", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 85
},
new()
{
Id = 4009, AllSeats = 40, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Slowenia", Price = 104, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4010, AllSeats = 40, DateTime = DateTime.Parse("2022-07-23"), From = "Slowenia", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4011, AllSeats = 35, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4012, AllSeats = 35, DateTime = DateTime.Parse("2022-07-23"), From = "Slowenia", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4013, AllSeats = 87, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Slowenia", Price = 105, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4014, AllSeats = 87, DateTime = DateTime.Parse("2022-07-23"), From = "Slowenia", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4015, AllSeats = 90, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Turcja", Price = 134, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4016, AllSeats = 90, DateTime = DateTime.Parse("2022-07-23"), From = "Turcja", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4017, AllSeats = 39, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Turcja", Price = 112, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 4018, AllSeats = 39, DateTime = DateTime.Parse("2022-07-23"), From = "Turcja", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 4019, AllSeats = 41, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Turcja", Price = 80, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4020, AllSeats = 41, DateTime = DateTime.Parse("2022-07-23"), From = "Turcja", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4021, AllSeats = 62, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 61, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 4022, AllSeats = 62, DateTime = DateTime.Parse("2022-07-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 4023, AllSeats = 88, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 86, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 4024, AllSeats = 88, DateTime = DateTime.Parse("2022-07-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 100, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 4025, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 96, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4026, AllSeats = 99, DateTime = DateTime.Parse("2022-07-23"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4027, AllSeats = 30, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Zanzibar", Price = 106, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4028, AllSeats = 30, DateTime = DateTime.Parse("2022-07-23"), From = "Zanzibar", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4029, AllSeats = 92, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Zanzibar", Price = 57, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4030, AllSeats = 92, DateTime = DateTime.Parse("2022-07-23"), From = "Zanzibar", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4031, AllSeats = 77, DateTime = DateTime.Parse("2022-07-23"), From = "Gdansk", To = "Zanzibar", Price = 102, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4032, AllSeats = 77, DateTime = DateTime.Parse("2022-07-23"), From = "Zanzibar", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4033, AllSeats = 54, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Albania", Price = 127, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 4034, AllSeats = 54, DateTime = DateTime.Parse("2022-07-24"), From = "Albania", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 4035, AllSeats = 73, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Albania", Price = 108, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4036, AllSeats = 73, DateTime = DateTime.Parse("2022-07-24"), From = "Albania", To = "Gdansk", Price = 88, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4037, AllSeats = 28, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Albania", Price = 109, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4038, AllSeats = 28, DateTime = DateTime.Parse("2022-07-24"), From = "Albania", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4039, AllSeats = 76, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Bulgaria", Price = 75, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 4040, AllSeats = 76, DateTime = DateTime.Parse("2022-07-24"), From = "Bulgaria", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 76
},
new()
{
Id = 4041, AllSeats = 92, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Bulgaria", Price = 141, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4042, AllSeats = 92, DateTime = DateTime.Parse("2022-07-24"), From = "Bulgaria", To = "Gdansk", Price = 102, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4043, AllSeats = 92, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Bulgaria", Price = 102, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 4044, AllSeats = 92, DateTime = DateTime.Parse("2022-07-24"), From = "Bulgaria", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 92
},
new()
{
Id = 4045, AllSeats = 48, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Czarnogora", Price = 77, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 4046, AllSeats = 48, DateTime = DateTime.Parse("2022-07-24"), From = "Czarnogora", To = "Gdansk", Price = 108, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 4047, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Czarnogora", Price = 87, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4048, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Czarnogora", To = "Gdansk", Price = 107, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4049, AllSeats = 49, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Czarnogora", Price = 72, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4050, AllSeats = 49, DateTime = DateTime.Parse("2022-07-24"), From = "Czarnogora", To = "Gdansk", Price = 84, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4051, AllSeats = 94, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Egipt", Price = 58, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 4052, AllSeats = 94, DateTime = DateTime.Parse("2022-07-24"), From = "Egipt", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 4053, AllSeats = 98, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Egipt", Price = 147, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4054, AllSeats = 98, DateTime = DateTime.Parse("2022-07-24"), From = "Egipt", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4055, AllSeats = 79, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Egipt", Price = 67, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4056, AllSeats = 79, DateTime = DateTime.Parse("2022-07-24"), From = "Egipt", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4057, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Grecja", Price = 138, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4058, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Grecja", To = "Gdansk", Price = 80, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4059, AllSeats = 67, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Grecja", Price = 141, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 4060, AllSeats = 67, DateTime = DateTime.Parse("2022-07-24"), From = "Grecja", To = "Gdansk", Price = 51, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 4061, AllSeats = 45, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Grecja", Price = 72, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 4062, AllSeats = 45, DateTime = DateTime.Parse("2022-07-24"), From = "Grecja", To = "Gdansk", Price = 132, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 4063, AllSeats = 58, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Gruzja", Price = 65, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 4064, AllSeats = 58, DateTime = DateTime.Parse("2022-07-24"), From = "Gruzja", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 4065, AllSeats = 40, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Gruzja", Price = 65, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4066, AllSeats = 40, DateTime = DateTime.Parse("2022-07-24"), From = "Gruzja", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4067, AllSeats = 99, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Gruzja", Price = 125, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4068, AllSeats = 99, DateTime = DateTime.Parse("2022-07-24"), From = "Gruzja", To = "Gdansk", Price = 60, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4069, AllSeats = 57, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Madera", Price = 103, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 4070, AllSeats = 57, DateTime = DateTime.Parse("2022-07-24"), From = "Madera", To = "Gdansk", Price = 129, Type = TransportType.Bus, AvailableSeats = 57
},
new()
{
Id = 4071, AllSeats = 65, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Madera", Price = 119, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 4072, AllSeats = 65, DateTime = DateTime.Parse("2022-07-24"), From = "Madera", To = "Gdansk", Price = 76, Type = TransportType.Plane, AvailableSeats = 65
},
new()
{
Id = 4073, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Madera", Price = 143, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4074, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Madera", To = "Gdansk", Price = 141, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4075, AllSeats = 45, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malediwy", Price = 138, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 4076, AllSeats = 45, DateTime = DateTime.Parse("2022-07-24"), From = "Malediwy", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 45
},
new()
{
Id = 4077, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malediwy", Price = 94, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4078, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Malediwy", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4079, AllSeats = 34, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 4080, AllSeats = 34, DateTime = DateTime.Parse("2022-07-24"), From = "Malediwy", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 4081, AllSeats = 26, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malta", Price = 140, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 4082, AllSeats = 26, DateTime = DateTime.Parse("2022-07-24"), From = "Malta", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 4083, AllSeats = 28, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malta", Price = 75, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 4084, AllSeats = 28, DateTime = DateTime.Parse("2022-07-24"), From = "Malta", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 4085, AllSeats = 54, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Malta", Price = 85, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 4086, AllSeats = 54, DateTime = DateTime.Parse("2022-07-24"), From = "Malta", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 4087, AllSeats = 94, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Mauritius", Price = 150, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 4088, AllSeats = 94, DateTime = DateTime.Parse("2022-07-24"), From = "Mauritius", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 94
},
new()
{
Id = 4089, AllSeats = 25, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Mauritius", Price = 65, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 4090, AllSeats = 25, DateTime = DateTime.Parse("2022-07-24"), From = "Mauritius", To = "Gdansk", Price = 82, Type = TransportType.Plane, AvailableSeats = 25
},
new()
{
Id = 4091, AllSeats = 66, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Mauritius", Price = 77, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 4092, AllSeats = 66, DateTime = DateTime.Parse("2022-07-24"), From = "Mauritius", To = "Gdansk", Price = 136, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 4093, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Meksyk", Price = 88, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 4094, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Meksyk", To = "Gdansk", Price = 106, Type = TransportType.Bus, AvailableSeats = 75
},
new()
{
Id = 4095, AllSeats = 47, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Meksyk", Price = 95, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4096, AllSeats = 47, DateTime = DateTime.Parse("2022-07-24"), From = "Meksyk", To = "Gdansk", Price = 92, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4097, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Meksyk", Price = 139, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4098, AllSeats = 41, DateTime = DateTime.Parse("2022-07-24"), From = "Meksyk", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4099, AllSeats = 65, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Seszele", Price = 128, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 4100, AllSeats = 65, DateTime = DateTime.Parse("2022-07-24"), From = "Seszele", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 4101, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Seszele", Price = 88, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4102, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Seszele", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4103, AllSeats = 38, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Seszele", Price = 71, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 4104, AllSeats = 38, DateTime = DateTime.Parse("2022-07-24"), From = "Seszele", To = "Gdansk", Price = 140, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 4105, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Slowenia", Price = 82, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4106, AllSeats = 87, DateTime = DateTime.Parse("2022-07-24"), From = "Slowenia", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4107, AllSeats = 93, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Slowenia", Price = 120, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 4108, AllSeats = 93, DateTime = DateTime.Parse("2022-07-24"), From = "Slowenia", To = "Gdansk", Price = 95, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 4109, AllSeats = 90, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Slowenia", Price = 102, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4110, AllSeats = 90, DateTime = DateTime.Parse("2022-07-24"), From = "Slowenia", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4111, AllSeats = 89, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Turcja", Price = 131, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 4112, AllSeats = 89, DateTime = DateTime.Parse("2022-07-24"), From = "Turcja", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 89
},
new()
{
Id = 4113, AllSeats = 80, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Turcja", Price = 92, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 4114, AllSeats = 80, DateTime = DateTime.Parse("2022-07-24"), From = "Turcja", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 4115, AllSeats = 55, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Turcja", Price = 76, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4116, AllSeats = 55, DateTime = DateTime.Parse("2022-07-24"), From = "Turcja", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4117, AllSeats = 82, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 71, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4118, AllSeats = 82, DateTime = DateTime.Parse("2022-07-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4119, AllSeats = 72, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 139, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4120, AllSeats = 72, DateTime = DateTime.Parse("2022-07-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4121, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 121, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4122, AllSeats = 75, DateTime = DateTime.Parse("2022-07-24"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 117, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4123, AllSeats = 61, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Zanzibar", Price = 105, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4124, AllSeats = 61, DateTime = DateTime.Parse("2022-07-24"), From = "Zanzibar", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4125, AllSeats = 89, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Zanzibar", Price = 117, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 4126, AllSeats = 89, DateTime = DateTime.Parse("2022-07-24"), From = "Zanzibar", To = "Gdansk", Price = 95, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 4127, AllSeats = 32, DateTime = DateTime.Parse("2022-07-24"), From = "Gdansk", To = "Zanzibar", Price = 99, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 4128, AllSeats = 32, DateTime = DateTime.Parse("2022-07-24"), From = "Zanzibar", To = "Gdansk", Price = 142, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 4129, AllSeats = 41, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Albania", Price = 59, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4130, AllSeats = 41, DateTime = DateTime.Parse("2022-07-25"), From = "Albania", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4131, AllSeats = 67, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Albania", Price = 130, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 4132, AllSeats = 67, DateTime = DateTime.Parse("2022-07-25"), From = "Albania", To = "Gdansk", Price = 52, Type = TransportType.Plane, AvailableSeats = 67
},
new()
{
Id = 4133, AllSeats = 38, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Albania", Price = 60, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 4134, AllSeats = 38, DateTime = DateTime.Parse("2022-07-25"), From = "Albania", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 38
},
new()
{
Id = 4135, AllSeats = 93, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Bulgaria", Price = 117, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 4136, AllSeats = 93, DateTime = DateTime.Parse("2022-07-25"), From = "Bulgaria", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 93
},
new()
{
Id = 4137, AllSeats = 81, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Bulgaria", Price = 70, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 4138, AllSeats = 81, DateTime = DateTime.Parse("2022-07-25"), From = "Bulgaria", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 81
},
new()
{
Id = 4139, AllSeats = 29, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Bulgaria", Price = 113, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4140, AllSeats = 29, DateTime = DateTime.Parse("2022-07-25"), From = "Bulgaria", To = "Gdansk", Price = 53, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4141, AllSeats = 90, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Czarnogora", Price = 102, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4142, AllSeats = 90, DateTime = DateTime.Parse("2022-07-25"), From = "Czarnogora", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4143, AllSeats = 30, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Czarnogora", Price = 146, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 4144, AllSeats = 30, DateTime = DateTime.Parse("2022-07-25"), From = "Czarnogora", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 4145, AllSeats = 81, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Czarnogora", Price = 68, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 4146, AllSeats = 81, DateTime = DateTime.Parse("2022-07-25"), From = "Czarnogora", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 81
},
new()
{
Id = 4147, AllSeats = 28, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Egipt", Price = 99, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 4148, AllSeats = 28, DateTime = DateTime.Parse("2022-07-25"), From = "Egipt", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 4149, AllSeats = 92, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Egipt", Price = 65, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4150, AllSeats = 92, DateTime = DateTime.Parse("2022-07-25"), From = "Egipt", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4151, AllSeats = 32, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Egipt", Price = 66, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 4152, AllSeats = 32, DateTime = DateTime.Parse("2022-07-25"), From = "Egipt", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 32
},
new()
{
Id = 4153, AllSeats = 82, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Grecja", Price = 78, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4154, AllSeats = 82, DateTime = DateTime.Parse("2022-07-25"), From = "Grecja", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4155, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Grecja", Price = 91, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4156, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Grecja", To = "Gdansk", Price = 74, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4157, AllSeats = 31, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Grecja", Price = 60, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4158, AllSeats = 31, DateTime = DateTime.Parse("2022-07-25"), From = "Grecja", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4159, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Gruzja", Price = 119, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4160, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Gruzja", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4161, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Gruzja", Price = 90, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4162, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Gruzja", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4163, AllSeats = 80, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Gruzja", Price = 84, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 4164, AllSeats = 80, DateTime = DateTime.Parse("2022-07-25"), From = "Gruzja", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 4165, AllSeats = 42, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Madera", Price = 69, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 4166, AllSeats = 42, DateTime = DateTime.Parse("2022-07-25"), From = "Madera", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 42
},
new()
{
Id = 4167, AllSeats = 55, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Madera", Price = 83, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4168, AllSeats = 55, DateTime = DateTime.Parse("2022-07-25"), From = "Madera", To = "Gdansk", Price = 101, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4169, AllSeats = 48, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Madera", Price = 143, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 4170, AllSeats = 48, DateTime = DateTime.Parse("2022-07-25"), From = "Madera", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 4171, AllSeats = 38, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malediwy", Price = 141, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 4172, AllSeats = 38, DateTime = DateTime.Parse("2022-07-25"), From = "Malediwy", To = "Gdansk", Price = 57, Type = TransportType.Bus, AvailableSeats = 38
},
new()
{
Id = 4173, AllSeats = 50, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malediwy", Price = 89, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4174, AllSeats = 50, DateTime = DateTime.Parse("2022-07-25"), From = "Malediwy", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4175, AllSeats = 27, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malediwy", Price = 70, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 4176, AllSeats = 27, DateTime = DateTime.Parse("2022-07-25"), From = "Malediwy", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 4177, AllSeats = 85, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malta", Price = 80, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 4178, AllSeats = 85, DateTime = DateTime.Parse("2022-07-25"), From = "Malta", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 85
},
new()
{
Id = 4179, AllSeats = 51, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malta", Price = 113, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 4180, AllSeats = 51, DateTime = DateTime.Parse("2022-07-25"), From = "Malta", To = "Gdansk", Price = 146, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 4181, AllSeats = 49, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Malta", Price = 113, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4182, AllSeats = 49, DateTime = DateTime.Parse("2022-07-25"), From = "Malta", To = "Gdansk", Price = 93, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4183, AllSeats = 30, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Mauritius", Price = 113, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4184, AllSeats = 30, DateTime = DateTime.Parse("2022-07-25"), From = "Mauritius", To = "Gdansk", Price = 130, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4185, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Mauritius", Price = 71, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4186, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Mauritius", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4187, AllSeats = 91, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Mauritius", Price = 86, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 4188, AllSeats = 91, DateTime = DateTime.Parse("2022-07-25"), From = "Mauritius", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 4189, AllSeats = 51, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Meksyk", Price = 107, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4190, AllSeats = 51, DateTime = DateTime.Parse("2022-07-25"), From = "Meksyk", To = "Gdansk", Price = 104, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4191, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Meksyk", Price = 97, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4192, AllSeats = 98, DateTime = DateTime.Parse("2022-07-25"), From = "Meksyk", To = "Gdansk", Price = 67, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4193, AllSeats = 41, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Meksyk", Price = 75, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4194, AllSeats = 41, DateTime = DateTime.Parse("2022-07-25"), From = "Meksyk", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4195, AllSeats = 34, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Seszele", Price = 62, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 4196, AllSeats = 34, DateTime = DateTime.Parse("2022-07-25"), From = "Seszele", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 4197, AllSeats = 95, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Seszele", Price = 139, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 4198, AllSeats = 95, DateTime = DateTime.Parse("2022-07-25"), From = "Seszele", To = "Gdansk", Price = 134, Type = TransportType.Plane, AvailableSeats = 95
},
new()
{
Id = 4199, AllSeats = 36, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Seszele", Price = 130, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4200, AllSeats = 36, DateTime = DateTime.Parse("2022-07-25"), From = "Seszele", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4201, AllSeats = 63, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Slowenia", Price = 109, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 4202, AllSeats = 63, DateTime = DateTime.Parse("2022-07-25"), From = "Slowenia", To = "Gdansk", Price = 131, Type = TransportType.Bus, AvailableSeats = 63
},
new()
{
Id = 4203, AllSeats = 29, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Slowenia", Price = 63, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 4204, AllSeats = 29, DateTime = DateTime.Parse("2022-07-25"), From = "Slowenia", To = "Gdansk", Price = 126, Type = TransportType.Plane, AvailableSeats = 29
},
new()
{
Id = 4205, AllSeats = 84, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Slowenia", Price = 61, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 4206, AllSeats = 84, DateTime = DateTime.Parse("2022-07-25"), From = "Slowenia", To = "Gdansk", Price = 147, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 4207, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 4208, AllSeats = 69, DateTime = DateTime.Parse("2022-07-25"), From = "Turcja", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 4209, AllSeats = 48, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Turcja", Price = 106, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4210, AllSeats = 48, DateTime = DateTime.Parse("2022-07-25"), From = "Turcja", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4211, AllSeats = 57, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Turcja", Price = 145, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 4212, AllSeats = 57, DateTime = DateTime.Parse("2022-07-25"), From = "Turcja", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 4213, AllSeats = 86, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 131, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4214, AllSeats = 86, DateTime = DateTime.Parse("2022-07-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 94, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4215, AllSeats = 54, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 134, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 4216, AllSeats = 54, DateTime = DateTime.Parse("2022-07-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 143, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 4217, AllSeats = 87, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 54, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4218, AllSeats = 87, DateTime = DateTime.Parse("2022-07-25"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 87
},
new()
{
Id = 4219, AllSeats = 100, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Zanzibar", Price = 58, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4220, AllSeats = 100, DateTime = DateTime.Parse("2022-07-25"), From = "Zanzibar", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4221, AllSeats = 26, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Zanzibar", Price = 70, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4222, AllSeats = 26, DateTime = DateTime.Parse("2022-07-25"), From = "Zanzibar", To = "Gdansk", Price = 93, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4223, AllSeats = 68, DateTime = DateTime.Parse("2022-07-25"), From = "Gdansk", To = "Zanzibar", Price = 130, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4224, AllSeats = 68, DateTime = DateTime.Parse("2022-07-25"), From = "Zanzibar", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4225, AllSeats = 100, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Albania", Price = 112, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4226, AllSeats = 100, DateTime = DateTime.Parse("2022-07-26"), From = "Albania", To = "Gdansk", Price = 79, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4227, AllSeats = 59, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Albania", Price = 109, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 4228, AllSeats = 59, DateTime = DateTime.Parse("2022-07-26"), From = "Albania", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 59
},
new()
{
Id = 4229, AllSeats = 96, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Albania", Price = 64, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4230, AllSeats = 96, DateTime = DateTime.Parse("2022-07-26"), From = "Albania", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4231, AllSeats = 68, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Bulgaria", Price = 147, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 4232, AllSeats = 68, DateTime = DateTime.Parse("2022-07-26"), From = "Bulgaria", To = "Gdansk", Price = 125, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 4233, AllSeats = 91, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Bulgaria", Price = 150, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 4234, AllSeats = 91, DateTime = DateTime.Parse("2022-07-26"), From = "Bulgaria", To = "Gdansk", Price = 54, Type = TransportType.Plane, AvailableSeats = 91
},
new()
{
Id = 4235, AllSeats = 91, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Bulgaria", Price = 69, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 4236, AllSeats = 91, DateTime = DateTime.Parse("2022-07-26"), From = "Bulgaria", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 91
},
new()
{
Id = 4237, AllSeats = 27, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Czarnogora", Price = 78, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 4238, AllSeats = 27, DateTime = DateTime.Parse("2022-07-26"), From = "Czarnogora", To = "Gdansk", Price = 140, Type = TransportType.Bus, AvailableSeats = 27
},
new()
{
Id = 4239, AllSeats = 43, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Czarnogora", Price = 67, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 4240, AllSeats = 43, DateTime = DateTime.Parse("2022-07-26"), From = "Czarnogora", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 43
},
new()
{
Id = 4241, AllSeats = 98, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Czarnogora", Price = 125, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 4242, AllSeats = 98, DateTime = DateTime.Parse("2022-07-26"), From = "Czarnogora", To = "Gdansk", Price = 96, Type = TransportType.Train, AvailableSeats = 98
},
new()
{
Id = 4243, AllSeats = 95, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Egipt", Price = 120, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4244, AllSeats = 95, DateTime = DateTime.Parse("2022-07-26"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4245, AllSeats = 72, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Egipt", Price = 71, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4246, AllSeats = 72, DateTime = DateTime.Parse("2022-07-26"), From = "Egipt", To = "Gdansk", Price = 132, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4247, AllSeats = 82, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Egipt", Price = 69, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 4248, AllSeats = 82, DateTime = DateTime.Parse("2022-07-26"), From = "Egipt", To = "Gdansk", Price = 101, Type = TransportType.Train, AvailableSeats = 82
},
new()
{
Id = 4249, AllSeats = 90, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Grecja", Price = 91, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4250, AllSeats = 90, DateTime = DateTime.Parse("2022-07-26"), From = "Grecja", To = "Gdansk", Price = 81, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4251, AllSeats = 53, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Grecja", Price = 87, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4252, AllSeats = 53, DateTime = DateTime.Parse("2022-07-26"), From = "Grecja", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4253, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Grecja", Price = 61, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4254, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Grecja", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4255, AllSeats = 29, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Gruzja", Price = 144, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 4256, AllSeats = 29, DateTime = DateTime.Parse("2022-07-26"), From = "Gruzja", To = "Gdansk", Price = 67, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 4257, AllSeats = 61, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Gruzja", Price = 122, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 4258, AllSeats = 61, DateTime = DateTime.Parse("2022-07-26"), From = "Gruzja", To = "Gdansk", Price = 133, Type = TransportType.Plane, AvailableSeats = 61
},
new()
{
Id = 4259, AllSeats = 54, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Gruzja", Price = 117, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 4260, AllSeats = 54, DateTime = DateTime.Parse("2022-07-26"), From = "Gruzja", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 54
},
new()
{
Id = 4261, AllSeats = 48, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Madera", Price = 78, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 4262, AllSeats = 48, DateTime = DateTime.Parse("2022-07-26"), From = "Madera", To = "Gdansk", Price = 66, Type = TransportType.Bus, AvailableSeats = 48
},
new()
{
Id = 4263, AllSeats = 68, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Madera", Price = 82, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 4264, AllSeats = 68, DateTime = DateTime.Parse("2022-07-26"), From = "Madera", To = "Gdansk", Price = 116, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 4265, AllSeats = 65, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Madera", Price = 60, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 4266, AllSeats = 65, DateTime = DateTime.Parse("2022-07-26"), From = "Madera", To = "Gdansk", Price = 94, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 4267, AllSeats = 86, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malediwy", Price = 149, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4268, AllSeats = 86, DateTime = DateTime.Parse("2022-07-26"), From = "Malediwy", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4269, AllSeats = 77, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malediwy", Price = 117, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 4270, AllSeats = 77, DateTime = DateTime.Parse("2022-07-26"), From = "Malediwy", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 77
},
new()
{
Id = 4271, AllSeats = 96, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malediwy", Price = 56, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4272, AllSeats = 96, DateTime = DateTime.Parse("2022-07-26"), From = "Malediwy", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4273, AllSeats = 86, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malta", Price = 146, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4274, AllSeats = 86, DateTime = DateTime.Parse("2022-07-26"), From = "Malta", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4275, AllSeats = 33, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malta", Price = 116, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4276, AllSeats = 33, DateTime = DateTime.Parse("2022-07-26"), From = "Malta", To = "Gdansk", Price = 106, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4277, AllSeats = 36, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Malta", Price = 98, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4278, AllSeats = 36, DateTime = DateTime.Parse("2022-07-26"), From = "Malta", To = "Gdansk", Price = 109, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4279, AllSeats = 31, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Mauritius", Price = 77, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 4280, AllSeats = 31, DateTime = DateTime.Parse("2022-07-26"), From = "Mauritius", To = "Gdansk", Price = 58, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 4281, AllSeats = 39, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Mauritius", Price = 118, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 4282, AllSeats = 39, DateTime = DateTime.Parse("2022-07-26"), From = "Mauritius", To = "Gdansk", Price = 106, Type = TransportType.Plane, AvailableSeats = 39
},
new()
{
Id = 4283, AllSeats = 70, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Mauritius", Price = 72, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 4284, AllSeats = 70, DateTime = DateTime.Parse("2022-07-26"), From = "Mauritius", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 4285, AllSeats = 88, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Meksyk", Price = 149, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 4286, AllSeats = 88, DateTime = DateTime.Parse("2022-07-26"), From = "Meksyk", To = "Gdansk", Price = 150, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 4287, AllSeats = 56, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Meksyk", Price = 127, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 4288, AllSeats = 56, DateTime = DateTime.Parse("2022-07-26"), From = "Meksyk", To = "Gdansk", Price = 63, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 4289, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Meksyk", Price = 110, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4290, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Meksyk", To = "Gdansk", Price = 58, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4291, AllSeats = 95, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Seszele", Price = 68, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4292, AllSeats = 95, DateTime = DateTime.Parse("2022-07-26"), From = "Seszele", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4293, AllSeats = 55, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Seszele", Price = 54, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4294, AllSeats = 55, DateTime = DateTime.Parse("2022-07-26"), From = "Seszele", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4295, AllSeats = 75, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Seszele", Price = 131, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4296, AllSeats = 75, DateTime = DateTime.Parse("2022-07-26"), From = "Seszele", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4297, AllSeats = 34, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Slowenia", Price = 136, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 4298, AllSeats = 34, DateTime = DateTime.Parse("2022-07-26"), From = "Slowenia", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 34
},
new()
{
Id = 4299, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Slowenia", Price = 65, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4300, AllSeats = 42, DateTime = DateTime.Parse("2022-07-26"), From = "Slowenia", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4301, AllSeats = 45, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Slowenia", Price = 79, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 4302, AllSeats = 45, DateTime = DateTime.Parse("2022-07-26"), From = "Slowenia", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 45
},
new()
{
Id = 4303, AllSeats = 84, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Turcja", Price = 50, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 4304, AllSeats = 84, DateTime = DateTime.Parse("2022-07-26"), From = "Turcja", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 4305, AllSeats = 92, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Turcja", Price = 62, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4306, AllSeats = 92, DateTime = DateTime.Parse("2022-07-26"), From = "Turcja", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4307, AllSeats = 37, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Turcja", Price = 63, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 4308, AllSeats = 37, DateTime = DateTime.Parse("2022-07-26"), From = "Turcja", To = "Gdansk", Price = 131, Type = TransportType.Train, AvailableSeats = 37
},
new()
{
Id = 4309, AllSeats = 51, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 55, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4310, AllSeats = 51, DateTime = DateTime.Parse("2022-07-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4311, AllSeats = 50, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 92, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4312, AllSeats = 50, DateTime = DateTime.Parse("2022-07-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 99, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4313, AllSeats = 59, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 87, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 4314, AllSeats = 59, DateTime = DateTime.Parse("2022-07-26"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 87, Type = TransportType.Train, AvailableSeats = 59
},
new()
{
Id = 4315, AllSeats = 83, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Zanzibar", Price = 125, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 4316, AllSeats = 83, DateTime = DateTime.Parse("2022-07-26"), From = "Zanzibar", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 4317, AllSeats = 66, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Zanzibar", Price = 124, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 4318, AllSeats = 66, DateTime = DateTime.Parse("2022-07-26"), From = "Zanzibar", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 66
},
new()
{
Id = 4319, AllSeats = 31, DateTime = DateTime.Parse("2022-07-26"), From = "Gdansk", To = "Zanzibar", Price = 115, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4320, AllSeats = 31, DateTime = DateTime.Parse("2022-07-26"), From = "Zanzibar", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4321, AllSeats = 71, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Albania", Price = 74, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 4322, AllSeats = 71, DateTime = DateTime.Parse("2022-07-27"), From = "Albania", To = "Gdansk", Price = 99, Type = TransportType.Bus, AvailableSeats = 71
},
new()
{
Id = 4323, AllSeats = 45, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Albania", Price = 71, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 4324, AllSeats = 45, DateTime = DateTime.Parse("2022-07-27"), From = "Albania", To = "Gdansk", Price = 78, Type = TransportType.Plane, AvailableSeats = 45
},
new()
{
Id = 4325, AllSeats = 67, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Albania", Price = 130, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 4326, AllSeats = 67, DateTime = DateTime.Parse("2022-07-27"), From = "Albania", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 4327, AllSeats = 84, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Bulgaria", Price = 110, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 4328, AllSeats = 84, DateTime = DateTime.Parse("2022-07-27"), From = "Bulgaria", To = "Gdansk", Price = 59, Type = TransportType.Bus, AvailableSeats = 84
},
new()
{
Id = 4329, AllSeats = 98, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Bulgaria", Price = 130, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4330, AllSeats = 98, DateTime = DateTime.Parse("2022-07-27"), From = "Bulgaria", To = "Gdansk", Price = 104, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4331, AllSeats = 39, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Bulgaria", Price = 139, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4332, AllSeats = 39, DateTime = DateTime.Parse("2022-07-27"), From = "Bulgaria", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4333, AllSeats = 58, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Czarnogora", Price = 78, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 4334, AllSeats = 58, DateTime = DateTime.Parse("2022-07-27"), From = "Czarnogora", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 58
},
new()
{
Id = 4335, AllSeats = 32, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Czarnogora", Price = 104, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 4336, AllSeats = 32, DateTime = DateTime.Parse("2022-07-27"), From = "Czarnogora", To = "Gdansk", Price = 80, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 4337, AllSeats = 27, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Czarnogora", Price = 108, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 4338, AllSeats = 27, DateTime = DateTime.Parse("2022-07-27"), From = "Czarnogora", To = "Gdansk", Price = 75, Type = TransportType.Train, AvailableSeats = 27
},
new()
{
Id = 4339, AllSeats = 41, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Egipt", Price = 147, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4340, AllSeats = 41, DateTime = DateTime.Parse("2022-07-27"), From = "Egipt", To = "Gdansk", Price = 88, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4341, AllSeats = 48, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Egipt", Price = 103, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4342, AllSeats = 48, DateTime = DateTime.Parse("2022-07-27"), From = "Egipt", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4343, AllSeats = 36, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Egipt", Price = 84, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4344, AllSeats = 36, DateTime = DateTime.Parse("2022-07-27"), From = "Egipt", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4345, AllSeats = 26, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Grecja", Price = 91, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 4346, AllSeats = 26, DateTime = DateTime.Parse("2022-07-27"), From = "Grecja", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 26
},
new()
{
Id = 4347, AllSeats = 44, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Grecja", Price = 134, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 4348, AllSeats = 44, DateTime = DateTime.Parse("2022-07-27"), From = "Grecja", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 4349, AllSeats = 43, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Grecja", Price = 80, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 4350, AllSeats = 43, DateTime = DateTime.Parse("2022-07-27"), From = "Grecja", To = "Gdansk", Price = 118, Type = TransportType.Train, AvailableSeats = 43
},
new()
{
Id = 4351, AllSeats = 95, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Gruzja", Price = 63, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4352, AllSeats = 95, DateTime = DateTime.Parse("2022-07-27"), From = "Gruzja", To = "Gdansk", Price = 68, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4353, AllSeats = 26, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Gruzja", Price = 114, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4354, AllSeats = 26, DateTime = DateTime.Parse("2022-07-27"), From = "Gruzja", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4355, AllSeats = 99, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Gruzja", Price = 109, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4356, AllSeats = 99, DateTime = DateTime.Parse("2022-07-27"), From = "Gruzja", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4357, AllSeats = 82, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Madera", Price = 104, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4358, AllSeats = 82, DateTime = DateTime.Parse("2022-07-27"), From = "Madera", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4359, AllSeats = 37, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Madera", Price = 141, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 4360, AllSeats = 37, DateTime = DateTime.Parse("2022-07-27"), From = "Madera", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 37
},
new()
{
Id = 4361, AllSeats = 76, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Madera", Price = 64, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4362, AllSeats = 76, DateTime = DateTime.Parse("2022-07-27"), From = "Madera", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4363, AllSeats = 37, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malediwy", Price = 111, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 4364, AllSeats = 37, DateTime = DateTime.Parse("2022-07-27"), From = "Malediwy", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 4365, AllSeats = 31, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malediwy", Price = 148, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4366, AllSeats = 31, DateTime = DateTime.Parse("2022-07-27"), From = "Malediwy", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4367, AllSeats = 70, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malediwy", Price = 50, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 4368, AllSeats = 70, DateTime = DateTime.Parse("2022-07-27"), From = "Malediwy", To = "Gdansk", Price = 112, Type = TransportType.Train, AvailableSeats = 70
},
new()
{
Id = 4369, AllSeats = 87, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malta", Price = 114, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4370, AllSeats = 87, DateTime = DateTime.Parse("2022-07-27"), From = "Malta", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4371, AllSeats = 53, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malta", Price = 132, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4372, AllSeats = 53, DateTime = DateTime.Parse("2022-07-27"), From = "Malta", To = "Gdansk", Price = 75, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4373, AllSeats = 71, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Malta", Price = 62, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 4374, AllSeats = 71, DateTime = DateTime.Parse("2022-07-27"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 71
},
new()
{
Id = 4375, AllSeats = 53, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Mauritius", Price = 123, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 4376, AllSeats = 53, DateTime = DateTime.Parse("2022-07-27"), From = "Mauritius", To = "Gdansk", Price = 84, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 4377, AllSeats = 93, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Mauritius", Price = 109, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 4378, AllSeats = 93, DateTime = DateTime.Parse("2022-07-27"), From = "Mauritius", To = "Gdansk", Price = 59, Type = TransportType.Plane, AvailableSeats = 93
},
new()
{
Id = 4379, AllSeats = 55, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Mauritius", Price = 137, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4380, AllSeats = 55, DateTime = DateTime.Parse("2022-07-27"), From = "Mauritius", To = "Gdansk", Price = 63, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4381, AllSeats = 64, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Meksyk", Price = 92, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4382, AllSeats = 64, DateTime = DateTime.Parse("2022-07-27"), From = "Meksyk", To = "Gdansk", Price = 124, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4383, AllSeats = 34, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Meksyk", Price = 56, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 4384, AllSeats = 34, DateTime = DateTime.Parse("2022-07-27"), From = "Meksyk", To = "Gdansk", Price = 66, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 4385, AllSeats = 42, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Meksyk", Price = 144, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4386, AllSeats = 42, DateTime = DateTime.Parse("2022-07-27"), From = "Meksyk", To = "Gdansk", Price = 139, Type = TransportType.Train, AvailableSeats = 42
},
new()
{
Id = 4387, AllSeats = 81, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Seszele", Price = 132, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4388, AllSeats = 81, DateTime = DateTime.Parse("2022-07-27"), From = "Seszele", To = "Gdansk", Price = 123, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4389, AllSeats = 52, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Seszele", Price = 86, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4390, AllSeats = 52, DateTime = DateTime.Parse("2022-07-27"), From = "Seszele", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4391, AllSeats = 84, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Seszele", Price = 135, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 4392, AllSeats = 84, DateTime = DateTime.Parse("2022-07-27"), From = "Seszele", To = "Gdansk", Price = 141, Type = TransportType.Train, AvailableSeats = 84
},
new()
{
Id = 4393, AllSeats = 100, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Slowenia", Price = 106, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4394, AllSeats = 100, DateTime = DateTime.Parse("2022-07-27"), From = "Slowenia", To = "Gdansk", Price = 56, Type = TransportType.Bus, AvailableSeats = 100
},
new()
{
Id = 4395, AllSeats = 87, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Slowenia", Price = 73, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4396, AllSeats = 87, DateTime = DateTime.Parse("2022-07-27"), From = "Slowenia", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4397, AllSeats = 79, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Slowenia", Price = 96, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4398, AllSeats = 79, DateTime = DateTime.Parse("2022-07-27"), From = "Slowenia", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4399, AllSeats = 39, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Turcja", Price = 124, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 4400, AllSeats = 39, DateTime = DateTime.Parse("2022-07-27"), From = "Turcja", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 39
},
new()
{
Id = 4401, AllSeats = 98, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Turcja", Price = 115, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4402, AllSeats = 98, DateTime = DateTime.Parse("2022-07-27"), From = "Turcja", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4403, AllSeats = 29, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Turcja", Price = 99, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4404, AllSeats = 29, DateTime = DateTime.Parse("2022-07-27"), From = "Turcja", To = "Gdansk", Price = 120, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4405, AllSeats = 32, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 69, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 4406, AllSeats = 32, DateTime = DateTime.Parse("2022-07-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 32
},
new()
{
Id = 4407, AllSeats = 68, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 100, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 4408, AllSeats = 68, DateTime = DateTime.Parse("2022-07-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 71, Type = TransportType.Plane, AvailableSeats = 68
},
new()
{
Id = 4409, AllSeats = 68, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 112, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4410, AllSeats = 68, DateTime = DateTime.Parse("2022-07-27"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4411, AllSeats = 61, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Zanzibar", Price = 73, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4412, AllSeats = 61, DateTime = DateTime.Parse("2022-07-27"), From = "Zanzibar", To = "Gdansk", Price = 141, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4413, AllSeats = 70, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Zanzibar", Price = 113, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 4414, AllSeats = 70, DateTime = DateTime.Parse("2022-07-27"), From = "Zanzibar", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 4415, AllSeats = 46, DateTime = DateTime.Parse("2022-07-27"), From = "Gdansk", To = "Zanzibar", Price = 103, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4416, AllSeats = 46, DateTime = DateTime.Parse("2022-07-27"), From = "Zanzibar", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4417, AllSeats = 72, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Albania", Price = 69, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 4418, AllSeats = 72, DateTime = DateTime.Parse("2022-07-28"), From = "Albania", To = "Gdansk", Price = 136, Type = TransportType.Bus, AvailableSeats = 72
},
new()
{
Id = 4419, AllSeats = 53, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Albania", Price = 104, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4420, AllSeats = 53, DateTime = DateTime.Parse("2022-07-28"), From = "Albania", To = "Gdansk", Price = 105, Type = TransportType.Plane, AvailableSeats = 53
},
new()
{
Id = 4421, AllSeats = 86, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Albania", Price = 121, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4422, AllSeats = 86, DateTime = DateTime.Parse("2022-07-28"), From = "Albania", To = "Gdansk", Price = 145, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4423, AllSeats = 92, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Bulgaria", Price = 86, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 4424, AllSeats = 92, DateTime = DateTime.Parse("2022-07-28"), From = "Bulgaria", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 4425, AllSeats = 31, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Bulgaria", Price = 112, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4426, AllSeats = 31, DateTime = DateTime.Parse("2022-07-28"), From = "Bulgaria", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4427, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Bulgaria", Price = 50, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4428, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Bulgaria", To = "Gdansk", Price = 110, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4429, AllSeats = 69, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Czarnogora", Price = 98, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 4430, AllSeats = 69, DateTime = DateTime.Parse("2022-07-28"), From = "Czarnogora", To = "Gdansk", Price = 113, Type = TransportType.Bus, AvailableSeats = 69
},
new()
{
Id = 4431, AllSeats = 92, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Czarnogora", Price = 76, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4432, AllSeats = 92, DateTime = DateTime.Parse("2022-07-28"), From = "Czarnogora", To = "Gdansk", Price = 109, Type = TransportType.Plane, AvailableSeats = 92
},
new()
{
Id = 4433, AllSeats = 75, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Czarnogora", Price = 123, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4434, AllSeats = 75, DateTime = DateTime.Parse("2022-07-28"), From = "Czarnogora", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 75
},
new()
{
Id = 4435, AllSeats = 35, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Egipt", Price = 99, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 4436, AllSeats = 35, DateTime = DateTime.Parse("2022-07-28"), From = "Egipt", To = "Gdansk", Price = 120, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 4437, AllSeats = 75, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Egipt", Price = 139, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4438, AllSeats = 75, DateTime = DateTime.Parse("2022-07-28"), From = "Egipt", To = "Gdansk", Price = 128, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4439, AllSeats = 94, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Egipt", Price = 86, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 4440, AllSeats = 94, DateTime = DateTime.Parse("2022-07-28"), From = "Egipt", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 4441, AllSeats = 86, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Grecja", Price = 133, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4442, AllSeats = 86, DateTime = DateTime.Parse("2022-07-28"), From = "Grecja", To = "Gdansk", Price = 78, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4443, AllSeats = 47, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Grecja", Price = 112, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4444, AllSeats = 47, DateTime = DateTime.Parse("2022-07-28"), From = "Grecja", To = "Gdansk", Price = 141, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4445, AllSeats = 76, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Grecja", Price = 126, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4446, AllSeats = 76, DateTime = DateTime.Parse("2022-07-28"), From = "Grecja", To = "Gdansk", Price = 96, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4447, AllSeats = 88, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Gruzja", Price = 66, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 4448, AllSeats = 88, DateTime = DateTime.Parse("2022-07-28"), From = "Gruzja", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 88
},
new()
{
Id = 4449, AllSeats = 54, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Gruzja", Price = 138, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 4450, AllSeats = 54, DateTime = DateTime.Parse("2022-07-28"), From = "Gruzja", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 54
},
new()
{
Id = 4451, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Gruzja", Price = 127, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 4452, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Gruzja", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 4453, AllSeats = 40, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Madera", Price = 140, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4454, AllSeats = 40, DateTime = DateTime.Parse("2022-07-28"), From = "Madera", To = "Gdansk", Price = 52, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4455, AllSeats = 83, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Madera", Price = 136, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 4456, AllSeats = 83, DateTime = DateTime.Parse("2022-07-28"), From = "Madera", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 83
},
new()
{
Id = 4457, AllSeats = 39, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Madera", Price = 95, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4458, AllSeats = 39, DateTime = DateTime.Parse("2022-07-28"), From = "Madera", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4459, AllSeats = 81, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malediwy", Price = 55, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4460, AllSeats = 81, DateTime = DateTime.Parse("2022-07-28"), From = "Malediwy", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4461, AllSeats = 42, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malediwy", Price = 77, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4462, AllSeats = 42, DateTime = DateTime.Parse("2022-07-28"), From = "Malediwy", To = "Gdansk", Price = 130, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4463, AllSeats = 57, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malediwy", Price = 80, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 4464, AllSeats = 57, DateTime = DateTime.Parse("2022-07-28"), From = "Malediwy", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 57
},
new()
{
Id = 4465, AllSeats = 61, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malta", Price = 127, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4466, AllSeats = 61, DateTime = DateTime.Parse("2022-07-28"), From = "Malta", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4467, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malta", Price = 103, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4468, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Malta", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4469, AllSeats = 77, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Malta", Price = 135, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4470, AllSeats = 77, DateTime = DateTime.Parse("2022-07-28"), From = "Malta", To = "Gdansk", Price = 105, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4471, AllSeats = 47, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Mauritius", Price = 80, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 4472, AllSeats = 47, DateTime = DateTime.Parse("2022-07-28"), From = "Mauritius", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 47
},
new()
{
Id = 4473, AllSeats = 73, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Mauritius", Price = 138, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4474, AllSeats = 73, DateTime = DateTime.Parse("2022-07-28"), From = "Mauritius", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4475, AllSeats = 67, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Mauritius", Price = 76, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 4476, AllSeats = 67, DateTime = DateTime.Parse("2022-07-28"), From = "Mauritius", To = "Gdansk", Price = 71, Type = TransportType.Train, AvailableSeats = 67
},
new()
{
Id = 4477, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Meksyk", Price = 134, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 4478, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Meksyk", To = "Gdansk", Price = 75, Type = TransportType.Bus, AvailableSeats = 28
},
new()
{
Id = 4479, AllSeats = 31, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Meksyk", Price = 80, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4480, AllSeats = 31, DateTime = DateTime.Parse("2022-07-28"), From = "Meksyk", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4481, AllSeats = 79, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Meksyk", Price = 71, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4482, AllSeats = 79, DateTime = DateTime.Parse("2022-07-28"), From = "Meksyk", To = "Gdansk", Price = 122, Type = TransportType.Train, AvailableSeats = 79
},
new()
{
Id = 4483, AllSeats = 80, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Seszele", Price = 75, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 4484, AllSeats = 80, DateTime = DateTime.Parse("2022-07-28"), From = "Seszele", To = "Gdansk", Price = 91, Type = TransportType.Bus, AvailableSeats = 80
},
new()
{
Id = 4485, AllSeats = 62, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Seszele", Price = 58, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 4486, AllSeats = 62, DateTime = DateTime.Parse("2022-07-28"), From = "Seszele", To = "Gdansk", Price = 142, Type = TransportType.Plane, AvailableSeats = 62
},
new()
{
Id = 4487, AllSeats = 46, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Seszele", Price = 145, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4488, AllSeats = 46, DateTime = DateTime.Parse("2022-07-28"), From = "Seszele", To = "Gdansk", Price = 56, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4489, AllSeats = 73, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Slowenia", Price = 113, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 4490, AllSeats = 73, DateTime = DateTime.Parse("2022-07-28"), From = "Slowenia", To = "Gdansk", Price = 96, Type = TransportType.Bus, AvailableSeats = 73
},
new()
{
Id = 4491, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Slowenia", Price = 112, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 4492, AllSeats = 28, DateTime = DateTime.Parse("2022-07-28"), From = "Slowenia", To = "Gdansk", Price = 56, Type = TransportType.Plane, AvailableSeats = 28
},
new()
{
Id = 4493, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Slowenia", Price = 113, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 4494, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Slowenia", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 30
},
new()
{
Id = 4495, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Turcja", Price = 79, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4496, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Turcja", To = "Gdansk", Price = 64, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4497, AllSeats = 26, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Turcja", Price = 50, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4498, AllSeats = 26, DateTime = DateTime.Parse("2022-07-28"), From = "Turcja", To = "Gdansk", Price = 150, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4499, AllSeats = 80, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Turcja", Price = 114, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 4500, AllSeats = 80, DateTime = DateTime.Parse("2022-07-28"), From = "Turcja", To = "Gdansk", Price = 66, Type = TransportType.Train, AvailableSeats = 80
},
new()
{
Id = 4501, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 102, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4502, AllSeats = 98, DateTime = DateTime.Parse("2022-07-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 69, Type = TransportType.Bus, AvailableSeats = 98
},
new()
{
Id = 4503, AllSeats = 78, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 82, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 4504, AllSeats = 78, DateTime = DateTime.Parse("2022-07-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 78
},
new()
{
Id = 4505, AllSeats = 88, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 51, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 4506, AllSeats = 88, DateTime = DateTime.Parse("2022-07-28"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 91, Type = TransportType.Train, AvailableSeats = 88
},
new()
{
Id = 4507, AllSeats = 51, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Zanzibar", Price = 77, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4508, AllSeats = 51, DateTime = DateTime.Parse("2022-07-28"), From = "Zanzibar", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4509, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Zanzibar", Price = 148, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 4510, AllSeats = 30, DateTime = DateTime.Parse("2022-07-28"), From = "Zanzibar", To = "Gdansk", Price = 125, Type = TransportType.Plane, AvailableSeats = 30
},
new()
{
Id = 4511, AllSeats = 25, DateTime = DateTime.Parse("2022-07-28"), From = "Gdansk", To = "Zanzibar", Price = 118, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4512, AllSeats = 25, DateTime = DateTime.Parse("2022-07-28"), From = "Zanzibar", To = "Gdansk", Price = 138, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4513, AllSeats = 96, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Albania", Price = 66, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 4514, AllSeats = 96, DateTime = DateTime.Parse("2022-07-29"), From = "Albania", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 96
},
new()
{
Id = 4515, AllSeats = 33, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Albania", Price = 95, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4516, AllSeats = 33, DateTime = DateTime.Parse("2022-07-29"), From = "Albania", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4517, AllSeats = 41, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Albania", Price = 54, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4518, AllSeats = 41, DateTime = DateTime.Parse("2022-07-29"), From = "Albania", To = "Gdansk", Price = 89, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4519, AllSeats = 35, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Bulgaria", Price = 56, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 4520, AllSeats = 35, DateTime = DateTime.Parse("2022-07-29"), From = "Bulgaria", To = "Gdansk", Price = 77, Type = TransportType.Bus, AvailableSeats = 35
},
new()
{
Id = 4521, AllSeats = 32, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Bulgaria", Price = 50, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 4522, AllSeats = 32, DateTime = DateTime.Parse("2022-07-29"), From = "Bulgaria", To = "Gdansk", Price = 127, Type = TransportType.Plane, AvailableSeats = 32
},
new()
{
Id = 4523, AllSeats = 36, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Bulgaria", Price = 50, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4524, AllSeats = 36, DateTime = DateTime.Parse("2022-07-29"), From = "Bulgaria", To = "Gdansk", Price = 126, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4525, AllSeats = 51, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Czarnogora", Price = 138, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4526, AllSeats = 51, DateTime = DateTime.Parse("2022-07-29"), From = "Czarnogora", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4527, AllSeats = 86, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Czarnogora", Price = 68, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 4528, AllSeats = 86, DateTime = DateTime.Parse("2022-07-29"), From = "Czarnogora", To = "Gdansk", Price = 124, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 4529, AllSeats = 26, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Czarnogora", Price = 94, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 4530, AllSeats = 26, DateTime = DateTime.Parse("2022-07-29"), From = "Czarnogora", To = "Gdansk", Price = 115, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 4531, AllSeats = 54, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Egipt", Price = 61, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 4532, AllSeats = 54, DateTime = DateTime.Parse("2022-07-29"), From = "Egipt", To = "Gdansk", Price = 116, Type = TransportType.Bus, AvailableSeats = 54
},
new()
{
Id = 4533, AllSeats = 55, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Egipt", Price = 61, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4534, AllSeats = 55, DateTime = DateTime.Parse("2022-07-29"), From = "Egipt", To = "Gdansk", Price = 147, Type = TransportType.Plane, AvailableSeats = 55
},
new()
{
Id = 4535, AllSeats = 55, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Egipt", Price = 83, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4536, AllSeats = 55, DateTime = DateTime.Parse("2022-07-29"), From = "Egipt", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 55
},
new()
{
Id = 4537, AllSeats = 59, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Grecja", Price = 120, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 4538, AllSeats = 59, DateTime = DateTime.Parse("2022-07-29"), From = "Grecja", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 59
},
new()
{
Id = 4539, AllSeats = 57, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Grecja", Price = 142, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4540, AllSeats = 57, DateTime = DateTime.Parse("2022-07-29"), From = "Grecja", To = "Gdansk", Price = 62, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4541, AllSeats = 49, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Grecja", Price = 52, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4542, AllSeats = 49, DateTime = DateTime.Parse("2022-07-29"), From = "Grecja", To = "Gdansk", Price = 72, Type = TransportType.Train, AvailableSeats = 49
},
new()
{
Id = 4543, AllSeats = 83, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Gruzja", Price = 102, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 4544, AllSeats = 83, DateTime = DateTime.Parse("2022-07-29"), From = "Gruzja", To = "Gdansk", Price = 93, Type = TransportType.Bus, AvailableSeats = 83
},
new()
{
Id = 4545, AllSeats = 34, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Gruzja", Price = 126, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 4546, AllSeats = 34, DateTime = DateTime.Parse("2022-07-29"), From = "Gruzja", To = "Gdansk", Price = 61, Type = TransportType.Plane, AvailableSeats = 34
},
new()
{
Id = 4547, AllSeats = 28, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Gruzja", Price = 134, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4548, AllSeats = 28, DateTime = DateTime.Parse("2022-07-29"), From = "Gruzja", To = "Gdansk", Price = 143, Type = TransportType.Train, AvailableSeats = 28
},
new()
{
Id = 4549, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Madera", Price = 78, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4550, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Madera", To = "Gdansk", Price = 104, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4551, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Madera", Price = 53, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 4552, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Madera", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 4553, AllSeats = 99, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Madera", Price = 140, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4554, AllSeats = 99, DateTime = DateTime.Parse("2022-07-29"), From = "Madera", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 99
},
new()
{
Id = 4555, AllSeats = 70, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malediwy", Price = 58, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 4556, AllSeats = 70, DateTime = DateTime.Parse("2022-07-29"), From = "Malediwy", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 70
},
new()
{
Id = 4557, AllSeats = 33, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malediwy", Price = 62, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4558, AllSeats = 33, DateTime = DateTime.Parse("2022-07-29"), From = "Malediwy", To = "Gdansk", Price = 77, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4559, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malediwy", Price = 116, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 4560, AllSeats = 97, DateTime = DateTime.Parse("2022-07-29"), From = "Malediwy", To = "Gdansk", Price = 69, Type = TransportType.Train, AvailableSeats = 97
},
new()
{
Id = 4561, AllSeats = 82, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malta", Price = 76, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4562, AllSeats = 82, DateTime = DateTime.Parse("2022-07-29"), From = "Malta", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 82
},
new()
{
Id = 4563, AllSeats = 48, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malta", Price = 69, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4564, AllSeats = 48, DateTime = DateTime.Parse("2022-07-29"), From = "Malta", To = "Gdansk", Price = 99, Type = TransportType.Plane, AvailableSeats = 48
},
new()
{
Id = 4565, AllSeats = 56, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Malta", Price = 127, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 4566, AllSeats = 56, DateTime = DateTime.Parse("2022-07-29"), From = "Malta", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 56
},
new()
{
Id = 4567, AllSeats = 92, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Mauritius", Price = 98, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 4568, AllSeats = 92, DateTime = DateTime.Parse("2022-07-29"), From = "Mauritius", To = "Gdansk", Price = 65, Type = TransportType.Bus, AvailableSeats = 92
},
new()
{
Id = 4569, AllSeats = 96, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Mauritius", Price = 110, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 4570, AllSeats = 96, DateTime = DateTime.Parse("2022-07-29"), From = "Mauritius", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 96
},
new()
{
Id = 4571, AllSeats = 90, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Mauritius", Price = 121, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4572, AllSeats = 90, DateTime = DateTime.Parse("2022-07-29"), From = "Mauritius", To = "Gdansk", Price = 130, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4573, AllSeats = 91, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Meksyk", Price = 108, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4574, AllSeats = 91, DateTime = DateTime.Parse("2022-07-29"), From = "Meksyk", To = "Gdansk", Price = 108, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4575, AllSeats = 26, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Meksyk", Price = 57, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4576, AllSeats = 26, DateTime = DateTime.Parse("2022-07-29"), From = "Meksyk", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 26
},
new()
{
Id = 4577, AllSeats = 29, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Meksyk", Price = 127, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4578, AllSeats = 29, DateTime = DateTime.Parse("2022-07-29"), From = "Meksyk", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4579, AllSeats = 25, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Seszele", Price = 62, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 4580, AllSeats = 25, DateTime = DateTime.Parse("2022-07-29"), From = "Seszele", To = "Gdansk", Price = 127, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 4581, AllSeats = 47, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Seszele", Price = 59, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4582, AllSeats = 47, DateTime = DateTime.Parse("2022-07-29"), From = "Seszele", To = "Gdansk", Price = 90, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4583, AllSeats = 36, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Seszele", Price = 89, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4584, AllSeats = 36, DateTime = DateTime.Parse("2022-07-29"), From = "Seszele", To = "Gdansk", Price = 123, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4585, AllSeats = 37, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Slowenia", Price = 63, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 4586, AllSeats = 37, DateTime = DateTime.Parse("2022-07-29"), From = "Slowenia", To = "Gdansk", Price = 50, Type = TransportType.Bus, AvailableSeats = 37
},
new()
{
Id = 4587, AllSeats = 41, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Slowenia", Price = 71, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4588, AllSeats = 41, DateTime = DateTime.Parse("2022-07-29"), From = "Slowenia", To = "Gdansk", Price = 120, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4589, AllSeats = 29, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Slowenia", Price = 136, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4590, AllSeats = 29, DateTime = DateTime.Parse("2022-07-29"), From = "Slowenia", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4591, AllSeats = 81, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Turcja", Price = 140, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4592, AllSeats = 81, DateTime = DateTime.Parse("2022-07-29"), From = "Turcja", To = "Gdansk", Price = 51, Type = TransportType.Bus, AvailableSeats = 81
},
new()
{
Id = 4593, AllSeats = 40, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Turcja", Price = 134, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4594, AllSeats = 40, DateTime = DateTime.Parse("2022-07-29"), From = "Turcja", To = "Gdansk", Price = 73, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4595, AllSeats = 74, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Turcja", Price = 122, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 4596, AllSeats = 74, DateTime = DateTime.Parse("2022-07-29"), From = "Turcja", To = "Gdansk", Price = 50, Type = TransportType.Train, AvailableSeats = 74
},
new()
{
Id = 4597, AllSeats = 62, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 58, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 4598, AllSeats = 62, DateTime = DateTime.Parse("2022-07-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 90, Type = TransportType.Bus, AvailableSeats = 62
},
new()
{
Id = 4599, AllSeats = 87, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 91, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4600, AllSeats = 87, DateTime = DateTime.Parse("2022-07-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 87
},
new()
{
Id = 4601, AllSeats = 46, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 78, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4602, AllSeats = 46, DateTime = DateTime.Parse("2022-07-29"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 119, Type = TransportType.Train, AvailableSeats = 46
},
new()
{
Id = 4603, AllSeats = 61, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Zanzibar", Price = 120, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4604, AllSeats = 61, DateTime = DateTime.Parse("2022-07-29"), From = "Zanzibar", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4605, AllSeats = 47, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Zanzibar", Price = 106, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4606, AllSeats = 47, DateTime = DateTime.Parse("2022-07-29"), From = "Zanzibar", To = "Gdansk", Price = 53, Type = TransportType.Plane, AvailableSeats = 47
},
new()
{
Id = 4607, AllSeats = 66, DateTime = DateTime.Parse("2022-07-29"), From = "Gdansk", To = "Zanzibar", Price = 50, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 4608, AllSeats = 66, DateTime = DateTime.Parse("2022-07-29"), From = "Zanzibar", To = "Gdansk", Price = 64, Type = TransportType.Train, AvailableSeats = 66
},
new()
{
Id = 4609, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Albania", Price = 115, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 4610, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Albania", To = "Gdansk", Price = 126, Type = TransportType.Bus, AvailableSeats = 31
},
new()
{
Id = 4611, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Albania", Price = 54, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4612, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Albania", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4613, AllSeats = 35, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Albania", Price = 142, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 4614, AllSeats = 35, DateTime = DateTime.Parse("2022-07-30"), From = "Albania", To = "Gdansk", Price = 80, Type = TransportType.Train, AvailableSeats = 35
},
new()
{
Id = 4615, AllSeats = 87, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Bulgaria", Price = 90, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4616, AllSeats = 87, DateTime = DateTime.Parse("2022-07-30"), From = "Bulgaria", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4617, AllSeats = 44, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Bulgaria", Price = 143, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 4618, AllSeats = 44, DateTime = DateTime.Parse("2022-07-30"), From = "Bulgaria", To = "Gdansk", Price = 55, Type = TransportType.Plane, AvailableSeats = 44
},
new()
{
Id = 4619, AllSeats = 26, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Bulgaria", Price = 54, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 4620, AllSeats = 26, DateTime = DateTime.Parse("2022-07-30"), From = "Bulgaria", To = "Gdansk", Price = 83, Type = TransportType.Train, AvailableSeats = 26
},
new()
{
Id = 4621, AllSeats = 30, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Czarnogora", Price = 113, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4622, AllSeats = 30, DateTime = DateTime.Parse("2022-07-30"), From = "Czarnogora", To = "Gdansk", Price = 142, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4623, AllSeats = 80, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Czarnogora", Price = 52, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 4624, AllSeats = 80, DateTime = DateTime.Parse("2022-07-30"), From = "Czarnogora", To = "Gdansk", Price = 60, Type = TransportType.Plane, AvailableSeats = 80
},
new()
{
Id = 4625, AllSeats = 83, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Czarnogora", Price = 51, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 4626, AllSeats = 83, DateTime = DateTime.Parse("2022-07-30"), From = "Czarnogora", To = "Gdansk", Price = 74, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 4627, AllSeats = 52, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Egipt", Price = 129, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4628, AllSeats = 52, DateTime = DateTime.Parse("2022-07-30"), From = "Egipt", To = "Gdansk", Price = 76, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4629, AllSeats = 51, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Egipt", Price = 60, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 4630, AllSeats = 51, DateTime = DateTime.Parse("2022-07-30"), From = "Egipt", To = "Gdansk", Price = 106, Type = TransportType.Plane, AvailableSeats = 51
},
new()
{
Id = 4631, AllSeats = 86, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Egipt", Price = 147, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4632, AllSeats = 86, DateTime = DateTime.Parse("2022-07-30"), From = "Egipt", To = "Gdansk", Price = 129, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4633, AllSeats = 91, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Grecja", Price = 113, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4634, AllSeats = 91, DateTime = DateTime.Parse("2022-07-30"), From = "Grecja", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4635, AllSeats = 72, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Grecja", Price = 134, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4636, AllSeats = 72, DateTime = DateTime.Parse("2022-07-30"), From = "Grecja", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 72
},
new()
{
Id = 4637, AllSeats = 62, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Grecja", Price = 59, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 4638, AllSeats = 62, DateTime = DateTime.Parse("2022-07-30"), From = "Grecja", To = "Gdansk", Price = 104, Type = TransportType.Train, AvailableSeats = 62
},
new()
{
Id = 4639, AllSeats = 43, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Gruzja", Price = 143, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 4640, AllSeats = 43, DateTime = DateTime.Parse("2022-07-30"), From = "Gruzja", To = "Gdansk", Price = 71, Type = TransportType.Bus, AvailableSeats = 43
},
new()
{
Id = 4641, AllSeats = 73, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Gruzja", Price = 104, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4642, AllSeats = 73, DateTime = DateTime.Parse("2022-07-30"), From = "Gruzja", To = "Gdansk", Price = 57, Type = TransportType.Plane, AvailableSeats = 73
},
new()
{
Id = 4643, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Gruzja", Price = 145, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4644, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Gruzja", To = "Gdansk", Price = 76, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4645, AllSeats = 78, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Madera", Price = 114, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 4646, AllSeats = 78, DateTime = DateTime.Parse("2022-07-30"), From = "Madera", To = "Gdansk", Price = 112, Type = TransportType.Bus, AvailableSeats = 78
},
new()
{
Id = 4647, AllSeats = 33, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Madera", Price = 121, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4648, AllSeats = 33, DateTime = DateTime.Parse("2022-07-30"), From = "Madera", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 33
},
new()
{
Id = 4649, AllSeats = 83, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Madera", Price = 65, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 4650, AllSeats = 83, DateTime = DateTime.Parse("2022-07-30"), From = "Madera", To = "Gdansk", Price = 113, Type = TransportType.Train, AvailableSeats = 83
},
new()
{
Id = 4651, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malediwy", Price = 65, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4652, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Malediwy", To = "Gdansk", Price = 148, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4653, AllSeats = 76, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malediwy", Price = 124, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 4654, AllSeats = 76, DateTime = DateTime.Parse("2022-07-30"), From = "Malediwy", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 76
},
new()
{
Id = 4655, AllSeats = 29, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malediwy", Price = 86, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4656, AllSeats = 29, DateTime = DateTime.Parse("2022-07-30"), From = "Malediwy", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 29
},
new()
{
Id = 4657, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malta", Price = 146, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 4658, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Malta", To = "Gdansk", Price = 105, Type = TransportType.Bus, AvailableSeats = 25
},
new()
{
Id = 4659, AllSeats = 70, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malta", Price = 149, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 4660, AllSeats = 70, DateTime = DateTime.Parse("2022-07-30"), From = "Malta", To = "Gdansk", Price = 129, Type = TransportType.Plane, AvailableSeats = 70
},
new()
{
Id = 4661, AllSeats = 94, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Malta", Price = 140, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 4662, AllSeats = 94, DateTime = DateTime.Parse("2022-07-30"), From = "Malta", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 94
},
new()
{
Id = 4663, AllSeats = 95, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Mauritius", Price = 62, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4664, AllSeats = 95, DateTime = DateTime.Parse("2022-07-30"), From = "Mauritius", To = "Gdansk", Price = 83, Type = TransportType.Bus, AvailableSeats = 95
},
new()
{
Id = 4665, AllSeats = 58, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Mauritius", Price = 134, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 4666, AllSeats = 58, DateTime = DateTime.Parse("2022-07-30"), From = "Mauritius", To = "Gdansk", Price = 136, Type = TransportType.Plane, AvailableSeats = 58
},
new()
{
Id = 4667, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Mauritius", Price = 66, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4668, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Mauritius", To = "Gdansk", Price = 95, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4669, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Meksyk", Price = 128, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4670, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Meksyk", To = "Gdansk", Price = 85, Type = TransportType.Bus, AvailableSeats = 41
},
new()
{
Id = 4671, AllSeats = 60, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Meksyk", Price = 89, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 4672, AllSeats = 60, DateTime = DateTime.Parse("2022-07-30"), From = "Meksyk", To = "Gdansk", Price = 97, Type = TransportType.Plane, AvailableSeats = 60
},
new()
{
Id = 4673, AllSeats = 68, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Meksyk", Price = 135, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4674, AllSeats = 68, DateTime = DateTime.Parse("2022-07-30"), From = "Meksyk", To = "Gdansk", Price = 111, Type = TransportType.Train, AvailableSeats = 68
},
new()
{
Id = 4675, AllSeats = 29, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Seszele", Price = 87, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 4676, AllSeats = 29, DateTime = DateTime.Parse("2022-07-30"), From = "Seszele", To = "Gdansk", Price = 111, Type = TransportType.Bus, AvailableSeats = 29
},
new()
{
Id = 4677, AllSeats = 42, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Seszele", Price = 60, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4678, AllSeats = 42, DateTime = DateTime.Parse("2022-07-30"), From = "Seszele", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 42
},
new()
{
Id = 4679, AllSeats = 39, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Seszele", Price = 56, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4680, AllSeats = 39, DateTime = DateTime.Parse("2022-07-30"), From = "Seszele", To = "Gdansk", Price = 90, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4681, AllSeats = 46, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Slowenia", Price = 73, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 4682, AllSeats = 46, DateTime = DateTime.Parse("2022-07-30"), From = "Slowenia", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 46
},
new()
{
Id = 4683, AllSeats = 56, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Slowenia", Price = 143, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 4684, AllSeats = 56, DateTime = DateTime.Parse("2022-07-30"), From = "Slowenia", To = "Gdansk", Price = 70, Type = TransportType.Plane, AvailableSeats = 56
},
new()
{
Id = 4685, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Slowenia", Price = 68, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4686, AllSeats = 41, DateTime = DateTime.Parse("2022-07-30"), From = "Slowenia", To = "Gdansk", Price = 149, Type = TransportType.Train, AvailableSeats = 41
},
new()
{
Id = 4687, AllSeats = 52, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Turcja", Price = 97, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4688, AllSeats = 52, DateTime = DateTime.Parse("2022-07-30"), From = "Turcja", To = "Gdansk", Price = 86, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4689, AllSeats = 97, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Turcja", Price = 140, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 4690, AllSeats = 97, DateTime = DateTime.Parse("2022-07-30"), From = "Turcja", To = "Gdansk", Price = 69, Type = TransportType.Plane, AvailableSeats = 97
},
new()
{
Id = 4691, AllSeats = 86, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Turcja", Price = 149, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4692, AllSeats = 86, DateTime = DateTime.Parse("2022-07-30"), From = "Turcja", To = "Gdansk", Price = 125, Type = TransportType.Train, AvailableSeats = 86
},
new()
{
Id = 4693, AllSeats = 97, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 102, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4694, AllSeats = 97, DateTime = DateTime.Parse("2022-07-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 114, Type = TransportType.Bus, AvailableSeats = 97
},
new()
{
Id = 4695, AllSeats = 69, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 105, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4696, AllSeats = 69, DateTime = DateTime.Parse("2022-07-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 69
},
new()
{
Id = 4697, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 148, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4698, AllSeats = 31, DateTime = DateTime.Parse("2022-07-30"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 31
},
new()
{
Id = 4699, AllSeats = 51, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Zanzibar", Price = 149, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4700, AllSeats = 51, DateTime = DateTime.Parse("2022-07-30"), From = "Zanzibar", To = "Gdansk", Price = 110, Type = TransportType.Bus, AvailableSeats = 51
},
new()
{
Id = 4701, AllSeats = 89, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Zanzibar", Price = 97, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 4702, AllSeats = 89, DateTime = DateTime.Parse("2022-07-30"), From = "Zanzibar", To = "Gdansk", Price = 99, Type = TransportType.Plane, AvailableSeats = 89
},
new()
{
Id = 4703, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Gdansk", To = "Zanzibar", Price = 76, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4704, AllSeats = 25, DateTime = DateTime.Parse("2022-07-30"), From = "Zanzibar", To = "Gdansk", Price = 62, Type = TransportType.Train, AvailableSeats = 25
},
new()
{
Id = 4705, AllSeats = 61, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Albania", Price = 125, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4706, AllSeats = 61, DateTime = DateTime.Parse("2022-07-31"), From = "Albania", To = "Gdansk", Price = 119, Type = TransportType.Bus, AvailableSeats = 61
},
new()
{
Id = 4707, AllSeats = 57, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Albania", Price = 150, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4708, AllSeats = 57, DateTime = DateTime.Parse("2022-07-31"), From = "Albania", To = "Gdansk", Price = 145, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4709, AllSeats = 48, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Albania", Price = 79, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 4710, AllSeats = 48, DateTime = DateTime.Parse("2022-07-31"), From = "Albania", To = "Gdansk", Price = 77, Type = TransportType.Train, AvailableSeats = 48
},
new()
{
Id = 4711, AllSeats = 86, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Bulgaria", Price = 74, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4712, AllSeats = 86, DateTime = DateTime.Parse("2022-07-31"), From = "Bulgaria", To = "Gdansk", Price = 128, Type = TransportType.Bus, AvailableSeats = 86
},
new()
{
Id = 4713, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Bulgaria", Price = 107, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4714, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Bulgaria", To = "Gdansk", Price = 138, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4715, AllSeats = 39, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Bulgaria", Price = 126, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4716, AllSeats = 39, DateTime = DateTime.Parse("2022-07-31"), From = "Bulgaria", To = "Gdansk", Price = 86, Type = TransportType.Train, AvailableSeats = 39
},
new()
{
Id = 4717, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Czarnogora", Price = 120, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4718, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Czarnogora", To = "Gdansk", Price = 115, Type = TransportType.Bus, AvailableSeats = 40
},
new()
{
Id = 4719, AllSeats = 41, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Czarnogora", Price = 88, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4720, AllSeats = 41, DateTime = DateTime.Parse("2022-07-31"), From = "Czarnogora", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 41
},
new()
{
Id = 4721, AllSeats = 96, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Czarnogora", Price = 134, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4722, AllSeats = 96, DateTime = DateTime.Parse("2022-07-31"), From = "Czarnogora", To = "Gdansk", Price = 146, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4723, AllSeats = 87, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Egipt", Price = 141, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4724, AllSeats = 87, DateTime = DateTime.Parse("2022-07-31"), From = "Egipt", To = "Gdansk", Price = 122, Type = TransportType.Bus, AvailableSeats = 87
},
new()
{
Id = 4725, AllSeats = 88, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Egipt", Price = 122, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 4726, AllSeats = 88, DateTime = DateTime.Parse("2022-07-31"), From = "Egipt", To = "Gdansk", Price = 98, Type = TransportType.Plane, AvailableSeats = 88
},
new()
{
Id = 4727, AllSeats = 96, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Egipt", Price = 139, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4728, AllSeats = 96, DateTime = DateTime.Parse("2022-07-31"), From = "Egipt", To = "Gdansk", Price = 73, Type = TransportType.Train, AvailableSeats = 96
},
new()
{
Id = 4729, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Grecja", Price = 108, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4730, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Grecja", To = "Gdansk", Price = 97, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4731, AllSeats = 50, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Grecja", Price = 51, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4732, AllSeats = 50, DateTime = DateTime.Parse("2022-07-31"), From = "Grecja", To = "Gdansk", Price = 65, Type = TransportType.Plane, AvailableSeats = 50
},
new()
{
Id = 4733, AllSeats = 76, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Grecja", Price = 118, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4734, AllSeats = 76, DateTime = DateTime.Parse("2022-07-31"), From = "Grecja", To = "Gdansk", Price = 134, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4735, AllSeats = 53, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Gruzja", Price = 146, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 4736, AllSeats = 53, DateTime = DateTime.Parse("2022-07-31"), From = "Gruzja", To = "Gdansk", Price = 109, Type = TransportType.Bus, AvailableSeats = 53
},
new()
{
Id = 4737, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Gruzja", Price = 71, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4738, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Gruzja", To = "Gdansk", Price = 119, Type = TransportType.Plane, AvailableSeats = 52
},
new()
{
Id = 4739, AllSeats = 47, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Gruzja", Price = 141, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 4740, AllSeats = 47, DateTime = DateTime.Parse("2022-07-31"), From = "Gruzja", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 47
},
new()
{
Id = 4741, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Madera", Price = 58, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4742, AllSeats = 52, DateTime = DateTime.Parse("2022-07-31"), From = "Madera", To = "Gdansk", Price = 138, Type = TransportType.Bus, AvailableSeats = 52
},
new()
{
Id = 4743, AllSeats = 35, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Madera", Price = 126, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4744, AllSeats = 35, DateTime = DateTime.Parse("2022-07-31"), From = "Madera", To = "Gdansk", Price = 111, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4745, AllSeats = 61, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Madera", Price = 149, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 4746, AllSeats = 61, DateTime = DateTime.Parse("2022-07-31"), From = "Madera", To = "Gdansk", Price = 114, Type = TransportType.Train, AvailableSeats = 61
},
new()
{
Id = 4747, AllSeats = 65, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malediwy", Price = 70, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 4748, AllSeats = 65, DateTime = DateTime.Parse("2022-07-31"), From = "Malediwy", To = "Gdansk", Price = 102, Type = TransportType.Bus, AvailableSeats = 65
},
new()
{
Id = 4749, AllSeats = 46, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malediwy", Price = 59, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 4750, AllSeats = 46, DateTime = DateTime.Parse("2022-07-31"), From = "Malediwy", To = "Gdansk", Price = 137, Type = TransportType.Plane, AvailableSeats = 46
},
new()
{
Id = 4751, AllSeats = 76, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malediwy", Price = 80, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4752, AllSeats = 76, DateTime = DateTime.Parse("2022-07-31"), From = "Malediwy", To = "Gdansk", Price = 97, Type = TransportType.Train, AvailableSeats = 76
},
new()
{
Id = 4753, AllSeats = 68, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malta", Price = 92, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 4754, AllSeats = 68, DateTime = DateTime.Parse("2022-07-31"), From = "Malta", To = "Gdansk", Price = 146, Type = TransportType.Bus, AvailableSeats = 68
},
new()
{
Id = 4755, AllSeats = 86, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malta", Price = 149, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 4756, AllSeats = 86, DateTime = DateTime.Parse("2022-07-31"), From = "Malta", To = "Gdansk", Price = 135, Type = TransportType.Plane, AvailableSeats = 86
},
new()
{
Id = 4757, AllSeats = 34, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Malta", Price = 88, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 4758, AllSeats = 34, DateTime = DateTime.Parse("2022-07-31"), From = "Malta", To = "Gdansk", Price = 52, Type = TransportType.Train, AvailableSeats = 34
},
new()
{
Id = 4759, AllSeats = 91, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Mauritius", Price = 59, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4760, AllSeats = 91, DateTime = DateTime.Parse("2022-07-31"), From = "Mauritius", To = "Gdansk", Price = 134, Type = TransportType.Bus, AvailableSeats = 91
},
new()
{
Id = 4761, AllSeats = 75, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Mauritius", Price = 87, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4762, AllSeats = 75, DateTime = DateTime.Parse("2022-07-31"), From = "Mauritius", To = "Gdansk", Price = 96, Type = TransportType.Plane, AvailableSeats = 75
},
new()
{
Id = 4763, AllSeats = 77, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Mauritius", Price = 108, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4764, AllSeats = 77, DateTime = DateTime.Parse("2022-07-31"), From = "Mauritius", To = "Gdansk", Price = 68, Type = TransportType.Train, AvailableSeats = 77
},
new()
{
Id = 4765, AllSeats = 74, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Meksyk", Price = 115, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 4766, AllSeats = 74, DateTime = DateTime.Parse("2022-07-31"), From = "Meksyk", To = "Gdansk", Price = 103, Type = TransportType.Bus, AvailableSeats = 74
},
new()
{
Id = 4767, AllSeats = 98, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Meksyk", Price = 143, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4768, AllSeats = 98, DateTime = DateTime.Parse("2022-07-31"), From = "Meksyk", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 98
},
new()
{
Id = 4769, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Meksyk", Price = 79, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 4770, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Meksyk", To = "Gdansk", Price = 121, Type = TransportType.Train, AvailableSeats = 40
},
new()
{
Id = 4771, AllSeats = 55, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Seszele", Price = 96, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 4772, AllSeats = 55, DateTime = DateTime.Parse("2022-07-31"), From = "Seszele", To = "Gdansk", Price = 133, Type = TransportType.Bus, AvailableSeats = 55
},
new()
{
Id = 4773, AllSeats = 31, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Seszele", Price = 83, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4774, AllSeats = 31, DateTime = DateTime.Parse("2022-07-31"), From = "Seszele", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 31
},
new()
{
Id = 4775, AllSeats = 90, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Seszele", Price = 114, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4776, AllSeats = 90, DateTime = DateTime.Parse("2022-07-31"), From = "Seszele", To = "Gdansk", Price = 79, Type = TransportType.Train, AvailableSeats = 90
},
new()
{
Id = 4777, AllSeats = 99, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Slowenia", Price = 144, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 4778, AllSeats = 99, DateTime = DateTime.Parse("2022-07-31"), From = "Slowenia", To = "Gdansk", Price = 72, Type = TransportType.Bus, AvailableSeats = 99
},
new()
{
Id = 4779, AllSeats = 94, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Slowenia", Price = 52, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 4780, AllSeats = 94, DateTime = DateTime.Parse("2022-07-31"), From = "Slowenia", To = "Gdansk", Price = 128, Type = TransportType.Plane, AvailableSeats = 94
},
new()
{
Id = 4781, AllSeats = 36, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Slowenia", Price = 146, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4782, AllSeats = 36, DateTime = DateTime.Parse("2022-07-31"), From = "Slowenia", To = "Gdansk", Price = 51, Type = TransportType.Train, AvailableSeats = 36
},
new()
{
Id = 4783, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Turcja", Price = 105, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4784, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Turcja", To = "Gdansk", Price = 145, Type = TransportType.Bus, AvailableSeats = 64
},
new()
{
Id = 4785, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Turcja", Price = 59, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4786, AllSeats = 40, DateTime = DateTime.Parse("2022-07-31"), From = "Turcja", To = "Gdansk", Price = 86, Type = TransportType.Plane, AvailableSeats = 40
},
new()
{
Id = 4787, AllSeats = 60, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Turcja", Price = 139, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 4788, AllSeats = 60, DateTime = DateTime.Parse("2022-07-31"), From = "Turcja", To = "Gdansk", Price = 82, Type = TransportType.Train, AvailableSeats = 60
},
new()
{
Id = 4789, AllSeats = 90, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 139, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4790, AllSeats = 90, DateTime = DateTime.Parse("2022-07-31"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 100, Type = TransportType.Bus, AvailableSeats = 90
},
new()
{
Id = 4791, AllSeats = 57, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 60, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4792, AllSeats = 57, DateTime = DateTime.Parse("2022-07-31"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 87, Type = TransportType.Plane, AvailableSeats = 57
},
new()
{
Id = 4793, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Wyspy Kanaryjskie", Price = 94, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 4794, AllSeats = 64, DateTime = DateTime.Parse("2022-07-31"), From = "Wyspy Kanaryjskie", To = "Gdansk", Price = 103, Type = TransportType.Train, AvailableSeats = 64
},
new()
{
Id = 4795, AllSeats = 30, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Zanzibar", Price = 147, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4796, AllSeats = 30, DateTime = DateTime.Parse("2022-07-31"), From = "Zanzibar", To = "Gdansk", Price = 135, Type = TransportType.Bus, AvailableSeats = 30
},
new()
{
Id = 4797, AllSeats = 35, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Zanzibar", Price = 53, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4798, AllSeats = 35, DateTime = DateTime.Parse("2022-07-31"), From = "Zanzibar", To = "Gdansk", Price = 81, Type = TransportType.Plane, AvailableSeats = 35
},
new()
{
Id = 4799, AllSeats = 65, DateTime = DateTime.Parse("2022-07-31"), From = "Gdansk", To = "Zanzibar", Price = 99, Type = TransportType.Train, AvailableSeats = 65
},
new()
{
Id = 4800, AllSeats = 65, DateTime = DateTime.Parse("2022-07-31"), From = "Zanzibar", To = "Gdansk", Price = 108, Type = TransportType.Train, AvailableSeats = 65
},
};
            context.TransportCollection.InsertMany(transports);
        }
    }
}
