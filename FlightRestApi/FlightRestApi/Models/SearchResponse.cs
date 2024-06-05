using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace FlightRestApi.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private AvailabilitySearchResponse availabilitySearchResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://tempuri.org/")]
        public AvailabilitySearchResponse AvailabilitySearchResponse
        {
            get
            {
                return this.availabilitySearchResponseField;
            }
            set
            {
                this.availabilitySearchResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/", IsNullable = false)]
    public partial class AvailabilitySearchResponse
    {

        private AvailabilitySearchResponseAvailabilitySearchResult availabilitySearchResultField;

        /// <remarks/>
        public AvailabilitySearchResponseAvailabilitySearchResult AvailabilitySearchResult
        {
            get
            {
                return this.availabilitySearchResultField;
            }
            set
            {
                this.availabilitySearchResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/")]
    public partial class AvailabilitySearchResponseAvailabilitySearchResult
    {

        private FlightOptionsFlightOption[] flightOptionsField;

        private bool hasErrorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.datacontract.org/2004/07/FlightProvider")]
        [System.Xml.Serialization.XmlArrayItemAttribute("FlightOption", IsNullable = false)]
        public FlightOptionsFlightOption[] FlightOptions
        {
            get
            {
                return this.flightOptionsField;
            }
            set
            {
                this.flightOptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/FlightProvider")]
        public bool HasError
        {
            get
            {
                return this.hasErrorField;
            }
            set
            {
                this.hasErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/FlightProvider")]
    public partial class FlightOptionsFlightOption
    {

        private System.DateTime arrivalDateTimeField;

        private System.DateTime departureDateTimeField;

        private string flightNumberField;

        private decimal priceField;

        private decimal returnCodeField;

        /// <remarks/>
        public System.DateTime ArrivalDateTime
        {
            get
            {
                return this.arrivalDateTimeField;
            }
            set
            {
                this.arrivalDateTimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DepartureDateTime
        {
            get
            {
                return this.departureDateTimeField;
            }
            set
            {
                this.departureDateTimeField = value;
            }
        }

        /// <remarks/>
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        public decimal ReturnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/FlightProvider")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/FlightProvider", IsNullable = false)]
    public partial class FlightOptions
    {

        private FlightOptionsFlightOption[] flightOptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FlightOption")]
        public FlightOptionsFlightOption[] FlightOption
        {
            get
            {
                return this.flightOptionField;
            }
            set
            {
                this.flightOptionField = value;
            }
        }
    }





}
