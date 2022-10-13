//using System;

//namespace Payments
//{

//    public class EventsInicial
//    {
//        public void iniciando()
//        {
//            Console.WriteLine("events");
//            var room = new Room(3);
//            room.RoomSoldOutEvent += OnRoomSoldOut;
//            room.ReserveSeat();
//            room.ReserveSeat();
//            room.ReserveSeat();
//            room.ReserveSeat();
//            room.ReserveSeat();
//        }

//        void OnRoomSoldOut(object? sender, EventArgs e)
//        {
//            Console.WriteLine("Sala lotada");
//        }
//    }

//    public class Room
//    {

//        public Room(int seats)
//        {
//            Seats = seats;
//            SeatsInUse = 0;
//        }
//        public int Seats = 0;

//        private int SeatsInUse { get; set; }

//        public void ReserveSeat()
//        {
//            SeatsInUse++;
//            if (SeatsInUse >= Seats)
//            {
//                //Evento fechado!
//                OnRoomSoldOut(EventArgs.Empty);
//            }
//            else
//            {
//                Console.WriteLine("Assento reservado!");
//            }
//        }

//        public event EventHandler RoomSoldOutEvent;

//        protected virtual void OnRoomSoldOut(EventArgs e)
//        {
//            EventHandler handler = RoomSoldOutEvent;
//            handler?.Invoke(this, e);
//        }
//    }
//}