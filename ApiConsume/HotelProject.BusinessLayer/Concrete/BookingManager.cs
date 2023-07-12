using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }

        public void TInsert(Booking entity)
        {
            _bookingDal.Insert(entity);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
