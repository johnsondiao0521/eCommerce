using System;
using System.Runtime.Serialization;
using System.Text;

[Serializable]
public class CustomException : Exception
{

    #region "Member Variables"
    const string _className = "CustomException";
    const int _hresult = -2146232832;
    #endregion

    #region "Constructors"
    public CustomException() : base()
    {
        base.HResult = _hresult;
    }

    public CustomException(string message)
        : base(message)
    {
        base.HResult = _hresult;
    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {
        base.HResult = _hresult;
    }

    protected CustomException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        base.HResult = _hresult;
    }
    #endregion

    #region "Properties & Operators"
    public static implicit operator string(CustomException ex)
    {
        return ex.ToString();
    }
    #endregion

    #region "Methods"
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendFormat("{0}: {1}", _className, this.Message);
        if (this.InnerException != null)
        {
            sb.AppendFormat(" ---> {0} <---", base.InnerException.ToString());
        }

        if (this.StackTrace != null)
        {
            sb.Append(Environment.NewLine);
            sb.Append(base.StackTrace);
        }

        return sb.ToString();
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    #endregion

}

