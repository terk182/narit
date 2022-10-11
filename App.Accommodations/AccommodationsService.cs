using App.Accommodations.Model.Requests;
using App.Accommodations.Model.Responses;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace App.Accommodations
{
    public class AccommodationsService : IAccommodationsService
    {
        private readonly NARIT_MIS_LINKContext _database;

        public AccommodationsService(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public BaseResponse Add(Accommodation Request)
        {
            _database.Entry(Request).State = Request.Id == 0 ?
                                       EntityState.Added :
                                       EntityState.Modified;

   
            var result = _database.SaveChanges();
            var response = new BaseResponse();
            response.Success = result > 0 ? true:false;
            return response;
        }

        public BaseResponse delete(int id)
        {
            var response = new BaseResponse();
            var data = _database.Accommodations.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                _database.Remove(data);
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true:false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }

        public  List<Accommodation> getAll()
        {

            return _database.Accommodations.ToList();
        }

        public Accommodation getById(int id)
        {

            var data =  _database.Accommodations.Where(x => x.Id == id).FirstOrDefault();
            return data == null? new Accommodation(): data;
        }

        public List<Accommodation> PostReadByName(AccommodationsRequest Request)
        {
            var data = _database.Accommodations.Where(x => x.Name == Request.Name && x.PhoneNumber == Request.PhoneNumber).ToList();
            return data == null ? new List<Accommodation>() : data;

        }

        public AccommodationsResponse update(Accommodation Request)
        {
            var response = new AccommodationsResponse();
            var data = _database.Accommodations.FirstOrDefault(x => x.Id == Request.Id);
            if(data != null)
            {
                data.Active = Request.Active;
                data.Name = Request.Name;
                data.Address = Request.Address;
                data.Distance = Request.Distance;
                data.Price = Request.Price;
                data.PhoneNumber = Request.PhoneNumber;
                data.Remark = Request.Remark;
                data.LatestUpdate = Request.LatestUpdate;
                data.OrganizationId = Request.OrganizationId;

                _database.Entry(data).State = EntityState.Modified;

                int returnValue = _database.SaveChanges();
                response.Success = returnValue > 0 ? true:false;
                response.Messsage = returnValue > 0 ?  "update complete": "update error";
                response.data = data;
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
               
            }
           
            response.Success = true;
      
            return response;
        }
    }
}
