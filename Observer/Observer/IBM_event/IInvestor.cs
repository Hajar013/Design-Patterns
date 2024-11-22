namespace Observer
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor_D
    {
        void OnPriceChanged(object sender, PriceChangedEventArgs e);

    }
}

