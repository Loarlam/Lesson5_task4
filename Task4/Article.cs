using System;

namespace Task4
{
    class Article
    {
        readonly string[] _productName, _shopName;
        const double _tableCost = 1500.30, _tvCost = 3320.50, _monitorCost = 2230;

        public Article(params string[] listOfInformationFromStore)
        {
            _productName = listOfInformationFromStore[0..3];
            _shopName = listOfInformationFromStore[3..6];
        }
        //public Article(string productName, string shopName)
        //{
        //    _productName = productName;
        //    _shopName = shopName;
        //}

        public string this[string index]
        {
            get
            {
                if (_productName[0] == index)
                    return $"{_productName[0]} расположен в {_shopName[0]}. Цена {_tableCost}";
                else if (_productName[1] == index)
                    return $"{_productName[1]} расположен в {_shopName}. Цена {_tvCost}";
                else if (_productName[2] == index)
                    return $"{_productName[2]} расположен в {_shopName[2]}. Цена {_monitorCost}";
                else
                    return $"{index} отсутствует в магазинах.";
            }
        }
    }
}
