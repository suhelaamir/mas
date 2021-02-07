using AutoMapper;
using BusinessEntity.Product.Common;
using BusinessEntity.Product.Master.RequestDTO;
using BusinessEntity.Product.Master.ResponseDTO;
using Repositories.Interface;
using Repositories.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Implementation
{
    public class ProvideServiceService
    {
        private readonly IProvideServiceRepository _IProvideServiceRepository;
        private IMapper _Mapper;
        public ProvideServiceService(IMapper mapper, IProvideServiceRepository iProvideServiceRepository)
        {
            _Mapper = mapper;
            _IProvideServiceRepository = iProvideServiceRepository;
        }

        public ResultDTO<long> Add(ProvideServiceRequest viewModel)
        {
            var res = new ResultDTO<long>
            {
                IsSuccess = false,
                Data = 0,
                Errors = new List<string>()
            };
            var response = _IProvideServiceRepository.Add(viewModel);
            if (response > 0)
            {
                res.IsSuccess = true;
                res.Data = response;
            }
            else
            {
                res.Errors.Add("Customers already exists !!");
            }
            return res;
        }

        public ResultDTO<long> Delete(long Id)
        {
            var res = new ResultDTO<long>
            {
                IsSuccess = false,
                Data = 0,
                Errors = new List<string>()
            };
            var response = _IProvideServiceRepository.Delete(Id);
            if (response > 0)
            {
                res.IsSuccess = true;
                res.Data = response;
            }
            else
            {
                res.Errors.Add("Record Not Found !!");
            }
            return res;
        }

        public ResultDTO<IEnumerable<ProvideServiceResponse>> GetAll()
        {
            var res = new ResultDTO<IEnumerable<ProvideServiceResponse>>
            {
                IsSuccess = false,
                Data = null,
                Errors = new List<string>()
            };
            var response = _IProvideServiceRepository.GetAll();
            if (response != null)
            {
                res.IsSuccess = true;
                res.Data = _Mapper.Map<IEnumerable<DBProvideService>, IEnumerable<ProvideServiceResponse>>(response);
            }
            else
            {
                res.Errors.Add("Records Not Found !!");
            }
            return res;
        }

        public ResultDTO<ProvideServiceResponse> GetById(long Id)
        {
            var res = new ResultDTO<ProvideServiceResponse>
            {
                IsSuccess = false,
                Data = null,
                Errors = new List<string>()
            };
            var response = _IProvideServiceRepository.GetById(Id);
            if (response != null)
            {
                res.IsSuccess = true;
                res.Data = _Mapper.Map<DBProvideService, ProvideServiceResponse>(response);
            }
            else
            {
                res.Errors.Add("Record Not Found !!");
            }
            return res;
        }

        public ResultDTO<long> Update(ProvideServiceRequest viewModel)
        {
            var res = new ResultDTO<long>
            {
                IsSuccess = false,
                Data = 0,
                Errors = new List<string>()
            };
            var response = _IProvideServiceRepository.Update(viewModel);
            if (response > 0)
            {
                res.IsSuccess = true;
                res.Data = response;
            }
            else
            {
                res.Errors.Add("Not Updated !!");
            }
            return res;
        }
    }
}
