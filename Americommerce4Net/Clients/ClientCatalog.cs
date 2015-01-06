#region License
//   Copyright 2014 Ken Worst - R.C. Worst & Company Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using Americommerce4Net.Clients;

namespace Americommerce4Net
{
    public class ClientCatalog
    {

        IRestEngine _RestEngine;

        public ClientCatalog() {
            _RestEngine = new RestEngine(new Configuration());
        }

        public ClientCatalog(IRestEngine restEngine) {
            _RestEngine = restEngine;
        }

        public ClientCatalog(Configuration configuration) {
            _RestEngine = new RestEngine(configuration);
        }


        private ClientProducts _Products;
        public ClientProducts Products {
            get {
                if (_Products == null) {
                    _Products = new ClientProducts(_RestEngine);
                }
                return _Products;
            }
        }

        private ClientProductVariants _ProductVariants;
        public ClientProductVariants ProductVariants {
            get {
                if (_ProductVariants == null) {
                    _ProductVariants = new ClientProductVariants(_RestEngine);
                }
                return _ProductVariants;
            }
        }

        private ClientProductPictures _ProductPictures;
        public ClientProductPictures ProductPictures {
            get {
                if (_ProductPictures == null) {
                    _ProductPictures = new ClientProductPictures(_RestEngine);
                }
                return _ProductPictures;
            }
        }

        private ClientCategories _Categories;
        public ClientCategories Categories {
            get {
                if (_Categories == null) {
                    _Categories = new ClientCategories(_RestEngine);
                }
                return _Categories;
            }
        }

        private ClientManufacturers _Manufacturers;
        public ClientManufacturers Manufacturers {
            get {
                if (_Manufacturers == null) {
                    _Manufacturers = new ClientManufacturers(_RestEngine);
                }
                return _Manufacturers;
            }
        }

        private ClientAttributes _Attributes;
        public ClientAttributes Attributes {
            get {
                if (_Attributes == null) {
                    _Attributes = new ClientAttributes(_RestEngine);
                }
                return _Attributes;
            }
        }

        private ClientAttributeGroups _AttributeGroups;
        public ClientAttributeGroups AttributeGroups {
            get {
                if (_AttributeGroups == null) {
                    _AttributeGroups = new ClientAttributeGroups(_RestEngine);
                }
                return _AttributeGroups;
            }
        }

        private ClientProductLists _ProductLists;
        public ClientProductLists ProductLists {
            get {
                if (_ProductLists == null) {
                    _ProductLists = new ClientProductLists(_RestEngine);
                }
                return _ProductLists;
            }
        }

        private ClientProductStatuses _ProductStatuses;
        public ClientProductStatuses ProductStatuses {
            get {
                if (_ProductStatuses == null) {
                    _ProductStatuses = new ClientProductStatuses(_RestEngine);
                }
                return _ProductStatuses;
            }
        }

        private ClientShippingRateAdjustments _ShippingRateAdjustments;
        public ClientShippingRateAdjustments ShippingRateAdjustments {
            get {
                if (_ShippingRateAdjustments == null) {
                    _ShippingRateAdjustments = new ClientShippingRateAdjustments(_RestEngine);
                }
                return _ShippingRateAdjustments;
            }
        }

        private ClientVariantGroups _VariantGroups;
        public ClientVariantGroups VariantGroups {
            get {
                if (_VariantGroups == null) {
                    _VariantGroups = new ClientVariantGroups(_RestEngine);
                }
                return _VariantGroups;
            }
        }

        private ClientVariantInventory _VariantInventory;
        public ClientVariantInventory VariantInventory {
            get {
                if (_VariantInventory == null) {
                    _VariantInventory = new ClientVariantInventory(_RestEngine);
                }
                return _VariantInventory;
            }
        }


    }
}
