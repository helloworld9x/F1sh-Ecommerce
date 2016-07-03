using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nop.Core;
using Nop.Core.Data;
//using Nop.Core.Domain;
//using Nop.Core.Domain.Affiliates;
//using Nop.Core.Domain.Blogs;
//using Nop.Core.Domain.Catalog;
//using Nop.Core.Domain.Cms;
//using Nop.Core.Domain.Common;
//using Nop.Core.Domain.Customers;
//using Nop.Core.Domain.Directory;
//using Nop.Core.Domain.Discounts;
//using Nop.Core.Domain.Forums;
//using Nop.Core.Domain.Localization;
//using Nop.Core.Domain.Logging;
//using Nop.Core.Domain.Media;
//using Nop.Core.Domain.Messages;
//using Nop.Core.Domain.News;
//using Nop.Core.Domain.Orders;
//using Nop.Core.Domain.Payments;
//using Nop.Core.Domain.Polls;
//using Nop.Core.Domain.Security;
//using Nop.Core.Domain.Seo;
//using Nop.Core.Domain.Shipping;
using Nop.Core.Domain.Stores;
//using Nop.Core.Domain.Tasks;
//using Nop.Core.Domain.Tax;
//using Nop.Core.Domain.Topics;
//using Nop.Core.Domain.Vendors;
//using Nop.Core.Infrastructure;
using Nop.Services.Common;

namespace Nop.Services.Installation
{
    public partial class CodeFirstInstallationService : IInstallationService
    {
        #region Fields

        private readonly IRepository<Store> _storeRepository;
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IWebHelper _webHelper;

        #endregion

        #region Ctor

        public CodeFirstInstallationService(IRepository<Store> storeRepository,
            IGenericAttributeService genericAttributeService,
            IWebHelper webHelper)
        {
            this._storeRepository = storeRepository;
            this._genericAttributeService = genericAttributeService;
            this._webHelper = webHelper;
        }

        #endregion

        #region Utilities

        protected virtual void InstallStores()
        {
            //var storeUrl = "http://www.yourStore.com/";
            var storeUrl = _webHelper.GetStoreLocation(false);
            var stores = new List<Store>
            {
                new Store
                {
                    Name = "Your store name",
                    Url = storeUrl,
                    SslEnabled = false,
                    Hosts = "yourstore.com,www.yourstore.com",
                    DisplayOrder = 1,
                    //should we set some default company info?
                    CompanyName = "Your company name",
                    CompanyAddress = "your company country, state, zip, street, etc",
                    CompanyPhoneNumber = "(123) 456-78901",
                    CompanyVat = null,
                },
            };

            _storeRepository.Insert(stores);
        }

        #endregion

        #region Methods

        public virtual void InstallData(string defaultUserEmail,
            string defaultUserPassword, bool installSampleData = true)
        {
            InstallStores();
            //InstallMeasures();
            //InstallTaxCategories();
            //InstallLanguages();
            //InstallCurrencies();
            //InstallCountriesAndStates();
            //InstallShippingMethods();
            //InstallDeliveryDates();
            //InstallCustomersAndUsers(defaultUserEmail, defaultUserPassword);
            //InstallEmailAccounts();
            //InstallMessageTemplates();
            //InstallSettings();
            //InstallTopicTemplates();
            //InstallTopics();
            //InstallLocaleResources();
            //InstallActivityLogTypes();
            //HashDefaultCustomerPassword(defaultUserEmail, defaultUserPassword);
            //InstallProductTemplates();
            //InstallCategoryTemplates();
            //InstallManufacturerTemplates();
            //InstallScheduleTasks();
            //InstallReturnRequestReasons();
            //InstallReturnRequestActions();

            //if (installSampleData)
            //{
            //    InstallCheckoutAttributes();
            //    InstallSpecificationAttributes();
            //    InstallProductAttributes();
            //    InstallCategories();
            //    InstallManufacturers();
            //    InstallProducts(defaultUserEmail);
            //    InstallForums();
            //    InstallDiscounts();
            //    InstallBlogPosts(defaultUserEmail);
            //    InstallNews(defaultUserEmail);
            //    InstallPolls();
            //    InstallWarehouses();
            //    InstallVendors();
            //    InstallAffiliates();
            //}
        }

        #endregion
    }
}