namespace CashMastersPOS.CustomExceptions
{
	public class NoCountryConfiguredException : Exception
	{
        public NoCountryConfiguredException()
            : base("No country configured in app config file.") { }
    }

    public class MoneyDenominationDoesNotExist : Exception
    {
        public MoneyDenominationDoesNotExist(string country)
		    : base($"Money denomination does not exist for country '{country}'.") { }
	}
}
