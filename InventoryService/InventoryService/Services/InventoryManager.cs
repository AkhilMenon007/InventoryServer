using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using InventoryService.Protos;
using MongoDB.Bson;
using InventorySystemMongoDB;
using MongoDB.Bson.Serialization.Attributes;

namespace InventoryService.Services
{
    public class InventoryManager:InventoryManagement.InventoryManagementBase
    {
        class Weapon: Item 
        {
            public int enchantment = 15;
        }
        class Armor : Item 
        {
            public int durability = 12;
        }
        [BsonDiscriminator(Required = true, RootClass = true)]
        [BsonKnownTypes(typeof(Weapon),typeof(Armor))]
        class Item 
        {
            [BsonId]
            public Guid ID { get; set; }
            public string Name { get; set; }
            public int amount { get; set; }
        }
        public async override Task<ReplyMessage> DropItem(InventoryItem request, ServerCallContext context)
        {
            var mongoDBCommunicator = new MongoDBCommunicator("Inventory");
            //var item = new Weapon { Name = "Sword", amount = 1 };
            //await mongoDBCommunicator.InsertRecord("item", item);
            //Console.WriteLine(item.ID.ToString());
            var res = await mongoDBCommunicator.GetRecord<Item>("item", "be09cc7e-2796-45bc-8fe2-c25d0fb38dd8");

            if (res is Weapon)
            {
                Console.WriteLine("The shit is a weapon");
            }
            if (res != null)
            {
                Console.WriteLine(res.ToJson());
            }

            return new ReplyMessage() { MessageCode = 0 };
        }
        public override Task<ItemObtainedMessage> GetItem(DroppedItem request, ServerCallContext context)
        {
            return base.GetItem(request, context);
        }
        public override Task<ItemObtainedMessage> TradeItem(InventoryItem request, ServerCallContext context)
        {
            return base.TradeItem(request, context);
        }
    }
}
