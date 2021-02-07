using BusinessEntity.Product.Common;
using BusinessEntity.Product.Master.RequestDTO;
using BusinessEntity.Product.Master.ResponseDTO;
using BusinessService.Interface;
using System.Collections.Generic;
using Repositories.Interface;
using AutoMapper;
using Repositories.Product;

namespace BusinessService.Implementation
{
    public class CustomersService: ICustomersService
    {
        private readonly ICustomersRepository _ICustomersRepository;
        private IMapper _Mapper;
        public CustomersService(IMapper mapper, ICustomersRepository iCustomersRepository)
        {
            _Mapper = mapper;
            _ICustomersRepository = iCustomersRepository;
        }

        public ResultDTO<long> Add(CustomersRequest viewModel)
        {
            var res = new ResultDTO<long>
            {
                IsSuccess = false,
                Data = 0,
                Errors = new List<string>()
            };
            var response = _ICustomersRepository.Add(viewModel);
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
            var response = _ICustomersRepository.Delete(Id);
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

        public ResultDTO<IEnumerable<CustomersResponse>> GetAll()
        {
            var res = new ResultDTO<IEnumerable<CustomersResponse>>
            {
                IsSuccess = false,
                Data =  null,
                Errors = new List<string>()
            };
            var response = _ICustomersRepository.GetAll();
            if (response != null)
            {
                res.IsSuccess = true;
                res.Data = _Mapper.Map<IEnumerable<DBCustomers>, IEnumerable<CustomersResponse>>(response);
            }
            else
            {
                res.Errors.Add("Records Not Found !!");
            }
            return res;
        }

        public ResultDTO<CustomersResponse> GetById(long Id)
        {
            var res = new ResultDTO<CustomersResponse>
            {
                IsSuccess = false,
                Data = null,
                Errors = new List<string>()
            };
            var response = _ICustomersRepository.GetById(Id);
            if (response != null)
            {
                res.IsSuccess = true;
                res.Data = _Mapper.Map<DBCustomers, CustomersResponse>(response);
            }
            else
            {
                res.Errors.Add("Record Not Found !!");
            }
            return res;
        }

        public ResultDTO<long> Update(CustomersRequest viewModel)
        {
            var res = new ResultDTO<long>
            {
                IsSuccess = false,
                Data = 0,
                Errors = new List<string>()
            };
            var response = _ICustomersRepository.Update(viewModel);
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
