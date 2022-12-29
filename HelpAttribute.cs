class HelpAttribute : System.Attribute
{
	private string url;
	private string description;
	private string target;
	private string enterCode;
	
	public HelpAttribute( string url, string description )
	{
		this.url = url;
		this.description = description;
	}
	
	public string Target
	{
		get 
		{
			return target;
		}
		set
		{
			target = value;
		}
	}
	
	public string EnterCode
	{
		get
		{
			return enterCode;
		}
		set
		{
			enterCode = verificationCode;
		}
	}
	
	public string URL
	{
		get
		{
			return url;
		}
	}
	
	public string Description
	{
		get
		{
			return description;
		}
	}
}

[Help("http://www.amazon.com", "Books Online")]
[Help("http://www.yahoo.com", "Search Engine", Target="Maps")]
[Help("http://www.google.com", "Google Voice", Target="Verification Code", enterCode="Recieved Verification Code")]