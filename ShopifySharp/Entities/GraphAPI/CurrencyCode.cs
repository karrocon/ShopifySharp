﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShopifySharp.Graph
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyCode
    {
        AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZN,
        BAM, BBD, BDT, BGN, BHD, BIF, BND, BOB, BRL, BSD, BTN, BYR, BZD,
        CAD, CDF, CHF, CLP, CNY, COP, CRC, CVE, CZK,
        DKK, DOP, DZD,
        EGP, ETB, EUR,
        FJD,
        GBP, GEL, GHS, GMD, GTQ, GYD,
        HKD, HNL, HRK, HTG, HUF,
        IDR, ILS, INR, IQD, ISK,
        JEP, JMD, JOD, JPY,
        KES, KGS, KHR, KMF, KRW, KWD, KYD, KZT,
        LAK, LBP, LKR, LRD, LSL, LTL, LVL,
        MAD, MDL, MGA, MKD, MMK, MNT, MOP, MUR, MVR, MWK, MXN, MYR, MZN,
        NAD, NGN, NIO, NOK, NPR, NZD,
        OMR,
        PEN, PGK, PHP, PKR, PLN, PYG,
        QAR,
        RON, RSD, RUB, RWF,
        SAR, SBD, SCR, SDG, SEK, SGD, SRD, SSP, STD, SYP, SZL,
        THB, TMT, TND, TRY, TTD, TWD, TZS,
        UAH, UGX, USD, UYU, UZS,
        VEF, VND, VUV,
        WST,
        XAF, XCD, XOF, XPF,
        YER,
        ZAR, ZMW
    }
}