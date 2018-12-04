using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentCheckedoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);

        void Add(Checkout newCheckout);
        void GetCheckoutByAssetId(int assetId);
        void CheckOutItem(int assetId, int LibraryCardId);
        void CheckInItem(int assetId, int LibraryCardId);
        void PlaceHold(int assetId, int LibraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
