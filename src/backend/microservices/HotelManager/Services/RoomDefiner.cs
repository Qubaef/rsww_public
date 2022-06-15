using Shared.DataModels.Hotel;

namespace HotelManager.Services
{
    public class RoomDefiner
    {
        public Dictionary<RoomType, RoomTypeStaticData> roomTypeDefinition { get; set; }

        public RoomDefiner()
        {
            roomTypeDefinition = new Dictionary<RoomType, RoomTypeStaticData>();
            roomTypeDefinition.Add(
                RoomType.Small, new RoomTypeStaticData
                {
                    AdultBeds = 2,
                    MinChildrenLT18Beds = 0,
                    MinChildrenLT10Beds = 0,
                    MinChildrenLT3Beds = 2,
                    PriceModifier = 1
                });

            roomTypeDefinition.Add(
                RoomType.Medium, new RoomTypeStaticData
                {
                    AdultBeds = 2,
                    MinChildrenLT18Beds = 0,
                    MinChildrenLT10Beds = 2,
                    MinChildrenLT3Beds = 0,
                    PriceModifier = 2
                });

            roomTypeDefinition.Add(
                RoomType.Large, new RoomTypeStaticData
                {
                    AdultBeds = 2,
                    MinChildrenLT18Beds = 2,
                    MinChildrenLT10Beds = 0,
                    MinChildrenLT3Beds = 0,
                    PriceModifier = 3
                });

            roomTypeDefinition.Add(
                RoomType.Apartment, new RoomTypeStaticData
                {
                    AdultBeds = 4,
                    MinChildrenLT18Beds = 0,
                    MinChildrenLT10Beds = 2,
                    MinChildrenLT3Beds = 0,
                    PriceModifier = 4
                });

            roomTypeDefinition.Add(
                RoomType.Studio, new RoomTypeStaticData
                {
                    AdultBeds = 5,
                    MinChildrenLT18Beds = 2,
                    MinChildrenLT10Beds = 0,
                    MinChildrenLT3Beds = 2,
                    PriceModifier = 5
                });
        }
    }
}
